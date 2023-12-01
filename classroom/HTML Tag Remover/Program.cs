using System.Text.RegularExpressions;

while (true)
{
    Console.WriteLine("Please enter an HTML string to clean: ");
    var html = Console.ReadLine();
    Console.WriteLine("Processing...");

    Console.WriteLine("Original Html String:\n" + html);
    Console.WriteLine("Cleaned text:\n" + HtmlTagsRemover(html));

    Console.WriteLine("Would you like to clean another Html string? (yes,no)");
    var answer = Console.ReadLine();
    if (answer == "no")
    {
        return;
    }
}

static string HtmlTagsRemover(string html)
{
    return Regex.Replace(html, "<.*?>", string.Empty);
}