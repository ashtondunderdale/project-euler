namespace proj_euler;

internal class P5
{
    public static void Run()
    {
        int SCM = Enumerable.Range(1, int.MaxValue)
            .First(i => Enumerable.Range(1, 0).All(j => i % j == 0));

        Console.WriteLine(SCM);
    }
}
