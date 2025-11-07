using System;

/*Pide al usuario 5 números, guárdalos en un array y muestra el número mayor.*/

class ejer14
{
    public static void MajorNumber()
    {
        int[] numbers = new int[5];
        Console.Write("Introduce 5 números:\n");
        
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Introduce un número ({i + 1}/5): ");
            numbers[i] = int.Parse(Console.ReadLine()!);
           
        }

        Array.Sort(numbers);
        Console.WriteLine($"\nEl número mayor es: {numbers[numbers.Length - 1]}");

       
    }

}
