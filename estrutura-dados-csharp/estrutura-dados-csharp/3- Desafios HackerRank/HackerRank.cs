using System;

namespace estrutura_dados_csharp._3__Desafios_HackerRank
{
    public class HackerRank
    {
        public void TestaHackerRank()
        {
            Console.WriteLine(" Selecione uma opção");
            Console.WriteLine();
            Console.WriteLine("1 - Desafio idade");
            Console.WriteLine("2 - Very Big Sum");
            Console.WriteLine("3 - Time Conversion");
            Console.WriteLine("4 - CompareTriplets");
            Console.WriteLine("5 - ");

            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    new DesafioMaiorIdade(18).CalcularIdade();
                    break;

                case '2':
                    new VeryBigSum().SolveSolutionVeryBigSum(); 
                    break;

                case '3':
                    new TimeConversion().CalculateTime("07:05:45PM"); 
                    break;

                case '4':
                    new CompareTriplets().Execute();
                    break;
            }
        }
    }
}
