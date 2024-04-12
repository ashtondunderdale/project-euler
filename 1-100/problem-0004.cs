namespace proj_euler;

internal class P0004 : Problem
{
    public override dynamic Solve()
    {
        int largestPalindrome = Enumerable.Range(100, 900)
            .SelectMany(i => Enumerable.Range(100, 900).Select(j => i * j))
            .Where(IsPalindrome)
            .Max();

        return largestPalindrome;
    }

    private static bool IsPalindrome(int number)
    {
        string numberStr = number.ToString();
        return numberStr.SequenceEqual(numberStr.Reverse());
    }
}
