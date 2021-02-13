using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Singleton
{
    /// <summary>
    /// 负载均衡器：单例类，真实环境可能非常复杂，这里只列出部分与模式相关的代码
    /// </summary>
    public class LoadBalancer
    {
        //私有静态成员变量，保存唯一实例
        private static LoadBalancer loadBalancer = null;
        //服务器集合
        private List<string> serverList = null;

        /// <summary>
        /// 私有构造函数
        /// </summary>
        private LoadBalancer()
        {
            serverList = new List<string>();
        }

        /// <summary>
        /// 公有静态成员方法，返回唯一实例
        /// </summary>
        /// <returns></returns>
        public static LoadBalancer GetLoadBalancer()
        {
            if (loadBalancer == null)
                loadBalancer = new LoadBalancer();
            return loadBalancer;
        }

        //增加服务器
        public void AddServer(string server)
        {
            serverList.Add(server);
        }

        //删除服务器
        public void RemoveServer(string server)
        {
            serverList.Remove(server);
        }

        //使用Random类随机获取服务器
        public string GetServer()
        {
            var random = new Random();
            var i = random.Next(serverList.Count);
            return serverList[i];
        }

    }
}
