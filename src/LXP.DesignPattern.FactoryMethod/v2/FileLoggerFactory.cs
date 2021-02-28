using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.FactoryMethod.v2
{
    /// <summary>
    /// 文件日志记录器工厂类：具体工厂
    /// </summary>
    public class FileLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            //创建文件日志记录器对象
            var logger = new FileLogger();
            //创建文件，省略代码
            return logger;
        }
    }
}
