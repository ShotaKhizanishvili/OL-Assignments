using System.Text.RegularExpressions;

namespace Text_Analyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Please enter a block of text for analysis:");
            input = Console.ReadLine();
            Console.WriteLine("Analyzing...");
            CountWords(input);
            FindMostCommonWord(input);
            FindLongestWord(input);
        }

        public static void CountWords(string input)
        {
            Regex wordRegex = new Regex(@"\b\w+\b");
            var matches = wordRegex.Matches(input);
            Console.WriteLine($"Word Count: {matches.Count}");
        }

        public static void FindMostCommonWord(string input)
        {
            Regex wordRegex = new Regex(@"\b\w+\b");
            MatchCollection matches = wordRegex.Matches(input);
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();
            
            foreach (Match match in matches)
            {
                string word = match.Value.ToLower();
                if (wordCounts.ContainsKey(word))
                {
                    wordCounts[word]++;
                }
                else
                {
                    wordCounts[word] = 1;
                }
            }
            string mostCommonWord = "";
            int maxCount = 0;
            foreach (var entry in wordCounts)
            {
                if (entry.Value > maxCount)
                {
                    mostCommonWord = entry.Key;
                    maxCount = entry.Value;
                }
            }
            Console.WriteLine($"Most Common Word: '{mostCommonWord}'");
        }

        public static void FindLongestWord(string input)
        {
            Regex wordRegex = new Regex(@"\b\w+\b");
            MatchCollection matches = wordRegex.Matches(input);
            
            string longestWord = "";
            foreach (Match match in matches)
            {
                string word = match.Value;
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            Console.WriteLine($"Longest Word: '{longestWord}'");
        }
    }
}