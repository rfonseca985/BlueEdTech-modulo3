using System;

//Implemente uma opção onde o professor poderá adicionar faltas 
//a esses alunos (utilizar apenas arrays, não utilizar listas ou 
//classes).
//• A quantidade de faltas não poderá ser adicionada pelo 
//professor, deve ser incrementada com +1 a cada registro.
//• Ao visualizar um aluno, deve ser possível validar a sua nota,
//sua quantidade de faltas e se ele foi aprovado ou não.
//• O requisito para ser aprovado é que a nota seja maior que 7,
//que o aluno tenha menos de 4 faltas.

namespace Exercicio4_CodeLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alunos;
            double[] notas;
            int[] faltas;
            string[] resultados;
            double nota;
            char opcaoNota, opcaoFalta;
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
                    resultados = new string[tamanho];
                    Console.WriteLine("Deseja Cadastrar a nota do aluno(a)? (S/N)");
                    opcaoNota = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
                    bool validacao = true;
                    if (opcaoNota == 'S')
                    {

                        while (validacao != false)
                        {
                            Console.WriteLine("Digite a nota do aluno:");
                            nota = Convert.ToDouble(Console.ReadLine());

                            if (nota < 0.0 || nota >= 10.0)
                            {
                                Console.WriteLine("Nota inválida, digite uma nota válida:");
                            }
                            else
                            {
                                notas[i] = nota;
                                Console.WriteLine($"Aluno(a) {alunos[i]},nota {notas[i]},cadastrado com sucesso!!!");
                                validacao = false;
                            }
                        }
                    }
                    bool validacaoF = true;
                    faltas = new int[tamanho];
                    while (validacaoF != false)
                    {
                        Console.WriteLine("Deseja adicionar 1 falta ao aluno(a)? (S/N)");
                        opcaoFalta = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

                        if (opcaoFalta == 'S')
                        {
                            faltas[i]++;
                            Console.WriteLine($"Aluno(a) {alunos[i]},tem {faltas[i]} faltas cadastradas");
                            Console.WriteLine($"Adicionar mais 1 falta ao aluno {alunos[i]}?(S/N)");
                            opcaoFalta = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
                            if (opcaoFalta == 'S')
                            {
                                Console.WriteLine($"Aluno(a) {alunos[i]},tem {faltas[i]+1} faltas cadastradas");
                                faltas[i]++;
                                validacaoF = true;
                            }  
                        }
                        else
                        {
                            validacaoF = false;
                        }
                    }
                        if (faltas[i]> 3 || notas[i]< 7)
                            {
                                resultados[i] = "REPROVADO";
                            }
                            else
                            {
                                resultados[i] = "APROVADO";
                            }
                    Console.WriteLine($"Aluno(a) {alunos[i]}, tirou nota {notas[i]}, teve {faltas[i]} faltas e o resultado {resultados[i]} ");
                       
                    
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

