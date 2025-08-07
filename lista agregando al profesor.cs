using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {  
        List<string> nombres = new List<string> 
        {
            "Victor",
            "Julio",
            "Mariana",
            "Dixon",
            "Elio"
        };
        Console.WriteLine("Lista :");
        foreach (string nombre in nombres)
        {
            Console.WriteLine(nombre);
        }
        nombres.Add("Daniel Espitia");
        Console.WriteLine("\nLista despues de añadir al profesor:");
        foreach (string nombre in nombres)
        {
            Console.WriteLine(nombre);
        }
    }
}