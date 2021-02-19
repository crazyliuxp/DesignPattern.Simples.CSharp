using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.FactoryMethod.v1
{
    public class LoggerFactory
    {
        public static ILogger CreateLogger(string args)
        {
            ILogger logger = null;
            if (args.Equals("db", StringComparison.OrdinalIgnoreCase))
            {
                //连接数据库，代码省略
                //创建数据库日志记录器对象
                logger = new DatabaseLogger();
                //初始化数据库日志记录器，代码省略
            }
            else if (args.Equals("file", StringComparison.OrdinalIgnoreCase))
            {
                //创建日志文件，代码省略
                //创建文件日志记录器队形
                logger = new FileLogger();
                //初始化文件日志记录器，代码省略
            }

            return logger;
        }
    }
}
