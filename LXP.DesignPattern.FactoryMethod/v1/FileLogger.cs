using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.FactoryMethod.v1
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("保存日志到文件！");
        }
    }
}
