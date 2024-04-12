namespace proj_euler;

internal class P0026 : Problem
{
    public override dynamic Solve()
    {
        int largestCycleLength = 0, largestDenominator = 0;

        for (int i = 2; i < 1000; i++)
        {
            int length = FindCycleLength(i);

            if (length > largestCycleLength)
                (largestCycleLength, largestDenominator) = (length, i);
        }

        return largestDenominator;
    }

    static int FindCycleLength(int d) 
    {
        var remainders = new Dictionary<int, int>();
        int remainder = 1, position = 0;

        while (!remainders.ContainsKey(remainder) && remainder != 0)
        {
            remainders[remainder] = position;
            remainder *= 10;
            remainder %= d;
            position++;
        } 
        
        return remainder == 0 ? 0 : position - remainders[remainder];
    }
}
