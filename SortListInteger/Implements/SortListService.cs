using SortListInteger.Helpers;
using SortListInteger.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SortListInteger.Implements
{
    /// <summary>
    /// Top 10 biggest numbers in the list => put in the middle of the list
    /// Next top 10 biggest numbers => put at the end of list
    /// The remaining numbers => put at the top of the list
    /// </summary>
    public class SortListService : ISortListService
    {
        public void Sort(List<int> listInteges, int topBiggestNumber)
        {
            // Initial List in string
            string initialListString = string.Join(", ", listInteges);

            // Get 10 biggest numbers in the list
            List<int> firstTenOfBiggestNumbers = ListHelper.FindNumberOfBiggestNumbers(listInteges, topBiggestNumber).ToList();

            // Get next 10 biggest numbers in the list
            List<int> nextTenOfBiggestNumbers = ListHelper.FindNumberOfBiggestNumbers(listInteges, topBiggestNumber).ToList();

            // Get remaining number
            List<int> remainingNumbers = listInteges; // Need to sort?

            // Concat to final list
            List<int> sortedList = remainingNumbers.Concat(firstTenOfBiggestNumbers).Concat(nextTenOfBiggestNumbers).ToList();

            // Sorted list to string
            string sortedListString = string.Join(", ", sortedList);

            Console.WriteLine("Initial list:\t" + initialListString);
            Console.WriteLine("Sorted list:\t" + sortedListString);
        }
    }
}
