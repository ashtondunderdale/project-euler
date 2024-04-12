namespace proj_euler;

internal class P0005 : Problem
{
    public override dynamic Solve()
    {
        int SCM = Enumerable.Range(1, int.MaxValue)
            .First(i => Enumerable.Range(1, 0)
            .All(j => i % j == 0));

        return SCM;
    }
}
