namespace proj_euler;

internal class P0029 : Problem
{
    public override dynamic Solve()
    {
        List<double> distinctPowers = new();

        for (int a = 2; a <= 100; a++) 
        {
            for (int b = 2; b <= 100; b++) 
            {
                if (!distinctPowers.Contains(Math.Pow(a, b)))
                    distinctPowers.Add(Math.Pow(a, b));
            }
        }

        return distinctPowers.Count; 
    }
}
