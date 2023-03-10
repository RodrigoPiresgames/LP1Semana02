using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            int num = 0;
            foreach (string arg in args)
            {
                int intArg;
                bool isInt = int.TryParse(arg, out intArg);
                if (isInt)
                    num = Convert.ToInt32(arg);
                else
                    str = arg;
            }

            for(int i = 0; i < num; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write(str);
                Console.WriteLine();
            }
        }
    }
}
