using System;

namespace FundamentosDeCSharp
{
    public class Program
    {
        public static void Main(string [] args)
        {   
            Console.WriteLine("Arrays");

            string [] nombres = new string [16];
            nombres [0] = "Victor Nava";
            nombres [1] = "Elio Bracho";
            nombres [2] = "Deivi Fonseca";
            nombres [3] = "Dixon Gonzalez";
            nombres [4] = "Darwin Villalobos";
            nombres [5] = "Mariana Quintero";
            nombres [6] = "Nestor Soto";
            nombres [7] = "Julio Pacheco";
            nombres [8] = "Leomar Ferrer";
            nombres [9] = "Mathias Tremont";
            nombres [10] = "Luis Quintero";
            nombres [11] = "Isaac Bracho";
            nombres [12] = "Victor Pimentel";
            nombres [13] = "Santiago Vilchez";
            nombres [14] = "Manuel Carvajal";
            nombres [15] = "Abraham Quintero";
            Console.WriteLine("Array de nombres");
            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }
            Console.WriteLine();
        
        }


    }

}