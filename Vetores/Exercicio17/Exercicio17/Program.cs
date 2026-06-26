using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];

        Console.WriteLine("Digite os números:");

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int menor = numeros[0];

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] < menor)
            {
                menor = numeros[i];
            }
        }

        Console.WriteLine("Menor valor armazenado: " + menor);
    }
}