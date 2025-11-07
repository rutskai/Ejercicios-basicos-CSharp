using System;

/*Crea un array con 5 nombres y usa un foreach para mostrarlos en consola.*/

class ejer12
{
    public static void ArrayNames()
    {
        string[] names = new string[5];

        for (int i = 0; i < names.Length; i++)
        {
        Console.WriteLine($"Introduce un nombre ({i + 1}/5):");
        names[i]= Console.ReadLine()!;
        }
          
       
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}