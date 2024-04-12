namespace proj_euler;

internal class P0038 : Problem
{
    public override dynamic Solve()
    {
        int largestPandigital = 0;

        for (int i = 1; i < 10000; i++)
        {
            string concatenatedProduct = "";

            for (int n = 1; concatenatedProduct.Length < 9; n++)
            {
                concatenatedProduct += (i * n).ToString();

                if (IsPandigital(concatenatedProduct) && concatenatedProduct.Length == 9)
                {
                    int pandigitalNumber = int.Parse(concatenatedProduct);

                    if (pandigitalNumber > largestPandigital)
                        largestPandigital = pandigitalNumber;
                }
            }
        }

        return largestPandigital;
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
