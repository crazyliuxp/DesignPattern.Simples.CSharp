using System;

namespace LXP.DesignPattern.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var skinFactory = (ISkinFactory) AppConfigHelper.GetSkinFactory();
            var button = skinFactory.CreateButton();
            var textField = skinFactory.CreateTextField();
            var comboBox = skinFactory.CreateComboBox();

            button.Display();
            textField.Display();
            comboBox.Display();
        }
    }
}
