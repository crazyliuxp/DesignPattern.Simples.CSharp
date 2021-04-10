using LXP.DesignPattern.Bridge.imps;
using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Bridge.abstractions
{
    /// <summary>
    /// 抽象图像类：抽象类
    /// </summary>
    public abstract class Image
    {
        protected IImageImp imageImp;

        public void SetImageImp(IImageImp imp)
        {
            imageImp = imp;
        }

        public abstract void ParseFile(string fileName);
    }
}
