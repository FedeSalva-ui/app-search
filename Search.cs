

using System;
using System.IO;

namespace Search
{
    public class Search
    {
        public static void DoSearch(string pathToFile, string columnNumber, string textToSearch) {
            if (!File.Exists(pathToFile))
                throw new ArgumentException($"File {pathToFile} not found");

            if (!Int32.TryParse(columnNumber, out int column))
                throw new ArgumentException($"Column number {columnNumber} not valid");

            if (textToSearch == null)
                throw new ArgumentException($"Text to search is NULL");

            try
            {
                using (StreamReader reader = new StreamReader(pathToFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var columns = line.Split(",");
                        if (columns?.Length > column && columns[column].ToLower().Contains(textToSearch.ToLower())) {
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error while reading the file: {e.Message}");
            }
        }
    }
}