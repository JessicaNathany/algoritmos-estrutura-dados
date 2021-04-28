using System;

namespace estrutura_dados_csharp._1__Introdução.Vetores
{
    public class BuscaSequencial
    {
        public void BuscarElementoArray()
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
    }
}
