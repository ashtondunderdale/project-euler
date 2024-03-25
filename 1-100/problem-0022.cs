using System;
using System.IO;
using System.Linq;

namespace proj_euler
{
    internal class P22
    {
        public static void Run()
        {
            string[] names = File.ReadAllText("C:\\Users\\adunderdale\\names.txt")
                .Split(',')
                .Select(name => name.Trim('"'))
                .OrderBy(name => name)
                .ToArray();

            int totalNameScore = names.Select((name, index) => (index + 1) * name.ToLower()
                .Sum(c => c - 'a' + 1)).Sum();

            Console.WriteLine(totalNameScore);
        }
    }
}
