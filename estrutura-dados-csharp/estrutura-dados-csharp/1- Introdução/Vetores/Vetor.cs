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

            // Array.ForEach(alunosArray, Console.WriteLine); um exemplo de array em uma só linha
            Console.WriteLine($"A média da turma é: {media}");
             
            Array.Sort(notasArray); // corrigir
            Console.WriteLine($"Parabéns: {alunosArray[0]} teve maior nota {notasArray[0]}");
        }

        private int BuscarElemento(int posicao)
        {
            return 0;
        }
    }
}
