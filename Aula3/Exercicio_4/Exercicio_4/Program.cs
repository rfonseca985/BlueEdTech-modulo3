using System;
using System.Collections.Generic;
using System.Linq;

//4.Altere o algoritmo anterior para que os números sejam inseridos no
//array aleatoriamente: utilizar o objeto Random(). A aplicação também
//deve apresentar o número que tem a maior frequência.

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanho, contador = 0, numero =0;
            int[] numeros;
            List<int> vezes = new List<int>();
            Console.WriteLine("Informe o tamanho do array:");
            tamanho = Convert.ToInt32(Console.ReadLine());
            numeros = new int[tamanho];
            var random = new Random();
            for (int i = 0; i < numeros.Length; i++)
            {   
                numeros[i] = random.Next(1, 100);
            }   
            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }
        }
    }
}
