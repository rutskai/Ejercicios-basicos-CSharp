using System;

/*Pide una nota (0–10) y muestra:
● “Suspendido” si < 5
● “Aprobado” si >= 5 y < 7
● “Notable” si >= 7 y < 9
● “Sobresaliente” si >= 9*/

class ejer07
{
    public static void Grades()
    {

        Console.Write("Introduce una nota: ");
        double grade = double.Parse(Console.ReadLine()!);

        switch (grade)
            {
                case < 0 or > 10:
                    Console.WriteLine("La nota debe estar entre 0 y 10");
                    break;
                case < 5:
                    Console.WriteLine("Suspendido");
                    break;
                case < 7:
                    Console.WriteLine("Aprobado");
                    break;
                case < 9:
                    Console.WriteLine("Notable");
                    break;
                default:
                    Console.WriteLine("Sobresaliente");
                    break;
            }
        
       
    }
}