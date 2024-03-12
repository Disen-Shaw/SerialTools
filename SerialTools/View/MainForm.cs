using SerialTools.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialTools
{
    public partial class MainForm : Form
    {
        public delegate void DLogAppend(TextBox box, string message);

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
        private string _folderName = "Data";
        private SerialManager _serialManager;
        private Dictionary<string, string> _portNameMap;
        #endregion

        #region 公有方法
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region 私有方法

        private void UpdateSerialPortName()
        {
            cmbx_SelectPort.Items.Clear();
            _portNameMap.Clear();
            foreach (string portName in SerialPort.GetPortNames())
            {
                // Create a WMI query for the device name
                string query = "SELECT * FROM Win32_PnPEntity WHERE Name LIKE '%" + portName + "%'";
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

                // Get the device name from the query result
                foreach (ManagementObject obj in searcher.Get())
                {
                    string deviceName = obj["Name"] as string;
                    cmbx_SelectPort.Items.Add(deviceName);
                    _portNameMap.Add(deviceName, portName);
                }
            }
        }

        private void LogAppend(TextBox box, string logMsg)
        {
            if (box.InvokeRequired)
            {
                DLogAppend stcb = new DLogAppend(LogAppend);
                this.Invoke(stcb, new object[] { box, logMsg });
            }
            else
            {
                box.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "\t\t\t\t\t\t\t\t" + logMsg + "\r\n");
            }
        }

        #endregion

        #region Callback

        /// <summary>
        /// SerialManager 回调初始化
        /// </summary>
        private void SerialManager_CallbackConfig()
        {
            switch (tabctrl_Form.SelectedIndex)
            {
                case 0:
                    _serialManager.ArriveMessageCallback += SerialManagerNormal_ArrivedMessageCallback;
                    _serialManager.ArriveCharCallback += SerialManagerNormal_ArriveCharCallback;
                    _serialManager.ArriveByteCallback += SerialManagerNormal_ArriveByteCallback;
                    _serialManager.ArriveBytesCallback += SerialManagerNormal_ArriveBytesCallback;
                    _serialManager.ConnectCallback += SerialManagerNormal_ConnectCallback;
                    _serialManager.ErrorCallback += SerialManagerNormal_ErrorCallback;
                    _serialManager.LogCallback += SerialManagerNormal_LogCallback;
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region 控件触发

        /// <summary>
        /// [开始连接] 按钮 Click 回调
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (_serialManager == null || !_serialManager.IsOpen)
            {
                switch (tabctrl_Form.SelectedIndex)
                {
                    case 0:
                        _serialManager = SerialManager.NewManager(Enum.SerialManagerType.Normal);
                        break;
                    case 1:
                        _serialManager = SerialManager.NewManager(Enum.SerialManagerType.ModbusMaster);
                        break;
                    case 2:
                        _serialManager = SerialManager.NewManager(Enum.SerialManagerType.ModbusSlave);
                        break;
                    default:
                        _serialManager = null;
                        break;
                }

                SerialManager_CallbackConfig();

                try
                {
                    _serialManager.Init(_portNameMap[cmbx_SelectPort.Text],
                                                     s_baudrate[cmbx_SelectBaudrate.SelectedIndex],
                                                     s_stopBits[cmbx_SelectStopBits.SelectedIndex],
                                                     s_dataBits[cmbx_SelectDatabits.SelectedIndex],
                                                     s_parity[cmbx_SelectParity.SelectedIndex]);
                }
                catch (Exception ex)
                {
                    LogAppend(txtbx_Log, ex.Message);
                    return;
                }

                _serialManager.Start();

                if (_serialManager.IsOpen)
                {
                    LogAppend(txtbx_Log, "串口设备连接成功");
                    btn_Start.Text = "关闭连接";
                }
            }
            else
            {
                LogAppend(txtbx_Log, "串口设备关闭成功");
                _serialManager.Close();
                btn_Start.Text = "开始连接";
            }

        }

        /// <summary>
        /// [退出软件] 按钮 Click 回调
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (_serialManager != null && _serialManager.IsOpen)
            {
                _serialManager.Close();
            }
            Process.GetCurrentProcess().Kill();
        }

        /// <summary>
        /// [清除窗口] 按钮 Click 回调
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Clean_Click(object sender, EventArgs e)
        {
            txtbx_NormalRx.Clear();
            txtbx_Log.Clear();
        }

        /// <summary>
        /// [打开文件夹] 按钮 Click 回调
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OpenFolder_Click(object sender, EventArgs e)
        {
            string targetDir = Directory.GetCurrentDirectory() + "/" + _folderName;
            if (!Directory.Exists(targetDir))
            {
                LogAppend(txtbx_Log, "未找到指定文件夹");
                try
                {
                    Directory.CreateDirectory(targetDir);
                }
                catch (Exception ex)
                {
                    LogAppend(txtbx_Log, "创建文件夹失败" + ex.Message + "\r\n");
                    return;
                }
                LogAppend(txtbx_Log, "已创建指定文件夹");
                try
                {
                    Process.Start(targetDir);
                    LogAppend(txtbx_Log, "已打开文件夹");
                }
                catch (Exception ex)
                {
                    LogAppend(txtbx_Log, "无法打开指定文件夹" + targetDir + ex.Message + "\r\n");
                    return;
                }
            }
            else
            {
                try
                {
                    Process.Start(targetDir);
                    LogAppend(txtbx_Log, "已打开文件夹");
                }
                catch (Exception ex)
                {
                    LogAppend(txtbx_Log, "无法打开指定文件夹" + targetDir + ex.Message + "\r\n");
                }
            }
        }
        private void lbl_SelectPort_Click(object sender, EventArgs e)
        {
            UpdateSerialPortName();
            if (!(_serialManager != null && _serialManager.IsOpen))
            {
                if (cmbx_SelectPort.Items.Count > 0)
                {
                    cmbx_SelectPort.Text = cmbx_SelectPort.Items[0].ToString();
                }
                else
                {
                    cmbx_SelectPort.Text = "";
                    LogAppend(txtbx_Log, "未发现串口设备");
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _portNameMap = new Dictionary<string, string>();

            // 波特率 
            foreach (int value in s_baudrate)
            {
                cmbx_SelectBaudrate.Items.Add(value.ToString());
            }
            cmbx_SelectBaudrate.SelectedIndex = 10;

            // 停止位
            foreach (StopBits sb in s_stopBits)
            {
                if (sb == StopBits.One)
                {
                    cmbx_SelectStopBits.Items.Add("1");
                }
                else if (sb == StopBits.OnePointFive)
                {
                    cmbx_SelectStopBits.Items.Add("1.5");
                }
                else
                {
                    cmbx_SelectStopBits.Items.Add("2");
                }
            }
            cmbx_SelectStopBits.SelectedIndex = 0;

            // 数据位
            foreach (int dataBits in s_dataBits)
            {
                cmbx_SelectDatabits.Items.Add(dataBits.ToString());
            }
            cmbx_SelectDatabits.SelectedIndex = 0;

            // 校验位
            foreach (Parity parity in s_parity)
            {
                cmbx_SelectParity.Items.Add(parity.ToString());
            }
            cmbx_SelectParity.SelectedIndex = 0;

        }

        /// <summary>
        /// 主窗体快捷键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Ctrl + W 快速退出
            if (e.Control && e.KeyCode == Keys.W)
            {
                if (_serialManager != null && _serialManager.IsOpen)
                {
                    _serialManager.Close();
                }
                Process.GetCurrentProcess().Kill();
            }
        }

        #endregion

        #region TabPage_Generic

        private void SerialManagerNormal_ArrivedMessageCallback(string message)
        {
            txtbx_NormalRx.AppendText(message);
        }
        private void SerialManagerNormal_ArriveCharCallback(char c)
        {
            txtbx_NormalRx.AppendText(c.ToString());
        }
        private void SerialManagerNormal_ArriveByteCallback(byte b)
        {
            txtbx_NormalRx.AppendText(b.ToString());
        }
        private void SerialManagerNormal_ArriveBytesCallback(byte[] bytes)
        {
            foreach (var item in bytes)
            {
                txtbx_NormalRx.AppendText(item.ToString());
            }
        }
        private void SerialManagerNormal_ConnectCallback(bool status)
        {
            LogAppend(txtbx_Log, status ? "串口设备连接成功" : "串口设备连接异常");
        }
        private void SerialManagerNormal_ErrorCallback(string errorMsg)
        {
            LogAppend(txtbx_Log, "异常信息: " + errorMsg);
        }

        private void SerialManagerNormal_LogCallback(string logMessage)
        {
            LogAppend(txtbx_Log, logMessage);
        }



        private void btn_NormalTxSend_Click(object sender, EventArgs e)
        {
            if (_serialManager != null && _serialManager.IsOpen)
            {
                _serialManager.Transmit(txtbx_NormalTx.Text);
            }
            else
            {
                LogAppend(txtbx_Log, "发送失败，串口未连接");
            }
        }

        private void chkbx_NormalHexDisplay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx_NormalHexTxDisplay.Checked)
            {
                LogAppend(txtbx_Log, "将开启十六进制格式发送");
            }
            else
            {
                LogAppend(txtbx_Log, "将关闭十六进制格式发送");
            }
        }
        private void chkbx_NormalHexRxDsplay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx_NormalHexRxDsplay.Checked)
            {
                LogAppend(txtbx_Log, "将开启十六进制格式发送");
            }
            else
            {
                LogAppend(txtbx_Log, "将关闭十六进制格式发送");
            }
        }

        private void chkbx_NormalTime_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx_NormalTime.Checked)
            {
                LogAppend(txtbx_Log, "将开启时间戳功能");
            }
            else
            {
                LogAppend(txtbx_Log, "将关闭时间戳功能");
            }
        }

        private void chkbx_NormalTxPs_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx_NormalTxPs.Checked)
            {
                int ms;
                try
                {
                    ms = int.Parse(txtbx_NormalTxPs.Text);
                }
                catch (Exception ex)
                {
                    LogAppend(txtbx_Log, "请输入正确的 ms 数值，" + ex.Message);
                    chkbx_NormalTxPs.Checked = false;
                    return;
                }

                if (_serialManager != null && _serialManager.IsOpen)
                {
                    txtbx_NormalTx.ReadOnly = true;
                    _serialManager.StartGenericTimer(ms, txtbx_NormalTx.Text);
                }
                else
                {
                    LogAppend(txtbx_Log, "串口设备未连接，功能启用失败");
                    chkbx_NormalTxPs.Checked = false;
                }
            }
            else
            {
                txtbx_NormalTx.ReadOnly = false;
                _serialManager.StopGenericTimer();
            }
        }
        private void btn_GenericTxClear_Click(object sender, EventArgs e)
        {
            txtbx_NormalTx.Clear();
        }

        #endregion

    }
}
