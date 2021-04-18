using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Composite.V1
{
    //图像文件类
    public class ImageFile
    {
        private string _name;

        public ImageFile(string name)
        {
            _name = name;
        }

        public void KillVirus()
        {
            //// 此处模拟杀毒操作
            Console.WriteLine("---- 对图像文件‘{0}’进行杀毒", _name);
        }
    }
}
