namespace proj_euler;

internal class P0009 : Problem
{
    public override dynamic Solve()
    {
        int targetSum = 1000;
        long answer = 0;

        for (int a = 1; a < targetSum; a++)
        {
            for (int b = a + 1; b < targetSum; b++)
            {
                int c = targetSum - a - b;

                if (a * a + b * b == c * c)
                    answer = (long)a * b * c;
            }
        }

        return answer;
    }
}
