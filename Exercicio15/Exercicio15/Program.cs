using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int contador = 0;

        Console.WriteLine("Digite os números:");

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] < 0)
            {
                contador++;
            }
        }

        Console.WriteLine("Quantidade de números negativos: " + contador);
    }
}