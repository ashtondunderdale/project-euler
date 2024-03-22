namespace proj_euler;

internal class Problem1
{
    public static void run()
    {
        int total = Enumerable.Range(0, 1000)
            .Where(n => n % 3 == 0 || n % 5 == 0)
            .Sum();

        Console.WriteLine(total);
    }
}
