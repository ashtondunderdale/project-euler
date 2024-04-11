namespace proj_euler;

internal class P46
{
    public static void Run() 
    {
        for (int i = 9; ; i++) 
            if (i % 2 != 0 && !IsPrime(i)) 
            {
                if (!IsGoldbachValid(i)) 
                {
                    Console.Write(i);
                    return;
                }
            }
    }

    private static bool IsGoldbachValid(long num)
    {
        for (long i = 1; 2 * i * i < num; i++)
        {
            if (IsPrime(num - 2 * i * i))
                return true;
        }
        return false;
    }

    private static bool IsPrime(long number)
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
