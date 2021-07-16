using System;

namespace Exercicio1_Codelabs
{
    class Program
    {
        static void Main(string[] args)
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


        }
    }

}
