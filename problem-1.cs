namespace proj_euler;

internal class P1
{
    public static void Run()
    {
        int total = Enumerable.Range(0, 1000)
            .Where(n => n % 3 == 0 || n % 5 == 0)
            .Sum();

        Console.WriteLine(total);
    }
}
