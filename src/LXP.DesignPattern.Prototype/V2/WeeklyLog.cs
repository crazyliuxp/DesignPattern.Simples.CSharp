using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Prototype.V2
{
    public class WeeklyLog : ICloneable
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Content { get; set; }
        public List<Attachment> Attachments { get; set; }

        public WeeklyLog()
        {
            Attachments = new List<Attachment>();
        }


        public object Clone()
        {
            //使用C#提供的方法实现浅克隆
            return this.MemberwiseClone();
        }
    }
}
