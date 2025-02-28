using System;
using System.Security;

namespace PerfectCountDown
{
    public class Program
    {
        private static void Main(string[] args)
        {
            WriteErrorMessage(AskForNums());
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
                    AskForNums();
                    break;
                case 1:
                    Console.WriteLine($"Start must be higher than step. Try again.");
                    AskForNums();
                    break;
                case 2:
                    Console.WriteLine($"Start not divisible by step. Try again.");
                    AskForNums();
                    break;
                case 3:
                    DoCountDown(nums);
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

        private static void DoCountDown((int,int) to_divide)
        {
            int counting = to_divide.Item1;
            Console.WriteLine($"{counting}");

            while(counting >= 0)
            {
                Console.WriteLine($"{to_divide.Item1 / to_divide.Item2}");
                counting = counting - to_divide.Item1 / to_divide.Item2;
            }
        }
    }
}
