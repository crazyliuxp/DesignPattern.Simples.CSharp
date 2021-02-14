using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Singleton
{
    /// <summary>
    /// 饿汉式单例
    /// </summary>
    public class EagerSingleton
    {
        //定义静态变量并实例化单例类
        private static readonly EagerSingleton instance = new EagerSingleton();

        //私有构造函数
        private EagerSingleton()
        {
        }

        //获取单例对象
        public static EagerSingleton GetInstance()
        {
            return instance;
        }
    }
}
