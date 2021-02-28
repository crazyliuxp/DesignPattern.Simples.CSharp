using System;
using LXP.DesignPattern.SimpleFactory.v2;

namespace LXP.DesignPattern.SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //获取配置文件中的chartType的值
            string type = System.Configuration.ConfigurationManager.AppSettings["chartType"];
            IChart chart = ChartFactory.GetChart(type);
            chart.Display();
        }
    }
}
