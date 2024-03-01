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
            this.lbl_SelectParty = new System.Windows.Forms.ToolStripLabel();
            this.cmbx_SelectParty = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Clean = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_OpenFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
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
            this.lbl_SelectParty,
            this.cmbx_SelectParty,
            this.toolStripSeparator7,
            this.btn_Clean,
            this.toolStripSeparator8,
            this.btn_OpenFolder,
            this.toolStripSeparator9});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 25);
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
            this.cmbx_PortSelect.Size = new System.Drawing.Size(200, 25);
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
            // cmbx_SelectStopBt
            // 
            this.cmbx_SelectStopBt.Name = "cmbx_SelectStopBt";
            this.cmbx_SelectStopBt.Size = new System.Drawing.Size(100, 25);
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
            this.cmbx_SelectDatabits.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // lbl_SelectParty
            // 
            this.lbl_SelectParty.Name = "lbl_SelectParty";
            this.lbl_SelectParty.Size = new System.Drawing.Size(44, 22);
            this.lbl_SelectParty.Text = "校验位";
            // 
            // cmbx_SelectParty
            // 
            this.cmbx_SelectParty.Name = "cmbx_SelectParty";
            this.cmbx_SelectParty.Size = new System.Drawing.Size(100, 25);
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
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "串口调试抓手";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripLabel lbl_SelectParty;
        private System.Windows.Forms.ToolStripComboBox cmbx_SelectParty;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btn_Clean;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton btn_OpenFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
    }
}

