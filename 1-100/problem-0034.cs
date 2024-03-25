using System;

namespace proj_euler
{
    class P34
    {
        public static void Run()
        {
            int totalFactorialSum = 0;

            for (int i = 10; i < 10000000; i++)
            {
                int totalSum = 0;
                int number = i;

                while (number > 0)
                {
                    int digit = number % 10;
                    int factorialSum = 1;

                    for (int j = digit; j > 0; j--) 
                        factorialSum *= j;
                    
                    totalSum += factorialSum;
                    number /= 10;
                }

                if (totalSum == i)
                    totalFactorialSum += totalSum;
            }

            Console.Write(totalFactorialSum);
        }
    }
}
