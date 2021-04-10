using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Bridge.imps
{
    /// <summary>
    /// 抽象操作系统实现类：实现类接口
    /// </summary>
    public interface IImageImp
    {
        /// <summary>
        /// 显示像素矩阵
        /// </summary>
        void DoPaint(Matrix matrix);
    }
}
