using System;

namespace proj_euler;

internal class P0012 : Problem
{
    public override dynamic Solve()
    {
        int triangleNum = 0;
        int i = 1;

        while (true)
        {
            triangleNum += i;
            int factors = 0;

            for (int j = 1; j <= Math.Sqrt(triangleNum); j++)
                if (triangleNum % j == 0)
                    factors += 2;

            if (factors >= 500)
                break;

            i++;
        }

        return triangleNum;
    }
}
