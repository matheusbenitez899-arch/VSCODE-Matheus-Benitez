using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[6];
        int soma = 0;

        Console.WriteLine("Digite 6 números:");

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
            soma += numeros[i];
        }

        Console.WriteLine("Soma = " + soma);
    }
}