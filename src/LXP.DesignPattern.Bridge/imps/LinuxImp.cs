using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Bridge.imps
{
    /// <summary>
    /// Linux操作系统实现类：具体实现类
    /// </summary>
    public class LinuxImp : IImageImp
    {
        public void DoPaint(Matrix matrix)
        {
            //调用Linux系统的绘制函数绘制像素矩阵
            Console.WriteLine("在 Linux 操作系统中显示图像");
        }
    }
}
