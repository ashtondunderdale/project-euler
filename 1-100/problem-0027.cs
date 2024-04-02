namespace proj_euler;

internal class P27
{
    public static void Run() 
    {
        int largestPrimeSequence = 0;
        int product = 0;

       for (int a = -999; a < 1000; a++)
            for (int b = -1000; b <= 1000; b++)
            {
                int n = 0;
                while (IsPrime(n * n + a * n + b)) 
                    n++;

                if (n > largestPrimeSequence)
                    (largestPrimeSequence, product) = (n, a * b);
            }

        Console.Write(product);
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
