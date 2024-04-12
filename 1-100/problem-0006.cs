namespace proj_euler;

internal class P0006 : Problem
{
    public override dynamic Solve()
    {
        int sumOfSquares = Enumerable.Range(1, 100).Select(n => n * n).Sum();
        double squareOfSum = Math.Pow(Enumerable.Range(1, 100).Sum(), 2);

        return squareOfSum - sumOfSquares;
    }
}
