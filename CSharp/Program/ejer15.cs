using System;

/*Crea un array de strings con 4 frutas. Pide una fruta al usuario y di si está o no
en el array.*/

class ejer15
{
    public static void Fruits()
    {
        string[] fruits = { "manzana", "plátano", "naranja", "pera" };


        Console.Write("Introduce el nombre de una fruta, te diré si está en el array: ");
        String answer = Console.ReadLine()!.ToLower();

        foreach (String f in fruits)
        {
            if (f == answer)
            {
                Console.WriteLine("El nombre sí que aparece!!");
                return;
            }
        }
        Console.WriteLine("El nombre no aparece en el array.");

    }



}
