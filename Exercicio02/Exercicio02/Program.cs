using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[5];

        Console.WriteLine("Digite 5 números:");

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Números digitados:");

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}