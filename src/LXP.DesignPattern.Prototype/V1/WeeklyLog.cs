using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Prototype.V1
{
    public class WeeklyLog : ICloneable
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Content { get; set; }


        public object Clone()
        {
            WeeklyLog obj = new WeeklyLog();
            obj.Name = this.Name;
            obj.Date = this.Date;
            obj.Content = this.Content;
            return obj;
        }
    }
}
