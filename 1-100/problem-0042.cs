namespace proj_euler;

internal class P42
{
    public static void Run() 
    {
        int triangleSum = 0;

        Dictionary<string, int> dict = new()
        {
            { "a", 1 }, { "b", 2 },{ "c", 3 },{ "d", 4 },{ "e", 5 },{ "f", 6 },{ "g", 7 },
            { "h", 8 },{ "i", 9 },{ "j", 10 },{ "k", 11 },{ "l", 12 },{ "m", 13 },{ "n", 14 },
            { "o", 15 },{ "p", 16 },{ "q", 17 },{ "r", 18 },{ "s", 19 },{ "t", 20 },{ "u", 21 },
            { "v", 22 },{ "w", 23 },{ "x", 24 },{ "y", 25 },{ "z", 26 }
        };

        string text = File.ReadAllText("C:\\Users\\adunderdale\\p42.txt");
        string[] words = text.Split(",");

        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i].Replace("\"", "");
            int letterSum = 0;

            foreach (char c in words[i]) 
                letterSum += dict[c.ToString().ToLower()];

            if (IsTriangleNumber(letterSum))
                triangleSum++;
        }

        Console.Write(triangleSum);
    }

    static bool IsTriangleNumber(int num)
    {
        int n = 1;
        int triangle = 0;

        while (triangle < num)
        {
            triangle = n * (n + 1) / 2;

            if (triangle == num)
                return true;

            n++;
        }

        return false;
    }
}
