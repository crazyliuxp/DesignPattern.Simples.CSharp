using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Decorator
{
    /// <summary>
    /// 构件装饰类：抽象装饰类
    /// </summary>
    public class ComponentDecorator : Component
    {
        //位置对抽象构件类型对象的引用
        private Component component;

        /// <summary>
        /// 注入抽象构件类型的对象
        /// </summary>
        /// <param name="component"></param>
        public ComponentDecorator(Component component)
        {
            this.component = component;
        }

        public override void Display()
        {
            component.Display();
        }
    }
}
