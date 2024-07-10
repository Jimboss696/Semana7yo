using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana7yo
{
    // Clase para resolver el problema de las Torres de Hanoi usando pilas
    internal class Hanoi
    {
        static Stack<int> torreA = new Stack<int>(); // Torre A
        static Stack<int> torreB = new Stack<int>(); // Torre B
        static Stack<int> torreC = new Stack<int>(); // Torre C

        public static void Run()
        {
            InicializarPilas(); // Inicializar las pilas/towers
            Console.Write("Cuántos discos contiene la torre: ");
            int numDiscos = int.Parse(Console.ReadLine());

            // Colocar los discos en la torre A
            for (int i = numDiscos; i >= 1; i--)
            {
                torreA.Push(i);
            }
            DibujarTorres(); // Dibujar el estado inicial de las torres

            Resolver(numDiscos, torreA, torreC, torreB); // Resolver el problema
        }

        // Función recursiva para resolver las Torres de Hanoi
        static void Resolver(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar)
        {
            if (n == 1)
            {
                MoverDisco(origen, destino); // Mover un disco del origen al destino
                DibujarTorres(); // Dibujar el estado de las torres después del movimiento
            }
            else
            {
                Resolver(n - 1, origen, auxiliar, destino); // Mover n-1 discos del origen al auxiliar
                MoverDisco(origen, destino); // Mover el disco restante del origen al destino
                DibujarTorres(); // Dibujar el estado de las torres después del movimiento
                Resolver(n - 1, auxiliar, destino, origen); // Mover los n-1 discos del auxiliar al destino
            }
        }

        // Función para mover un disco de una torre a otra
        static void MoverDisco(Stack<int> origen, Stack<int> destino)
        {
            destino.Push(origen.Pop());
        }

        // Función para mostrar el estado de las torres en pantalla
        static void DibujarTorres()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Estado de las Torres:");
            Console.WriteLine("Torre A: {0}", string.Join(", ", torreA.Reverse()));
            Console.WriteLine("Torre B: {0}", string.Join(", ", torreB.Reverse()));
            Console.WriteLine("Torre C: {0}", string.Join(", ", torreC.Reverse()));
            Console.WriteLine(new string('*', 30));
            Console.ResetColor();
        }

        // Inicializar las torres limpiando las pilas
        static void InicializarPilas()
        {
            torreA.Clear();
            torreB.Clear();
            torreC.Clear();
        }
    }
}
