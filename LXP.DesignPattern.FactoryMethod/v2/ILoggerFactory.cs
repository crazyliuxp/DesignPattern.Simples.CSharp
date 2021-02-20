using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.FactoryMethod.v2
{
    /// <summary>
    /// 日志记录器工厂接口：抽象工厂
    /// </summary>
    public interface ILoggerFactory
    {
        ILogger CreateLogger();
    }
}
