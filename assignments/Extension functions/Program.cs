using Extension_functions;

//String
string testNumber = "123";
Console.WriteLine($"{testNumber}: {testNumber.IsNumber()}");

string testDate = "2024-02-08";
Console.WriteLine($"{testDate}: {testDate.IsDate()}");

string testString = "extension methods";
string[] words = testString.ToWords();
Console.WriteLine("Words:");
foreach (string word in words)
{
    Console.WriteLine(word);
}

string HashInput = "text";
Console.WriteLine($"Hash of \"{HashInput}\": {HashInput.CalculateHash()}");

string contentToSave = "test";
string filePath = "C:\\Users\\Shota\\Desktop\\OL-Assignments\\assignments\\Extension functions\\text.txt";
contentToSave.SaveToFile(filePath);

//Double
double number = 0.5;

Console.WriteLine($"{number}: {number.ToPercent()}%");

double number2 = 36.7;
Console.WriteLine($"{number2}: {number2.RoundDown()}");

double number3 = 123.45;
Console.WriteLine($"{number3}: {number3.ToDecimal()}");

double number4 = 10;
double compare = 5;
Console.WriteLine($"{number4} is greater than {compare}: {number4.IsGreater(compare)}");

double number5 = 3;
double compare2 = 5;
Console.WriteLine($"{number5} is less than {compare2}: {number5.IsLess(compare2)}");

DateTime date1 = new DateTime(2022, 10, 15);
DateTime date2 = new DateTime(2022, 11, 23);

Console.WriteLine($"Minimum between {date1} and {date2} is: {date1.Min(date2)}");

Console.WriteLine($"Maximum between {date1} and {date2} is: {date1.Max(date2)}");

DateTime date3 = new DateTime(2022, 11, 23);

Console.WriteLine($"Beginning of month for {date3}: {date3.BeginningOfMonth()}");

Console.WriteLine($"End of month for {date3}: {date3.EndOfMonth()}");