namespace proj_euler;

internal class P19
{
    public static void Run()
    {
        int sundays = 0;

        for (int year = 1901; year <= 2000; year++)
        {
            for (int month = 1; month <= 12; month++)
            {
                int tempMonth = month;
                int tempYear = year;

                if (tempMonth < 3)
                {
                    tempMonth += 12;
                    tempYear--;
                }

                int century = tempYear / 100;
                tempYear %= 100;

                int dayOfWeek = (1 + 13 * (tempMonth + 1) / 5 + tempYear + tempYear / 4 + century / 4 - 2 * century) % 7;
                dayOfWeek = (dayOfWeek + 6) % 7;

                if (dayOfWeek == 0)
                    sundays++;
            }
        }

        Console.WriteLine(sundays);
    }
}
