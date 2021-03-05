using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Prototype.PM
{
    /// <summary>
    /// 抽象公文接口，也可以定义为抽象类
    /// </summary>
    public interface IOfficialDocument : ICloneable
    {
        new IOfficialDocument Clone();//隐藏ICloneable的Clone方法接口
        void Display();
    }
}
