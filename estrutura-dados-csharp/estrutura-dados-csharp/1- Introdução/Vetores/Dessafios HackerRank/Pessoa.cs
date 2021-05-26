using System;

namespace estrutura_dados_csharp._1__Introdução.Vetores
{
    public class Pessoa
    {
        public int Idade { get; set; }

        public Pessoa(int idade)
        {
            if(idade <= 0)
            {
                Console.WriteLine("Age is not valid, setting age to 0.");
                idade = 0;
            }
            else
            {
               Idade = idade;
            }
        }

        public void CalcularIdade()
        {
            int idadeTeste = int.Parse(Console.In.ReadLine());

            for (int i = 0; i < idadeTeste; i++)
            {
                int age = int.Parse(Console.In.ReadLine());
                Pessoa pessoa = new Pessoa(age);

                pessoa.SouMaisVelho();

                for (int j = 0; j < 3; j++)
                {
                    pessoa.PassaAno();
                }
                
                pessoa.SouMaisVelho();
                Console.WriteLine();
            }
        }

        private void SouMaisVelho()
        {
            if (Idade < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (13 <= Idade && Idade < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else if (Idade >= 18)
            {
                Console.WriteLine("You are old.");
            }
        }

        private void PassaAno()
        {
            Idade++;
        }
    }
}
