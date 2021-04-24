using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Decorator
{
    /// <summary>
    /// 滚动条装饰类：具体装饰类
    /// </summary>
    public class SrollBarDecorator : ComponentDecorator
    {
        public SrollBarDecorator(Component component) : base(component)
        {

        }

        public override void Display()
        {
            this.SetSsrollBar();
            base.Display();
        }

        public void SetSsrollBar()
        {
            Console.WriteLine("为构件增加滚动条");
        }
    }
}
