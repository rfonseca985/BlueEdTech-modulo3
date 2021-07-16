using System;

//3.Algoritmo para definir um array de números com tamanho e valores
//definidos pelo usuário e apresentá-lo em tela ordenado de forma
//crescente.

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o tamanho do array:");
            int tamanho = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine($"Digite o {i+1}º numero");
                int add = Convert.ToInt32(Console.ReadLine());
                numeros[i] = add;   
            }
            Array.Sort(numeros);
            Console.WriteLine("\nNúmeros em ordem crescente:");
            Console.WriteLine("============");
            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("============");
        }
    }
}
