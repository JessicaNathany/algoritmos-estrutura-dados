using System;
using System.Linq;

namespace estrutura_dados_csharp._1__Estrutura_de_Dados_inicio.Vetores
{
    public class Vetor
    {
        public void TestaVetor()
        {
            // ObtemNotasAlunos();
            BuscarElementoArray();
        }

        private void ObtemNotasAlunos()
        {
            int[] notasArray = new int[3];
            string[] alunosArray = new string[3];
            var media = 0;
            var soma = 0;
            var count = 0;

            for (int i = 0; i < alunosArray.Length; i++)
            {
                Console.WriteLine("Informe o nome do aluno: ");
                var aluno = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine($"Informe a nota da(o) {aluno}");
                var nota = Convert.ToInt16(Console.ReadLine());
                count++;

                alunosArray[i] = aluno;
                notasArray[i] = nota;
                soma = soma + notasArray[i];
                media = soma / count;
            }

            // Array.ForEach(alunosArray, Console.WriteLine); um exemplo de array utilizando o framework
            Console.WriteLine($"A média da turma é: {media}");
            var maiorNota = notasArray.Max();
          
            Console.WriteLine($"Maior nota {maiorNota}");
            Console.ReadKey();
        }

        // Busca / Pesquisa Sequencial
        private void BuscarElementoArray()
        {
            Console.WriteLine("Digite o nome de uma fruta que deseja procurar");
            var fruta = Console.ReadLine();
            string[] frutas =  {"Maçã", "Banana", "Pera", "Melão", "Melancia", "Abacate", "Goiaba" };

            for(int i=0; i < frutas.Length; i++)
            {
                if(frutas[i].Equals(fruta, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"A fruta {fruta} foi localizada na posição {frutas[i].Length}");
                }
                else
                {
                    Console.WriteLine($"Não foi localizado {fruta} na posição {frutas[i].Length}!");
                }
            }
        }

        private void AdicionarElementoEmUmaPosicaoNoArray()
        {

        }
    }
}
