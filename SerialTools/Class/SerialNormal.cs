using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;


namespace SerialTools.Class
{
    public class SerialNormal : SerialManager
    {
        #region 私有成员
        private string _txCycleSendMessage;
        #endregion

        #region 公有方法
        public SerialNormal()
        {
            _sp = new SerialPort();
            _tmrGeneric = new System.Timers.Timer();
        }
        #endregion

        #region 私有方法

        private void Sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            ArriveMessageCallback.Invoke(_sp.ReadExisting());
        }

        private void TmrGeneric_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            _sp.Write(_txCycleSendMessage);
        }

        #endregion

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
                ErrorCallback.Invoke("串口打开失败，" + ex.Message);
                return false;
            }
            _sp.DataReceived += Sp_DataReceived;

            return true;
        }

        public override bool Transmit(byte[] date, int len)
        {
            if (_sp != null && _sp.IsOpen)
            {
                _sp.Write(date, 0, len);
                return true;
            }
            else
            {
                ErrorCallback.Invoke("信息发送失败");
                return false;
            }
        }

        public override bool Transmit(string message)
        {
            if (_sp != null && _sp.IsOpen)
            {
                _sp.Write(message);
                return true;
            }
            else
            {
                ErrorCallback.Invoke("信息发送失败");
                return false;
            }
        }

        public override void StartGenericTimer(int ms, string message)
        {
            _tmrGeneric.Interval = ms;
            _txCycleSendMessage = message;
            _tmrGeneric.Elapsed += TmrGeneric_Elapsed;
            _tmrGeneric.Start();
        }


        public override void StopGenericTimer()
        {
            _tmrGeneric.Stop();
        }

        public override bool Close()
        {
            _tmrGeneric.Stop();
            _sp.Close();
            return true;
        }

        #endregion
    }
}
