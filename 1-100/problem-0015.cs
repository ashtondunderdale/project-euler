using System.Numerics;

namespace proj_euler;

internal class P15
{
    public static void Run() 
    {
        BigInteger result = 1;

        for (int i = 1; i <= 20; i++)
        {
            result *= (20 + i);
            result /= i;
        }

        Console.WriteLine(result);
    }
}
