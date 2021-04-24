﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Decorator
{
    /// <summary>
    /// 文本框类：具体构件类
    /// </summary>
    public class TextBox : Component
    {
        public override void Display()
        {
            Console.WriteLine("显示文本框");
        }
    }
}
