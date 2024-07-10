using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana7yo
{
    // Clase principal que contiene el menú y controla la ejecución del programa
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                MostrarMenu(); // Mostrar el menú de opciones
                string opcion = Console.ReadLine();

                // Ejecución según la opción seleccionada
                switch (opcion)
                {
                    case "0":
                        return; // Salir del programa
                    case "1":
                        Encabezado("Teoría de pilas");
                        Pila.Run(); // Ejecutar demostración de pilas
                        Pie();
                        break;
                    case "2":
                        Encabezado("Pilas - Torre de Hanoi");
                        Hanoi.Run(); // Ejecutar Torres de Hanoi
                        Pie();
                        break;
                    case "3":
                        Encabezado("Verificación de balanceo de fórmulas");
                        VerificacionBalanceo.Run(); // Ejecutar verificación de fórmulas
                        Pie();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opción no válida, presione una tecla para continuar");
                        Console.ResetColor();
                        break;
                }
            }
        }

        // Función para mostrar el menú de opciones
        static void MostrarMenu()
        {
            Caratula();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1 Teoría de pilas");
            Console.WriteLine("2 Pilas - Torre de Hanoi");
            Console.WriteLine("3 Verificación de balanceo de fórmulas");
            Console.WriteLine(new string('-', 55));
            Console.WriteLine("0 Salir");
            Console.WriteLine();
            Console.ResetColor();
        }

        // Función para mostrar la carátula del menú
        static void Caratula()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+             UNIVERSIDAD ESTATAL AMAZÓNICA           +");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            Console.WriteLine("           Menú de opciones - Escriba un número");
            Console.WriteLine();
            Console.ResetColor();
        }

        // Función para mostrar el encabezado de una sección
        static void Encabezado(string opcion)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("======================================");
            Console.WriteLine(opcion);
            Console.WriteLine("======================================");
            Console.ResetColor();
        }

        // Función para mostrar el pie de una sección
        static void Pie()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(new string('=', 20));
            Console.Read();
            Console.ResetColor();
        }
    }
}
