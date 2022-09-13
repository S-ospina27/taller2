using System;
using System.Collections.Generic;
using Ejercisio3;

 

internal class Program
{
    private static void Main(string[] args)
    {
        Pastel pastel = new Pastel("Cumpleaños", "Grande");

        Ingredientes Masa = new Ingredientes("Masa para pasteles", 2, 10000);
        Ingredientes Crema = new Ingredientes("Crema para pasteles", 2, 7500);
        Ingredientes Cebada = new Ingredientes("Cebada para pasteles", 2, 12000);

      pastel.anadirIngrediente(Masa);
      pastel.anadirIngrediente(Crema);
      pastel.anadirIngrediente(Cebada);

      System.Console.WriteLine($"Cantidad de ingredientes : {pastel.contar()}");
      System.Console.WriteLine($"Costo de ingredientes : {pastel.costoTotal()}");
      System.Console.WriteLine($"Ingredientes: {pastel.listar()}");
    }
}