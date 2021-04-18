using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Composite.V1
{
    //文本文件类
    public class TextFile
    {
        private string _name;

        public TextFile(string name)
        {
            _name = name;
        }

        public void KillVirus()
        {
            //// 此处模拟杀毒操作
            Console.WriteLine("---- 对文本文件‘{0}’进行杀毒", _name);
        }
    }
}
