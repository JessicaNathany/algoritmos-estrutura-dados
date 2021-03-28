using estrutura_dados_csharp._1__Estrutura_de_Dados_inicio.Vetores;
using System;

namespace estrutura_dados_csharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ..:: Selecione uma opção ::..");
            Console.WriteLine();
            Console.WriteLine("1 - Vetores");

            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    new Vetor().TestaVetor();
                    break;
            }

        }
    }
}
