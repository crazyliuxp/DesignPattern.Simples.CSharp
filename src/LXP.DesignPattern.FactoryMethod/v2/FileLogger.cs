using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.FactoryMethod.v2
{
    /// <summary>
    /// 文件日志记录器：具体产品
    /// </summary>
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("文件日志记录！");
        }
    }
}
