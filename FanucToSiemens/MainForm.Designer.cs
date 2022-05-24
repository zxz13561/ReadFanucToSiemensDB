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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxPLC_DBNum = new System.Windows.Forms.TextBox();
            this.labelDBNum = new System.Windows.Forms.Label();
            this.labelMsg = new System.Windows.Forms.Label();
            this.listBoxMsg = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBtnZHTW = new System.Windows.Forms.RadioButton();
            this.radioBtnEN = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.btnConnect.Location = new System.Drawing.Point(46, 102);
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
            this.btnDisconnect.Location = new System.Drawing.Point(174, 102);
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
            this.labelConnectStatus.Location = new System.Drawing.Point(299, 122);
            this.labelConnectStatus.Name = "labelConnectStatus";
            this.labelConnectStatus.Size = new System.Drawing.Size(92, 25);
            this.labelConnectStatus.TabIndex = 4;
            this.labelConnectStatus.Text = "尚未連線";
            this.labelConnectStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCNCPath
            // 
            this.labelCNCPath.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelCNCPath.Location = new System.Drawing.Point(18, 189);
            this.labelCNCPath.Name = "labelCNCPath";
            this.labelCNCPath.Size = new System.Drawing.Size(171, 42);
            this.labelCNCPath.TabIndex = 5;
            this.labelCNCPath.Text = "CNC路徑 :";
            this.labelCNCPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBoxCNCPath
            // 
            this.txtBoxCNCPath.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBoxCNCPath.Location = new System.Drawing.Point(195, 186);
            this.txtBoxCNCPath.Name = "txtBoxCNCPath";
            this.txtBoxCNCPath.Size = new System.Drawing.Size(114, 51);
            this.txtBoxCNCPath.TabIndex = 6;
            this.txtBoxCNCPath.Text = "1";
            this.txtBoxCNCPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReadValue
            // 
            this.btnReadValue.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReadValue.Location = new System.Drawing.Point(374, 235);
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
            this.listView_Result.Location = new System.Drawing.Point(21, 433);
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
            this.labelOffsetType.Location = new System.Drawing.Point(18, 250);
            this.labelOffsetType.Name = "labelOffsetType";
            this.labelOffsetType.Size = new System.Drawing.Size(103, 42);
            this.labelOffsetType.TabIndex = 10;
            this.labelOffsetType.Text = "種類 :";
            this.labelOffsetType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelOffsetNum
            // 
            this.labelOffsetNum.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelOffsetNum.Location = new System.Drawing.Point(167, 250);
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
            this.labelOuputOffsetType.Location = new System.Drawing.Point(127, 250);
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
            this.labelOuputOffsetNum.Location = new System.Drawing.Point(273, 250);
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
            this.labelViewListStatus.Location = new System.Drawing.Point(369, 202);
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
            this.labelPLCConnectStatus.Location = new System.Drawing.Point(12, 108);
            this.labelPLCConnectStatus.Name = "labelPLCConnectStatus";
            this.labelPLCConnectStatus.Size = new System.Drawing.Size(92, 25);
            this.labelPLCConnectStatus.TabIndex = 19;
            this.labelPLCConnectStatus.Text = "尚未連線";
            this.labelPLCConnectStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPLCDisconnect
            // 
            this.btnPLCDisconnect.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPLCDisconnect.Location = new System.Drawing.Point(153, 145);
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
            this.btnPLCConnect.Location = new System.Drawing.Point(17, 145);
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
            this.txtBoxPLCIP.Location = new System.Drawing.Point(212, 49);
            this.txtBoxPLCIP.Name = "txtBoxPLCIP";
            this.txtBoxPLCIP.Size = new System.Drawing.Size(261, 51);
            this.txtBoxPLCIP.TabIndex = 16;
            this.txtBoxPLCIP.Text = "192.168.3.15";
            // 
            // labelPLCIP
            // 
            this.labelPLCIP.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelPLCIP.Location = new System.Drawing.Point(10, 52);
            this.labelPLCIP.Name = "labelPLCIP";
            this.labelPLCIP.Size = new System.Drawing.Size(196, 42);
            this.labelPLCIP.TabIndex = 15;
            this.labelPLCIP.Text = "PLC IP位址 :";
            this.labelPLCIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPLCWriteDB
            // 
            this.btnPLCWriteDB.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPLCWriteDB.Location = new System.Drawing.Point(255, 235);
            this.btnPLCWriteDB.Name = "btnPLCWriteDB";
            this.btnPLCWriteDB.Size = new System.Drawing.Size(239, 57);
            this.btnPLCWriteDB.TabIndex = 20;
            this.btnPLCWriteDB.Text = "寫入PLC DB";
            this.btnPLCWriteDB.UseVisualStyleBackColor = true;
            this.btnPLCWriteDB.Click += new System.EventHandler(this.btnPLCWriteDB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.txtBoxPLC_DBNum);
            this.groupBox1.Controls.Add(this.labelDBNum);
            this.groupBox1.Controls.Add(this.btnPLCWriteDB);
            this.groupBox1.Controls.Add(this.labelPLCConnectStatus);
            this.groupBox1.Controls.Add(this.btnPLCDisconnect);
            this.groupBox1.Controls.Add(this.btnPLCConnect);
            this.groupBox1.Controls.Add(this.txtBoxPLCIP);
            this.groupBox1.Controls.Add(this.labelPLCIP);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(675, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 308);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PLC功能";
            // 
            // txtBoxPLC_DBNum
            // 
            this.txtBoxPLC_DBNum.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBoxPLC_DBNum.Location = new System.Drawing.Point(157, 235);
            this.txtBoxPLC_DBNum.Name = "txtBoxPLC_DBNum";
            this.txtBoxPLC_DBNum.Size = new System.Drawing.Size(78, 51);
            this.txtBoxPLC_DBNum.TabIndex = 22;
            this.txtBoxPLC_DBNum.Text = "300";
            // 
            // labelDBNum
            // 
            this.labelDBNum.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelDBNum.Location = new System.Drawing.Point(10, 238);
            this.labelDBNum.Name = "labelDBNum";
            this.labelDBNum.Size = new System.Drawing.Size(141, 42);
            this.labelDBNum.TabIndex = 21;
            this.labelDBNum.Text = "DB編號:";
            this.labelDBNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelMsg.Location = new System.Drawing.Point(758, 433);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(82, 22);
            this.labelMsg.TabIndex = 23;
            this.labelMsg.Text = "執行訊息:";
            // 
            // listBoxMsg
            // 
            this.listBoxMsg.FormattingEnabled = true;
            this.listBoxMsg.ItemHeight = 15;
            this.listBoxMsg.Location = new System.Drawing.Point(762, 458);
            this.listBoxMsg.Name = "listBoxMsg";
            this.listBoxMsg.Size = new System.Drawing.Size(432, 319);
            this.listBoxMsg.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDisconnect);
            this.groupBox2.Controls.Add(this.labelCNCIP);
            this.groupBox2.Controls.Add(this.txtBoxIP);
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Controls.Add(this.labelViewListStatus);
            this.groupBox2.Controls.Add(this.labelConnectStatus);
            this.groupBox2.Controls.Add(this.labelOuputOffsetNum);
            this.groupBox2.Controls.Add(this.btnReadValue);
            this.groupBox2.Controls.Add(this.labelOuputOffsetType);
            this.groupBox2.Controls.Add(this.labelCNCPath);
            this.groupBox2.Controls.Add(this.labelOffsetNum);
            this.groupBox2.Controls.Add(this.txtBoxCNCPath);
            this.groupBox2.Controls.Add(this.labelOffsetType);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(21, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 308);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CNC功能";
            // 
            // radioBtnZHTW
            // 
            this.radioBtnZHTW.AutoSize = true;
            this.radioBtnZHTW.Checked = true;
            this.radioBtnZHTW.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioBtnZHTW.Location = new System.Drawing.Point(6, 29);
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
            this.radioBtnEN.Location = new System.Drawing.Point(125, 29);
            this.radioBtnEN.Name = "radioBtnEN";
            this.radioBtnEN.Size = new System.Drawing.Size(100, 29);
            this.radioBtnEN.TabIndex = 27;
            this.radioBtnEN.Text = "English";
            this.radioBtnEN.UseVisualStyleBackColor = true;
            this.radioBtnEN.CheckedChanged += new System.EventHandler(this.radioBtnEN_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioBtnEN);
            this.groupBox3.Controls.Add(this.radioBtnZHTW);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(21, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 78);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "顯示語言/Language";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 797);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBoxMsg);
            this.Controls.Add(this.labelMsg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView_Result);
            this.Name = "MainForm";
            this.Text = "主程式";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelMsg;
        private System.Windows.Forms.ListBox listBoxMsg;
        private System.Windows.Forms.TextBox txtBoxPLC_DBNum;
        private System.Windows.Forms.Label labelDBNum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioBtnZHTW;
        private System.Windows.Forms.RadioButton radioBtnEN;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

