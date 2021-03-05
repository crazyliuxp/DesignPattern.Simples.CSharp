using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Prototype.PM
{
    /// <summary>
    /// 可行性分析报告
    /// </summary>
    public class FAR : IOfficialDocument
    {
        public IOfficialDocument Clone()
        {
            return (IOfficialDocument) base.MemberwiseClone();
        }

        public void Display()
        {
            Console.WriteLine("《可行性分析报告》");
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }
    }
}
