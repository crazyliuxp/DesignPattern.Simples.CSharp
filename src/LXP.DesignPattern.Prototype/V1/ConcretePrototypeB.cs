using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Prototype.V1
{
    public class ConcretePrototypeB : ICloneable
    {
        public object Clone()
        {
            return (object) this.MemberwiseClone();
        }
    }
}
