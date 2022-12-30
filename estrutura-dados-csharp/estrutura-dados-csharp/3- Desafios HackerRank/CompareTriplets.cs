using System;
using System.Collections.Generic;

namespace estrutura_dados_csharp._3__Desafios_HackerRank
{
    public class CompareTriplets
    {
        public void Execute()
        {
            Console.WriteLine("The task is to find their comparison points by comparing Alice and Bob. Ex: ");
            Console.WriteLine();

            Console.WriteLine("If a[i] > b[i], then Alice is awarded 1 point. ");
            Console.WriteLine();

            Console.WriteLine("If a[i] < b[i], then Bob is awarded 1 point. ");
            Console.WriteLine();
            Console.WriteLine("If a[i] = b[i], then neither person receives a point. ");
            
            Console.WriteLine("Alice points: 17, 28, 30");
            Console.WriteLine("Bob points: 99, 16, 8");
            Console.WriteLine();

            Console.WriteLine("Result");

            var numbersA = new List<int>();
            numbersA.Add(17);
            numbersA.Add(28);
            numbersA.Add(30);

            var numbersB = new List<int>();
            numbersB.Add(99);
            numbersB.Add(16);
            numbersB.Add(8);

            var listCompare = CalculateCompareTriplets(numbersA, numbersB);

            foreach (var element in listCompare)
                Console.WriteLine(element);

            Console.ReadKey();
        }
        private List<int> CalculateCompareTriplets(List<int> listA, List<int> listB)
        {
            int aliceScore = 0;
            int bobScore = 0;
            var results = new List<int>();

            for (int index = 0; index < 3; index++)
            {
                if (listA[index] > listB[index])
                {
                    aliceScore++;

                } else if (listB[index] > listA[index])
                {
                    bobScore++;
                }
            }

            results.Add(aliceScore);
            results.Add(bobScore);

            return results;
        }
    }
}
       
