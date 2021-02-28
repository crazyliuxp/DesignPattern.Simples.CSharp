using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Singleton
{
    /// <summary>
    /// 懒汉式单例类
    /// </summary>
    public class LazySingleton
    {
        //私有静态成员变量，保存唯一实例
        private static LazySingleton instance = null;

        private static readonly object syncLocker = new object();

        private LazySingleton() {}

        /// <summary>
        /// 公有静态成员方法，返回唯一实例
        /// </summary>
        /// <returns></returns>
        public static LazySingleton GetInstance()
        {
            //第一重判读
            if (instance == null)
            {
                //锁定代码快
                lock (syncLocker)
                {
                    //第二重判断
                    if (instance == null)
                        instance = new LazySingleton();
                }
            }

            return instance;
        }
    }
}
