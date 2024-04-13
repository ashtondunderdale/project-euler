namespace proj_euler;

internal class P0052 : Problem
{
    public override dynamic Solve()
    {
        for (int i = 1; ; i++)
            if (ContainsSameCharacters(i, i * 2, i * 3, i * 4, i * 5, i * 6))
                return i;
    }

    public static bool ContainsSameCharacters(params int[] numbers)
    {
        string[] sortedNumbers = numbers.Select(n => string.Concat(n.ToString().OrderBy(c => c))).ToArray();
        return sortedNumbers.All(s => s == sortedNumbers[0]);
    }
}
