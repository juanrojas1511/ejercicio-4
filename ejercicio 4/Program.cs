using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número maximo:");
            int numeroMaximo=int.Parse(Console.ReadLine());
            Console.WriteLine("Escoja una opción:");
            Console.WriteLine("1. Números pares.");
            Console.WriteLine("2. Números impares.");
            Console.WriteLine("3. Factorial.");
            Console.WriteLine("->");
            int opcion=int.Parse(Console.ReadLine());
            long factorial = 1;
            switch (opcion) 
            {
                case 1:
                    Console.WriteLine("Lista de números pares:");
                    for (int i = 2;i <= numeroMaximo;i+=2) 
                    {
                        Console.WriteLine(i);
                    }
                    break;
                case 2:
                    Console.WriteLine("Lista de números impares:");
                    for (int i = 1; i <= numeroMaximo; i += 2)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                case 3:
                 
                   for (int i = 1; i <= numeroMaximo; i++)
                    {
                        factorial=factorial*i;
                      
                    }
                    Console.WriteLine("El factorial es:" + factorial);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break; 
            }
            Console.ReadKey();
        }
    }
}
