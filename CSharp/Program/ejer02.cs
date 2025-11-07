//Declara variables para el precio de un producto y la cantidad comprada.
//Calcula y muestra el total a pagar.

using System;
class ejer02
{
    public static void Products()
    {
        int productPrice = 20;
        int quantity = 4;

        int total = productPrice * quantity;
        Console.WriteLine($"Precio de los productos: {productPrice}");
        Console.WriteLine($"Cantidad de productos: {quantity}");
        Console.WriteLine("El total a pagar es: " + total);
    }
}