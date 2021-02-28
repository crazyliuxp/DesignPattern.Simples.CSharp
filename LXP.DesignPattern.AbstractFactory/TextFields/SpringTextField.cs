using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.AbstractFactory
{
    /// <summary>
    /// Spring 文本框类：具体产品
    /// </summary>
    public class SpringTextField : TextField
    {
        public void Display()
        {
            Console.WriteLine("显示Spring风格文本框");
        }
    }
}
