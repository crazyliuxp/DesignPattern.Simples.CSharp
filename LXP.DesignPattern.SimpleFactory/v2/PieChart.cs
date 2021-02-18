﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.SimpleFactory.v2
{
    /// <summary>
    /// 饼状图类：具体产品类
    /// </summary>
    public class PieChart : IChart
    {
        public PieChart()
        {
            Console.WriteLine("创建饼状图！");
        }

        public void Display()
        {
            Console.WriteLine("显示饼状图!");
        }
    }
}
