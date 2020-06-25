using System;

namespace PrimerDeber
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine(args[0]);
            }
            //Ingresar datos
            Console.Write("Marcas de celulares");
            //Resive caracteres atravez de la consola con el ReadLine 
            string marcaCelular = Console.ReadLine();
            string modelo = Console.ReadLine();
            string color = Console.ReadLine();
            //Resive valores numeros
            decimal precio = Console.Read();

            //Se muestra en la consola
            Console.WriteLine("La nombre de la marca: " + marcaCelular + ".");
            Console.Write("Modelo: " + modelo + ".");
            Console.WriteLine("Color: " + color + ".");
            Console.Write("Precio del movil: " + precio + ".");
        }
    }
}           