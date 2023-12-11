using Burger_Builder;

Console.WriteLine("Choose the order mode:");
Console.WriteLine("1. Pre-made burgers");
Console.WriteLine("2. Create my own burger");
var choice = Console.ReadLine();

if (choice == "1")
{
    var builder = new BurgerBuilder();
    AskForPremadeBurger(builder);
    Console.WriteLine((builder.GetBurger().ListParts()));
}

if (choice == "2")
{
    var builder = new BurgerBuilder();
    AskForCheese(builder);
    AskForPickles(builder);
    AskForMeatType(builder);
    AskForSauce(builder);

    Console.WriteLine(builder.GetBurger().ListParts());
}

#region MethodsForMain

void AskForCheese(BurgerBuilder builder)
{
    Console.WriteLine("Do you want melted cheese? (Yes,No)");
    var choice = Console.ReadLine();
    if (choice == "Yes")
    {
        builder.AddCheese();
    }
}

void AskForPickles(BurgerBuilder builder)
{
    Console.WriteLine("Do you want pickles? (Yes,No)");
    var choice = Console.ReadLine();
    if (choice == "Yes")
    {
        builder.AddPickles();
    }
}

void AskForMeatType(BurgerBuilder builder)
{
    Console.WriteLine("Which type of meat do you want? (Chicken, Beef, Neither)");
    var choice = Console.ReadLine();
    builder.AddMeat(choice);
}

void AskForSauce(BurgerBuilder builder)
{
    Console.WriteLine("Which type of sauce do you want? (Hot, Sweet, Signature, Neither)");
    var choice = Console.ReadLine();
    builder.AddSauce(choice);
}

void AskForPremadeBurger(BurgerBuilder burgerBuilder)
{
    Console.WriteLine("Which type of pre-made burger do you want?(Cheeseburger, Hamburger, Signature burger)");
    var choice = Console.ReadLine();
    burgerBuilder.GetPremadeBurger(choice);
}

#endregion