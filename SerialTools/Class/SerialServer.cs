using SerialTools.Enum;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialTools.Class
{
    /// <summary>
    /// 串口调试基类
    /// </summary>
    public abstract class SerialServer
    {
        #region 基类成员
        public string PortName;
        public int BaudrateVal;
        public StopBits StopBitsVal;
        public int DataBitsVal;
        public Parity ParitVal;
        public SerialPort SerialPortServer;
        #endregion

        /// <summary>
        /// 新建一个 SerialServer
        /// </summary>
        /// <param name="type">Server类型</param>
        /// <returns></returns>
        static SerialServer NewServer(SerialServerType type)
        {
            switch (type)
            {
                case SerialServerType.SerialServer_Generic:
                    return new SerialGeneric();
                case SerialServerType.SerialServerModbusMaster:
                    return new SerialModbusMaster();
                case SerialServerType.SerialServerModbusSlave:
                    return new SerialModbusSlave();
                default:
                    return null;
            }
        }

        #region 基类公共方法
        /// <summary>
        /// 初始化 SeralPort 
        /// </summary>
        /// <param name="_port">端口名</param>
        /// <param name="_baudrate">波特率</param>
        /// <param name="_stopbits">停止位</param>
        /// <param name="_databits">数据位</param>
        /// <param name="_parity">校验位</param>
        public abstract void Init(string _port, int _baudrate, StopBits _stopbits, int _databits, Parity _parity);

        /// <summary>
        /// 关闭 SerialPort
        /// </summary>
        public abstract void Close();

        #endregion
    }
}
