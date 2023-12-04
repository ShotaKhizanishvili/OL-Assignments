Console.WriteLine("Welcome to Directory Explorer.\n");
while (true)
{
    Console.WriteLine("Please enter a directory path to list files and folders, or use commands:" +
                      " [NEW: Create New Directory] [DEL: Delete Directory]");
    var input = Console.ReadLine();
    if (Directory.Exists(input))
    {
        ListAllDirectoryContents(input);
        continue;
    }

    if (input.Substring(0, 3) == "NEW")
    {
        var directoryPath = input.Substring(4);
        CreateNewDirectory(directoryPath);
        continue;
    }

    if (input.Substring(0, 3) == "DEL")
    {
        var directoryPath = input.Substring(4);
        DeleteDirectory(directoryPath);
    }
}

static void CreateNewDirectory(string directoryPath)
{
    Directory.CreateDirectory(directoryPath);
    Console.WriteLine($"Creating directory: {directoryPath}... Done.");
}

static void DeleteDirectory(string directoryPath)
{
    Console.WriteLine($"Are you sure you want to delete {directoryPath}? (yes/no): ");
    var answer = Console.ReadLine();
    if (answer == "yes")
    {
        Directory.Delete(directoryPath);
        Console.WriteLine($"Deleting directory: {directoryPath}... Done.");
    }
}

static void ListAllDirectoryContents(string directoryPath)
{
    var folders = Directory.GetDirectories(directoryPath);
    var files = Directory.GetFiles(directoryPath);
    Console.WriteLine($"Listing contents of {directoryPath}:\n");
    Console.WriteLine("Folders:");
    for (int i = 0; i < folders.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {folders[i]}");
    }

    Console.WriteLine("Files:");
    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {files[i]}");
    }
}