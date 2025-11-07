using System;

// Pide al usuario dos números enteros y muestra:
// ● La suma
// ● La resta
// ● El producto
// ● El cociente (división entera)
// ● El resto

class ejer04
{
    public static void WholeNumbers()
    {
        Console.WriteLine("Ingrese un número entero: ");
        int num = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Ingrese un segundo número entero: ");
        int num2 = int.Parse(Console.ReadLine()!);
        
            int sum = num + num2;
            int difference = Math.Abs(num - num2);
            int product = num * num2;
         

            Console.WriteLine($"Suma: {sum}");
            Console.WriteLine($"Resta: {difference}");
            Console.WriteLine($"Producto: {product}");

            if (num2!=0)
        {
                
            int quotient = num / num2;
            int remainder = num % num2;
            
            Console.WriteLine($"Cociente : {quotient}");
            Console.WriteLine($"Resto: {remainder}");

            }
            else
            {
                Console.WriteLine("División entre 0 no puede hacerse.");
            }

    }
}