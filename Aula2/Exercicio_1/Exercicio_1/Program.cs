using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, numero, fatorial;
            Console.WriteLine("Informe o número");
            numero = Convert.ToInt32(Console.ReadLine());

            fatorial = numero;
            for (i = numero - 1; i >= 1; i--)
            {
                Console.WriteLine($"{fatorial} * {i}");

                fatorial = fatorial * i;

                Console.WriteLine($"n={i}");
                Console.WriteLine($"fatorial={fatorial}");
                Console.WriteLine("  ");
            }
            Console.WriteLine($"\nFatorial de {numero} é {fatorial} ");
        }
    }
}
