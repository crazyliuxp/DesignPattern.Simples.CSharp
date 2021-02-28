using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.AbstractFactory
{
    /// <summary>
    /// Spring 皮肤工厂：具体工厂
    /// </summary>
    public class SpringSkinFactory : ISkinFactory
    {
        public Button CreateButton()
        {
            return new SpringButton();
        }

        public TextField CreateTextField()
        {
            return new SpringTextField();
        }

        public ComboBox CreateComboBox()
        {
            return new SpringComboBox();
        }
    }
}
