using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Prototype.V1
{
    /// <summary>
    /// 抽象原型类
    /// </summary>
    public abstract class Prototype
    {
        public string Id { get; private set; }

        protected Prototype(string id)
        {
            this.Id = id;
        }

        //抽象类关键就是这样一个Clone方法
        public abstract Prototype Clone();
    }
}
