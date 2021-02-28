using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.AbstractFactory
{
    /// <summary>
    /// Summer 组合框类：具体产品
    /// </summary>
    public class SummerComboBox : ComboBox
    {
        public void Display()
        {
            Console.WriteLine("显示Summer风格组合框");
        }
    }
}
