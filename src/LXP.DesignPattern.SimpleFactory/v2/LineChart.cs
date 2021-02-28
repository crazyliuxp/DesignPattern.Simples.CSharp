﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.SimpleFactory.v2
{
    /// <summary>
    /// 折线图类：具体产品类
    /// </summary>
    public class LineChart : IChart
    {
        public LineChart()
        {
            Console.WriteLine("创建折线图！");
        }

        public void Display()
        {
            Console.WriteLine("显示折线图！");
        }
    }
}
