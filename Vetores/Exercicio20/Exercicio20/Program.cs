using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        bool encontrou = false;

        Console.WriteLine("Digite os números:");

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == 100)
            {
                encontrou = true;
            }
        }

        if (encontrou)
        {
            Console.WriteLine("O número 100 existe no vetor.");
        }
        else
        {
            Console.WriteLine("O número 100 não existe no vetor.");
        }
    }
}