using System.Numerics;

namespace proj_euler;

internal class P16
{
    public static void Run() 
    {
        BigInteger num = BigInteger.Pow(2, 1000);
        int sum = num.ToString().Select(c => c - '0').Sum();

        Console.WriteLine(sum);
    }
}
