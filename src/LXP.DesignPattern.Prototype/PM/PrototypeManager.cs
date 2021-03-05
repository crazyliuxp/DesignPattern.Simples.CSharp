using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Prototype.PM
{
    /// <summary>
    /// 原型管理器（使用饿汉式单例）
    /// </summary>
    public class PrototypeManager
    {
        private Dictionary<string, IOfficialDocument> odDic = new Dictionary<string, IOfficialDocument>();
        private static PrototypeManager pm = new PrototypeManager();

        private PrototypeManager()
        {
            odDic.Add("far", new FAR());
            odDic.Add("srs", new FAR());
        }

        public static PrototypeManager GetPrototypeManager() => pm;

        /// <summary>
        /// 增加新的公文对象
        /// </summary>
        public void AddOfficialDocument(string key, IOfficialDocument doc)
        {
            odDic.Add(key, doc);
        }

        /// <summary>
        /// 通过浅克隆获取新的公文对象
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public IOfficialDocument GetOfficialDocument(string key)
        {
            return odDic[key].Clone();
        }
    }
}
