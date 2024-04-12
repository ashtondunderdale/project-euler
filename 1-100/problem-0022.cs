namespace proj_euler;

internal class P0022 : Problem
{
    public override dynamic Solve()
    {
        string[] names = File.ReadAllText("path to file")
            .Split(',')
            .Select(name => name.Trim('"'))
            .OrderBy(name => name)
            .ToArray();

        int totalNameScore = names.Select((name, index) => (index + 1) * name.ToLower()
            .Sum(c => c - 'a' + 1)).Sum();

        return totalNameScore;
    }
}
