using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace LXP.DesignPattern.Adapter
{
    public class AppConfigHelper
    {
        public static object GetAdapter()
        {
            try
            {
                var adapterName = ConfigurationManager.AppSettings["AdapterName"];
                var type = Type.GetType(adapterName);

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
