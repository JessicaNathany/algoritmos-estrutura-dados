using System;
using System.Collections.Generic;
using System.Linq;

namespace estrutura_dados_csharp._3__Desafios_HackerRank
{
    public class VeryBigSum
    {
        public static long CalculateBigSum(List<long> arrayNumber)
        {
            return  arrayNumber.Sum(x => x);
        }

        public void SolveSolutionVeryBigSum()
        {
            /*
             Sample Input:  
              
              arrayCount = 5
              array =  1000000001 1000000002 1000000003 1000000004 1000000005;

              Sample Output: 5000000015
            */

            Console.WriteLine("Write the array count: ");
            Console.WriteLine();
            int arrayCount = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("Write the array numbers: ");
            Console.WriteLine();
            var arrayNumber = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrayTemp => Convert.ToInt64(arrayTemp)).ToList();

            var result = CalculateBigSum(arrayNumber);
            Console.WriteLine(result);
        }
    }
}
