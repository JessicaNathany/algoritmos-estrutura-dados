using System;
using System.Linq;

namespace estrutura_dados_csharp._1__Introdução.Vetores
{
    public class ExemplosArrays
    {
        public void TestaArrays()
        {
            Console.WriteLine(" Selecione uma opção");
            Console.WriteLine();
            Console.WriteLine("1 - Adicionar elemento em qualquer posição do Array");
            Console.WriteLine("2 - Remover elemento do Array");
            Console.WriteLine("3 - Buscar elementos no Array");
            Console.WriteLine("4 - Tabuada usando laço for");
            Console.WriteLine("5 - Obtém notas alunos");

            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    AdicionarElementoEmQualquerPosicaoNoArray();
                    break;

                case '2':
                    RemoverItemsNoArray();
                    break;

                case '3':
                    ProcurarUmaFrutaNaLista();
                    break;

                case '4':
                    TabuadaLacoFor();
                    break;

                case '5':
                    ObtemNotasAlunos();
                    break;
            }
        }
        public int BuscarElementos(string elemento, string[] array)
        {
            var tamanho = array.Length;

            for (int i = 0; i < tamanho; i++)
            {
                if (array[i].Equals(elemento, StringComparison.InvariantCultureIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
        }
        private void ProcurarUmaFrutaNaLista()
        {
            Console.WriteLine("Digite o nome de uma fruta que deseja procurar");
            var fruta = Console.ReadLine();
            string[] frutas = { "Maçã", "Banana", "Pera", "Melão", "Melancia", "Abacate", "Goiaba" };

            for (int i = 0; i < frutas.Length; i++)
            {
                if (frutas[i].Equals(fruta, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"A fruta {fruta} foi localizada na posição {frutas[i].Length}");
                }
                else
                {
                    Console.WriteLine($"Não foi localizado {fruta} na posição {frutas[i].Length}!");
                }
            }
        }
        private void TabuadaLacoFor()
        {
            Console.WriteLine("Digite um número da tabuada");
            int numeroTabuada = Convert.ToInt32(Console.ReadLine());

            for (int contador = 0; contador <= 10; contador++)
            {
                var result = numeroTabuada * contador;
                Console.WriteLine(numeroTabuada + " x " + contador + " = " + result);
            }
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

            Console.WriteLine($"A média da turma é: {media}");
            var maiorNota = notasArray.Max();

            Console.WriteLine($"Maior nota {maiorNota}");
            Console.ReadKey();
        }

        private void AdicionarElementoEmQualquerPosicaoNoArray()
        {
            Console.WriteLine("Digite a posição: ");
            Console.WriteLine();
            int posicao = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite a moeda: ");
            Console.WriteLine();
            string moeda = Console.ReadLine();

            string[] criptomoedas = new string[7];

            criptomoedas[0] = "Bitcoin";
            criptomoedas[1] = "Ethereum";
            criptomoedas[2] = "Binance";
            criptomoedas[3] = "XRP";
            criptomoedas[4] = "Litecoin";

            var tamanho = criptomoedas.Length;

            if (!(posicao >= 0 && posicao < tamanho))
            {
                Console.WriteLine("Posição inválida");
            }

            for (int i = tamanho - 1; i >= posicao; i--)
            {
                criptomoedas[i + 1] = criptomoedas[posicao];
            }

            criptomoedas[posicao] = moeda;
            tamanho++;

            Console.WriteLine();
            Array.ForEach(criptomoedas, Console.WriteLine);
        }

        private void RemoverItemsNoArray()
        {
            string[] linguagensProgramacao = new string[7];

            linguagensProgramacao[0] = "C#";
            linguagensProgramacao[1] = "Python";
            linguagensProgramacao[2] = "R";
            linguagensProgramacao[3] = "Golang";
            linguagensProgramacao[4] = "Java";
            linguagensProgramacao[5] = "JavaScript";

            var tamanho = linguagensProgramacao.Length;

            Console.WriteLine("Lista de linguagens de programação: ");
            Console.WriteLine();
            Array.ForEach(linguagensProgramacao, Console.WriteLine);

            Console.WriteLine("Digite a linguagem que você queira remover : ");
            Console.WriteLine();
            var nomeLinguagem = Console.ReadLine();

            var posicao = BuscarElementos(nomeLinguagem, linguagensProgramacao);

            var itensRemovidos = RemoverItem(posicao, linguagensProgramacao);

            Console.WriteLine();
            Array.ForEach(linguagensProgramacao, Console.WriteLine);
        }

        private object[] RemoverItem(int posicao, string[] array)
        {
            var tamanho = array.Length;

            if (!(posicao >= 0 && posicao < tamanho))
            {
                Console.WriteLine("Posição inválida!");
            }

            for (int i = posicao; i < tamanho - 1; i++)
            {
                array[i] = array[i + 1];
            }

            tamanho--;
            return array;
        }

     
    }
}
