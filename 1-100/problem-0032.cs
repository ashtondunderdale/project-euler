namespace proj_euler;

internal class P32
{
    public static void Run()
    {
        List<int> productSum = new();

        for (int i = 1; i < 10000; i++)
        {
            for (int j = 1; j < 10000; j++)
            {
                int product = i * j;
                string concatenatedString = product.ToString() + i.ToString() + j.ToString();

                if (IsPandigital(concatenatedString) && !productSum.Contains(product))
                    productSum.Add(product);
            }
        }

        Console.Write(productSum.Sum());
    }

    private static bool IsPandigital(string concatenatedString)
    {
        if (concatenatedString.Length != 9)
            return false;

        for (int digit = 1; digit <= 9; digit++)
            if (!concatenatedString.Contains(digit.ToString()))
                return false;
        
        return true;
    }
}
