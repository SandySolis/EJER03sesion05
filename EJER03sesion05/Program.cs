using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJER_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número de notas: ");
            int nota = int.Parse(Console.ReadLine());
            int resultado = 0;
            for (int i = 1; i <= nota; i++)
            {
                Console.Write("Ingrese la nota " + i + ": ");
                int nota1 = int.Parse(Console.ReadLine());
                resultado = nota1 + (i) / nota;
            }
            Console.WriteLine("El promedio es: " + resultado);
            Console.ReadKey();
        }
    }
}