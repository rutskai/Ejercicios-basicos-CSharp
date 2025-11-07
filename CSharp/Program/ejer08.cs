using System;

/*Crea un programa que pida un número del 1 al 7 y muestre el día de la semana
correspondiente usando switch.*/

class ejer08
{
    public static void DayOfWeek()
    {

        Console.Write("Introduce un número del 1 al 7: ");
        int num = int.Parse(Console.ReadLine()!);

        switch (num)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miércoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            case 6:
                Console.WriteLine("Sábado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine(" El número debe estar entre 1 y 7.");
                break;
        }
        
       
    }
}