using System;
using System.Collections.Generic;
using System.Linq;

namespace SortListInteger.Helpers
{
    static class ListHelper
    {
        /// <summary>
        /// Find top {number} of biggest number in a list
        /// </summary>
        /// <param name="list">List integer</param>
        /// <param name="count">Count of biggest numbers</param>
        /// <returns>Top {number} biggest numbers</returns>
        public static IEnumerable<int> FindNumberOfBiggestNumbers(List<int> list, int number)
        {
            if (list.Count >= number)
            {
                for (int i = 0; i < number; i++)
                {
                    int maxValue = list.Max();
                    list.Remove(maxValue);
                    yield return maxValue;
                }
            }
            else
            {
                throw new IndexOutOfRangeException("Out of index.");
            }
        }
    }
}
