using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.AbstractFactory
{
    /// <summary>
    /// Summer 皮肤工厂：具体皮肤工厂
    /// </summary>
    public class SummerSkinFactory : ISkinFactory
    {
        public Button CreateButton()
        {
            return new SummerButton();
        }

        public TextField CreateTextField()
        {
            return new SummerTextField();
        }

        public ComboBox CreateComboBox()
        {
            return new SummerComboBox();
        }
    }
}
