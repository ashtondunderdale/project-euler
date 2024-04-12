namespace proj_euler;

internal class P0037 : Problem
{
    public override dynamic Solve()
    {
        int sum = 0;

        for (int i = 10; i < 1000000; i++)
            if (IsTruncatablePrime(i))
                sum += i;

        return sum;
    }

    private static bool IsTruncatablePrime(int number)
    {
        string primeStr = number.ToString();

        for (int j = 0; j < primeStr.Length; j++)
            if (!IsPrime(int.Parse(primeStr[j..])))
                return false;

        for (int j = primeStr.Length; j > 0; j--)
            if (!IsPrime(int.Parse(primeStr[..j])))
                return false;

        return true;
    }

    private static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        if (number == 2)
            return true;

        if (number % 2 == 0)
            return false;

        int boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
            if (number % i == 0)
                return false;
        
        return true;
    }
}
