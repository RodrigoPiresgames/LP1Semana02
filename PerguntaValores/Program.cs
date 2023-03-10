using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gimme a");
            string str = Console.ReadLine();
            float a = float.Parse(str);
            Console.WriteLine("Gimme r");
            str = Console.ReadLine();
            float r = float.Parse(str);

            double pi = 3.1415926;
            Console.WriteLine($"{ pi * (r * r) * a}");
            Console.WriteLine($"{ (2 * pi * r) * (r + a)}");

        }
    }
}
