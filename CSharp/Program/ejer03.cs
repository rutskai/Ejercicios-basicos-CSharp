using System;

// Declara variables de tipo int, double, char, bool y string. Asigna valores
// y muéstralos en consola.

class ejer03
{
    public static void ShowVariables()
    {
        int num = 2;
        double numDecimal = 2.4;
        char character = 'a';
        bool isFalse = false;
        String name = "Ruth";

        Console.WriteLine("Número entero: " + num);
        Console.WriteLine("Número decimal: " + numDecimal);
        Console.WriteLine("Carácter: " + character);
        Console.WriteLine("Booleano: " + isFalse);
        Console.WriteLine("Texto: " + name);


    }
}