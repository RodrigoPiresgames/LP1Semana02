using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(string arg in args)
            {
                int num = int.Parse(arg);
                Console.WriteLine(num);
            }
        }
    }
}
