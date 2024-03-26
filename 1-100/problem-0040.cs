using System.Numerics;

namespace proj_euler;

internal class P40
{
    public static void Run() 
    {
        string c = "";

        for (int i = 0; c.Length < 1000000; i++) 
            c += i.ToString();

        int[] indices = { 1, 10, 100, 1000, 10000, 100000, 1000000 };
        BigInteger product = 1;

        foreach (int index in indices)
            if (index < c.Length)
                product *= (int)char.GetNumericValue(c[index]);

        Console.Write(product);
    }
}
