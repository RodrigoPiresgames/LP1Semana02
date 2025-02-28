using System;
using System.Security;

namespace PerfectCountDown
{
    public class Program
    {
        private static void Main(string[] args)
        {
            WriteErrorMessage(AskForNums());
            Console.Write($"Start number: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write($"Step number: ");
            int step = int.Parse(Console.ReadLine());

        }

        private static (int, int) AskForNums()
        {
            Console.Write($"Start number: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write($"Step number: ");
            int step = int.Parse(Console.ReadLine());
            
            return (start, step);
        }

        private static void WriteErrorMessage((int, int) nums)
        {
            switch(CheckIfLegal(nums))
            {
                case 0:
                    Console.WriteLine($"Out-of-range start or step. Try again.");
                    break;
                case 1:
                    Console.WriteLine($"Start must be higher than step. Try again.");
                    break;
                case 2:
                    Console.WriteLine($"Start not divisible by step. Try again.");
                    break;
                case 3:

                    break;

            }
        }
        private static int CheckIfLegal((int, int) to_verify)
        {
            if(to_verify.Item1 <= 1 || to_verify.Item2 <= 1 )
                return 1;
            else if(to_verify.Item2 >= to_verify.Item1)
                return 2;
            else if(to_verify.Item1 % to_verify.Item2 != 0)
                return 3;
            else
                return 0;
        }
    }
}
