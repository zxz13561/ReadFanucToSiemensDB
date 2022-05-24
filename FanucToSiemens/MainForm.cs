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

        #region Form Initial Functions
        public MainForm()
        {
            InitializeComponent();
            Client = new S7Client();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 讀取設定檔
            txtBoxIP.Text = Properties.Settings.Default.CNC_IP;
            txtBoxCNCPath.Text = Properties.Settings.Default.CNC_File_Path;
            txtBoxPLCIP.Text = Properties.Settings.Default.PLC_IP;
            txtBoxPLC_DBNum.Text = Properties.Settings.Default.PLC_DB_Num;

            // 顯示完成載入
            listBoxMsg.Items.Add(DateTime.Now.ToString() + " | Program Ready");
            listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
        }
        #endregion

        #region Form Element Functions
        private void btnConnect_Click(object sender, EventArgs e)
        {
            ShowAllMsg("CNC Connecting...");
            try
            {
                ushort connect_result = FocasFunctions.CNC_Connect(txtBoxIP.Text);
                switch (connect_result)
                {
                    case 404:
                        labelConnectStatus.Text = "連線失敗";
                        ShowAllMsg("Error : CNC Connect Fail");
                        break;

                    case 405:
                        labelConnectStatus.Text = "IP格式錯誤";
                        ShowAllMsg("Error : CNC Wrong IP format");
                        break;

                    default:
                        cncHandle = connect_result;
                        connectStatus = true;
                        labelConnectStatus.Text = "連線成功";
                        ShowAllMsg("CNC Connect Success");
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

                }
                else
                {
                    labelConnectStatus.Text = "中斷失敗";
                    ShowAllMsg("Error : CNC Disconnect Fail");
                }              
            }
            else
            {
                labelConnectStatus.Text = "請先與機台連線";
                ShowAllMsg("Error : CNC Not Connecting");
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
                labelOuputOffsetType.Text = "-";
                labelOuputOffsetNum.Text = "-";
                return;
            }

            // 顯示資料數值
            if (connectStatus && value_List != null)
            {
                labelViewListStatus.Text = "讀取成功";
                ShowAllMsg("Getting CNC Offset Data Successfully");

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
            }
        }

        private void btnPLCConnect_Click(object sender, EventArgs e)
        {
            ShowAllMsg("PLC Connecting...");

            labelPLCConnectStatus.Text = PLCFunctions.ConnectPLC(Client, txtBoxPLCIP.Text);

            ShowAllMsg(labelPLCConnectStatus.Text);
        }

        private void btnPLCDisconnect_Click(object sender, EventArgs e)
        {
            ShowAllMsg("PLC Disconnecting...");

            string return_msg = PLCFunctions.DisconnectPLC(Client);
            labelPLCConnectStatus.Text = return_msg == "OK" ? "已中斷" : return_msg;

            ShowAllMsg(labelPLCConnectStatus.Text);
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


        #endregion
    }
}
