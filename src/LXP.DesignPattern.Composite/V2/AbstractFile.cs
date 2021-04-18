﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Composite.V2
{
    /// <summary>
    /// 抽象文件类：抽象构件
    /// </summary>
    public abstract class AbstractFile
    {
        public abstract void Add(AbstractFile file);
        public abstract void Remove(AbstractFile file);
        public abstract AbstractFile GetChild(int i);
        public abstract void KillVirus();
    }
}
