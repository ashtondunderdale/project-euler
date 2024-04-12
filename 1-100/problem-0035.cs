namespace proj_euler;

internal class P0035 : Problem
{
    public override dynamic Solve()
    {
        int primeCount = 0;

        for (int i = 0; i < 1000000; i++)
        {
            if (IsPrime(i))
            {
                string primeStr = i.ToString();
                bool isCircularPrime = true;

                for (int j = 0; j < primeStr.Length; j++)
                {
                    primeStr = primeStr[^1] + primeStr[..^1];

                    int rotatedPrime = int.Parse(primeStr);

                    if (!IsPrime(rotatedPrime))
                    {
                        isCircularPrime = false;
                        break;
                    }
                }

                if (isCircularPrime)
                    primeCount++;
            }
        }

        return primeCount;
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
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}
