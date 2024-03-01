using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialTools
{
    public partial class MainForm : Form
    {
        #region 公有方法
        /// <summary>
        /// 主窗体构造函数
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region 私有方法

        #endregion

        #region 控件回调

        /// <summary>
        /// [开始连接] 按钮 Click 回调
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Start_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// [退出软件] 按钮 Click 回调
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Exit_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// [清除窗口] 按钮 Click 回调
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Clean_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// [打开文件夹] 按钮 Click 回调
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OpenFolder_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
