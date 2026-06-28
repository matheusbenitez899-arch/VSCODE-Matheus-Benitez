using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        bool encontrou = false;

        Console.WriteLine("Digite os números:");

        int quantidade = 0;

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
                Console.WriteLine("Posição: " + i);
                quantidade++; ;
            }
        }

        if (!encontrou)
        {
            Console.WriteLine("O número apareceu " + quantidade + " vez(es).");
        }
    }
}