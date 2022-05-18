using System;
using System.Collections;

namespace estrutura_dados_csharp._1_Introdução.Pilhas
{
    public class ExemploPilhas
    {
        Stack pilha = new Stack();
        public void TestaPilhas()
        {
            int menu = 0;

            while (menu != 1)
            {
                Console.WriteLine(" Selecione uma opção");
                Console.WriteLine();
                Console.WriteLine("1.Sai do fluxo");
                Console.WriteLine("2. Verificar se a pilha está vazia");
                Console.WriteLine("3. Empilhar");
                Console.WriteLine("4. Desempilhar");
                Console.WriteLine("5. Tamanho da pilha");
                Console.WriteLine("6. Mostrar topo");
                Console.WriteLine("7. Limpar pilha");

                var opcao = Console.ReadKey();

                switch (opcao.KeyChar)
                {
                    case '2':
                        VerificaSePilhaEstaVazia();
                        break;

                    case '3':
                        VerificaSePilhaEstaVazia();
                        break;
                }
            }

           
        }

        public void VerificaSePilhaEstaVazia()
        {
            if(pilha.Count == 0)
            {
                Console.WriteLine("7. Limpar pilha");
            }

            // criar a lógica
        }
    }
}
