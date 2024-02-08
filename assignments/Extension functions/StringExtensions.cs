using System.Security.Cryptography;
using System.Text;

namespace Extension_functions
{
    public static class StringExtensions
    {
        public static bool IsNumber(this string input)
        {
            return int.TryParse(input, out _);
        }

        public static bool IsDate(this string input)
        {
            return DateTime.TryParse(input, out _);
        }

        public static string[] ToWords(this string input)
        {
            return input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        }

        public static string CalculateHash(this string input)
        {
            var hash = SHA256.HashData(Encoding.UTF8.GetBytes(input));

            StringBuilder sb = new StringBuilder();
            foreach (byte b in hash)
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        public static void SaveToFile(this string input, string filePath)
        {
            File.WriteAllText(filePath, input, Encoding.UTF8);
        }
    }
}
