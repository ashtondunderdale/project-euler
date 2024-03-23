using System;

namespace proj_euler
{
    internal class P10
    {
        public static void Run()
        {
            long sumOfPrimes = 0;

            for (int i = 2; i < 2000000; i++)
            {
                if (IsPrime(i))
                    sumOfPrimes += i;
            }

            Console.WriteLine(sumOfPrimes);
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
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
