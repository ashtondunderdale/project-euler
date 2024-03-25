namespace proj_euler;

internal class P21
{
    public static void Run() 
    {
        int perfectNumberSum = 0;

        for (int i = 1; i < 10000; i++) 
        {
            int factorSum = 0;

            for (int j = 1; j < i; j++) 
                if (i % j == 0) factorSum += j;
            
            int secondFactorSum = 0;

            for (int k = 1; k < factorSum; k++) 
                if (factorSum % k == 0) secondFactorSum += k;
            
            if (i == secondFactorSum && factorSum != secondFactorSum)
                perfectNumberSum += factorSum;     
        }

        Console.Write(perfectNumberSum);
    }
}
