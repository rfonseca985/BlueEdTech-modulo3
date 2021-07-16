using System;
using System.Collections.Generic;

//2.Algoritmo para encontrar o maior valor de uma lista de números com
//tamanho e valores definidos por usuário

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o tamanho da lista:");
            int tamanho = Convert.ToInt32(Console.ReadLine());
            List<int> numeros = new List<int>(tamanho);
            int count = 1;
            while (count <= tamanho)
            {
                Console.WriteLine($"Digite o {count}º numero");
                int add = Convert.ToInt32(Console.ReadLine());
                numeros.Add(add);
                count++;
            }
            int maior = int.MinValue;
            foreach (int i in numeros)
            {
                Console.WriteLine($"{i}º {numeros}");
                if (i > maior)
                {
                    maior = i;
                }
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"O maior número da lista é: {maior}");
            Console.WriteLine("------------------------------------");
        }
    }
}
