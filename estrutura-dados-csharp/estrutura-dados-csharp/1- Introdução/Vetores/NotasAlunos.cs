using System;
using System.Linq;

namespace estrutura_dados_csharp._1__Introdução.Vetores
{
    public class NotasAlunos
    {
        public void ObtemNotasAlunos()
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
    }
}
