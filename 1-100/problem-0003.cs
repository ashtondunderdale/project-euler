﻿using System;

namespace proj_euler;


internal class P0003 : Problem
{
    public override dynamic Solve()
    {
        long n = 600851475143;
        long largestFactor = 1;

        while (n % 2 == 0)
        {
            largestFactor = 2;
            n /= 2;
        }

        for (long i = 3; i <= Math.Sqrt(n); i += 2)
        {
            while (n % i == 0)
            {
                largestFactor = i;
                n /= i;
            }
        }

        if (n > 2) 
            largestFactor = n;

        return largestFactor;
    }
}
