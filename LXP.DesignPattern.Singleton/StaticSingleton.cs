using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Singleton
{
    /// <summary>
    /// 静态内部类单例，线程安全
    /// </summary>
    public class StaticSingleton
    {
        //私有构造函数，防止从外边实例化
        private StaticSingleton(){}

        //公有静态成员方法，返回唯一实例
        public static StaticSingleton GetInstance()
        {
            return InnerClass.instance;
        }

        //内部类，第一次调用GetInstance()时加载InnerClass
        class InnerClass
        {
            //在类被实例化或静态成员被调用的时候进行调用
            //这里也就是当instance被调用的时候，会执行静态函数
            static InnerClass(){}
            internal static readonly StaticSingleton instance = new StaticSingleton();
        }
    }
}
