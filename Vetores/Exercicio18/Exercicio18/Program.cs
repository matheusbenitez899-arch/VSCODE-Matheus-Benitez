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

        int maior = numeros[0];
        int posicaoMaior = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] > maior)
            {
                maior = numeros[i];
                posicaoMaior = i;
            }
        }

        Console.WriteLine("Posição do maior elemento: " + posicaoMaior);
    }
}