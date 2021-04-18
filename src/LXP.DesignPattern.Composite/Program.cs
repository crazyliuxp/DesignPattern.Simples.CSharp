using LXP.DesignPattern.Composite.V1;
using LXP.DesignPattern.Composite.V2;
using System;

namespace LXP.DesignPattern.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            #region V1
            //Folder folder1 = new Folder("十一的资料");
            //Folder folder2 = new Folder("图像文件");
            //Folder folder3 = new Folder("文本文件");

            //ImageFile image1 = new ImageFile("小龙女.jpg");
            //ImageFile image2 = new ImageFile("张无忌.gif");

            //TextFile text1 = new TextFile("降龙十八掌.txt");
            //TextFile text2 = new TextFile("乾坤大挪移.doc");

            //folder2.AddImageFile(image1);
            //folder2.AddImageFile(image2);

            //folder3.AddTextFile(text1);
            //folder3.AddTextFile(text2);

            //folder1.AddFolder(folder2);
            //folder1.AddFolder(folder3);

            //folder1.KillVirus();
            #endregion

            #region V2
            var folder1 = new V2.Folder("十一的资料");
            var folder2 = new V2.Folder("图像文件");
            var folder3 = new V2.Folder("视频文件");
            var folder4 = new V2.Folder("文本文件");

            var image1 = new V2.ImageFile("小龙女.jpg");
            var image2 = new V2.ImageFile("张无忌.gif");

            var text1 = new V2.TextFile("降龙十八掌.txt");
            var text2 = new V2.TextFile("乾坤大挪移.doc");

            var video1 = new V2.TextFile("天龙八部.mp4");
            var video2 = new V2.TextFile("笑傲江湖.rmvb");

            folder2.Add(image1);
            folder2.Add(image2);

            folder3.Add(video1);
            folder3.Add(video2);

            folder4.Add(text1);
            folder4.Add(text2);

            folder1.Add(folder2);
            folder1.Add(folder3);
            folder1.Add(folder4);

            //从“十一的资料”节点开始进行杀毒操作
            folder1.KillVirus();
            #endregion
        }
    }
}
