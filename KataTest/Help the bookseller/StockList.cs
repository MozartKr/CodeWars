using System;
using System.Collections.Generic;
using System.Linq;

namespace KataTest.Help_the_bookseller
{
    public class StockList {

        public static string stockSummary(String[] lstOfArt, String[] lstOf1stLetter)
        {
            var stockList = new List<string>();
            var sumCosts = 0;
            foreach (var firstLetter in lstOf1stLetter)
            {
                var costs = lstOfArt.
                    Where(s => s.StartsWith(firstLetter)).
                    Select(s => Convert.ToInt32(s.Split(' ')[1])).
                    Sum();

                sumCosts += costs;
                stockList.Add(string.Format("({0} : {1})", firstLetter, costs));
            }

            return sumCosts == 0 ? string.Empty : string.Join(" - ", stockList);
        }
    }
}