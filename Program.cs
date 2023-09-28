using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana6_Problema03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacidadMaxima = 0;
            int asistentesActuales = 0;

            while (capacidadMaxima <= 0 || capacidadMaxima > 50)
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("Ingrese el número máximo de personas:");
                Console.Write("========================================\n");

                if (int.TryParse(Console.ReadLine(), out capacidadMaxima) && capacidadMaxima > 0 && capacidadMaxima <= 50)
                {
                    Console.WriteLine($"\nEl número máximo establecido es de {capacidadMaxima} personas.");
                    Console.WriteLine("Presione una tecla para comenzar a contar.");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("\nIngrese un número válido entre 1 y 50. Presione una tecla para continuar.");
                    Console.ReadKey();
                }
            }

            while (true)
            {
                Console.Clear();
                double porcentajeAforo = (double)asistentesActuales / capacidadMaxima * 100;

                Console.WriteLine("====================================");
                Console.WriteLine($"Asistentes actuales | {asistentesActuales}");
                Console.WriteLine($"Aforo               | {porcentajeAforo:F2}%");
                Console.WriteLine($"Máximo              | {capacidadMaxima} personas");
                Console.WriteLine("====================================");
                Console.WriteLine("Presione");
                Console.WriteLine("[ i ] si ingresa una persona");
                Console.WriteLine("[ s ] si sale una persona");
                Console.WriteLine("[ x ] para terminar");

                char opcion = Console.ReadKey().KeyChar;

                switch (opcion)
                {
                    case 'i':
                        if (asistentesActuales < capacidadMaxima)
                        {
                            asistentesActuales++;
                            Console.WriteLine("\nUna persona ha entrado al local. Presione una tecla para continuar.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\nEl local está lleno. No se permite la entrada. Presione una tecla para continuar.");
                            Console.ReadKey();
                        }
                        break;

                    case 's':
                        if (asistentesActuales > 0)
                        {
                            asistentesActuales--;
                            Console.WriteLine("\nUna persona ha salido del local. Presione una tecla para continuar.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay personas en el local para que salgan. Presione una tecla para continuar.");
                            Console.ReadKey();
                        }
                        break;

                    case 'x':
                        Console.WriteLine("\nSaliendo del programa. ¡Gracias por usar el sistema de control de aforo!");
                        return;

                    default:
                        Console.WriteLine("\nOpción no válida. Presione una tecla para continuar.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }

}
    

