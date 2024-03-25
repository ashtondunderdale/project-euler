using System.Numerics;

namespace proj_euler;

internal class P20
{
    public static void Run() 
    {
        BigInteger factorialSum = 1;

        for (int i = 100; i > 0; i--)
            factorialSum *= i;
        
        int digitSum = 0;

        foreach (char c in factorialSum.ToString())
            digitSum += c - '0';
        
        Console.Write(digitSum);
    }
}
