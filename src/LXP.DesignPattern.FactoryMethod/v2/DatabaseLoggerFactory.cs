using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.FactoryMethod.v2
{
    /// <summary>
    /// 数据库日志记录器工厂类：具体工厂
    /// </summary>
    public class DatabaseLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            //连接数据库，代码省略
            //创建数据库日志记录器对象
            var logger = new DatabaseLogger();
            //初始化数据库日志记录器，代码省略
            return logger;
        }
    }
}
