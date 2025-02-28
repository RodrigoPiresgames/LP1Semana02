using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            sbyte n = sbyte.Parse(Console.ReadLine());
            Console.WriteLine($"{ n-- }");
            Console.WriteLine($"{ n++ }");
            
        }
    }
}
