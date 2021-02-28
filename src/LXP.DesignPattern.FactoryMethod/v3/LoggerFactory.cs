using System;
using System.Collections.Generic;
using System.Text;
using LXP.DesignPattern.FactoryMethod.v2;

namespace LXP.DesignPattern.FactoryMethod.v3
{
    /// <summary>
    /// 将工厂接口改为抽象类
    /// </summary>
    public abstract class LoggerFactory
    {
        /// <summary>
        /// 在工厂类中直接调用日志记录器类的业务方法 WriteLog()
        /// </summary>
        public void WriteLog()
        {
            var logger = this.CreateLogger();
            logger.WriteLog();
        }

        public abstract ILogger CreateLogger();
    }
}
