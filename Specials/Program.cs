using System;

namespace Specials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{sbyte.MaxValue} {sbyte.MinValue}");
            Console.WriteLine($"{byte.MaxValue} {byte.MinValue}");
            Console.WriteLine($"{short.MaxValue} {short.MinValue}");
            Console.WriteLine($"{ushort.MaxValue} {ushort.MinValue}");
            Console.WriteLine($"{int.MaxValue} {int.MinValue}");
            Console.WriteLine($"{uint.MaxValue} {uint.MinValue}");
            Console.WriteLine($"{long.MaxValue} {long.MinValue}");
            Console.WriteLine($"{ulong.MaxValue} {ulong.MinValue}");
            Console.WriteLine($"{float.MaxValue} {float.MinValue}");
            Console.WriteLine($"{double.MaxValue} {double.MinValue}");
            Console.WriteLine($"{decimal.MaxValue} {decimal.MinValue}");
            Console.WriteLine($"{char.MaxValue} {char.MinValue}");

            Console.WriteLine($"{double.PositiveInfinity} {double.NegativeInfinity}");
            Console.WriteLine($"{float.NaN}");

            int x = byte.MaxValue;
            Console.WriteLine((byte)(x + 1));

            Console.WriteLine(2 * double.MaxValue);
            Console.WriteLine(double.MaxValue + 1);

            float f1, f2;
            f1 = f2 = 10.01f;
            Console.WriteLine(f1 == f2 + 0.00000000000001f);

        }
    }
}
