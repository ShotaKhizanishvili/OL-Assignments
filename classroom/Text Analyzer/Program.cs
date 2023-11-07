using System.Text.RegularExpressions;

namespace Text_Analyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Please enter a block of text for analysis:");
            input = Console.ReadLine().ToLower();
            string[] inputStrings = input.Split(',');
            for (int i = 0; i < inputStrings.Length; i++)
            {
                inputStrings[i] = inputStrings[i].Trim();
            }
        }
        public static void CountWords(string[] arr)
        {

        }
        public static void FindMostCommonWord()
        {

        }
        public static void FindLongestWord()
        {

        }
        private static void arrayCleaner(string[] arr)
        {

        }
    }
}