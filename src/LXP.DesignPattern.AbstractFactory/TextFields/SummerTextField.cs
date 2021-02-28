using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.AbstractFactory
{
    /// <summary>
    /// Summer 文本框类：具体产品
    /// </summary>
    public class SummerTextField : TextField
    {
        public void Display()
        {
            Console.WriteLine("显示Summer风格文本框");
        }
    }
}
