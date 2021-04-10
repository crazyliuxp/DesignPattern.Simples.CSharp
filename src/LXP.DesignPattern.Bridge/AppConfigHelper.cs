using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace LXP.DesignPattern.Bridge
{
    public class AppConfigHelper
    {
        public static object GetInstance(string key)
        {
            try
            {
                var className = ConfigurationManager.AppSettings[key];
                var type = Type.GetType(className);

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
