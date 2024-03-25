namespace proj_euler;

internal class P23
{
    public static void Run() // please fix this, it takes like 2 minutes to get the answer
    {
        List<int> abundantNumbers = new();
        int intSum = 0;

        for (int i = 1; i <= 28123; i++)
        {
            int sum = 0;
            
            for (int j = i; j > 0; j--) 
                if (i % j == 0 && i != j) sum += j;
                
            if (sum > i)
                abundantNumbers.Add(i);
            
            bool sumFound = false;

            for (int k = 0; k < abundantNumbers.Count; k++) 
            {
                if (sumFound) break;

                int num1 = abundantNumbers[k];

                for (int l = 0; l < abundantNumbers.Count; l++) 
                {
                    int num2 = abundantNumbers[l];

                    if (num1 + num2 == i) 
                        sumFound = true;
                }
            }

            if (!sumFound) 
                intSum += i;

            Console.WriteLine(i);
            
        }

        Console.Write(intSum);
    }
}
