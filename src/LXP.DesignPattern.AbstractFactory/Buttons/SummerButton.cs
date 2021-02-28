using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.AbstractFactory
{
    /// <summary>
    /// Summer按钮类：具体产品
    /// </summary>
    public class SummerButton : Button
    {
        public void Display()
        {
            Console.WriteLine("显示Summer风格按钮");
        }
    }
}
