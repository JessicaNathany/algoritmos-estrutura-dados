using System;
using System.Collections.Generic;
using System.Text;

namespace estrutura_dados_csharp._3__Desafios_HackerRank
{
    public class CompareTriplets
    {
        public void Execute()
        {
            Console.WriteLine("Enter 3 numbers for letter A.");
            Console.WriteLine();
            int posicao = Convert.ToInt16(Console.ReadLine());

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

        /*
         * Complete the 'compareTriplets' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
             *  2. INTEGER_ARRAY b
         */

        /*
         * 
            a[0] > b[0] => se for maior então, Alice recebe 1 ponto
            a[1] = b[1] => se for igual então, ninguém recebe pontos
            a[2] < b[2] => se for menor então, Bob recebe 1 ponto
         */

        public int[] CalculateCompareTriplets(List<int> numbersA, List<int> numbersB)
        {
           var result = new int[2];
            int a = 0;
            int b = 0;
           

            foreach (var numberA in numbersA)
            {
                a = numberA;

                for (int i = 0; i < numberA; i++)
                {

                }

                
            }

            return result;
        }
    }
}


//class Result
//{

//    

//    public static List<int> compareTriplets(List<int> a, List<int> b)
//    {

//    }

//}

//class Solution
//{
//    public static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

//        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

//        List<int> result = Result.compareTriplets(a, b);

//        textWriter.WriteLine(String.Join(" ", result));

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}

