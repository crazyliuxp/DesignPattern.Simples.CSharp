using System;

namespace LXP.DesignPattern.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建4个LoadBalancer对象
            LoadBalancer balancer1, balancer2, balancer3, balancer4;
            balancer1 = LoadBalancer.GetLoadBalancer();
            balancer2 = LoadBalancer.GetLoadBalancer();
            balancer3 = LoadBalancer.GetLoadBalancer();
            balancer4 = LoadBalancer.GetLoadBalancer();

            //判断服务器负载均衡器是否相同
            if (balancer1 == balancer2 && balancer2 == balancer3 && balancer3 == balancer4)
            {
                Console.WriteLine("服务器负载均衡器具有唯一性！");
            }

            //增加服务器
            balancer1.AddServer("server 1");
            balancer1.AddServer("server 2");
            balancer1.AddServer("server 3");
            balancer1.AddServer("server 4");

            for (int i = 0; i < 10; i++)
            {
                var server = balancer1.GetServer();
                Console.WriteLine("分发请求至服务器：" + server);
            }
        }
    }
}
