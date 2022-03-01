using System.Collections.Generic;

namespace SortListInteger.Interfaces
{
    public interface ISortListService
    {

        /// <summary>
        /// Top 10 biggest numbers in the list => put in the middle of the list
        /// Next top 10 biggest numbers => put at the end of list
        /// The remaining numbers => put at the top of the list
        /// </summary>
        void Sort(List<int> listInteges, int topBiggestNumber);
    }
}
