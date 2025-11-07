using System;

/*Usando un while, pide números al usuario hasta que introduzca un número
negativo.Al final, muestra cuántos números positivos se introdujeron..*/

class ejer11
{
    public static void PositiveNumbers()
    {
        int num;
        int count = 0;

        do
        {
            
            Console.WriteLine("Introduce un número positivo:");
            num = int.Parse(Console.ReadLine()!);

            if(num >= 0){
               count++; 
            }
            

        } while (num >= 0);

        Console.WriteLine($"Has introducido {count} números positivos.");

    }
}