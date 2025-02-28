using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Gimme a");
            string str = Console.ReadLine();
            float a = float.Parse(str);
            Console.WriteLine("Gimme r");
            str = Console.ReadLine();
            float r = float.Parse(str);

            Console.WriteLine($"{ Math.PI * Math.Pow(r, 2) * a}");
            Console.WriteLine($"{ (2 * Math.PI * r) * (r + a)}");
        }
    }
}
