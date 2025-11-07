using System;

/*Crea un método Average(double[] notas) que reciba un array y devuelva
el promedio. Llama al método desde Main() y muestra el resultado.*/

class ejer20
{
    public static double Average(double[] grades)
    {

        double sum = 0;

        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];
        }

        return sum / grades.Length;

    }

}