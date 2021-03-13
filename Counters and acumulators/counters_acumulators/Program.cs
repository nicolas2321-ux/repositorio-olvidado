using System;

namespace counters_acumulators
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            Console.WriteLine("Digite su numero: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = number; i >= 0; i --)
            {
                Console.Write($"{i}, ");

            }
        

          }
    }
}
