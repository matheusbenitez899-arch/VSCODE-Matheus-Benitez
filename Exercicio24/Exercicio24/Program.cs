﻿using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        bool todosIguais = true;

        Console.WriteLine("Digite os números:");

        


        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int pesquisa = int.Parse(Console.ReadLine());

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] != pesquisa)
            {
                Console.WriteLine("Posição: " + i);
                todosIguais = false;
            }
        }

        if (todosIguais)
        {
            Console.WriteLine("Todos os numeros são iguais. ");
        }

        else
        {
            Console.WriteLine("Nem todos os valores são iguais. ");
        }
    }
}

