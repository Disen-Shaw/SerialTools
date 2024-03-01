﻿using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialTools.Class
{
    public class SerialGeneric : SerialServer
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public SerialGeneric()
        {
        }

        /// <summary>
        /// 初始化 SeralPort 
        /// </summary>
        /// <param name="_port">端口名</param>
        /// <param name="_baudrate">波特率</param>
        /// <param name="_stopbits">停止位</param>
        /// <param name="_databits">数据位</param>
        /// <param name="_parity">校验位</param>
        public override void Init(string _port, int _baudrate, StopBits _stopbits, int _databits, Parity _parity)
        {
            SerialPortServer.PortName = _port;
            SerialPortServer.BaudRate = _baudrate;
            SerialPortServer.DataBits = _databits;
            SerialPortServer.Parity = _parity;
            SerialPortServer.StopBits = _stopbits;
        }

        /// <summary>
        /// 关闭 SerialPort
        /// </summary>
        public override void Close()
        {
        }
    }
}
