using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Adapter
{
    /// <summary>
    /// 抽象成绩操作类：目标接口
    /// </summary>
    public interface IScoreOperation
    {
        /// <summary>
        /// 成绩排序
        /// </summary>
        int[] Sort(int[] array);
        /// <summary>
        /// 成绩查找
        /// </summary>
        int Search(int[] array, int key);
    }
}
