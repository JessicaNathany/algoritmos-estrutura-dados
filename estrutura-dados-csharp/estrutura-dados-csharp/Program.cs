﻿using estrutura_dados_csharp._1__Introdução.Arrays;
using estrutura_dados_csharp._1__Introdução.Arvores;
using estrutura_dados_csharp._1__Introdução.Filas;
using estrutura_dados_csharp._3__Desafios_HackerRank;
using estrutura_dados_csharp._2__Avançado.QuickSort;
using System;

namespace estrutura_dados_csharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ..:: Selecione uma opção ::..");
            Console.WriteLine();
            Console.WriteLine("1 - Arrays");
            Console.WriteLine("2 - Pilhas");
            Console.WriteLine("3 - Filas");
            Console.WriteLine("4 - Árvores");
            Console.WriteLine("5 - BubleSort");
            Console.WriteLine("6 - Desafios HarckerRank");

            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    new ExemplosArrays().TestaArrays();
                    break;

                case '2':
                    //new ExemploPilhas().TestaPilhas();
                    break;

                case '3':
                    new Filas().TestaFilas();
                    break;

                case '4':
                    new ExemploArvores().TestaArvores();
                    break;

                case '5':
                    new ExemploBubbleSort().TestaBubbleSort();
                    break;

                case '6':
                    new HackerRank().TestaHackerRank();
                    break;
            }
        }
    }
}
