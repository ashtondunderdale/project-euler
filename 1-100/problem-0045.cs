namespace proj_euler;

internal class P45
{
    public static void Run() 
    {
        int count = 0;
        for (long i = 2; ; i++) 
        {
            long triNum = i * (i + 1) / 2;

            if (IsPentagonal(triNum) && IsHexagonal(triNum)) 
            {
                count++;

                if (count == 2) 
                {
                    Console.WriteLine(triNum);
                    return;
                }
            }
        }     
    }

    private static bool IsPentagonal(long num)
    {
        double discriminant = 1 + 24 * num;
        double sqrtDiscriminant = Math.Sqrt(discriminant);

        if (sqrtDiscriminant % 1 == 0)
        {
            double n = (1 + sqrtDiscriminant) / 6;
            return n % 1 == 0;
        }

        return false;
    }

    public static bool IsHexagonal(long num)
    {
        double discriminant = 1 + 8 * num;
        double sqrtDiscriminant = Math.Sqrt(discriminant);

        if (sqrtDiscriminant % 1 == 0)
        {
            double n = (1 + sqrtDiscriminant) / 4;
            return n % 1 == 0;
        }

        return false;
    }

}
