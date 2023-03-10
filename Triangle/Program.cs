using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(string arg in args)
            {
                int intArg;
                bool isInt = int.TryParse(arg, out intArg);
                if (isInt)
                {
                    int num = Convert.ToInt32(arg);
                    Console.WriteLine(num);
                }
                else
                {
                    string str = arg;
                    Console.WriteLine(str);
                }
            }
        }
    }
}
