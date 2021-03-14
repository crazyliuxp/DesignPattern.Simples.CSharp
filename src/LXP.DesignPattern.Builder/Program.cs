using System;

namespace LXP.DesignPattern.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var ab = AppConfigHelper.GetBuilder() as ActorBuilder;
            var controller=new ActorController();
            var actor = controller.Construct(ab);

            Console.WriteLine($"{actor.Type}的外观");
            Console.WriteLine($"性别：{actor.Sex}");
            Console.WriteLine($"面容：{actor.Face}");
            Console.WriteLine($"服装：{actor.Costume}");
            Console.WriteLine($"发行：{actor.Hairstyle}");
        }
    }
}
