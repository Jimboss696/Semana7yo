using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana7yo
{
    // Clase para la demostración de operaciones básicas con pilas
    internal class Pila
    {
        public static void Run()
        {
            // Definición de una pila para enteros
            Stack<int> pilaEnteros = new Stack<int>();

            // Agregar elementos a la pila
            pilaEnteros.Push(1);
            pilaEnteros.Push(2);
            pilaEnteros.Push(20);
            pilaEnteros.Push(4);

            // Imprimir los elementos de la pila
            ImprimirPila(pilaEnteros);

            // Mostrar el elemento en la parte superior sin sacarlo de la pila
            int ElementoSuperior = pilaEnteros.Peek();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Elemento en la cima (Peek): {0}", ElementoSuperior);
            Console.ResetColor();

            // Sacar el elemento de la cima de la pila
            int ElementoSacado = pilaEnteros.Pop();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Se ha sacado el elemento {0}", ElementoSacado);
            Console.ResetColor();
            ImprimirPila(pilaEnteros);

            // Vaciar la pila
            while (pilaEnteros.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Se saca el elemento {0}", pilaEnteros.Pop());
                Console.ResetColor();
            }
        }

        // Función para mostrar el contenido de una pila en pantalla
        static void ImprimirPila(Stack<int> pila)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Elementos de la pila: ");
            foreach (var item in pila) // Recorrer elementos de la pila
            {
                Console.WriteLine(item); // Muestra el item en pantalla
            }
            Console.ResetColor();
        }
    }
}
