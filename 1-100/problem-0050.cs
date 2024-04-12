namespace proj_euler;

internal class P50
{
    public static void Run()
    {
        int largestPrimeFromSequence = 0;
        int maxLength = 0;

        for (int i = 2; i < 1000000; i++)
        {
            int sum = 0;
            int count = 0;
            int currentPrime = i;

            while (sum + currentPrime < 1000000)
            {
                if (IsPrime(currentPrime))
                {
                    sum += currentPrime;
                    count++;

                    if (IsPrime(sum) && count > maxLength)
                    {
                        maxLength = count;
                        largestPrimeFromSequence = sum;
                    }
                }
                currentPrime++;
            }
        }

        Console.Write(largestPrimeFromSequence);
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
