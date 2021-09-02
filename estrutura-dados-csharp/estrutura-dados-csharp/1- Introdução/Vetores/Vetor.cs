using estrutura_dados_csharp._1__Introdução.Vetores;
using estrutura_dados_csharp._1__Introdução.Vetores.Dessafios_HackerRank;
using System;

namespace estrutura_dados_csharp._1__Estrutura_de_Dados_inicio.Vetores
{
    public class Vetor
    {
        public void TestaVetor()
        {
            Console.WriteLine(" Selecione em exemplo");
            Console.WriteLine();
            Console.WriteLine("1 - Testar Arrays");
            Console.WriteLine("2 - Testar HackerRank");
            Console.WriteLine("3 - Testar Pilhas ");
            Console.WriteLine("4 - r");

            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    new ExemplosArrays().TestaArrays();
                    break;

                case '2':
                    new HackerRank().TestaHackerRank();
                    break;

                case '3':
                    new ExemplosArrays().TestaArrays(); // pilhas
                    break;

                case '4':
                    new Pessoa(18).CalcularIdade();
                    break;
            }
        }
    }
}
