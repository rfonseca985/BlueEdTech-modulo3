using System;

//2- Implemente uma opção para ser possível cadastrar seus alunos
//(utilizar apenas arrays, não utilizar listas ou classes).
//• Deve ser possível visualizar os alunos cadastrados
//• Só é necessário cadastrar os nomes dos alunos
//• Respeitar limite da turma definido pelo professor

namespace Exercicio2_CodeLabs
{
    class Program
    {
        static void Main(string[] args)
        {
           


            Console.WriteLine("Digite 1 para cadastrar uma turma ou 0 para sair:");
            int opcao = Convert.ToInt32(Console.ReadLine());
            while (opcao == 1)
            {
                string[] alunos;
                Console.WriteLine("Digite o nome da turma:");
                string turma = Console.ReadLine();

                Console.WriteLine("Digite o tamando da turma");
                int tamanho = Convert.ToInt32(Console.ReadLine());
                alunos = new string[tamanho];
                for (int i = 0; i < alunos.Length; i++)
                {
                    Console.WriteLine($"Digite o nome do {i + 1}º aluno");
                    string nomes = Console.ReadLine();
                    alunos[i] = nomes;
                }

                if (tamanho == alunos.Length)
                {
                    Console.WriteLine($"Turma {turma}, máximo de {tamanho} alunos, foi criada com sucesso");
                }
                Console.WriteLine("\nDigite 1 para cadastrar uma turma ou 0 para sair:");
                opcao = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    
}
