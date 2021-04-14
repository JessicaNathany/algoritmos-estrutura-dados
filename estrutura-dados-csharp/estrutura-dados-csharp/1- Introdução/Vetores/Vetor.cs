﻿using System;
using System.Linq;

namespace estrutura_dados_csharp._1__Estrutura_de_Dados_inicio.Vetores
{
    public class Vetor
    {
        public void TestaVetor()
        {
            // ObtemNotasAlunos();

            // BuscarElementoArray();

            AdicionarElementoEmQualquerPosicaoNoArray(0, "Tether");

            //TabuadaLacoFor();
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

        // Busca / Pesquisa Sequencial
        private void BuscarElementoArray()
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

        private void AdicionarElementoEmQualquerPosicaoNoArray(int posicao, string moeda)
        {
            string[] criptomoedas = new string[7];

            criptomoedas[0] = "Bitcoin";
            criptomoedas[1] = "Ethereum";
            criptomoedas[2] = "Binance";
            criptomoedas[3] = "XRP";
            criptomoedas[4] = "Litecoin";

            var tamanho = criptomoedas.Length;

            if(!(posicao >= 0 && posicao < tamanho))
            {
                Console.WriteLine("Posição inválida");
            }

            for(int i = tamanho-1; i >= posicao; i--)
            {
                criptomoedas[i+1] = criptomoedas[i];
            }

            criptomoedas[posicao] = moeda;
            tamanho++;

            Console.WriteLine();
            Array.ForEach(criptomoedas, Console.WriteLine);
        }
    }
}
