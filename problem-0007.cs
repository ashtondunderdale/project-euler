using System;
class P7
{
    public static void Run()
    {
        var primeNum = Enumerable.Range(2, int.MaxValue - 1)
            .Where(num => Enumerable.Range(2, (int)Math.Sqrt(num) - 1).All(i => num % i != 0))
            .Take(10001).Last();

        Console.WriteLine(primeNum);
    }
}
