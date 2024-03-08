using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialTools.Class
{
    public class SerialModbusSlave : SerialServer
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public SerialModbusSlave()
        {
        }
        public override void Init(string _port, int _baudrate, StopBits _stopbits, int _databits, Parity _parity)
        {
        }

        public override bool Start()
        {
            return true;
        }

        public override bool Close()
        {
            return true;
        }
    }
}
