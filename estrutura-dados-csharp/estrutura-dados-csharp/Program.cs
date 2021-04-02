using estrutura_dados_csharp._1__Estrutura_de_Dados_inicio.Vetores;
using estrutura_dados_csharp._1__Introdução.Arvores;
using estrutura_dados_csharp._1__Introdução.Filas;
using estrutura_dados_csharp._1__Introdução.Pilhas;
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
            Console.WriteLine("2 - Pilhas");
            Console.WriteLine("3 - Filas");
            Console.WriteLine("4 - Árvores");

            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    new Vetor().TestaVetor();
                    break;

                case '2':
                    new Pilhas().TestaPilhas();
                    break;

                case '3':
                    new Filas().TestaFilas();
                    break;

                case '4':
                    new Arvores().TestaArvores();
                    break;
            }
        }
    }
}
