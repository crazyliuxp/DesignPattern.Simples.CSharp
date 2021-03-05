using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Prototype.V1
{
    /// <summary>
    /// 具体原型类
    /// </summary>
    public class ConcretePrototypeA : Prototype
    {
        public ConcretePrototypeA(string id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            Prototype prototype = new ConcretePrototypeA(Id);
            return prototype;
        }
    }
}
