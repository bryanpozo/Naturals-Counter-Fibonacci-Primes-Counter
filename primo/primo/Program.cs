using System;

namespace primo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrar el numero que desea comenzar: ");
            int startNumber = int.Parse(Console.ReadLine());
            Console.Write("Entrar numero que desea terminar: ");

            int endNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Numeros primos entre {startNumber} y {endNumber} son : ");
            for (int i = startNumber; i <= endNumber; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0 && i != 1)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.ReadKey();
        }
    }
}