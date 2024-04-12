using System.Numerics;

namespace proj_euler;

internal class P0015 : Problem
{
    public override dynamic Solve()
    {
        BigInteger result = 1;

        for (int i = 1; i <= 20; i++)
        {
            result *= (20 + i);
            result /= i;
        }

        return result;
    }
}
