using static System.Enum;

Console.Write("Enter a weather condition: ");
var input = Console.ReadLine();

TryParse(input, out WeatherConditions condition);
switch (condition)
{
    case WeatherConditions.Sunny:
        OutfitSuggestion("Wear a t-shirt and sunglasses.");
        ActivitySuggestion("Go for a hike.");
        break;
    case WeatherConditions.Rainy:
        OutfitSuggestion("Wear a raincoat and boots.");
        ActivitySuggestion("Stay at home.");
        break;
    case WeatherConditions.Cloudy:
        OutfitSuggestion("Wear a sweater and jeans.");
        ActivitySuggestion("Watch TV.");
        break;
    case WeatherConditions.Windy:
        OutfitSuggestion("Wear a sweater and boots.");
        ActivitySuggestion("Read a book at home.");
        break;
    case WeatherConditions.Snowy:
        OutfitSuggestion("Wear a heavy coat and boots.");
        ActivitySuggestion("Build a snowman.");
        break;
    default:
        Console.WriteLine("Wrong input, try again.");
        break;
}

void OutfitSuggestion(string suggestion)
{
    Console.WriteLine(suggestion);
}

void ActivitySuggestion(string suggestion)
{
    Console.WriteLine(suggestion);
}

public enum WeatherConditions
{
    Sunny,
    Rainy,
    Cloudy,
    Windy,
    Snowy
}