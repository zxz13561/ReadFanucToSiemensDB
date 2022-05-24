using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace FanucToSiemens
{
    public class FocasFunctions
    {
        /// <summary>
        /// 依照提供的IP與CNC連線
        /// </summary>
        /// <param name="cnc_ip">目標CNC IP</param>
        /// <returns>狀態碼</returns>
        public static ushort CNC_Connect(string cnc_ip)
        {
            try
            {
                // 檢查來源IP格式
                Match is_IP_Ok = Regex.Match(cnc_ip, @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");

                if (is_IP_Ok.Success)
                {
                    if ((Focas1.focas_ret)Focas1.cnc_allclibhndl3(cnc_ip, 8193, 5, out ushort cncHandle) == 0)
                        return cncHandle;
                    else
                        return 404; // 連線失敗
                }
                else
                {
                    return 405; // IP格式錯誤
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 中斷與CNC的連線
        /// </summary>
        public static string CNC_Disconnect(ushort cncHandle)
        {
            if ((Focas1.focas_ret)Focas1.cnc_freelibhndl(cncHandle) == 0)
                return "連線已中斷";
            else
                return "中斷失敗";
        }

        /// <summary>
        /// 依照提供的CNC路徑編號，讀取CNC偏移號碼與種類
        /// </summary>
        /// <param name="num_txt">CNC路徑編號</param>
        /// <param name="cncHandle">cncHandle</param>
        /// <returns>[Type, Number]</returns>
        public static string[] Read_CNC_Tool_Offset_Type(string num_txt, ushort cncHandle)
        {
            // 檢查來源是否正確
            if (short.TryParse(num_txt, out short path_num))
            {
                Focas1.ODBTLINF tofsinfo = new Focas1.ODBTLINF();
                Focas1.cnc_setpath(cncHandle, path_num);
                Focas1.cnc_rdtofsinfo(cncHandle, tofsinfo);

                string tool_offset_type = tofsinfo.ofs_type.ToString();
                string tool_offset_number = tofsinfo.use_no.ToString();

                return new string[] { tool_offset_type, tool_offset_number};
            }

            return new string[] { "Short Parse Error" };
        }

        /// <summary>
        /// 依照提供的CNC路徑編號，讀取CNC刀具補正參數表
        /// </summary>
        /// <param name="num_txt">CNC路徑編號</param>
        /// <param name="cncHandle">cncHandle</param>
        public static List<CNCToolOffsetModel> Read_CNC_Tool_Offset_Values(string num_txt, ushort cncHandle)
        {
            // 檢查編號正確
            if (!short.TryParse(num_txt, out short path_num))
                return null;

            // 宣告參數List
            List<CNCToolOffsetModel> cnc_Data_List = new List<CNCToolOffsetModel>();

            // 讀取CNC偏移號碼與種類
            Focas1.ODBTLINF tofsinfo = new Focas1.ODBTLINF();
            Focas1.T_OFS_B tofsr = new Focas1.T_OFS_B();
            Focas1.cnc_setpath(cncHandle, path_num);
            Focas1.cnc_rdtofsinfo(cncHandle, tofsinfo);

            // 計算所需緩衝區大小
            short MAXTOOL = tofsinfo.use_no;
            short ret, idx;
            byte[] bytes = new byte[8 + 36 * MAXTOOL];

            // 配置記憶體
            IntPtr ptrData = Marshal.AllocCoTaskMem(Marshal.SizeOf(tofsr));

            // 連線檢查
            ret = Focas1.cnc_rdtofsr(cncHandle, 1, -2, MAXTOOL, (short)(8 + 36 * MAXTOOL), bytes);

            // 讀取數值
            if (ret == Focas1.EW_OK)
            {
                for (idx = 0; idx < MAXTOOL; idx++)
                {
                    int pos = 8 + idx * Marshal.SizeOf(tofsr);
                    Marshal.Copy(bytes, pos, ptrData, Marshal.SizeOf(tofsr));
                    Marshal.PtrToStructure(ptrData, tofsr);

                    CNCToolOffsetModel single_line_data = new CNCToolOffsetModel()
                    {
                        T_NO = idx + 1,
                        X_Wear = tofsr.data[4] / 1000.0,
                        Z_Wear = tofsr.data[6] / 1000.0,
                        R_Wear = tofsr.data[7] / 1000.0,
                        X_Geom = tofsr.data[0] / 1000.0,
                        Z_Geom = tofsr.data[2] / 1000.0,
                        R_Geom = tofsr.data[3] / 1000.0,
                        Tip = tofsr.tip
                    };

                    cnc_Data_List.Add(single_line_data);
                }

                // 釋放記憶體
                Marshal.FreeCoTaskMem(ptrData);
            }

            return cnc_Data_List;
        }
    }
}
