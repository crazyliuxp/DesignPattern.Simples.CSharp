using System;
using LXP.DesignPattern.FactoryMethod.v2;

namespace LXP.DesignPattern.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new FileLoggerFactory();//可引入配置文件实现
            var logger = factory.CreateLogger();
            logger.WriteLog();
        }
    }
}
