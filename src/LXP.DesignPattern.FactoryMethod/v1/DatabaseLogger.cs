using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.FactoryMethod.v1
{
    public class DatabaseLogger:ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("保存日志到数据库！");
        }
    }
}
