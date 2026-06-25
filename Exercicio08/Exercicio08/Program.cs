using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[7];

        Console.WriteLine("Digite 7 números:");

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Quantidade de elementos: " + numeros.Length);
    }
}