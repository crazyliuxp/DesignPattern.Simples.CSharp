using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Composite.V1
{
    //文件夹类
    public class Folder
    {
        private string name;
        private IList<Folder> folderList = new List<Folder>();
        private IList<ImageFile> imageList = new List<ImageFile>();
        private IList<TextFile> textList = new List<TextFile>();

        public Folder(string name)
        {
            this.name = name;
        }

        public void AddFolder(Folder f)
        {
            folderList.Add(f);
        }

        public void AddImageFile(ImageFile image)
        {
            imageList.Add(image);
        }

        public void AddTextFile(TextFile text)
        {
            textList.Add(text);
        }

        //另外还需要提供3个不同的方法来删除相应的成员，此处省略
        //还需要提供3个不同的方法来获取成员，此处省略

        public void KillVirus()
        {
            Console.WriteLine("**** 对文件夹‘{0}’进行杀毒", name);
            foreach (var item in folderList)
            {
                item.KillVirus();
            }

            foreach (var item in imageList)
            {
                item.KillVirus();
            }

            foreach (var item in textList)
            {
                item.KillVirus();
            }
        }
    }
}
