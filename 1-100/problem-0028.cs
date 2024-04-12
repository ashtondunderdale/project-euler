namespace proj_euler;

internal class P0028 : Problem
{
    public override dynamic Solve()
    {
        int n = 1001;
        int answer = 1;

        for (int i = 1; i <= (n - 1) / 2; i++)
        {
            int tr = (2 * i + 1) * (2 * i + 1);
            int tl = tr - 2 * i;
            int bl = tl - 2 * i;
            int br = bl - 2 * i;

            answer += tr + tl + bl + br;
        }

        return answer;
    }
}
