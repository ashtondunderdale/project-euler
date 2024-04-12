using System.Numerics;

namespace proj_euler;

internal class P0016 : Problem
{
    public override dynamic Solve()
    {
        BigInteger num = BigInteger.Pow(2, 1000);
        int sum = num.ToString().Select(c => c - '0').Sum();

        return sum;
    }
}
