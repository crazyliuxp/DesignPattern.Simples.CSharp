using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Decorator
{
    /// <summary>
    /// 抽象界面构件类：抽象构件类。为了突出与模式相关的代码，对原有控件代码进行了大量的简化
    /// </summary>
    public abstract class Component
    {
        public abstract void Display();
    }
}
