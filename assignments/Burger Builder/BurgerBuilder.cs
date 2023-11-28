namespace Burger_Builder;

public class BurgerBuilder : IBurgerBuilder
{
    private CustomBurger _customBurger = new CustomBurger();
    private PremadeBurgers _premadeBurgers = new PremadeBurgers(); 

    public BurgerBuilder()
    {
        this.Reset();
    }

    private void Reset()
    {
        this._customBurger = new CustomBurger();
    }

    public void AskForCheese()
    {
        Console.WriteLine("Do you want melted cheese? (Yes,No)");
        var choice = Console.ReadLine();
        if (choice == "Yes")
        {
            this._customBurger.Add("melted cheese");
        }
    }

    public void AskForPickles()
    {
        Console.WriteLine("Do you want pickles? (Yes,No)");
        var choice = Console.ReadLine();
        if (choice == "Yes")
        {
            this._customBurger.Add("pickles");
        }
    }

    public void AskForMeatType()
    {
        Console.WriteLine("Which type of meat do you want? (Chicken, Beef, Neither)");
        var choice = Console.ReadLine();
        switch (choice)
        {
            case "Chicken":
                this._customBurger.Add($"{choice.ToLower()} meat");
                break;
            case "Beef":
                this._customBurger.Add(choice.ToLower());
                break;
            case "Neither":
                this._customBurger.Add("without meat");
                break;
        }
    }

    public void AskForSauce()
    {
        Console.WriteLine("Which type of sauce do you want? (Hot, Sweet, Signature, Neither)");
        var choice = Console.ReadLine();
        switch (choice)
        {
            case "Hot":
                this._customBurger.Add($"{choice.ToLower()} sauce");
                break;
            case "Sweet":
                this._customBurger.Add($"{choice.ToLower()} sauce");
                break;
            case "Signature":
                this._customBurger.Add($"{choice.ToLower()} sauce");
                break;
            case "Neither":
                this._customBurger.Add("no sauce");
                break;
        }
    }

    public void AskForPremadeBurgers()
    {
        Console.WriteLine("Which type of pre-made burger do you want?(Cheeseburger, Hamburger, Signature burger)");
        var choice = Console.ReadLine();
        _premadeBurgers.premadeBurgers.TryGetValue(choice, out var burger);
        burger.ListParts();
    }

    public CustomBurger GetBurger()
    {
        var result = this._customBurger;

        this.Reset();

        return result;
    }
}