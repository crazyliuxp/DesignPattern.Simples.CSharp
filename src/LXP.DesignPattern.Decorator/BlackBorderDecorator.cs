using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Decorator
{
    /// <summary>
    /// 黑色边框装饰类：具体装饰类
    /// </summary>
    public class BlackBorderDecorator : ComponentDecorator
    {
        public BlackBorderDecorator(Component component) : base(component)
        {

        }

        public override void Display()
        {
            this.SetBlackBorder();
            base.Display();
        }

        public void SetBlackBorder()
        {
            Console.WriteLine("为构件增加黑色边框");
        }
    }
}
