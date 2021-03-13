using System;

namespace counters_acumulators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar un numero: ");
            var number = Int32.Parse(Console.ReadLine());
            int counter = 1;
            for (int i = number; i > 1; --i)
            {
                for(int j = number; j > counter; --j)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine("");
                ++counter;
            }
        }
    }
}