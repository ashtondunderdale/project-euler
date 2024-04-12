namespace proj_euler;

internal class P0017 : Problem
{
    public override dynamic Solve()
    {
        Dictionary<int, string> map = new()
        {
            { 1, "one" }, { 2, "two" }, { 3, "three" },
            { 4, "four" }, { 5, "five" }, { 6, "six" },
            { 7, "seven" }, { 8, "eight" }, { 9, "nine" },

            { 10, "ten" }, { 11, "eleven" }, { 12, "twelve"}, { 13, "thirteen"}, { 14, "fourteen"},
            { 15, "fifteen"}, { 16, "sixteen"}, { 17, "seventeen"}, { 18, "eighteen"}, { 19, "nineteen"},

            { 20, "twenty"}, { 30, "thirty"}, { 40, "forty"}, { 50, "fifty"},
            { 60, "sixty"}, { 70, "seventy"}, { 80, "eighty"}, { 90, "ninety"},

            { 100, "hundred"}, { 1000, "onethousand"}
        };

        int totalLetters = 0;

        for (int i = 1; i <= 1000; i++)
        {
            string numberRepresentation = GetNumberRepresentation(i, map);

            if (map.ContainsKey(i))
                totalLetters += map[i].Length + (numberRepresentation == "hundred" ? 3 : 0); // not proud

            else
                totalLetters += numberRepresentation.Replace(" ", "").Length;
        }

        return totalLetters;
    }

    private static string GetNumberRepresentation(int num, Dictionary<int, string> map)
    {
        if (map.ContainsKey(num))
            return map[num];

        int hundreds = num / 100;
        int tens = (num % 100) / 10;
        int units = num % 10;

        string representation = "";

        if (hundreds > 0)
        {
            representation += map[hundreds] + " hundred";

            if (tens > 0 || units > 0)
                representation += " and ";
        }

        if (tens == 1)
            return representation + map[num % 100];

        if (tens > 1)
        {
            representation += map[tens * 10];

            if (units > 0)
                representation += " " + map[units];
        }

        else if (units > 0)
            representation += map[units];

        return representation;
    }
}