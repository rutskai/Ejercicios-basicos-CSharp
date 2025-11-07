using System;

/*Pide un número y muestra su tabla de multiplicar del 1 al 10.*/

class ejer10
{
    public static void ListMult()
    {

        Console.WriteLine("Introduce un número:");
       int num= int.Parse(Console.ReadLine()!);
         
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} * {i} = {num*i}" );
        }
       
    }
}