using System;

namespace estrutura_dados_csharp._1__Introdução.Vetores
{
    public class ExemplosArrays
    {
        public void AdicionarElementoEmQualquerPosicaoNoArray()
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
                criptomoedas[i + 1] = criptomoedas[i];
            }

            criptomoedas[posicao] = moeda;
            tamanho++;

            Console.WriteLine();
            Array.ForEach(criptomoedas, Console.WriteLine);
        }
    }
}
