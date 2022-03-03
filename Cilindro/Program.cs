using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("gibe height");
            float height = Console.ReadLine();
            Console.WriteLine("gibe radius");
            float radius = Console.ReadLine();
            Console.WriteLine($"Volume = {3.1415926*(radius*radius)*height} and Area de superficie = {2*3.1415926*raius*(raius+hieght)}");
            

            //V = π(r*r)a Sa = 2πr(r + a) π = 3.1415926
        }
    }
}
