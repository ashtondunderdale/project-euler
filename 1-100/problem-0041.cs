namespace proj_euler;

internal class P0041 : Problem
{
    public override dynamic Solve()
    {
        int largestPandigitalPrime = 0;

        for (int i = 0; i < 10000000; i++) 
            if (IsPandigital(i.ToString()) && IsPrime(i)) 
                if (i > largestPandigitalPrime)
                    largestPandigitalPrime = i;

       return largestPandigitalPrime;
    }

    private static bool IsPandigital(string concatenatedString)
    {
        for (int digit = 1; digit <= concatenatedString.Length; digit++)
            if (!concatenatedString.Contains(digit.ToString()))
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
