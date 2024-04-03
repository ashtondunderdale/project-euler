namespace proj_euler;

internal class P33
{
    public static void Run() 
    {
        int fractionProductNumerator = 1;
        int fractionProductDenominator = 1;

        for (int n = 10; n < 100; n++) 
            for (int d = 10; d < 100; d++) 
            {
                if (HasCommonDigits(n, d)) 
                {
                    fractionProductNumerator *= n;
                    fractionProductDenominator *= d;
                }
            }

        Console.Write(fractionProductNumerator / fractionProductDenominator);
    }

    static bool HasCommonDigits(int n, int d) 
    {
        foreach (char c in n.ToString())
        {
            if (d.ToString().Contains(c) && c != '0')
            {
                string nWithoutChar = n.ToString().Remove(n.ToString().IndexOf(c), 1);
                string dWithoutChar = d.ToString().Remove(d.ToString().IndexOf(c), 1);

                int newN = int.Parse(nWithoutChar);
                int newD = int.Parse(dWithoutChar);

                if (SimplifiesNonTrivially(n, d, newN, newD))
                    return true;
            }
        }

        return false;
    }

    static bool SimplifiesNonTrivially(int n, int d, int newN, int newD)
    {
        int gcdNumerator = GCD(n, d);
        int gcdDenominator = GCD(newN, newD);

        if ((gcdNumerator == 0 || gcdDenominator == 0) || n == d || n < d)
            return false;

        return (n / gcdNumerator == newN / gcdDenominator) && (d / gcdNumerator == newD / gcdDenominator);
    }

    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }
}
