using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace LXP.DesignPattern.Builder
{
    /// <summary>
    /// 配置文件帮助类
    /// </summary>
    public static class AppConfigHelper
    {
        public static object GetBuilder()
        {
            try
            {
                var concreteBuilder = ConfigurationManager.AppSettings["ConcreteBuilder"];
                var type = Type.GetType(concreteBuilder);

                return type == null ? null : Activator.CreateInstance(type);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }
    }
}
