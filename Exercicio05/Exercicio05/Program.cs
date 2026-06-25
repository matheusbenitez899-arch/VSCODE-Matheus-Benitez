using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[8];

        Console.WriteLine("Digite 8 números:");

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Ordem inversa:");

        for (int i = numeros.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}