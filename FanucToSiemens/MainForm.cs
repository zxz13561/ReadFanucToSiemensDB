using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using Snap7;

namespace FanucToSiemens
{
    public partial class MainForm : Form
    {
        // CNC 變數
        private ushort cncHandle;
        private bool connectStatus = false;
        List<CNCToolOffsetModel> value_List = null;
        // PLC 變數
        private S7Client Client;
        private bool missingPLCdll = false;

        #region Form Initial Functions
        public MainForm()
        {
            InitializeComponent();
            try
            {
                Client = new S7Client();
            }
            catch (Exception ex)
            {
                missingPLCdll = true;
                ShowAllMsg(ex.ToString());
            }   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 讀取設定檔
            txtBoxIP.Text = Properties.Settings.Default.CNC_IP;
            txtBoxCNCPath.Text = Properties.Settings.Default.CNC_File_Path;
            txtBoxPLCIP.Text = Properties.Settings.Default.PLC_IP;
            txtBoxPLC_DBNum.Text = Properties.Settings.Default.PLC_DB_Num;

            if (!missingPLCdll)
            {
                // 顯示完成載入
                listBoxMsg.Items.Add(DateTime.Now.ToString() + " | Program Ready");
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
            }
            else
            {
                // 顯示完成載入
                listBoxMsg.Items.Add(DateTime.Now.ToString() + " | PLC S7 dll file missing");
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
            }
        }
        #endregion

