using System.Numerics;

namespace proj_euler;

internal class P0048 : Problem
{
    public override dynamic Solve()
    {
        BigInteger sum = 0;

        for (int i = 1; i <= 1000; i++)
            sum += Power(i, i);

        return sum.ToString()[^10..];
    }

    public static BigInteger Power(int x, int y) => BigInteger.Pow(x, y);
}
