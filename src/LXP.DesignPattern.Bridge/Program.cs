using LXP.DesignPattern.Bridge.abstractions;
using LXP.DesignPattern.Bridge.imps;
using System;

namespace LXP.DesignPattern.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var image = (Image)AppConfigHelper.GetInstance("RefinedAbstraction");
            var imp = (IImageImp)AppConfigHelper.GetInstance("CpncreteImplementor");
            image.SetImageImp(imp);
            image.ParseFile("小龙女");
        }
    }
}
