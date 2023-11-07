namespace Palindrome_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string input;

                Console.WriteLine("Please enter a string to check if it's a palindrome:");
                input = Console.ReadLine();

                if (input == string.Empty)
                {
                    throw new ArgumentException("The string is empty, try again.");
                }
                if (IsPalindrome(input))
                {
                    Console.WriteLine("The string is palindrome.");
                }
                else
                {
                    Console.WriteLine("The string is not a palindrome.");
                }
            }
            while (Prompt());
        }

        private static bool Prompt()
        {
            string answer;
            Console.WriteLine("Would you like to check another string? (yes/no):");
            answer = Console.ReadLine();
            if (answer == "yes")
            {
                return true;
            }
            return false;
        }

        public static bool IsPalindrome(string input)
        {
            Console.WriteLine("Checking...");
            input = input.Replace(",", "").Replace(" ", "").ToLower();
            if (input == Reverse(input))
            {
                return true;
            }
            return false;
        }
        private static string Reverse(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}