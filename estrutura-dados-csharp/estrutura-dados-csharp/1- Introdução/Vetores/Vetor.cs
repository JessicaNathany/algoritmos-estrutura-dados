using estrutura_dados_csharp._1__Introdução.Vetores;
using System;

namespace estrutura_dados_csharp._1__Estrutura_de_Dados_inicio.Vetores
{
    public class Vetor
    {
        public void TestaVetor()
        {
            Console.WriteLine(" Selecione em exemplo");
            Console.WriteLine();
            Console.WriteLine("1 - Notas alunos");
            Console.WriteLine("2 - Busca Sequencial");
            Console.WriteLine("3 - Adicionar elementos no array");
            Console.WriteLine("4 - Tabuada usando laço for");
            Console.WriteLine("5 - Busca elemento no array");
            Console.WriteLine("6 - Calcula idade pessoa");

            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    new NotasAlunos().ObtemNotasAlunos();
                    break;

                case '2':
                    new BuscaSequencial().BuscarElementoArray();
                    break;

                case '3':
                    new ExemplosArrays().AdicionarElementoEmQualquerPosicaoNoArray();
                    break;

                case '4':
                    new Tabuada().TabuadaLacoFor();
                    break;

                case '5':
                    new Pessoa(18).CalcularIdade();
                    break;
            }
        }
    }
}
