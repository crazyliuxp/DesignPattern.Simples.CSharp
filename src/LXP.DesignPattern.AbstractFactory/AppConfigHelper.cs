using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace LXP.DesignPattern.AbstractFactory
{
    public class AppConfigHelper
    {
        /// <summary>
        /// 获取具体皮肤工厂方法
        /// </summary>
        /// <returns></returns>
        public static object GetSkinFactory()
        {
            try
            {
                var skinFactoryName = ConfigurationManager.AppSettings["SkinFactory"];
                var type = Type.GetType(skinFactoryName);


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
