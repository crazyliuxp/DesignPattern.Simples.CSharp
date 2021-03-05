using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Prototype.V2
{
    /// <summary>
    /// 附件类
    /// </summary>
    public class Attachment
    {
        public string Name { get; set; }

        public Attachment(string name)
        {
            Name = name;
        }

        public void DownLoad()
        {
            Console.WriteLine("下载文件，文件名为" + Name);
        }
    }
}
