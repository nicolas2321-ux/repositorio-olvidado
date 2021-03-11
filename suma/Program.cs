using System;

namespace suma
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            Console.WriteLine("Digite el numero de a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el numero de b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"La suma de los numeros {a} + {b} es: {addnumbers( a, b)}");
        }
            public static int addnumbers (int a, int b)
        {
            return a + b;
        } 
   
    }
}
