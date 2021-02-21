using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
using System.Text;

namespace LXP.DesignPattern.FactoryMethod
{
    /// <summary>
    /// 配置文件帮助类
    /// </summary>
    public class AppConfigHelper
    {
        /// <summary>
        /// 获取具体日志工厂方法
        /// </summary>
        /// <returns></returns>
        public static object GetLoggerFactory()
        {
            try
            {
                var loggerFactoryName = ConfigurationManager.AppSettings["LoggerFactory"];
                var type = Type.GetType(loggerFactoryName);


                return type == null ? null : Activator.CreateInstance(type);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }
    }
}
