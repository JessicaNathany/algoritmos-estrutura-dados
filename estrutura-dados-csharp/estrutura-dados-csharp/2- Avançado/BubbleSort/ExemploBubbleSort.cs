using System;
using System.Collections.Generic;
using System.Linq;

namespace estrutura_dados_csharp._2__Avançado.BubbleSort
{
    public class ExemploBubbleSort
    {
        public void TestaBubbleSort()
        {
            Console.WriteLine(" Selecione uma opção para testar e ver o Bubble Sort em ação!");
            Console.WriteLine();
            Console.WriteLine("1 - Ordenar lista de números");
            Console.WriteLine("2 - Comparar lista de palavras");
            Console.WriteLine("3 - Contar trocas");
            Console.WriteLine("4 - Ordenação descrescente");

            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    ListaNumerosOrdenada();
                    break;

                case '2':
                    OrdenarUmaListaPalavras();
                    break;

                case '3':
                    ContarTrocas();
                    break;

                case '4':
                    OrdenacaoDecrescente();
                    break;
            }
        }

        /// <summary>
        ///  Crie um programa que recebe uma lista de números inteiros do usuário, 
        ///  ordena essa lista usando o Bubble Sort e, em seguida, imprime a lista ordenada.
        /// </summary> 
        /// <returns></returns>
        public List<int> ListaNumerosOrdenada()
        {
            Console.WriteLine(" Informe uma lista sequência de números, separados por vírgula");
            var entrada = Console.ReadLine();

            if(String.IsNullOrEmpty(entrada))
            {
                Console.WriteLine("A entrada não pode ser vazia, informa uma sequência de números!");
            }

            string[] stringNumeros = entrada.Split(',').Select(s => s.Trim()).ToArray();

            var numeros = stringNumeros.Select(int.Parse).ToList();

            var resultado = new List<int>();

            for (int index = 0; index < numeros.Count -1; index++)
            {
                for (int j = 0; j < numeros.Count -1 -1; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        // troca os elementos
                        int temp = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine($"O resultado é: {string.Join(", ", numeros)}");
            return numeros;
        }


        /// <summary>
        /// Modifique o programa para que ele possa ordenar uma lista de palavras. 
        /// Você terá que considerar como comparar palavras - em geral, você pode usar a função string.Compare.
        /// </summary>
        /// <returns></returns>
        public List<string> OrdenarUmaListaPalavras()
        {
            var palavras = new List<string>();

            Console.WriteLine(" Este algoritmo ainda não foi criado!");

            return palavras;
        }

        /// <summary>
        /// Modifique o algoritmo Bubble Sort para contar quantas trocas faz enquanto ordena a lista.
        /// Imprima esse número após a lista ordenada.
        /// </summary>
        /// <returns></returns>
        public List<string> ContarTrocas()
        {
            var palavras = new List<string>();

            Console.WriteLine(" Este algoritmo ainda não foi criado!");

            return palavras;
        }

        /// <summary>
        /// Modifique o algoritmo Bubble Sort para ordenar a lista em ordem decrescente em vez de ordem crescente.
        /// </summary>
        /// <returns></returns>
        public List<string> OrdenacaoDecrescente()
        {
            var palavras = new List<string>();

            Console.WriteLine(" Este algoritmo ainda não foi criado!");

            return palavras;
        }
    }
}
