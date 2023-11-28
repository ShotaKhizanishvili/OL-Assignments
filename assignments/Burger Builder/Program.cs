using Burger_Builder;

Console.WriteLine("Choose the order mode:");
Console.WriteLine("1. Pre-made burgers");
Console.WriteLine("2. Create my own burger");
var choice = Console.ReadLine();

if (choice == "1")
{
    var builder = new BurgerBuilder();
    builder.AskForPremadeBurgers();
    //...
}

if (choice == "2")
{
    var builder = new BurgerBuilder();
    builder.AskForCheese();
    builder.AskForPickles();
    builder.AskForMeatType();
    builder.AskForSauce();

    Console.WriteLine(builder.GetBurger().ListParts());
}