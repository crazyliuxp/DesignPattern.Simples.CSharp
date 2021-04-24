using System;

namespace LXP.DesignPattern.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Component component = new Window();
            Component componentSB = new SrollBarDecorator(component);
            Component componentBB = new BlackBorderDecorator(componentSB);
            componentBB.Display();
        }
    }
}
