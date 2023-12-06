using Extended_String_Manipulation;

string originalString = "Lorem ipsum dolor sit amet";

Console.WriteLine($"Original String: \"{originalString}\"");
Console.WriteLine($"Reversed: \"{originalString.Reverse()}\"");
Console.WriteLine($"Title Case: \"{originalString.ToTitleCase()}\"");
Console.WriteLine($"Word Count: {originalString.WordCount()}");