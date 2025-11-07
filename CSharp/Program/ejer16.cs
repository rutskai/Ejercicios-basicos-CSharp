using System;

/*Declara un array de 10 enteros aleatorios (usa Random) y muestra solo los
pares.*/

class ejer16
{
    public static void RandomNumbers()
    {
          int[] numbers = new int[10];
        Random rand = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(1, 101);
        }

        Console.WriteLine("Números pares:\n");
        foreach (int num in numbers)
        {
            if (num%2==0)
            {
                Console.WriteLine(num);
            }
        }


    }
}