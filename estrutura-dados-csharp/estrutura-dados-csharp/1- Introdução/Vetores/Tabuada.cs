using System;

namespace estrutura_dados_csharp._1__Introdução.Vetores
{
    public class Tabuada
    {
        public void TabuadaLacoFor()
        {
            Console.WriteLine("Digite um número da tabuada");
            int numeroTabuada = Convert.ToInt32(Console.ReadLine());

            for (int contador = 0; contador <= 10; contador++)
            {
                var result = numeroTabuada * contador;
                Console.WriteLine(numeroTabuada + " x " + contador + " = " + result);
            }
        }
    }
}
