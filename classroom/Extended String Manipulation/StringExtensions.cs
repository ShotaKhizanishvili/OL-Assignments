using System.Runtime.InteropServices;
using System.Text;

namespace Extended_String_Manipulation;

public static class StringExtensions
{
    public static string Reverse(this string input)
    {
        var charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public static string ToTitleCase(this string input)
    {
        var words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < words.Length; i++)
        {
            char[] letters = words[i].ToCharArray();
            letters[0] = char.ToUpper(letters[0]);
            for (int j = 1; j < letters.Length; j++)
            {
                letters[j] = char.ToLower(letters[j]);
            }

            words[i] = new string(letters);
        }

        return string.Join(" ", words);
    }

    public static int WordCount(this string input)
    {
        var words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}