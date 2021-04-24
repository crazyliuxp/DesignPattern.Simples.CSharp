using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Decorator
{
    /// <summary>
    /// 列表框类：具体构件类
    /// </summary>
    public class ListBox : Component
    {
        public override void Display()
        {
            Console.WriteLine("显示列表框");
        }
    }
}
