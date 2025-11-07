// See https://aka.ms/new-console-template for more information

using System;
using System.Threading;

class mainProgram
{

    static void Main(string[] args)
    {
        while (true)
        {


            Console.WriteLine("\n=== Ingrese un número ===\n");
            Console.WriteLine("Sintaxis básica\n===============");
            Console.WriteLine("1) Mostrar datos\n2) Precio del producto");
            Console.WriteLine("\nTipos de datos\n===============");
            Console.WriteLine("3) Mostrar variables\n4) Números enteros\n5) Conversor");
            Console.WriteLine("\nEstructuras condicionales\n===============");
            Console.WriteLine("6) Mayor de edad\n7) Notas\n8) Días de la semana");
            Console.WriteLine("\nBucles for/while/forEach\n===============");
            Console.WriteLine("9) Suma total\n10) Listar multiplicaciones\n11) Números positivos\n12) Nombres dentro de arrays");
            Console.WriteLine("\nArrays\n===============");
            Console.WriteLine("13) Suma de 5 arrays\n14) Número mayor de un array\n15) Adivinar frutas\n16) Números pares random");
            Console.WriteLine("\nMétodos (Funciones)\n===============");
            Console.WriteLine("17) Saludar\n18) Suma de dos números (2,2)\n19) Números pares\n20) Promedio de notas");


            int option = int.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    ejer01.ShowData();
                    break;
                case 2:
                    ejer02.Products();
                    break;
                case 3:
                    ejer03.ShowVariables();
                    break;
                case 4:
                    ejer04.WholeNumbers();
                    break;
                case 5:
                    ejer05.CelsiusToFahrn();
                    break;
                case 6:
                    ejer06.Age();
                    break;
                case 7:
                    ejer07.Grades();
                    break;
                case 8:
                    ejer08.DayOfWeek();
                    break;
                case 9:
                    ejer09.ListNumbers();
                    break;
                case 10:
                    ejer10.ListMult();
                    break;
                case 11:
                    ejer11.PositiveNumbers();
                    break;
                case 12:
                    ejer12.ArrayNames();
                    break;
                case 13:
                    ejer13.TotalSum();
                    break;
                case 14:
                    ejer14.MajorNumber();
                    break;
                case 15:
                    ejer15.Fruits();
                    break;
                case 16:
                    ejer16.RandomNumbers();
                    break;
                case 17:
                    ejer17.Greet();
                    break;
                case 18:
                    Console.WriteLine($"Resultado: {ejer18.Sum(2, 2)}");
                    break;
                case 19:
                    Console.Write("Ingresa un número: ");
                    int numero = int.Parse(Console.ReadLine()!);

                    if (ejer19.IsEven(numero))
                    {
                        Console.WriteLine($"{numero} es par.");
                    }
                    else
                    {
                        Console.WriteLine($"{numero} es impar.");
                    }
                    break;
                case 20:
                    double[] grades = { 7.5, 8.0, 9.0, 6.5 };
                    Console.WriteLine("Tus notas son: ");
                    foreach (double g in grades)
                    {
                         Console.Write($"{g} ");
                    }
                    double average = ejer20.Average(grades);
                    Console.WriteLine($"\nEl promedio es: {average}");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

            Thread.Sleep(2500);
        }

    }
}
