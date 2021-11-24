using System;

namespace MetodoDeSimpson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese precision: ");
            string cantidad = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Variacion de x: ");
            double varicion = double.Parse(Console.ReadLine());

            int cant = int.Parse(cantidad);
            string[] almacenamiento = new string[cant];
            double tmp = 0;

            for (int i = 1; i <= almacenamiento.Length; i++)
            {
                Console.WriteLine($"Dato {i}: ");
                almacenamiento[i -1] = Console.ReadLine();
            }

            Console.WriteLine("Espere resultados.... ");

            for (int i = 0; i < almacenamiento.Length; i++)
            {
                if (i % 2 == 0)
                {
                    tmp += double.Parse(almacenamiento[i]) * 4;
                }
                else
                {
                    tmp += double.Parse(almacenamiento[i]) * 2;
                }
            }

            Console.WriteLine();

            Console.WriteLine($"{(tmp*varicion)/3}");

            Console.ReadKey();

        }
    }
}