        #region Form Element Functions
        private void btnConnect_Click(object sender, EventArgs e)
        {
            ShowAllMsg("CNC Connecting...");
            try
            {
                if(!ushort.TryParse(textBoxCNCPort.Text, out ushort CNC_Port))
                {
                    ShowAllMsg("Error : Port Number Parse to ushort error");
                    lightBall_CNC.Image = Properties.Resources.Yellow_light_25;
                    return;
                }

                ushort connect_result = FocasFunctions.CNC_Connect(txtBoxIP.Text, CNC_Port);
                switch (connect_result)
                {
                    case 404:
                        labelConnectStatus.Text = "連線失敗";
                        ShowAllMsg("Error : CNC Connect Fail");
                        lightBall_CNC.Image = Properties.Resources.Red_light_25;
                        break;

                    case 405:
                        labelConnectStatus.Text = "IP格式錯誤";
                        ShowAllMsg("Error : CNC Wrong IP format");
                        lightBall_CNC.Image = Properties.Resources.Yellow_light_25;
                        break;

                    default:
                        cncHandle = connect_result;
                        connectStatus = true;
                        labelConnectStatus.Text = "連線成功";
                        ShowAllMsg("CNC Connect Success");
                        lightBall_CNC.Image = Properties.Resources.Green_light_25;
                        break;
                }
            }
            catch (Exception ex)
            {
                ShowAllMsg(ex.ToString());
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            ShowAllMsg("CNC Disconnect...");

            if (connectStatus)
            {
                string result_string = FocasFunctions.CNC_Disconnect(cncHandle);
                if (result_string == "中斷失敗")
                {
                    cncHandle = 404;
                    connectStatus = false;
                    labelOuputOffsetType.Text = "NaN";
                    labelOuputOffsetNum.Text = "NaN";
                    listView_Result.Items.Clear();
                    labelConnectStatus.Text = "尚未連線";
                    value_List = null;
                    ShowAllMsg("Error : CNC Not Connecting");
                    lightBall_CNC.Image = Properties.Resources.Red_light_25;
                }
                else
                {                   
                    labelConnectStatus.Text = "中斷失敗";
                    ShowAllMsg("Error : CNC Disconnect Fail");
                    lightBall_CNC.Image = Properties.Resources.Yellow_light_25;
                }              
            }
            else
            {                
                labelConnectStatus.Text = "請先與機台連線";
                ShowAllMsg("Error : CNC Not Connecting");
                lightBall_CNC.Image = Properties.Resources.Yellow_light_25;
            }               
        }

        private void btnReadValue_Click(object sender, EventArgs e)
        {
            ShowAllMsg("Getting CNC Data...");

            // 清空ListView
            listView_Result.Items.Clear();

            // 檢查是否已連線
            if (!connectStatus)
            {
                ShowAllMsg("Error : CNC Not Connecting");
                lightBall_CNCData.Image = Properties.Resources.Red_light_25;
                return;
            }
                

            // 宣告變數
            string[] read_Result = new string[] { };
            value_List = new List<CNCToolOffsetModel>();

            // 取得參數表單與資料
            read_Result = FocasFunctions.Read_CNC_Tool_Offset_Type(txtBoxCNCPath.Text, cncHandle);
            value_List = FocasFunctions.Read_CNC_Tool_Offset_Values(txtBoxCNCPath.Text, cncHandle);

            // 顯示資料長度與種類
            if (read_Result != null && read_Result.Length == 2)
            {
                labelOuputOffsetType.Text = read_Result[0];
                labelOuputOffsetNum.Text = read_Result[1];
                ShowAllMsg("Getting CNC Offset Info Successfully");
            }
            else
            {
                labelViewListStatus.Text = connectStatus ? read_Result[0] : "尚未連線";
                lightBall_CNCData.Image = Properties.Resources.Red_light_25;
                labelOuputOffsetType.Text = "-";
                labelOuputOffsetNum.Text = "-";
                return;
            }

            // 顯示資料數值
            if (connectStatus && value_List != null)
            {
                labelViewListStatus.Text = "讀取成功";
                ShowAllMsg("Getting CNC Offset Data Successfully");
                lightBall_CNCData.Image = Properties.Resources.Green_light_25;

                int index = 1;
                // 寫入ViewList
                foreach (CNCToolOffsetModel offset_Value in value_List)
                {
                    ListViewItem tempItem = new ListViewItem(new string[] {
                        $"{offset_Value.T_NO}",
                        $"{offset_Value.X_Wear}",
                        $"{offset_Value.Z_Wear}",
                        $"{offset_Value.R_Wear}",
                        $"{offset_Value.X_Geom}",
                        $"{offset_Value.Z_Geom}",
                        $"{offset_Value.R_Geom}",
                        $"{offset_Value.Tip}"
                    });

                    listView_Result.Items.Add(tempItem);

                    ShowAllMsg($"Data Reading... [{index}, {labelOuputOffsetNum.Text}]...");
                    index++;
                }

                ShowAllMsg("CNC Data Reading Finished");
            }
            else
            {
                labelViewListStatus.Text = connectStatus?"讀取失敗":"請先與機台連線"; ;
                ShowAllMsg("Error: CNC Reading Fail");
                lightBall_CNCData.Image = Properties.Resources.Yellow_light_25;
            }
        }

        private void btnPLCConnect_Click(object sender, EventArgs e)
        {
            ShowAllMsg("PLC Connecting...");

            labelPLCConnectStatus.Text = PLCFunctions.ConnectPLC(Client, txtBoxPLCIP.Text);
            lightBall_PLC.Image = labelPLCConnectStatus.Text == "OK" ? Properties.Resources.Green_light_25 : Properties.Resources.Red_light_25;

            ShowAllMsg(labelPLCConnectStatus.Text);
        }

        private void btnPLCDisconnect_Click(object sender, EventArgs e)
        {
            ShowAllMsg("PLC Disconnecting...");

            string return_msg = PLCFunctions.DisconnectPLC(Client);
            labelPLCConnectStatus.Text = return_msg == "OK" ? "已中斷" : return_msg;
            lightBall_PLC.Image = return_msg == "OK" ? Properties.Resources.Red_light_25 : Properties.Resources.Yellow_light_25;

            ShowAllMsg("PLC Disconnect " + return_msg);
        }

        private void btnPLCWriteDB_Click(object sender, EventArgs e)
        {
            ShowAllMsg("Start Write Data into PLC DB...");

            if (value_List == null)
            {
                ShowAllMsg("Error : No CNC Data");
                return;
            }

            try
            {
                ShowAllMsg(PLCFunctions.WriteDataToDB(Client, txtBoxPLC_DBNum.Text, value_List));
            }
            catch (Exception ex)
            {
                ShowAllMsg(ex.ToString());
            }          
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 寫入設定
            Properties.Settings.Default.CNC_IP = txtBoxIP.Text;
            Properties.Settings.Default.CNC_File_Path = txtBoxCNCPath.Text;
            Properties.Settings.Default.PLC_IP = txtBoxPLCIP.Text;
            Properties.Settings.Default.PLC_DB_Num = txtBoxPLC_DBNum.Text;
            Properties.Settings.Default.Save();
        }

        private void radioBtnZHTW_CheckedChanged(object sender, EventArgs e)
        {          
            ChangeLanguage();
        }
        #endregion

        #region Sub-Functions
        /// <summary>
        /// 顯示系統執行的訊息
        /// </summary>
        /// <param name="getMsg">要顯示的訊息</param>
        public void ShowAllMsg(string getMsg)
        {
            getMsg = DateTime.Now.ToString() + " | " + getMsg;
            listBoxMsg.Items.Add(getMsg + Environment.NewLine);
            listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
        }

        /// <summary>
        /// 變更顯示語言
        /// </summary>
        public void ChangeLanguage()
        {
            if (radioBtnZHTW.Checked)
            {
                ShowAllMsg("Change to Chinese");
                System.Drawing.Font origin_size = new System.Drawing.Font("微軟正黑體", 19);

                labelCNCIP.Font = origin_size;
                labelCNCPath.Font = origin_size;
                labelOffsetType.Font = origin_size;
                labelOffsetNum.Font = origin_size;
                btnConnect.Font = origin_size;
                btnDisconnect.Font = origin_size;
                btnReadValue.Font = origin_size;
                labelPLCIP.Font = origin_size;
                labelDBNum.Font = origin_size;
                btnPLCConnect.Font = origin_size;
                btnPLCDisconnect.Font = origin_size;
                btnPLCWriteDB.Font = origin_size;

                labelCNCIP.Text = "CNC IP位址 :";
                labelCNCPath.Text = "CNC路徑 :";
                labelOffsetType.Text = "種類:";
                labelOffsetNum.Text = "總數:";
                btnConnect.Text = "連線";
                btnDisconnect.Text = "中斷";
                btnReadValue.Text = "讀取補正數值";
                labelPLCIP.Text = "PLC IP位址 :";
                labelDBNum.Text = "DB編號:";
                btnPLCConnect.Text = "連線";
                btnPLCDisconnect.Text = "中斷";
                btnPLCWriteDB.Text = "寫入PLC DB";
                groupBoxCNC.Text = "CNC功能";
                groupBoxPLC.Text = "PLC功能";
                labelMsg.Text = "執行訊息:";
                groupBoxStatus.Text = "運行狀態";
            }
            else if (radioBtnEN.Checked)
            {
                ShowAllMsg("Change to English");
                System.Drawing.Font size14 = new System.Drawing.Font("微軟正黑體", 14);
                System.Drawing.Font size10 = new System.Drawing.Font("微軟正黑體", 10);

                labelCNCIP.Font = size14;
                labelCNCPath.Font = size14;
                labelOffsetType.Font = size14;
                labelOffsetNum.Font = size14;
                btnConnect.Font = size10;
                btnDisconnect.Font = size10;
                btnReadValue.Font = size14;
                labelPLCIP.Font = size14;
                labelDBNum.Font = size14;
                btnPLCConnect.Font = size10;
                btnPLCDisconnect.Font = size10;
                btnPLCWriteDB.Font = size14;

                labelCNCIP.Text = "CNC IP Address :";
                labelCNCPath.Text = "CNC Path :";
                labelOffsetType.Text = "Type :";
                labelOffsetNum.Text = "Count :";
                btnConnect.Text = "Connect";
                btnDisconnect.Text = "Disconnect";
                btnReadValue.Text = "Get Offset Data";
                labelPLCIP.Text = "PLC IP Address :";
                labelDBNum.Text = "DB Num :";
                btnPLCConnect.Text = "Connect";
                btnPLCDisconnect.Text = "Disconnect";
                btnPLCWriteDB.Text = "Transfer to PLC DB";
                groupBoxCNC.Text = "CNC Function";
                groupBoxPLC.Text = "PLC Function";
                labelMsg.Text = "Program Message:";
                groupBoxStatus.Text = "Running Status";
            }
        }
        #endregion
    }
}
