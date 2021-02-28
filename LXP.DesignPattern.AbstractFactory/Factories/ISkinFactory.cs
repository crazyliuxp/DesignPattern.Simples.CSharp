using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.AbstractFactory
{
    /// <summary>
    /// 界面皮肤工厂接口：抽象工厂
    /// </summary>
    public interface ISkinFactory
    {
        Button CreateButton();
        TextField CreateTextField();
        ComboBox CreateComboBox();
    }
}
