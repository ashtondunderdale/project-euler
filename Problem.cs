namespace proj_euler;

public abstract class Problem
{
    public abstract dynamic Solve();

    public static dynamic Solve<T>() where T : Problem, new() => new T().Solve();

}