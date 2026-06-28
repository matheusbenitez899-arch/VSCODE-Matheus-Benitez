using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        bool repetido = false;

        Console.WriteLine("Digite os números:");

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numeros.Length; i++)
        {
            for (int j = i + 1; j < numeros.Length; j++)
            {
                if (numeros[i] == numeros[j])
                {
                    repetido = true;
                }
            }
        }
        

        if (repetido)
        {
            Console.WriteLine("Existe numeros repetidos. ");
        }

        else
        {
            Console.WriteLine("Não existe numeros repetidos. ");
        }
    }
}