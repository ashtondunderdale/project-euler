namespace proj_euler;

internal class P29
{
    public static void Run() 
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

        Console.Write(distinctPowers.Count); 
    }
}
