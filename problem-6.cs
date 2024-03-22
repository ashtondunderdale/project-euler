namespace proj_euler;

internal class P6
{
    public static void Run() 
    {
        int sumOfSquares = Enumerable.Range(1, 100).Select(n => n * n).Sum();
        double squareOfSum = Math.Pow(Enumerable.Range(1, 100).Sum(), 2);

        Console.WriteLine(squareOfSum - sumOfSquares);
    }
}
