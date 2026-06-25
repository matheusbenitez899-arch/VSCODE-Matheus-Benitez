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

        Console.Write("Digite o número para pesquisa: ");
        int pesquisa = int.Parse(Console.ReadLine());

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == pesquisa)
            {
                encontrou = true;
            }
        }

        if (encontrou)
        {
            Console.WriteLine("Esse número existe.");
        }
        else
        {
            Console.WriteLine("Esse número não existe.");
        }
    }
}