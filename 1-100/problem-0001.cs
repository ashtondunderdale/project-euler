namespace proj_euler;

internal class P0001 : Problem
{
    public override dynamic Solve()
    {
        int total = Enumerable.Range(0, 1000)
            .Where(n => n % 3 == 0 || n % 5 == 0)
            .Sum();

        return total;
    }
}
