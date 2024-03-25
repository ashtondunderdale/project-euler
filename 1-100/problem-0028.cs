namespace proj_euler
{
    internal class P28
    {
        public static void Run()
        {
            int n = 1001;
            int sum = 1;

            for (int i = 1; i <= (n - 1) / 2; i++)
            {
                int tr = (2 * i + 1) * (2 * i + 1);
                int tl = tr - 2 * i;
                int bl = tl - 2 * i;
                int br = bl - 2 * i;

                sum += tr + tl + bl + br;
            }

            Console.WriteLine(sum);
        }
    }
}
