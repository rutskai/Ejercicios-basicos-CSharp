using System;

// Pide al usuario su edad y muestra si es mayor o menor de edad.

class ejer06
{
    public static void Age()
    {

        Console.Write("Introduce tu edad: ");
        int age = int.Parse(Console.ReadLine()!);

        if (age>=18)
        {
             Console.Write("Eres mayor de edad!!!");
        }
        else
        {
            Console.WriteLine("Eres menor de edad.");
        }
        
       
    }
}