using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Gimme a");
            string str = Console.ReadLine();
            double a = double.Parse(str);
            Console.WriteLine("Gimme r");
            str = Console.ReadLine();
            double r = double.Parse(str);

            Console.WriteLine($"{ Math.PI * Math.Pow(r, 2) * a:f3}");
            Console.WriteLine($"{ (2 * Math.PI * r) * (r + a):f3}");
        }
    }
}
