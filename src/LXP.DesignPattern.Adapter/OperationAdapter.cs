using System;
using System.Collections.Generic;
using System.Text;

namespace LXP.DesignPattern.Adapter
{
    /// <summary>
    /// 操作适配器：适配器类
    /// </summary>
    public class OperationAdapter : IScoreOperation
    {
        private QuickSortService _quickSort;
        private BinarySearchService _binarySearch;

        public OperationAdapter()
        {
            _quickSort = new QuickSortService();
            _binarySearch = new BinarySearchService();
        }

        public int[] Sort(int[] array)
        {
            return _quickSort.QuickSort(array);
        }

        public int Search(int[] array, int key)
        {
            return _binarySearch.BinarySearch(array, key);
        } 
    }
}
