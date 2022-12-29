using System;
using System.Collections.Generic;

namespace estrutura_dados_csharp._3__Desafios_HackerRank
{
    public class CompareTriplets
    {
        public void Execute()
        {
            Console.WriteLine("Enter 3 numbers for letter A.");
            //Console.WriteLine();
            //int posicao = Convert.ToInt16(Console.ReadLine());

            var numbersA = new List<int>();
            numbersA.Add(17);
            numbersA.Add(28);
            numbersA.Add(30);

            var numbersB = new List<int>();
            numbersB.Add(99);
            numbersB.Add(16);
            numbersB.Add(8);

            CalculateCompareTriplets(numbersA, numbersB);
        }
        private List<int> CalculateCompareTriplets(List<int> listA, List<int> listB)
        {
            List<int> scores = new List<int>() { 0, 0 };

            for (int i = 0; i < listA.Count; i++)
            {
                if (listA[i] > listB[i])
                {
                    scores[0]++;
                }
                else if (listA[i] < listB[i])
                {
                    scores[i]++;
                }

            }

            return scores;
        }
    }
}
       
