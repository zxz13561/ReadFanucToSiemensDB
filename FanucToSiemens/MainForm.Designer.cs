namespace FanucToSiemens
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCNCIP = new System.Windows.Forms.Label();
            this.txtBoxIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.labelConnectStatus = new System.Windows.Forms.Label();
            this.labelCNCPath = new System.Windows.Forms.Label();
            this.txtBoxCNCPath = new System.Windows.Forms.TextBox();
            this.btnReadValue = new System.Windows.Forms.Button();
            this.listView_Result = new System.Windows.Forms.ListView();
            this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.X_w = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Z_w = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.R_w = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.X_g = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Z_g = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.R_g = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelOffsetType = new System.Windows.Forms.Label();
            this.labelOffsetNum = new System.Windows.Forms.Label();
            this.labelOuputOffsetType = new System.Windows.Forms.Label();
            this.labelOuputOffsetNum = new System.Windows.Forms.Label();
            this.labelViewListStatus = new System.Windows.Forms.Label();
            this.labelPLCConnectStatus = new System.Windows.Forms.Label();
            this.btnPLCDisconnect = new System.Windows.Forms.Button();
            this.btnPLCConnect = new System.Windows.Forms.Button();
            this.txtBoxPLCIP = new System.Windows.Forms.TextBox();
            this.labelPLCIP = new System.Windows.Forms.Label();
            this.btnPLCWriteDB = new System.Windows.Forms.Button();
            this.groupBoxPLC = new System.Windows.Forms.GroupBox();
            this.txtBoxPLC_DBNum = new System.Windows.Forms.TextBox();
            this.labelDBNum = new System.Windows.Forms.Label();
            this.labelMsg = new System.Windows.Forms.Label();
            this.listBoxMsg = new System.Windows.Forms.ListBox();
            this.groupBoxCNC = new System.Windows.Forms.GroupBox();
            this.labelCNCPort = new System.Windows.Forms.Label();
            this.textBoxCNCPort = new System.Windows.Forms.TextBox();
            this.radioBtnZHTW = new System.Windows.Forms.RadioButton();
            this.radioBtnEN = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.lblStatus_PLC = new System.Windows.Forms.Label();
            this.lightBall_PLC = new System.Windows.Forms.PictureBox();
            this.lblStatus_CNCData = new System.Windows.Forms.Label();
            this.lightBall_CNCData = new System.Windows.Forms.PictureBox();
            this.lblStatus_CNC = new System.Windows.Forms.Label();
            this.lightBall_CNC = new System.Windows.Forms.PictureBox();
            this.groupBoxPLC.SuspendLayout();
            this.groupBoxCNC.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lightBall_PLC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightBall_CNCData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightBall_CNC)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCNCIP
            // 
            this.labelCNCIP.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelCNCIP.Location = new System.Drawing.Point(18, 39);
            this.labelCNCIP.Name = "labelCNCIP";
            this.labelCNCIP.Size = new System.Drawing.Size(208, 42);
            this.labelCNCIP.TabIndex = 0;
            this.labelCNCIP.Text = "CNC IP位址 :";
            this.labelCNCIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBoxIP
            // 
            this.txtBoxIP.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBoxIP.Location = new System.Drawing.Point(232, 36);
            this.txtBoxIP.Name = "txtBoxIP";
            this.txtBoxIP.Size = new System.Drawing.Size(261, 51);
            this.txtBoxIP.TabIndex = 1;
            this.txtBoxIP.Text = "127.0.0.1";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConnect.Location = new System.Drawing.Point(358, 99);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(106, 57);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "連線";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDisconnect.Location = new System.Drawing.Point(486, 99);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(106, 57);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "中斷";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // labelConnectStatus
            // 
            this.labelConnectStatus.AutoSize = true;
            this.labelConnectStatus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelConnectStatus.Location = new System.Drawing.Point(132, 33);
            this.labelConnectStatus.Name = "labelConnectStatus";
            this.labelConnectStatus.Size = new System.Drawing.Size(92, 25);
            this.labelConnectStatus.TabIndex = 4;
            this.labelConnectStatus.Text = "尚未連線";
            this.labelConnectStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCNCPath
            // 
            this.labelCNCPath.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelCNCPath.Location = new System.Drawing.Point(53, 173);
            this.labelCNCPath.Name = "labelCNCPath";
            this.labelCNCPath.Size = new System.Drawing.Size(171, 42);
            this.labelCNCPath.TabIndex = 5;
            this.labelCNCPath.Text = "CNC路徑 :";
            this.labelCNCPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBoxCNCPath
            // 
            this.txtBoxCNCPath.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBoxCNCPath.Location = new System.Drawing.Point(230, 170);
            this.txtBoxCNCPath.Name = "txtBoxCNCPath";
            this.txtBoxCNCPath.Size = new System.Drawing.Size(94, 51);
            this.txtBoxCNCPath.TabIndex = 6;
            this.txtBoxCNCPath.Text = "1";
            this.txtBoxCNCPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReadValue
            // 
            this.btnReadValue.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReadValue.Location = new System.Drawing.Point(358, 166);
            this.btnReadValue.Name = "btnReadValue";
            this.btnReadValue.Size = new System.Drawing.Size(234, 57);
            this.btnReadValue.TabIndex = 8;
            this.btnReadValue.Text = "讀取補正數值";
            this.btnReadValue.UseVisualStyleBackColor = true;
            this.btnReadValue.Click += new System.EventHandler(this.btnReadValue_Click);
            // 
            // listView_Result
            // 
            this.listView_Result.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.X_w,
            this.Z_w,
            this.R_w,
            this.X_g,
            this.Z_g,
            this.R_g,
            this.Tip});
            this.listView_Result.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listView_Result.GridLines = true;
            this.listView_Result.Location = new System.Drawing.Point(21, 389);
            this.listView_Result.Name = "listView_Result";
            this.listView_Result.Size = new System.Drawing.Size(731, 344);
            this.listView_Result.TabIndex = 9;
            this.listView_Result.UseCompatibleStateImageBehavior = false;
            this.listView_Result.View = System.Windows.Forms.View.Details;
            // 
            // No
            // 
            this.No.Text = "No";
            // 
            // X_w
            // 
            this.X_w.Text = "X:Wear";
            this.X_w.Width = 72;
            // 
            // Z_w
            // 
            this.Z_w.Text = "Z:Wear";
            this.Z_w.Width = 68;
            // 
            // R_w
            // 
            this.R_w.Text = "R:Wear";
            this.R_w.Width = 73;
            // 
            // X_g
            // 
            this.X_g.Text = "X:GEOM";
            this.X_g.Width = 82;
            // 
            // Z_g
            // 
            this.Z_g.Text = "Z:GEOM";
            this.Z_g.Width = 81;
            // 
            // R_g
            // 
            this.R_g.Text = "R:GEOM";
            this.R_g.Width = 79;
            // 
            // Tip
            // 
            this.Tip.Text = "Tip";
            this.Tip.Width = 58;
            // 
            // labelOffsetType
            // 
            this.labelOffsetType.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelOffsetType.Location = new System.Drawing.Point(18, 234);
            this.labelOffsetType.Name = "labelOffsetType";
            this.labelOffsetType.Size = new System.Drawing.Size(103, 42);
            this.labelOffsetType.TabIndex = 10;
            this.labelOffsetType.Text = "種類 :";
            this.labelOffsetType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelOffsetNum
            // 
            this.labelOffsetNum.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelOffsetNum.Location = new System.Drawing.Point(209, 234);
            this.labelOffsetNum.Name = "labelOffsetNum";
            this.labelOffsetNum.Size = new System.Drawing.Size(100, 42);
            this.labelOffsetNum.TabIndex = 11;
            this.labelOffsetNum.Text = "總數 :";
            this.labelOffsetNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelOuputOffsetType
            // 
            this.labelOuputOffsetType.AutoSize = true;
            this.labelOuputOffsetType.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelOuputOffsetType.Location = new System.Drawing.Point(127, 234);
            this.labelOuputOffsetType.Name = "labelOuputOffsetType";
            this.labelOuputOffsetType.Size = new System.Drawing.Size(32, 42);
            this.labelOuputOffsetType.TabIndex = 12;
            this.labelOuputOffsetType.Text = "-";
            this.labelOuputOffsetType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelOuputOffsetNum
            // 
            this.labelOuputOffsetNum.AutoSize = true;
            this.labelOuputOffsetNum.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelOuputOffsetNum.Location = new System.Drawing.Point(315, 234);
            this.labelOuputOffsetNum.Name = "labelOuputOffsetNum";
            this.labelOuputOffsetNum.Size = new System.Drawing.Size(32, 42);
            this.labelOuputOffsetNum.TabIndex = 13;
            this.labelOuputOffsetNum.Text = "-";
            this.labelOuputOffsetNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelViewListStatus
            // 
            this.labelViewListStatus.AutoSize = true;
            this.labelViewListStatus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelViewListStatus.Location = new System.Drawing.Point(464, 33);
            this.labelViewListStatus.Name = "labelViewListStatus";
            this.labelViewListStatus.Size = new System.Drawing.Size(92, 25);
            this.labelViewListStatus.TabIndex = 14;
            this.labelViewListStatus.Text = "尚未讀取";
            this.labelViewListStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPLCConnectStatus
            // 
            this.labelPLCConnectStatus.AutoSize = true;
            this.labelPLCConnectStatus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelPLCConnectStatus.Location = new System.Drawing.Point(736, 33);
            this.labelPLCConnectStatus.Name = "labelPLCConnectStatus";
            this.labelPLCConnectStatus.Size = new System.Drawing.Size(92, 25);
            this.labelPLCConnectStatus.TabIndex = 19;
            this.labelPLCConnectStatus.Text = "尚未連線";
            this.labelPLCConnectStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPLCDisconnect
            // 
            this.btnPLCDisconnect.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPLCDisconnect.Location = new System.Drawing.Point(340, 105);
            this.btnPLCDisconnect.Name = "btnPLCDisconnect";
            this.btnPLCDisconnect.Size = new System.Drawing.Size(106, 57);
            this.btnPLCDisconnect.TabIndex = 18;
            this.btnPLCDisconnect.Text = "中斷";
            this.btnPLCDisconnect.UseVisualStyleBackColor = true;
            this.btnPLCDisconnect.Click += new System.EventHandler(this.btnPLCDisconnect_Click);
            // 
            // btnPLCConnect
            // 
            this.btnPLCConnect.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPLCConnect.Location = new System.Drawing.Point(212, 105);
            this.btnPLCConnect.Name = "btnPLCConnect";
            this.btnPLCConnect.Size = new System.Drawing.Size(106, 57);
            this.btnPLCConnect.TabIndex = 17;
            this.btnPLCConnect.Text = "連線";
            this.btnPLCConnect.UseVisualStyleBackColor = true;
            this.btnPLCConnect.Click += new System.EventHandler(this.btnPLCConnect_Click);
            // 
            // txtBoxPLCIP
            // 
            this.txtBoxPLCIP.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBoxPLCIP.Location = new System.Drawing.Point(212, 36);
            this.txtBoxPLCIP.Name = "txtBoxPLCIP";
            this.txtBoxPLCIP.Size = new System.Drawing.Size(261, 51);
            this.txtBoxPLCIP.TabIndex = 16;
            this.txtBoxPLCIP.Text = "192.168.3.15";
            // 
            // labelPLCIP
            // 
            this.labelPLCIP.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelPLCIP.Location = new System.Drawing.Point(10, 39);
            this.labelPLCIP.Name = "labelPLCIP";
            this.labelPLCIP.Size = new System.Drawing.Size(196, 42);
            this.labelPLCIP.TabIndex = 15;
            this.labelPLCIP.Text = "PLC IP位址 :";
            this.labelPLCIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPLCWriteDB
            // 
            this.btnPLCWriteDB.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPLCWriteDB.Location = new System.Drawing.Point(250, 182);
            this.btnPLCWriteDB.Name = "btnPLCWriteDB";
            this.btnPLCWriteDB.Size = new System.Drawing.Size(239, 57);
            this.btnPLCWriteDB.TabIndex = 20;
            this.btnPLCWriteDB.Text = "寫入PLC DB";
            this.btnPLCWriteDB.UseVisualStyleBackColor = true;
            this.btnPLCWriteDB.Click += new System.EventHandler(this.btnPLCWriteDB_Click);
            // 
            // groupBoxPLC
            // 
            this.groupBoxPLC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxPLC.Controls.Add(this.txtBoxPLC_DBNum);
            this.groupBoxPLC.Controls.Add(this.labelDBNum);
            this.groupBoxPLC.Controls.Add(this.btnPLCWriteDB);
            this.groupBoxPLC.Controls.Add(this.btnPLCDisconnect);
            this.groupBoxPLC.Controls.Add(this.btnPLCConnect);
            this.groupBoxPLC.Controls.Add(this.txtBoxPLCIP);
            this.groupBoxPLC.Controls.Add(this.labelPLCIP);
            this.groupBoxPLC.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBoxPLC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxPLC.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxPLC.Location = new System.Drawing.Point(656, 96);
            this.groupBoxPLC.Name = "groupBoxPLC";
            this.groupBoxPLC.Size = new System.Drawing.Size(510, 287);
            this.groupBoxPLC.TabIndex = 21;
            this.groupBoxPLC.TabStop = false;
            this.groupBoxPLC.Text = "PLC功能";
            // 
            // txtBoxPLC_DBNum
            // 
            this.txtBoxPLC_DBNum.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBoxPLC_DBNum.Location = new System.Drawing.Point(157, 186);
            this.txtBoxPLC_DBNum.Name = "txtBoxPLC_DBNum";
            this.txtBoxPLC_DBNum.Size = new System.Drawing.Size(78, 51);
            this.txtBoxPLC_DBNum.TabIndex = 22;
            this.txtBoxPLC_DBNum.Text = "300";
            // 
            // labelDBNum
            // 
            this.labelDBNum.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelDBNum.Location = new System.Drawing.Point(10, 189);
            this.labelDBNum.Name = "labelDBNum";
            this.labelDBNum.Size = new System.Drawing.Size(141, 42);
            this.labelDBNum.TabIndex = 21;
            this.labelDBNum.Text = "DB編號:";
            this.labelDBNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelMsg.Location = new System.Drawing.Point(758, 389);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(82, 22);
            this.labelMsg.TabIndex = 23;
            this.labelMsg.Text = "執行訊息:";
            // 
            // listBoxMsg
            // 
            this.listBoxMsg.FormattingEnabled = true;
            this.listBoxMsg.ItemHeight = 15;
            this.listBoxMsg.Location = new System.Drawing.Point(762, 414);
            this.listBoxMsg.Name = "listBoxMsg";
            this.listBoxMsg.Size = new System.Drawing.Size(432, 319);
            this.listBoxMsg.TabIndex = 24;
            // 
            // groupBoxCNC
            // 
            this.groupBoxCNC.Controls.Add(this.labelCNCPort);
            this.groupBoxCNC.Controls.Add(this.textBoxCNCPort);
            this.groupBoxCNC.Controls.Add(this.btnDisconnect);
            this.groupBoxCNC.Controls.Add(this.labelCNCIP);
            this.groupBoxCNC.Controls.Add(this.txtBoxIP);
            this.groupBoxCNC.Controls.Add(this.btnConnect);
            this.groupBoxCNC.Controls.Add(this.labelOuputOffsetNum);
            this.groupBoxCNC.Controls.Add(this.btnReadValue);
            this.groupBoxCNC.Controls.Add(this.labelOuputOffsetType);
            this.groupBoxCNC.Controls.Add(this.labelCNCPath);
            this.groupBoxCNC.Controls.Add(this.labelOffsetNum);
            this.groupBoxCNC.Controls.Add(this.txtBoxCNCPath);
            this.groupBoxCNC.Controls.Add(this.labelOffsetType);
            this.groupBoxCNC.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxCNC.Location = new System.Drawing.Point(21, 96);
            this.groupBoxCNC.Name = "groupBoxCNC";
            this.groupBoxCNC.Size = new System.Drawing.Size(629, 287);
            this.groupBoxCNC.TabIndex = 25;
            this.groupBoxCNC.TabStop = false;
            this.groupBoxCNC.Text = "CNC功能";
            // 
            // labelCNCPort
            // 
            this.labelCNCPort.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelCNCPort.Location = new System.Drawing.Point(18, 106);
            this.labelCNCPort.Name = "labelCNCPort";
            this.labelCNCPort.Size = new System.Drawing.Size(208, 42);
            this.labelCNCPort.TabIndex = 15;
            this.labelCNCPort.Text = "CNC Port :";
            this.labelCNCPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxCNCPort
            // 
            this.textBoxCNCPort.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxCNCPort.Location = new System.Drawing.Point(232, 103);
            this.textBoxCNCPort.Name = "textBoxCNCPort";
            this.textBoxCNCPort.Size = new System.Drawing.Size(92, 51);
            this.textBoxCNCPort.TabIndex = 14;
            this.textBoxCNCPort.Text = "8193";
            this.textBoxCNCPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioBtnZHTW
            // 
            this.radioBtnZHTW.AutoSize = true;
            this.radioBtnZHTW.Checked = true;
            this.radioBtnZHTW.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioBtnZHTW.Location = new System.Drawing.Point(8, 29);
            this.radioBtnZHTW.Name = "radioBtnZHTW";
            this.radioBtnZHTW.Size = new System.Drawing.Size(113, 29);
            this.radioBtnZHTW.TabIndex = 26;
            this.radioBtnZHTW.TabStop = true;
            this.radioBtnZHTW.Text = "繁體中文";
            this.radioBtnZHTW.UseVisualStyleBackColor = true;
            this.radioBtnZHTW.CheckedChanged += new System.EventHandler(this.radioBtnZHTW_CheckedChanged);
            // 
            // radioBtnEN
            // 
            this.radioBtnEN.AutoSize = true;
            this.radioBtnEN.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioBtnEN.Location = new System.Drawing.Point(134, 29);
            this.radioBtnEN.Name = "radioBtnEN";
            this.radioBtnEN.Size = new System.Drawing.Size(100, 29);
            this.radioBtnEN.TabIndex = 27;
            this.radioBtnEN.Text = "English";
            this.radioBtnEN.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioBtnEN);
            this.groupBox3.Controls.Add(this.radioBtnZHTW);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(21, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 78);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "顯示語言/Language";
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.lblStatus_PLC);
            this.groupBoxStatus.Controls.Add(this.labelConnectStatus);
            this.groupBoxStatus.Controls.Add(this.lightBall_PLC);
            this.groupBoxStatus.Controls.Add(this.labelPLCConnectStatus);
            this.groupBoxStatus.Controls.Add(this.lblStatus_CNCData);
            this.groupBoxStatus.Controls.Add(this.labelViewListStatus);
            this.groupBoxStatus.Controls.Add(this.lightBall_CNCData);
            this.groupBoxStatus.Controls.Add(this.lblStatus_CNC);
            this.groupBoxStatus.Controls.Add(this.lightBall_CNC);
            this.groupBoxStatus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxStatus.Location = new System.Drawing.Point(274, 12);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(892, 78);
            this.groupBoxStatus.TabIndex = 29;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "運行狀態";
            // 
            // lblStatus_PLC
            // 
            this.lblStatus_PLC.AutoSize = true;
            this.lblStatus_PLC.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStatus_PLC.Location = new System.Drawing.Point(673, 31);
            this.lblStatus_PLC.Name = "lblStatus_PLC";
            this.lblStatus_PLC.Size = new System.Drawing.Size(57, 25);
            this.lblStatus_PLC.TabIndex = 5;
            this.lblStatus_PLC.Text = "PLC :";
            // 
            // lightBall_PLC
            // 
            this.lightBall_PLC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lightBall_PLC.Image = global::FanucToSiemens.Properties.Resources.Red_light_25;
            this.lightBall_PLC.Location = new System.Drawing.Point(642, 33);
            this.lightBall_PLC.Name = "lightBall_PLC";
            this.lightBall_PLC.Size = new System.Drawing.Size(25, 25);
            this.lightBall_PLC.TabIndex = 4;
            this.lightBall_PLC.TabStop = false;
            // 
            // lblStatus_CNCData
            // 
            this.lblStatus_CNCData.AutoSize = true;
            this.lblStatus_CNCData.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStatus_CNCData.Location = new System.Drawing.Point(345, 33);
            this.lblStatus_CNCData.Name = "lblStatus_CNCData";
            this.lblStatus_CNCData.Size = new System.Drawing.Size(113, 25);
            this.lblStatus_CNCData.TabIndex = 3;
            this.lblStatus_CNCData.Text = "CNC Data :";
            // 
            // lightBall_CNCData
            // 
            this.lightBall_CNCData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lightBall_CNCData.Image = global::FanucToSiemens.Properties.Resources.Red_light_25;
            this.lightBall_CNCData.Location = new System.Drawing.Point(314, 33);
            this.lightBall_CNCData.Name = "lightBall_CNCData";
            this.lightBall_CNCData.Size = new System.Drawing.Size(25, 25);
            this.lightBall_CNCData.TabIndex = 2;
            this.lightBall_CNCData.TabStop = false;
            // 
            // lblStatus_CNC
            // 
            this.lblStatus_CNC.AutoSize = true;
            this.lblStatus_CNC.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStatus_CNC.Location = new System.Drawing.Point(62, 33);
            this.lblStatus_CNC.Name = "lblStatus_CNC";
            this.lblStatus_CNC.Size = new System.Drawing.Size(64, 25);
            this.lblStatus_CNC.TabIndex = 1;
            this.lblStatus_CNC.Text = "CNC :";
            // 
            // lightBall_CNC
            // 
            this.lightBall_CNC.AccessibleName = "";
            this.lightBall_CNC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lightBall_CNC.Cursor = System.Windows.Forms.Cursors.Default;
            this.lightBall_CNC.Image = global::FanucToSiemens.Properties.Resources.Red_light_25;
            this.lightBall_CNC.Location = new System.Drawing.Point(31, 33);
            this.lightBall_CNC.Name = "lightBall_CNC";
            this.lightBall_CNC.Size = new System.Drawing.Size(25, 25);
            this.lightBall_CNC.TabIndex = 0;
            this.lightBall_CNC.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 749);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxCNC);
            this.Controls.Add(this.listBoxMsg);
            this.Controls.Add(this.labelMsg);
            this.Controls.Add(this.groupBoxPLC);
            this.Controls.Add(this.listView_Result);
            this.Name = "MainForm";
            this.Text = "主程式";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPLC.ResumeLayout(false);
            this.groupBoxPLC.PerformLayout();
            this.groupBoxCNC.ResumeLayout(false);
            this.groupBoxCNC.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lightBall_PLC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightBall_CNCData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightBall_CNC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCNCIP;
        private System.Windows.Forms.TextBox txtBoxIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label labelConnectStatus;
        private System.Windows.Forms.Label labelCNCPath;
        private System.Windows.Forms.TextBox txtBoxCNCPath;
        private System.Windows.Forms.Button btnReadValue;
        private System.Windows.Forms.ListView listView_Result;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader X_w;
        private System.Windows.Forms.ColumnHeader Z_w;
        private System.Windows.Forms.ColumnHeader R_w;
        private System.Windows.Forms.ColumnHeader X_g;
        private System.Windows.Forms.ColumnHeader Z_g;
        private System.Windows.Forms.ColumnHeader R_g;
        private System.Windows.Forms.ColumnHeader Tip;
        private System.Windows.Forms.Label labelOffsetType;
        private System.Windows.Forms.Label labelOffsetNum;
        private System.Windows.Forms.Label labelOuputOffsetType;
        private System.Windows.Forms.Label labelOuputOffsetNum;
        private System.Windows.Forms.Label labelViewListStatus;
        private System.Windows.Forms.Label labelPLCConnectStatus;
        private System.Windows.Forms.Button btnPLCDisconnect;
        private System.Windows.Forms.Button btnPLCConnect;
        private System.Windows.Forms.TextBox txtBoxPLCIP;
        private System.Windows.Forms.Label labelPLCIP;
        private System.Windows.Forms.Button btnPLCWriteDB;
        private System.Windows.Forms.GroupBox groupBoxPLC;
        private System.Windows.Forms.Label labelMsg;
        private System.Windows.Forms.ListBox listBoxMsg;
        private System.Windows.Forms.TextBox txtBoxPLC_DBNum;
        private System.Windows.Forms.Label labelDBNum;
        private System.Windows.Forms.GroupBox groupBoxCNC;
        private System.Windows.Forms.RadioButton radioBtnZHTW;
        private System.Windows.Forms.RadioButton radioBtnEN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.Label lblStatus_CNC;
        private System.Windows.Forms.Label lblStatus_PLC;
        private System.Windows.Forms.PictureBox lightBall_PLC;
        private System.Windows.Forms.Label lblStatus_CNCData;
        private System.Windows.Forms.PictureBox lightBall_CNCData;
        private System.Windows.Forms.PictureBox lightBall_CNC;
        private System.Windows.Forms.Label labelCNCPort;
        private System.Windows.Forms.TextBox textBoxCNCPort;
    }
}

