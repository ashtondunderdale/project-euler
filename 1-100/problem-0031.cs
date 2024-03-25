namespace proj_euler;

internal class P31
{
    public static void Run()
    {
        int[] coins = { 1, 2, 5, 10, 20, 50, 100, 200 };
        int target = 200;

        int[] ways = new int[201];
        ways[0] = 1;

        foreach (var coin in coins)
        {
            for (int i = coin; i <= target; i++)
                ways[i] += ways[i - coin];
        }

        Console.Write(ways[target]);
    }
}
