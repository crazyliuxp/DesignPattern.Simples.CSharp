﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Composite.V2
{
    /// <summary>
    /// 图像文件类：叶子构件
    /// </summary>
    public class ImageFile : AbstractFile
    {
        private string _name;
        public ImageFile(string name)
        {
            _name = name;
        }
        public override void Add(AbstractFile file)
        {
            Console.WriteLine("对不起不支持该方法");
        }

        public override void Remove(AbstractFile file)
        {
            Console.WriteLine("对不起不支持该方法");
        }

        public override AbstractFile GetChild(int i)
        {
            Console.WriteLine("对不起不支持该方法");
            return null;
        }

        public override void KillVirus()
        {
            //模拟杀毒
            Console.WriteLine("------ 对图像文件'{0}'进行杀毒", _name);
        }
    }
}
