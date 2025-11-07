using System;

// Crea un programa que convierta grados Celsius a Fahrenheit. Fórmula: F = (C * 9 / 5) + 32

class ejer05
{
    public static void CelsiusToFahrn()
    {
         
        Console.Write("Introduce los grados Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine($"{celsius}°C equivalen a {fahrenheit}°F");
       
    }
}