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
    public enum SerialManagerType
    {
        Normal = 0,         //!< 普通串口调试助手
        ModbusMaster = 1,   //!< Modbus RTU Master
        ModbusSlave = 2     //!< Modbus RTU Slave
    }
}

