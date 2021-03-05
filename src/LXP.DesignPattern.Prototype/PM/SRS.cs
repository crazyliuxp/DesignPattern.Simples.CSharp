using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Prototype.PM
{
    /// <summary>
    /// 软件需求规格说明书
    /// </summary>
    public class SRS : IOfficialDocument
    {
        public IOfficialDocument Clone()
        {
            return (IOfficialDocument) base.MemberwiseClone();
        }

        public void Display()
        {
            Console.WriteLine("《软件需求规格说明书》");
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}
