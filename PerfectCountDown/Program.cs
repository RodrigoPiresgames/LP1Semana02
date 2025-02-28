using System;
using System.Security;

namespace PerfectCountDown
{
    public class Program
    {
        private static void Main(string[] args)
        {

            Console.Write($"Start number: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write($"Step number: ");
            int step = int.Parse(Console.ReadLine());

            switch(CheckIfLegal(start,step))
            {
                case 0:
                    Console.WriteLine($"Step number: ");
                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;

            }

        }

        private static int CheckIfLegal(int x, int y)
        {
            if(x <= 1 || y <= 1 )
                return 1;
            else if(y >= x)
                return 2;
            else if(x % y != 0)
                return 3;
            else
                return 0;
        }
    }
}
