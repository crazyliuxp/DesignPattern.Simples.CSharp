using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.AbstractFactory
{
    /// <summary>
    /// Spring按钮类：具体产品
    /// </summary>
    public class SpringButton : Button
    {
        public void Display()
        {
            Console.WriteLine("显示Spring风格按钮");
        }
    }
}
