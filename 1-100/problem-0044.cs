﻿namespace proj_euler;

internal class P0044 : Problem
{
    public override dynamic Solve()
    {
        int answer = 0;
        for (int i = 1; i <= 10000; i++) 
        {
            int pentNumA = i * (3*i - 1) / 2;

            for (int j = 1; j <= 10000; j++) 
            {
                int pentNumB = j * (3 * j - 1) / 2;

                if (IsPentagonal(pentNumA + pentNumB) && IsPentagonal(pentNumA - pentNumB)) 
                    answer = pentNumA - pentNumB;
            }
        }

        return answer;
    }

    private static bool IsPentagonal(int num)
    {
        double discriminant = 1 + 24 * num;
        double sqrtDiscriminant = Math.Sqrt(discriminant);

        if (sqrtDiscriminant % 1 == 0)
        {
            double n = (1 + sqrtDiscriminant) / 6;
            return n % 1 == 0;
        }

        return false;
    }
}
