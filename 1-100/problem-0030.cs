namespace proj_euler;

internal class P30
{
    public static void Run() 
    {
        double totalSum = 0;

        for (int i = 2; i < 10000000; i++) 
        { 
            char[] chars = i.ToString().ToCharArray();
            double sum = 0;

            foreach (char c in chars)
            {
                double digit = c - '0';
                sum += Math.Pow(digit, 5);
            }

            if (sum == i) totalSum += sum;
        }

        Console.Write(totalSum);
    }
}
