namespace proj_euler;

public abstract class Problem
{
    public abstract dynamic Solve();

    public static void Solve<T>() where T : Problem, new() 
    {
        Console.WriteLine(new T().Solve());
    }

    public static string NotSolved() => "Not Solved";
}