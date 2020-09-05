using System;
using System.IO;

namespace Search
{
    class Program
    {
        private static readonly String Usage = "Usage: app-search.exe <path to file> <column number> <text to search>";
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine(Usage);
                return;
            }

            try
            {
                Search.DoSearch(args[0], args[1], args[2]);
            }
            catch (Exception e)
            {
                Console.WriteLine(Usage);
                Console.WriteLine($"Error during seach: {e.Message}");
            }
        }
    }
}
