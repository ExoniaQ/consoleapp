using System;

namespace programus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Joe Biden?");
            for (int i = int.Parse(Console.ReadLine()); i > 0; i--)
            {
                Console.WriteLine("Joe Biden");
            }
            Console.ReadKey();
            
        }
    }
}
