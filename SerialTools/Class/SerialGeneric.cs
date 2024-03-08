using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SerialTools.Class
{
    public class SerialGeneric : SerialServer
    {
        #region 公用成员
        public SerialServerError SerialServerErrorCallback;
        public SerialServerMessage SerialServerMessageCallback;
        public SerialServerConnect SerialServerConnectCallback;
        public SerialServerMessageArrived SerialServerMessageArrivedCallback;
        #endregion

        #region 私有成员
        #endregion

        public SerialGeneric()
        {
            _sp = new SerialPort();
        }

        #region 覆盖基类方法
        public override void Init(string _port, int _baudrate, StopBits _stopbits, int _databits, Parity _parity)
        {
            _sp.PortName = _port;
            _sp.BaudRate = _baudrate;
            _sp.StopBits = _stopbits;
            _sp.DataBits = _databits;
            _sp.Parity = _parity;
        }

        public override bool Start()
        {
            try
            {
                _sp.Open();
            }
            catch (Exception ex)
            {
                SerialServerErrorCallback.Invoke("串口开启异常，请检查串口设备连接和使用情况\r\n" + ex.ToString());
            }
            if (_sp.IsOpen)
            {
                SerialServerConnectCallback.Invoke(true);
                return true;
            }
            else
            {
                SerialServerConnectCallback.Invoke(false);
                return false;
            }
        }

        public override bool Close()
        {
            return true;
        }

        #endregion
    }
}
