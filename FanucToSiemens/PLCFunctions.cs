using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snap7;

namespace FanucToSiemens
{
    public class PLCFunctions
    {
        /// <summary>
        /// 與PLC連線
        /// </summary>
        /// <param name="Client">客戶端變數</param>
        /// <param name="PLC_IP">PLC IP</param>
        /// <returns>執行訊息</returns>
        public static string ConnectPLC(S7Client Client, string PLC_IP)
        {
            try
            {
                int Rack = 0;
                int Slot = 0;
                int code = (Client.ConnectTo(PLC_IP, Rack, Slot));
                return Client.ErrorText(code);
            }
            catch (Exception ex)
            {
                return "Connect Error " + ex.ToString();
            }
        }

        /// <summary>
        /// 與PLC中斷連線
        /// </summary>
        /// <param name="Client">客戶端變數</param>
        /// <returns>執行訊息</returns>
        public static string DisconnectPLC(S7Client Client)
        {
            try
            {
                int code = Client.Disconnect();
                return Client.ErrorText(code);
            }
            catch (Exception ex)
            {
                return "Disconnect Error " + ex.ToString();
            }
        }

        /// <summary>
        /// 將資料寫入PLC資料庫
        /// </summary>
        /// <param name="Client">客戶端變數</param>
        /// <param name="PLC_DB_Num">資料庫編號</param>
        /// <param name="value_List">CNC補正資料表</param>
        /// <returns>執行訊息</returns>
        public static string WriteDataToDB(S7Client Client, string PLC_DB_Num, List<CNCToolOffsetModel> value_List)
        {
            // 檢查編號格式
            if (!int.TryParse(PLC_DB_Num, out int dbNum))
                return "PLC DB Number Error";

            // 宣告變數
            int code = 0;
            int index = 1;
            int start_index = 0;
            int total_data = value_List.Count();

            try
            {
                // 寫入資料
                foreach (CNCToolOffsetModel single_line in value_List)
                {
                    byte[] dbBuffer = new byte[32];
                    S7.SetRealAt(dbBuffer, 0, (float)single_line.T_NO);
                    S7.SetRealAt(dbBuffer, 4, (float)single_line.X_Wear);
                    S7.SetRealAt(dbBuffer, 8, (float)single_line.Z_Wear);
                    S7.SetRealAt(dbBuffer, 12, (float)single_line.R_Wear);
                    S7.SetRealAt(dbBuffer, 16, (float)single_line.X_Geom);
                    S7.SetRealAt(dbBuffer, 20, (float)single_line.Z_Geom);
                    S7.SetRealAt(dbBuffer, 24, (float)single_line.R_Geom);
                    S7.SetRealAt(dbBuffer, 28, (float)single_line.Tip);
                    code = Client.DBWrite(dbNum, start_index, dbBuffer.Length, dbBuffer);

                    if (code != 0)
                        return Client.ErrorText(code);

                    index++;
                    start_index += 32; // 資料起始位置偏移32byte
                }

                return "Data transfer to DB Succssfully";
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: Data[{index}, {total_data}]" + ex.ToString());
            }
        }
    }
}
