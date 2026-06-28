using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int soma = 0;

        Console.WriteLine("Digite 10 números:");

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
            soma += numeros[i];
        }

        double media = (double)soma / numeros.Length;

        Console.WriteLine("Média = " + media);
    }
}