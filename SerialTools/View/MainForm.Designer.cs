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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Start = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Exit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_SelectPort = new System.Windows.Forms.ToolStripLabel();
            this.cmbx_PortSelect = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_SelectBaudrate = new System.Windows.Forms.ToolStripLabel();
            this.cmbx_SelectBaudrate = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_SelectStopBits = new System.Windows.Forms.ToolStripLabel();
            this.cmbx_SelectStopBt = new System.Windows.Forms.ToolStripComboBox();
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
            this.txtbx_Log = new System.Windows.Forms.TextBox();
            this.tabctrl_Form = new System.Windows.Forms.TabControl();
            this.tabPage_Generic = new System.Windows.Forms.TabPage();
            this.tabPage_ModbusMaster = new System.Windows.Forms.TabPage();
            this.tabPage_ModbusSlave = new System.Windows.Forms.TabPage();
            this.toolStrip1.SuspendLayout();
            this.tabctrl_Form.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Start,
            this.toolStripSeparator1,
            this.btn_Exit,
            this.toolStripSeparator2,
            this.lbl_SelectPort,
            this.cmbx_PortSelect,
            this.toolStripSeparator3,
            this.lbl_SelectBaudrate,
            this.cmbx_SelectBaudrate,
            this.toolStripSeparator4,
            this.lbl_SelectStopBits,
            this.cmbx_SelectStopBt,
            this.toolStripSeparator5,
            this.lbl_SelectDataBits,
            this.cmbx_SelectDatabits,
            this.toolStripSeparator6,
            this.lbl_SelectParity,
            this.cmbx_SelectParity,
            this.toolStripSeparator7,
            this.btn_Clean,
            this.toolStripSeparator8,
            this.btn_OpenFolder,
            this.toolStripSeparator9});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1685, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // 
            // cmbx_PortSelect
            // 
            this.cmbx_PortSelect.Name = "cmbx_PortSelect";
            this.cmbx_PortSelect.Size = new System.Drawing.Size(265, 25);
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
            this.cmbx_SelectBaudrate.Size = new System.Drawing.Size(132, 25);
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
            // cmbx_SelectStopBt
            // 
            this.cmbx_SelectStopBt.Name = "cmbx_SelectStopBt";
            this.cmbx_SelectStopBt.Size = new System.Drawing.Size(132, 25);
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
            this.cmbx_SelectDatabits.Size = new System.Drawing.Size(132, 25);
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
            this.cmbx_SelectParity.Size = new System.Drawing.Size(132, 25);
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
            // txtbx_Log
            // 
            this.txtbx_Log.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtbx_Log.Location = new System.Drawing.Point(0, 665);
            this.txtbx_Log.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbx_Log.Multiline = true;
            this.txtbx_Log.Name = "txtbx_Log";
            this.txtbx_Log.ReadOnly = true;
            this.txtbx_Log.Size = new System.Drawing.Size(1685, 186);
            this.txtbx_Log.TabIndex = 1;
            // 
            // tabctrl_Form
            // 
            this.tabctrl_Form.Controls.Add(this.tabPage_Generic);
            this.tabctrl_Form.Controls.Add(this.tabPage_ModbusMaster);
            this.tabctrl_Form.Controls.Add(this.tabPage_ModbusSlave);
            this.tabctrl_Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabctrl_Form.Location = new System.Drawing.Point(0, 25);
            this.tabctrl_Form.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabctrl_Form.Name = "tabctrl_Form";
            this.tabctrl_Form.SelectedIndex = 0;
            this.tabctrl_Form.Size = new System.Drawing.Size(1685, 640);
            this.tabctrl_Form.TabIndex = 2;
            // 
            // tabPage_Generic
            // 
            this.tabPage_Generic.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Generic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_Generic.Name = "tabPage_Generic";
            this.tabPage_Generic.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_Generic.Size = new System.Drawing.Size(1677, 611);
            this.tabPage_Generic.TabIndex = 0;
            this.tabPage_Generic.Text = "串口助手";
            this.tabPage_Generic.UseVisualStyleBackColor = true;
            // 
            // tabPage_ModbusMaster
            // 
            this.tabPage_ModbusMaster.Location = new System.Drawing.Point(4, 25);
            this.tabPage_ModbusMaster.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_ModbusMaster.Name = "tabPage_ModbusMaster";
            this.tabPage_ModbusMaster.Size = new System.Drawing.Size(1677, 603);
            this.tabPage_ModbusMaster.TabIndex = 2;
            this.tabPage_ModbusMaster.Text = "Modbus主站";
            this.tabPage_ModbusMaster.UseVisualStyleBackColor = true;
            // 
            // tabPage_ModbusSlave
            // 
            this.tabPage_ModbusSlave.Location = new System.Drawing.Point(4, 25);
            this.tabPage_ModbusSlave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_ModbusSlave.Name = "tabPage_ModbusSlave";
            this.tabPage_ModbusSlave.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_ModbusSlave.Size = new System.Drawing.Size(1677, 603);
            this.tabPage_ModbusSlave.TabIndex = 1;
            this.tabPage_ModbusSlave.Text = "Modbus从站";
            this.tabPage_ModbusSlave.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 851);
            this.Controls.Add(this.tabctrl_Form);
            this.Controls.Add(this.txtbx_Log);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "串口调试抓手";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabctrl_Form.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Start;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_Exit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lbl_SelectPort;
        private System.Windows.Forms.ToolStripComboBox cmbx_PortSelect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel lbl_SelectBaudrate;
        private System.Windows.Forms.ToolStripComboBox cmbx_SelectBaudrate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel lbl_SelectStopBits;
        private System.Windows.Forms.ToolStripComboBox cmbx_SelectStopBt;
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
        private System.Windows.Forms.TabPage tabPage_Generic;
        private System.Windows.Forms.TabPage tabPage_ModbusSlave;
        private System.Windows.Forms.TabPage tabPage_ModbusMaster;
    }
}

