using System;
using System.Collections.Generic;
using System.Linq;

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
            int scoreAlice = 0;
            int scoreBob = 0;

            List<int> results = new List<int>();

            foreach (var numberA in listA)
            {
                for (int index = 0; index < listA.Count(); index++)
                {
                    var positionA = listA[index];
                    var positionB = listB[index];

                    CompareNumbers(positionA, positionB, listB, scoreAlice, scoreBob);
                }
            }

            
            return new List<int> { scoreAlice, scoreBob };
        }

        private void CompareNumbers(int positionA, int positionB, List<int> listB, int scoreAlice, int scoreBob)
        {
            if (positionA > positionB)
            {
                scoreAlice += 1;
            }
            else if (positionA < positionB)
            {
                scoreBob += 1;
            }
        }

        //private List<int> CalculateCompareTriplets(List<int> listA, List<int> listB)
        //{
        //    int scoreAlice = 0;
        //    int scoreBob = 0;
        //    List<int> results = new List<int>();

        //    for (int index = 0; index < listA.Count(); index++)
        //    {
        //        var positionA = listA[0];
        //        var positionB = listB[0];



        //        if (positionA > positionB)
        //        {
        //            scoreAlice += 1;
        //        }
        //        else if (positionA < positionB)
        //        {
        //            scoreBob += 1;
        //        }
        //        else
        //        {
        //            continue;
        //        }
        //    }
        //    return new List<int> { scoreAlice, scoreBob };
        //}
    }
}
       
