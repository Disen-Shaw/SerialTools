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
    public abstract class SerialServer
    {
        public delegate void SerialServerError(string str);
        public delegate void SerialServerMessage(string msg);
        public delegate void SerialServerConnect(bool status);

        public delegate void SerialServerByteArrived(byte b);
        public delegate void SerialServerByteArrayArrived(byte[] list);
        public delegate void SerialServerMessageArrived(string msg);

        protected SerialPort _sp;

        public bool SerialServerIsOpen
        {
            get
            {
                return _sp.IsOpen;
            }
        }

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

        #region 基类通用方法

        public abstract void Init(string _port, int _baudrate, StopBits _stopbits, int _databits, Parity _parity);

        public abstract bool Start();

        public abstract bool Close();

        #endregion
    }
}
