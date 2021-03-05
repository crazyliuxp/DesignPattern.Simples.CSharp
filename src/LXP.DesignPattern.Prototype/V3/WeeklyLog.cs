using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace LXP.DesignPattern.Prototype.V3
{
    [Serializable]
    public class WeeklyLog
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Content { get; set; }
        public List<Attachment> Attachments { get; set; }

        public WeeklyLog()
        {
            Attachments = new List<Attachment>();
        }

        public object DeepClone()
        {
            MemoryStream ms = new MemoryStream(); // 初始化一个内存流
            BinaryFormatter bf = new BinaryFormatter(); // 以二进制的格式来序列化和反序列化对象
            bf.Serialize(ms, this); // 将档案对象序列化到内存流中
            //设置流的位置，SeekOrigin.Begin表示流的开始，0表示相对于SeekOrigin.Begin的偏移量
            ms.Seek(0, SeekOrigin.Begin); 
            return bf.Deserialize(ms); // 反序列化，实现深克隆
        }
    }
}
