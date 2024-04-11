namespace proj_euler;

internal class P47
{
    public static void Run()
    {
        for (int i = 0; ; i++) 
        {
            List<int> factorsFirst = PrimeFactorsOf(i);
            List<int> factorsSecond = PrimeFactorsOf(i + 1);
            List<int> factorsThird = PrimeFactorsOf(i + 2);
            List<int> factorsFourth = PrimeFactorsOf(i + 3);

            if (factorsFirst.Count == 4 && factorsSecond.Count == 4 && 
                factorsThird.Count == 4 && factorsFourth.Count == 4) 
            {
                Console.WriteLine(i);
                break;
            }        
        }
    }

    public static List<int> PrimeFactorsOf(int number)
    {
        var primeFactors = new List<int>();

        for (int factor = 2; factor * factor <= number; factor++)
        {
            while (number % factor == 0)
            {
                if (!primeFactors.Contains(factor))
                    primeFactors.Add(factor);

                number /= factor;
            }
        }

        if (number > 1 && !primeFactors.Contains(number))
            primeFactors.Add(number);

        return primeFactors;
    }

}
