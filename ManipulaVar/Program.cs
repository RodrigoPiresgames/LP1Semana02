using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                int x = int.Parse(arg);
                Console.WriteLine($"{x++}");
                Console.WriteLine($"{--x}");
            }
        }
    }
}
