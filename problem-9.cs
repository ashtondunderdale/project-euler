using System;

namespace proj_euler
{
    internal class P9
    {
        public static void Run()
        {
            int targetSum = 1000;

            for (int a = 1; a < targetSum; a++)
            {
                for (int b = a + 1; b < targetSum; b++)
                {
                    int c = targetSum - a - b;

                    if (a * a + b * b == c * c)
                    {
                        long product = (long)a * b * c;
                        Console.WriteLine(product);
                        return;
                    }
                }
            }
        }
    }
}
