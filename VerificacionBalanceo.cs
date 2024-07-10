using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana7yo
{
    // Clase para la verificación de una fórmula matemática balanceada usando pilas
    internal class VerificacionBalanceo
    {
        public static void Run()
        {
            Console.Write("Ingrese la fórmula matemática: ");
            string formula = Console.ReadLine();

            // Verificar si la fórmula está balanceada
            if (IsBalanced(formula))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Fórmula balanceada.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fórmula no balanceada.");
                Console.ResetColor();
            }
        }

        // Función para verificar si una fórmula está balanceada
        public static bool IsBalanced(string expression)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in expression)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c); // Empujar los caracteres de apertura en la pila
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0) return false; // Si la pila está vacía, la fórmula no está balanceada

                    char open = stack.Pop(); // Sacar el último carácter de apertura

                    // Verificar si el carácter de cierre corresponde al de apertura
                    if ((c == ')' && open != '(') ||
                        (c == '}' && open != '{') ||
                        (c == ']' && open != '['))
                    {
                        return false; // Si no corresponde, la fórmula no está balanceada
                    }
                }
            }

            return stack.Count == 0; // La pila debe estar vacía si la fórmula está balanceada
        }
    }

}
