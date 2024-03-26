namespace proj_euler;

internal class P39
{
    public static void Run() 
    {
        List<List<double>> solutions = new() { };
        int largestSolutionCount = 0;
        int max = 0;

        for (int i = 0; i < 1000; i++) 
        {
            int solutionCount = 0;

            for (int a = 1; a < 1000; a++)
            {
                for (int b = 1; b < 1000; b++)
                {
                    int cSquared = (a * a) + (b * b);
                    List<double> tempSolution = new() { a, b, Math.Sqrt(cSquared) };
                    tempSolution.Sort();

                    if (a + b + Math.Sqrt(cSquared) == i && !solutions.Any(sol => sol.SequenceEqual(tempSolution)))
                    {
                        solutionCount++;
                        solutions.Add(tempSolution);

                        Console.WriteLine(a + " " + b + " " + Math.Sqrt(cSquared));
                    }
                }
            }

            if (solutionCount > largestSolutionCount)
            {
                largestSolutionCount = solutionCount;
                max = i;
            }
        }

        Console.WriteLine(max);
    }
}
