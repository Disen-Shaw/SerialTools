using SerialTools.Enum;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialTools.Class
{
    public abstract class SerialManager
    {
        public delegate void DArrivedString(string message);
        public delegate void DArrivedChar(char c);
        public delegate void DArrivedByte(byte c);
        public delegate void DArrivedBytes(byte[] bytes);

        public delegate void DConnect(bool status);
        public delegate void DPortChange(Dictionary<string, string> portNameMap);
        public delegate void DError(string errorMsg);
        public delegate void DLog(string log);

        #region 子类继承成员
        public DArrivedString ArriveMessageCallback;
        public DArrivedChar ArriveCharCallback;
        public DArrivedByte ArriveByteCallback;
        public DArrivedBytes ArriveBytesCallback;

        public DConnect ConnectCallback;
        public DError ErrorCallback;
        public DLog LogCallback;

        protected SerialPort _sp;
        protected System.Timers.Timer _tmrGeneric;          //!< 通用定时器
        #endregion

        #region SET && GET
        public bool IsOpen
        {
            get
            {
                return _sp.IsOpen;
            }
        }
        #endregion

        static public SerialManager NewManager(SerialManagerType type)
        {
            switch (type)
            {
                case SerialManagerType.Normal:
                    return new SerialNormal();
                case SerialManagerType.ModbusMaster:
                    return new SerialModbusMaster();
                case SerialManagerType.ModbusSlave:
                    return new SerialModbusSlave();
                default:
                    return null;
            }
        }

        #region 基类通用方法
        public abstract void Init(string _port, int _baudrate, StopBits _stopbits, int _databits, Parity _parity);
        public abstract bool Start();
        public abstract bool Close();
        public abstract bool Transmit(byte[] date, int len);
        public abstract bool Transmit(string message);
        public abstract void StartGenericTimer(int ms, string message);
        public abstract void StopGenericTimer();

        #endregion
    }
}
