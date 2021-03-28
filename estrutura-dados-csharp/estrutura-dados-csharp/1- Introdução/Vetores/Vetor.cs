using System;

namespace estrutura_dados_csharp._1__Estrutura_de_Dados_inicio.Vetores
{
    public class Vetor
    {
        public void TestaVetor()
        {
            ObtemNotasAlunos();
        }

        private void ObtemNotasAlunos()
        {
            int[] notasArray = new int[5];
            string[] alunosArray = new string[5];
            var media = 0;

            for (int i = 0; i < alunosArray.Length; i++)
            {
                Console.WriteLine("Informe o nome do aluno: ");
                var aluno = Console.ReadLine();

                Console.WriteLine($"Informe a nota do aluno: {aluno}");
                var nota = Convert.ToInt16(Console.ReadLine());

                alunosArray[i] = aluno;
                notasArray[i] = nota;
                media = media + notasArray[i];
                media = media / notasArray[i];
            }

            // Array.ForEach(alunosArray, Console.WriteLine); um exemplo de array em uma só linha
            Console.WriteLine($"A média da turma é: {media}");

            for(int i =0; i < alunosArray.Length; i++)
            {
                if(notasArray[i] > media)
                {
                    Console.WriteLine($"Parabéns: {alunosArray[i]}");
                }
            }
        }
    }
}
