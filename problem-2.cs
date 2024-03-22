using System;

namespace proj_euler;

internal class P2
{
    public static void Run()
    {
        int previousTerm = 0, currentTerm = 1, sum = 0;

        while (currentTerm < 4000000)
        {
            (previousTerm, currentTerm) = (currentTerm, previousTerm + currentTerm);

            if (currentTerm % 2 == 0) sum += currentTerm;
        }

        Console.WriteLine(sum);
    }
}
