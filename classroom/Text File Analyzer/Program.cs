do
{
    Console.Write("Please enter the path to the text file you wish to analyze: ");
    var path = Console.ReadLine();
    var text = File.ReadAllText(path);
    var textArr = ParseText(text);

    Console.WriteLine($"Word Count: {CountWords(textArr)}");
    Console.WriteLine($"Longest Word: {FindLongestWord(textArr)}");
    Console.WriteLine($"Shortest Word: {FindShortestWord(textArr)}");
    Console.WriteLine($"Average Word Length: {AverageWordLength(textArr)} characters");
    Console.WriteLine($"Most Frequent Word: {MostFrequentWord(textArr, out int count)} appeared {count} times");
} while (Prompt());

static bool Prompt()
{
    Console.WriteLine("Would you like to analyze another file? (yes/no): ");
    var answer = Console.ReadLine();
    if (answer == "yes")
    {
        return true;
    }

    return false;
}

static string MostFrequentWord(string[] textArr, out int count)
{
    var dictionary = new Dictionary<string, int>();
    foreach (var word in textArr)
    {
        if (dictionary.ContainsKey(word))
        {
            dictionary[word]++;
        }
        else
        {
            dictionary[word] = 1;
        }
    }

    var mostFrequentWord = dictionary.OrderByDescending(a => a.Key).FirstOrDefault();
    count = mostFrequentWord.Value;
    return mostFrequentWord.Key;
}


static string[] ParseText(string text)
{
    char[] separators = { '.', ',', ' ' };
    return text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
}

static int CountWords(string[] textArr)
{
    return textArr.Length;
}

static string FindLongestWord(string[] textArr)
{
    return textArr.OrderByDescending(a => a.Length).FirstOrDefault();
}

static string FindShortestWord(string[] textArr)
{
    return textArr.OrderByDescending(a => a.Length).LastOrDefault();
}

static double AverageWordLength(string[] textArr)
{
    return textArr.Average(a => a.Length);
}