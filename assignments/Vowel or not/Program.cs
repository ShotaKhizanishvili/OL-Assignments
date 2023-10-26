namespace Vowel_or_not
{
    internal class Program
    {
        static char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'ა', 'ე', 'ი', 'ო', 'უ' };
        static void Main(string[] args)
        {
            var isVowel = IsVowel('a'); // true
            Console.WriteLine(isVowel);

            isVowel = IsVowel('b'); // false
            Console.WriteLine(isVowel);

            isVowel = IsVowel('ე'); // true
            Console.WriteLine(isVowel);

            isVowel = IsVowel('კ'); // false
            Console.WriteLine(isVowel);
        }
        public static bool IsVowel(char c)
        {
            if (vowels.Contains(c))
            {
                return true;
            }
            return false;
        }
    }
}