using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.SimpleFactory.v2
{
    /// <summary>
    /// 图表工厂类：工厂类
    /// </summary>
    public class ChartFactory
    {
        /// <summary>
        /// 静态工厂方法
        /// </summary>
        /// <param name="type">图表类型</param>
        /// <returns></returns>
        public static IChart GetChart(string type)
        {
            IChart chart = null;
            if (type.Equals("histogram", StringComparison.OrdinalIgnoreCase))
            {
                chart = new HistogramChart();
                Console.WriteLine("初始化设置柱状图");
            }
            else if (type.Equals("line", StringComparison.OrdinalIgnoreCase))
            {
                chart = new LineChart();
                Console.WriteLine("初始化设置折线图");
            }
            else if (type.Equals("pie", StringComparison.OrdinalIgnoreCase))
            {
                chart = new PieChart();
                Console.WriteLine("初始化设置饼状图");
            }

            return chart;
        }
    }
}
