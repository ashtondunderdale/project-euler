using proj_euler;

class P0007 : Problem
{
    public override dynamic Solve()
    {
        var primeNum = Enumerable.Range(2, int.MaxValue - 1)
            .Where(num => Enumerable.Range(2, (int)Math.Sqrt(num) - 1).All(i => num % i != 0))
            .Take(10001).Last();

        return primeNum;
    }
}
