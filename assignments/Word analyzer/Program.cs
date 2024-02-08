string[] words = File.ReadAllLines("C:\\Users\\Shota\\Desktop\\OL-Assignments\\assignments\\Word analyzer\\words_alpha.txt");

string shortestWord = words.OrderBy(w => w.Length).FirstOrDefault();
string longestWord = words.OrderByDescending(w => w.Length).FirstOrDefault();

Console.WriteLine($"Shortest word: {shortestWord}, Length: {shortestWord.Length}");
Console.WriteLine($"Longest word: {longestWord}, Length: {longestWord.Length}");

var wordsWithVowels = words.Select(w => new { Word = w, VowelCount = CountVowels(w) })
                           .OrderByDescending(w => w.VowelCount)
                           .Take(100)
                           .Select(w => w.Word);

Console.WriteLine("100 words with the most vowels:");
foreach (var word in wordsWithVowels)
{
    Console.WriteLine(word);
}

static int CountVowels(string word)
{
    char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
    return word.Count(c => vowels.Contains(c));
}