using System;
using System.Configuration;
using LXP.DesignPattern.FactoryMethod.v2;

namespace LXP.DesignPattern.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //var factory = new FileLoggerFactory();//可引入配置文件实现 v1
            var factory = (ILoggerFactory) AppConfigHelper.GetLoggerFactory();
            var logger = factory.CreateLogger();
            logger.WriteLog();

            //factory.WriteLog();//直接使用工厂对象来调用产品对象的业务方法
        }
    }
}
