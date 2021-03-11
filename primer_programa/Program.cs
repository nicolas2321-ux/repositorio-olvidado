using System;

namespace example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
                Console.WriteLine("Digite el valor de a: ");
                a =  Int32.Parse(Console.ReadLine());
                
                Console.WriteLine("Digite el valor de b: ");
                b = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"La suma de los numeros a + b es: {addnumbers(a,b)}");
        }
    public static int addnumbers (int a, int b);
    {
        return a + b;
    }
    }
}
