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
        exit :
        
            for (int i = number; i >= 0; i --)
                {
                Console.Write($"{i}, ");
                }
            number --;
            if (number==0)
            {
            Console.Write("\n");
            Console.Write("0");
            }
            else 
               {
                Console.Write("\n");
                goto exit;           
               }
          }
    }
}
