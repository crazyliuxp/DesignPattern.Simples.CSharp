using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Composite.V2
{
    /// <summary>
    /// 文件夹类：容器构件
    /// </summary>
    public class Folder : AbstractFile
    {
        /// <summary>
        /// 定义集合 _fileList，用于存储AbstractFile类型的成员
        /// </summary>
        private List<AbstractFile> _fileList = new List<AbstractFile>();
        private string _name;

        public Folder(string name)
        {
            _name = name;
        }

        public override void Add(AbstractFile file)
        {
            _fileList.Add(file);
        }

        public override void Remove(AbstractFile file)
        {
            _fileList.Remove(file);
        }

        public override AbstractFile GetChild(int i)
        {
            return _fileList[i];
        }

        public override void KillVirus()
        {
            //模拟杀毒
            Console.WriteLine("****** 对文件夹'{0}'进行杀毒", _name);

            //递归调用成员构件的KillVirus()方法
            _fileList.ForEach(file =>
            {
                file.KillVirus();
            });
        }
    }
}
