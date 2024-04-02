namespace SerialTools
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip_Form = new System.Windows.Forms.ToolStrip();
            this.btn_Start = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Exit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_SelectPort = new System.Windows.Forms.ToolStripLabel();
            this.cmbx_SelectPort = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_SelectBaudrate = new System.Windows.Forms.ToolStripLabel();
            this.cmbx_SelectBaudrate = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_SelectStopBits = new System.Windows.Forms.ToolStripLabel();
            this.cmbx_SelectStopBits = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_SelectDataBits = new System.Windows.Forms.ToolStripLabel();
            this.cmbx_SelectDatabits = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_SelectParity = new System.Windows.Forms.ToolStripLabel();
            this.cmbx_SelectParity = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Clean = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_OpenFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_topDisplay = new System.Windows.Forms.ToolStripButton();
            this.txtbx_Log = new System.Windows.Forms.TextBox();
            this.tabctrl_Form = new System.Windows.Forms.TabControl();
            this.tabPage_Generic = new System.Windows.Forms.TabPage();
            this.pnl_GenericRx = new System.Windows.Forms.Panel();
            this.txtbx_NormalRx = new System.Windows.Forms.TextBox();
            this.pnl_GenericTx = new System.Windows.Forms.Panel();
            this.txtbx_NormalTx = new System.Windows.Forms.TextBox();
            this.pnl_GenericTxCtrl = new System.Windows.Forms.Panel();
            this.lbl_NormalTxCnt = new System.Windows.Forms.Label();
            this.lbl_NormalRxCnt = new System.Windows.Forms.Label();
            this.chkbx_NormalHexRxDsplay = new System.Windows.Forms.CheckBox();
            this.lbl_GenericTxPs = new System.Windows.Forms.Label();
            this.txtbx_NormalTxPs = new System.Windows.Forms.TextBox();
            this.chkbx_NormalTxPs = new System.Windows.Forms.CheckBox();
            this.chkbx_NormalTime = new System.Windows.Forms.CheckBox();
            this.chkbx_NormalHexTxDisplay = new System.Windows.Forms.CheckBox();
            this.btn_GenericTxClear = new System.Windows.Forms.Button();
            this.btn_GenericTxSend = new System.Windows.Forms.Button();
            this.tabPage_ModbusMaster = new System.Windows.Forms.TabPage();
            this.tabPage_ModbusSlave = new System.Windows.Forms.TabPage();
            this.toolStrip_Form.SuspendLayout();
            this.tabctrl_Form.SuspendLayout();
            this.tabPage_Generic.SuspendLayout();
            this.pnl_GenericRx.SuspendLayout();
            this.pnl_GenericTx.SuspendLayout();
            this.pnl_GenericTxCtrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip_Form
            // 
            this.toolStrip_Form.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Start,
            this.toolStripSeparator1,
            this.btn_Exit,
            this.toolStripSeparator2,
            this.btn_Clean,
            this.toolStripSeparator8,
            this.lbl_SelectPort,
            this.cmbx_SelectPort,
            this.toolStripSeparator3,
            this.lbl_SelectBaudrate,
            this.cmbx_SelectBaudrate,
            this.toolStripSeparator4,
            this.lbl_SelectStopBits,
            this.cmbx_SelectStopBits,
            this.toolStripSeparator5,
            this.lbl_SelectDataBits,
            this.cmbx_SelectDatabits,
            this.toolStripSeparator6,
            this.lbl_SelectParity,
            this.cmbx_SelectParity,
            this.toolStripSeparator7,
            this.btn_OpenFolder,
            this.toolStripSeparator9,
            this.btn_topDisplay});
            this.toolStrip_Form.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_Form.Name = "toolStrip_Form";
            this.toolStrip_Form.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip_Form.TabIndex = 0;
            this.toolStrip_Form.Text = "toolStrip1";
            // 
            // btn_Start
            // 
            this.btn_Start.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Start.Image = ((System.Drawing.Image)(resources.GetObject("btn_Start.Image")));
            this.btn_Start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(60, 22);
            this.btn_Start.Text = "开始连接";
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Exit
            // 
            this.btn_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(60, 22);
            this.btn_Exit.Text = "退出软件";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lbl_SelectPort
            // 
            this.lbl_SelectPort.Name = "lbl_SelectPort";
            this.lbl_SelectPort.Size = new System.Drawing.Size(32, 22);
            this.lbl_SelectPort.Text = "端口";
            this.lbl_SelectPort.Click += new System.EventHandler(this.lbl_SelectPort_Click);
            this.lbl_SelectPort.DoubleClick += new System.EventHandler(this.lbl_SelectPort_Click);
            // 
            // cmbx_SelectPort
            // 
            this.cmbx_SelectPort.Name = "cmbx_SelectPort";
            this.cmbx_SelectPort.Size = new System.Drawing.Size(300, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // lbl_SelectBaudrate
            // 
            this.lbl_SelectBaudrate.Name = "lbl_SelectBaudrate";
            this.lbl_SelectBaudrate.Size = new System.Drawing.Size(44, 22);
            this.lbl_SelectBaudrate.Text = "波特率";
            // 
            // cmbx_SelectBaudrate
            // 
            this.cmbx_SelectBaudrate.Name = "cmbx_SelectBaudrate";
            this.cmbx_SelectBaudrate.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // lbl_SelectStopBits
            // 
            this.lbl_SelectStopBits.Name = "lbl_SelectStopBits";
            this.lbl_SelectStopBits.Size = new System.Drawing.Size(44, 22);
            this.lbl_SelectStopBits.Text = "停止位";
            // 
            // cmbx_SelectStopBits
            // 
            this.cmbx_SelectStopBits.Name = "cmbx_SelectStopBits";
            this.cmbx_SelectStopBits.Size = new System.Drawing.Size(95, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // lbl_SelectDataBits
            // 
            this.lbl_SelectDataBits.Name = "lbl_SelectDataBits";
            this.lbl_SelectDataBits.Size = new System.Drawing.Size(44, 22);
            this.lbl_SelectDataBits.Text = "数据位";
            // 
            // cmbx_SelectDatabits
            // 
            this.cmbx_SelectDatabits.Name = "cmbx_SelectDatabits";
            this.cmbx_SelectDatabits.Size = new System.Drawing.Size(95, 25);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // lbl_SelectParity
            // 
            this.lbl_SelectParity.Name = "lbl_SelectParity";
            this.lbl_SelectParity.Size = new System.Drawing.Size(44, 22);
            this.lbl_SelectParity.Text = "校验位";
            // 
            // cmbx_SelectParity
            // 
            this.cmbx_SelectParity.Name = "cmbx_SelectParity";
            this.cmbx_SelectParity.Size = new System.Drawing.Size(95, 25);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Clean
            // 
            this.btn_Clean.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Clean.Image = ((System.Drawing.Image)(resources.GetObject("btn_Clean.Image")));
            this.btn_Clean.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.Size = new System.Drawing.Size(60, 22);
            this.btn_Clean.Text = "清除窗口";
            this.btn_Clean.Click += new System.EventHandler(this.btn_Clean_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_OpenFolder
            // 
            this.btn_OpenFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_OpenFolder.Image = ((System.Drawing.Image)(resources.GetObject("btn_OpenFolder.Image")));
            this.btn_OpenFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_OpenFolder.Name = "btn_OpenFolder";
            this.btn_OpenFolder.Size = new System.Drawing.Size(72, 22);
            this.btn_OpenFolder.Text = "打开文件夹";
            this.btn_OpenFolder.Click += new System.EventHandler(this.btn_OpenFolder_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_topDisplay
            // 
            this.btn_topDisplay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_topDisplay.Image = ((System.Drawing.Image)(resources.GetObject("btn_topDisplay.Image")));
            this.btn_topDisplay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_topDisplay.Name = "btn_topDisplay";
            this.btn_topDisplay.Size = new System.Drawing.Size(23, 22);
            this.btn_topDisplay.Text = "~";
            this.btn_topDisplay.Click += new System.EventHandler(this.btn_topDisplay_Click);
            // 
            // txtbx_Log
            // 
            this.txtbx_Log.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtbx_Log.Font = new System.Drawing.Font("JetBrainsMono NFM", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Log.Location = new System.Drawing.Point(0, 551);
            this.txtbx_Log.Multiline = true;
            this.txtbx_Log.Name = "txtbx_Log";
            this.txtbx_Log.ReadOnly = true;
            this.txtbx_Log.Size = new System.Drawing.Size(1264, 130);
            this.txtbx_Log.TabIndex = 1;
            // 
            // tabctrl_Form
            // 
            this.tabctrl_Form.Controls.Add(this.tabPage_Generic);
            this.tabctrl_Form.Controls.Add(this.tabPage_ModbusMaster);
            this.tabctrl_Form.Controls.Add(this.tabPage_ModbusSlave);
            this.tabctrl_Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabctrl_Form.Location = new System.Drawing.Point(0, 25);
            this.tabctrl_Form.Name = "tabctrl_Form";
            this.tabctrl_Form.SelectedIndex = 0;
            this.tabctrl_Form.Size = new System.Drawing.Size(1264, 526);
            this.tabctrl_Form.TabIndex = 2;
            // 
            // tabPage_Generic
            // 
            this.tabPage_Generic.Controls.Add(this.pnl_GenericRx);
            this.tabPage_Generic.Controls.Add(this.pnl_GenericTx);
            this.tabPage_Generic.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Generic.Name = "tabPage_Generic";
            this.tabPage_Generic.Size = new System.Drawing.Size(1256, 500);
            this.tabPage_Generic.TabIndex = 3;
            this.tabPage_Generic.Text = "通用串口助手";
            this.tabPage_Generic.UseVisualStyleBackColor = true;
            // 
            // pnl_GenericRx
            // 
            this.pnl_GenericRx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_GenericRx.Controls.Add(this.txtbx_NormalRx);
            this.pnl_GenericRx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_GenericRx.Location = new System.Drawing.Point(0, 0);
            this.pnl_GenericRx.Name = "pnl_GenericRx";
            this.pnl_GenericRx.Size = new System.Drawing.Size(1256, 356);
            this.pnl_GenericRx.TabIndex = 1;
            // 
            // txtbx_NormalRx
            // 
            this.txtbx_NormalRx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbx_NormalRx.Font = new System.Drawing.Font("JetBrainsMono NFM", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_NormalRx.Location = new System.Drawing.Point(0, 0);
            this.txtbx_NormalRx.Multiline = true;
            this.txtbx_NormalRx.Name = "txtbx_NormalRx";
            this.txtbx_NormalRx.ReadOnly = true;
            this.txtbx_NormalRx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbx_NormalRx.Size = new System.Drawing.Size(1252, 352);
            this.txtbx_NormalRx.TabIndex = 0;
            // 
            // pnl_GenericTx
            // 
            this.pnl_GenericTx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_GenericTx.Controls.Add(this.txtbx_NormalTx);
            this.pnl_GenericTx.Controls.Add(this.pnl_GenericTxCtrl);
            this.pnl_GenericTx.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_GenericTx.Location = new System.Drawing.Point(0, 356);
            this.pnl_GenericTx.Name = "pnl_GenericTx";
            this.pnl_GenericTx.Size = new System.Drawing.Size(1256, 144);
            this.pnl_GenericTx.TabIndex = 0;
            // 
            // txtbx_NormalTx
            // 
            this.txtbx_NormalTx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbx_NormalTx.Font = new System.Drawing.Font("JetBrainsMono NFM", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_NormalTx.Location = new System.Drawing.Point(0, 0);
            this.txtbx_NormalTx.Multiline = true;
            this.txtbx_NormalTx.Name = "txtbx_NormalTx";
            this.txtbx_NormalTx.Size = new System.Drawing.Size(993, 140);
            this.txtbx_NormalTx.TabIndex = 1;
            // 
            // pnl_GenericTxCtrl
            // 
            this.pnl_GenericTxCtrl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_GenericTxCtrl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_GenericTxCtrl.Controls.Add(this.lbl_NormalTxCnt);
            this.pnl_GenericTxCtrl.Controls.Add(this.lbl_NormalRxCnt);
            this.pnl_GenericTxCtrl.Controls.Add(this.chkbx_NormalHexRxDsplay);
            this.pnl_GenericTxCtrl.Controls.Add(this.lbl_GenericTxPs);
            this.pnl_GenericTxCtrl.Controls.Add(this.txtbx_NormalTxPs);
            this.pnl_GenericTxCtrl.Controls.Add(this.chkbx_NormalTxPs);
            this.pnl_GenericTxCtrl.Controls.Add(this.chkbx_NormalTime);
            this.pnl_GenericTxCtrl.Controls.Add(this.chkbx_NormalHexTxDisplay);
            this.pnl_GenericTxCtrl.Controls.Add(this.btn_GenericTxClear);
            this.pnl_GenericTxCtrl.Controls.Add(this.btn_GenericTxSend);
            this.pnl_GenericTxCtrl.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_GenericTxCtrl.Location = new System.Drawing.Point(993, 0);
            this.pnl_GenericTxCtrl.Name = "pnl_GenericTxCtrl";
            this.pnl_GenericTxCtrl.Size = new System.Drawing.Size(259, 140);
            this.pnl_GenericTxCtrl.TabIndex = 0;
            // 
            // lbl_NormalTxCnt
            // 
            this.lbl_NormalTxCnt.AutoSize = true;
            this.lbl_NormalTxCnt.Location = new System.Drawing.Point(136, 121);
            this.lbl_NormalTxCnt.Name = "lbl_NormalTxCnt";
            this.lbl_NormalTxCnt.Size = new System.Drawing.Size(65, 12);
            this.lbl_NormalTxCnt.TabIndex = 9;
            this.lbl_NormalTxCnt.Text = "发送字节数";
            // 
            // lbl_NormalRxCnt
            // 
            this.lbl_NormalRxCnt.AutoSize = true;
            this.lbl_NormalRxCnt.Location = new System.Drawing.Point(4, 121);
            this.lbl_NormalRxCnt.Name = "lbl_NormalRxCnt";
            this.lbl_NormalRxCnt.Size = new System.Drawing.Size(65, 12);
            this.lbl_NormalRxCnt.TabIndex = 9;
            this.lbl_NormalRxCnt.Text = "接收字节数";
            // 
            // chkbx_NormalHexRxDsplay
            // 
            this.chkbx_NormalHexRxDsplay.AutoSize = true;
            this.chkbx_NormalHexRxDsplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkbx_NormalHexRxDsplay.Location = new System.Drawing.Point(3, 56);
            this.chkbx_NormalHexRxDsplay.Name = "chkbx_NormalHexRxDsplay";
            this.chkbx_NormalHexRxDsplay.Size = new System.Drawing.Size(96, 16);
            this.chkbx_NormalHexRxDsplay.TabIndex = 8;
            this.chkbx_NormalHexRxDsplay.Text = "十六进制接收";
            this.chkbx_NormalHexRxDsplay.UseVisualStyleBackColor = true;
            this.chkbx_NormalHexRxDsplay.CheckedChanged += new System.EventHandler(this.chkbx_NormalHexRxDsplay_CheckedChanged);
            // 
            // lbl_GenericTxPs
            // 
            this.lbl_GenericTxPs.AutoSize = true;
            this.lbl_GenericTxPs.Location = new System.Drawing.Point(4, 100);
            this.lbl_GenericTxPs.Name = "lbl_GenericTxPs";
            this.lbl_GenericTxPs.Size = new System.Drawing.Size(107, 12);
            this.lbl_GenericTxPs.TabIndex = 7;
            this.lbl_GenericTxPs.Text = "定时发送间隔（ms)";
            // 
            // txtbx_NormalTxPs
            // 
            this.txtbx_NormalTxPs.Font = new System.Drawing.Font("JetBrainsMono NFM", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_NormalTxPs.Location = new System.Drawing.Point(138, 95);
            this.txtbx_NormalTxPs.Name = "txtbx_NormalTxPs";
            this.txtbx_NormalTxPs.Size = new System.Drawing.Size(105, 23);
            this.txtbx_NormalTxPs.TabIndex = 5;
            this.txtbx_NormalTxPs.Text = "1000";
            // 
            // chkbx_NormalTxPs
            // 
            this.chkbx_NormalTxPs.AutoSize = true;
            this.chkbx_NormalTxPs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkbx_NormalTxPs.Location = new System.Drawing.Point(3, 78);
            this.chkbx_NormalTxPs.Name = "chkbx_NormalTxPs";
            this.chkbx_NormalTxPs.Size = new System.Drawing.Size(72, 16);
            this.chkbx_NormalTxPs.TabIndex = 4;
            this.chkbx_NormalTxPs.Text = "定时发送";
            this.chkbx_NormalTxPs.UseVisualStyleBackColor = true;
            this.chkbx_NormalTxPs.CheckedChanged += new System.EventHandler(this.chkbx_NormalTxPs_CheckedChanged);
            // 
            // chkbx_NormalTime
            // 
            this.chkbx_NormalTime.AutoSize = true;
            this.chkbx_NormalTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkbx_NormalTime.Location = new System.Drawing.Point(138, 78);
            this.chkbx_NormalTime.Name = "chkbx_NormalTime";
            this.chkbx_NormalTime.Size = new System.Drawing.Size(60, 16);
            this.chkbx_NormalTime.TabIndex = 3;
            this.chkbx_NormalTime.Text = "时间戳";
            this.chkbx_NormalTime.UseVisualStyleBackColor = true;
            this.chkbx_NormalTime.CheckedChanged += new System.EventHandler(this.chkbx_NormalTime_CheckedChanged);
            // 
            // chkbx_NormalHexTxDisplay
            // 
            this.chkbx_NormalHexTxDisplay.AutoSize = true;
            this.chkbx_NormalHexTxDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkbx_NormalHexTxDisplay.Location = new System.Drawing.Point(138, 56);
            this.chkbx_NormalHexTxDisplay.Name = "chkbx_NormalHexTxDisplay";
            this.chkbx_NormalHexTxDisplay.Size = new System.Drawing.Size(96, 16);
            this.chkbx_NormalHexTxDisplay.TabIndex = 2;
            this.chkbx_NormalHexTxDisplay.Text = "十六进制发送";
            this.chkbx_NormalHexTxDisplay.UseVisualStyleBackColor = true;
            this.chkbx_NormalHexTxDisplay.CheckedChanged += new System.EventHandler(this.chkbx_NormalHexDisplay_CheckedChanged);
            // 
            // btn_GenericTxClear
            // 
            this.btn_GenericTxClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GenericTxClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_GenericTxClear.Location = new System.Drawing.Point(0, 25);
            this.btn_GenericTxClear.Name = "btn_GenericTxClear";
            this.btn_GenericTxClear.Size = new System.Drawing.Size(255, 25);
            this.btn_GenericTxClear.TabIndex = 1;
            this.btn_GenericTxClear.Text = "清除发送区";
            this.btn_GenericTxClear.UseVisualStyleBackColor = true;
            this.btn_GenericTxClear.Click += new System.EventHandler(this.btn_GenericTxClear_Click);
            // 
            // btn_GenericTxSend
            // 
            this.btn_GenericTxSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GenericTxSend.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_GenericTxSend.Location = new System.Drawing.Point(0, 0);
            this.btn_GenericTxSend.Name = "btn_GenericTxSend";
            this.btn_GenericTxSend.Size = new System.Drawing.Size(255, 25);
            this.btn_GenericTxSend.TabIndex = 0;
            this.btn_GenericTxSend.Text = "发送";
            this.btn_GenericTxSend.UseVisualStyleBackColor = true;
            this.btn_GenericTxSend.Click += new System.EventHandler(this.btn_NormalTxSend_Click);
            // 
            // tabPage_ModbusMaster
            // 
            this.tabPage_ModbusMaster.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ModbusMaster.Name = "tabPage_ModbusMaster";
            this.tabPage_ModbusMaster.Size = new System.Drawing.Size(1256, 500);
            this.tabPage_ModbusMaster.TabIndex = 2;
            this.tabPage_ModbusMaster.Text = "Modbus主站";
            this.tabPage_ModbusMaster.UseVisualStyleBackColor = true;
            // 
            // tabPage_ModbusSlave
            // 
            this.tabPage_ModbusSlave.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ModbusSlave.Name = "tabPage_ModbusSlave";
            this.tabPage_ModbusSlave.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ModbusSlave.Size = new System.Drawing.Size(1256, 500);
            this.tabPage_ModbusSlave.TabIndex = 1;
            this.tabPage_ModbusSlave.Text = "Modbus从站";
            this.tabPage_ModbusSlave.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tabctrl_Form);
            this.Controls.Add(this.txtbx_Log);
            this.Controls.Add(this.toolStrip_Form);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "串口调试抓手";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.toolStrip_Form.ResumeLayout(false);
            this.toolStrip_Form.PerformLayout();
            this.tabctrl_Form.ResumeLayout(false);
            this.tabPage_Generic.ResumeLayout(false);
            this.pnl_GenericRx.ResumeLayout(false);
            this.pnl_GenericRx.PerformLayout();
            this.pnl_GenericTx.ResumeLayout(false);
            this.pnl_GenericTx.PerformLayout();
            this.pnl_GenericTxCtrl.ResumeLayout(false);
            this.pnl_GenericTxCtrl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip_Form;
        private System.Windows.Forms.ToolStripButton btn_Start;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_Exit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lbl_SelectPort;
        private System.Windows.Forms.ToolStripComboBox cmbx_SelectPort;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel lbl_SelectBaudrate;
        private System.Windows.Forms.ToolStripComboBox cmbx_SelectBaudrate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel lbl_SelectStopBits;
        private System.Windows.Forms.ToolStripComboBox cmbx_SelectStopBits;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel lbl_SelectDataBits;
        private System.Windows.Forms.ToolStripComboBox cmbx_SelectDatabits;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel lbl_SelectParity;
        private System.Windows.Forms.ToolStripComboBox cmbx_SelectParity;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btn_Clean;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton btn_OpenFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.TextBox txtbx_Log;
        private System.Windows.Forms.TabControl tabctrl_Form;
        private System.Windows.Forms.TabPage tabPage_ModbusSlave;
        private System.Windows.Forms.TabPage tabPage_ModbusMaster;
        private System.Windows.Forms.TabPage tabPage_Generic;
        private System.Windows.Forms.Panel pnl_GenericTx;
        private System.Windows.Forms.Panel pnl_GenericTxCtrl;
        private System.Windows.Forms.TextBox txtbx_NormalTx;
        private System.Windows.Forms.Panel pnl_GenericRx;
        private System.Windows.Forms.TextBox txtbx_NormalRx;
        private System.Windows.Forms.Button btn_GenericTxSend;
        private System.Windows.Forms.Button btn_GenericTxClear;
        private System.Windows.Forms.CheckBox chkbx_NormalHexTxDisplay;
        private System.Windows.Forms.CheckBox chkbx_NormalTime;
        private System.Windows.Forms.CheckBox chkbx_NormalTxPs;
        private System.Windows.Forms.TextBox txtbx_NormalTxPs;
        private System.Windows.Forms.Label lbl_GenericTxPs;
        private System.Windows.Forms.CheckBox chkbx_NormalHexRxDsplay;
        private System.Windows.Forms.Label lbl_NormalRxCnt;
        private System.Windows.Forms.Label lbl_NormalTxCnt;
        private System.Windows.Forms.ToolStripButton btn_topDisplay;
    }
}

