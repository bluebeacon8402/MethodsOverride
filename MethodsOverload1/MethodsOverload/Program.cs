using System;

namespace MethodsOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(2, 3);
            Add(5.2m, 1.6m);
            Add("dollars", 6, 8, true);
        }

        static void Add(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine($"{sum}");
        }

        static void Add(decimal x, decimal y)
        {
            decimal sum = x + y;
            Console.WriteLine($"{sum}");
        }

        static void Add(string x, int y, int z, bool u)
        {
            Console.WriteLine("Please type True or False");
            u = Convert.ToBoolean(Console.ReadLine());
            if (u == true)
            {
                x = " dollars"; 
                string result = y + z + x;
                Console.WriteLine($"{result}");
            }
            else
            {
                Console.WriteLine("This is a false statement");
            }
        }
    }
}
