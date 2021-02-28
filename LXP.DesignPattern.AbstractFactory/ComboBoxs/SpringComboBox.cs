using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.AbstractFactory
{
    /// <summary>
    /// Spring组合框类：具体产品
    /// </summary>
    public class SpringComboBox : ComboBox
    {
        public void Display()
        {
            Console.WriteLine("显示Spring风格组合框");
        }
    }
}
