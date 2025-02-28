using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
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
        }
    }
}
