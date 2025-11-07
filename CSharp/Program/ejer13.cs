using System;

/*Crea un array de 5 enteros, asígnales valores manualmente y muestra la suma
total.*/

class ejer13
{
    public static void TotalSum()
    {
        int[] numbers = new int[5];
        int sum = 0;

        Console.Write("Introduce 5 números: ");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Introduce un número ({i + 1}/5): ");
            numbers[i] = int.Parse(Console.ReadLine()!);
            sum = sum + numbers[i];
        }

        Console.WriteLine($"\nLa suma total de los números es: {sum}");
       
    }
}