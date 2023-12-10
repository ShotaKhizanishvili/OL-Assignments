do
{
    Console.Write("Please enter the operation (countlines/findword): ");
    var choice = Console.ReadLine();

    Console.Write("Enter file paths (separated by a comma): ");
    var filePaths = Console.ReadLine();

    var parsedPaths = ParsePaths(filePaths);
    if (choice == "countlines")
    {
        foreach (var path in parsedPaths)
        {
            Console.WriteLine($"{path} - Lines counted: {await CountLinesAsync(path)}");
        }
    }

    if (choice == "findword")
    {
        foreach (var path in parsedPaths)
        {
            Console.Write("Enter a word to find: ");
            var word = Console.ReadLine();
            if (await FindWordAsync(path, word))
            {
                Console.WriteLine($"Word {word} was found in {path}");
                break;
            }

            Console.WriteLine($"Word {word} was not found.");
        }
    }
} while (Prompt());

static bool Prompt()
{
    Console.Write("Would you like to perform another operation? (yes/no): ");
    var choice = Console.ReadLine();
    if (choice == "yes")
    {
        return true;
    }

    return false;
}


static string[] ParsePaths(string paths)
{
    var parsedPaths = paths.Split(',', StringSplitOptions.RemoveEmptyEntries);
    return parsedPaths;
}

static async Task<int> CountLinesAsync(string filePath)
{
    int lineCount = 0;
    using (var reader = new StreamReader(filePath))
    {
        while (await reader.ReadLineAsync() != null)
        {
            lineCount++;
        }
    }

    return lineCount;
}

static async Task<bool> FindWordAsync(string filePath, string word)
{
    using (var reader = new StreamReader(filePath))
    {
        var text = await reader.ReadToEndAsync();

        char[] separators = { ' ', ',', '.' };
        var words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        if (words.Contains(word))
        {
            return true;
        }
    }

    return false;
}