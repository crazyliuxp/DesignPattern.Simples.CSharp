using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Adapter
{
    /// <summary>
    /// 二分查找类：适配者
    /// </summary>
    public class BinarySearchService
    {
        public int BinarySearch(int[] array, int key)
        {
            int low = 0;
            int high = array.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                int midVal = array[mid];
                if (midVal < key)
                {
                    low = mid + 1;
                }
                else if (midVal > key)
                {
                    high = mid - 1;
                }
                else
                {
                    return 1;
                }
            }
            return -1;
        }
    }
}
