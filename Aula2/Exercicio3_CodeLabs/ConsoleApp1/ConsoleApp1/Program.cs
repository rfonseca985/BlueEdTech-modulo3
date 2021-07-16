using System;

//3- Implemente uma opção onde o professor poderá adicionar notas
//a esses alunos(utilizar apenas arrays, não utilizar listas ou
//classes).
//• Cada aluno só terá uma nota
//• A nota não pode ser negativa e nem maior que 10
//• Ao visualizar um aluno, deve ser possível validar a sua nota.

namespace Exercicio3_CodeLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alunos;
            double[] notas;
            double nota;
            char opcaoNota;
            int tamanho;
            string nome, turma;
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Digite 1 para cadastrar uma turma ou 0 para sair:");
            Console.WriteLine("-------------------------------------------------");

            int opcao = Convert.ToInt32(Console.ReadLine());
            while (opcao == 1)
            {

                Console.WriteLine("Digite o nome da turma:");
                turma = Console.ReadLine();

                Console.WriteLine("Digite o tamando da turma");
                tamanho = Convert.ToInt32(Console.ReadLine());
                alunos = new string[tamanho];
                for (int i = 0; i < alunos.Length; i++)
                {
                    Console.WriteLine($"Digite o nome do {i + 1}º aluno");
                    nome = Console.ReadLine();
                    alunos[i] = nome;

                    notas = new double[tamanho];
                    Console.WriteLine("Deseja Cadastrar a nota do aluno? (S/N)");
                    opcaoNota = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
                    if (opcaoNota == 'S')
                    {
                        bool validacao = true;
                        while (validacao != false)
                        {
                            Console.WriteLine("Digite a nota do aluno:");
                            nota = Convert.ToDouble(Console.ReadLine());

                            if (nota < 0.0 || nota > 10.0)
                            {
                                Console.WriteLine("Nota inválida, digite uma nota válida:");
                            }
                            else
                            {
                                notas[i] = nota;
                                Console.WriteLine($"Aluno {alunos[i]},nota {notas[i]},cadastrado com sucesso!!!");
                                validacao = false;
                               
                            }
                        }
                    }
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




