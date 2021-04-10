using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Bridge.imps
{
    /// <summary>
    /// Windows操作系统实现类：具体实现类
    /// </summary>
    public class WindowsImp : IImageImp
    {
        public void DoPaint(Matrix matrix)
        {
            //调用Windows系统的绘制函数绘制像素矩阵
            Console.WriteLine("在 Windows 操作系统中显示图像");
        }
    }
}
