using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialTools
{
    public partial class MainForm : Form
    {
        #region 串口配置信息

        static int[] s_baudrate = new int[]
        {
            1200,
            2400,
            4800,
            9600,
            14400,
            19200,
            38400,
            43000,
            57600,
            76800,
            115200,
            128000,
            230400,
            256000,
            460800,
            921600,
            1000000,
            2000000,
            3000000,
        };

        static StopBits[] s_stopBits = new StopBits[]
        {
            StopBits.One,
            StopBits.OnePointFive,
            StopBits.Two,
        };

        static int[] s_dataBits = new int[]
        {
            8,
            7,
            6,
            5
        };

        static Parity[] s_parity = new Parity[]
        {
            Parity.None,
            Parity.Odd,
            Parity.Even,
        };

        #endregion

        #region 私有成员
        private List<string> _portNameList;
        private List<string> _portNameListNew;
        private System.Timers.Timer _portUpdateTimer;
        #endregion

        #region 公有方法
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region 私有方法
        private void UpdatePort(ref List<string> portNameList)
        {
            portNameList.Clear();
            foreach (string portName in SerialPort.GetPortNames())
            {
                // Create a WMI query for the device name
                string query = "SELECT * FROM Win32_PnPEntity WHERE Name LIKE '%" + portName + "%'";
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

                // Get the device name from the query result
                foreach (ManagementObject obj in searcher.Get())
                {
                    string deviceName = obj["Name"] as string;
                    portNameList.Add(deviceName);
                }
            }
        }

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

        private void MainForm_Load(object sender, EventArgs e)
        {
            _portNameList = new List<string>();
            _portNameListNew = new List<string>();
            _portUpdateTimer = new System.Timers.Timer(200);
            _portUpdateTimer.Elapsed += PortUpdateTimer_Elapsed;
            _portUpdateTimer.Start();
        }
        #endregion

        #region 其他回调

        /// <summary>
        /// 更新端口定时器回调 TODO 线程间操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PortUpdateTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            UpdatePort(ref _portNameListNew);
            if (_portNameList.Count != _portNameListNew.Count)
            {
                _portNameList.Clear();
                _portNameList.AddRange(_portNameListNew);
                cmbx_PortSelect.Items.Clear();
                foreach (string str in _portNameList)
                {
                    cmbx_PortSelect.Items.Add(str);
                }
                cmbx_PortSelect.Text = cmbx_PortSelect.Items[0].ToString();
            }
        }
        #endregion
    }
}
