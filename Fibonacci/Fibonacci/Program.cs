using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, numero, i, ayuda;


            Console.Write("Ingrese el número de Fibonacci que desea mostrar: ");
            numero = int.Parse(Console.ReadLine());

            a = 0;
            b = 1;
            for (i = 0; i < numero; i++)
            {
                ayuda = a;
                a = b;
                b = ayuda + a;
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
