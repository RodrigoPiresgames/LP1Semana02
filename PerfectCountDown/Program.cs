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
                
                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;

            }

        }
    }
}
