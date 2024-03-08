using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialTools.Enum
{
    /// <summary>
    /// 串口调试 Server 类型
    /// </summary>
    internal enum SerialServerType
    {
        SerialServer_Generic = 0,       //!< 通用串口调试助手
        SerialServerModbusMaster = 1,   //!< Modbus RTU Master
        SerialServerModbusSlave = 2     //!< Modbus RTU Slave
    }
}

