namespace Burger_Builder;

public class BurgerBuilder : IBurgerBuilder
{
    private Burger _burger = new Burger();

    public BurgerBuilder()
    {
        Reset();
    }

    private void Reset()
    {
        _burger = new Burger();
    }

    public void AddCheese()
    {
        _burger.Add("melted cheese");
    }

    public void AddPickles()
    {
        _burger.Add("pickles");
    }

    public void AddMeat(string choice)
    {
        switch (choice)
        {
            case "Chicken":
                _burger.Add($"{choice.ToLower()} meat");
                break;
            case "Beef":
                _burger.Add(choice.ToLower());
                break;
            case "Neither":
                _burger.Add("without meat");
                break;
        }
    }

    public void AddSauce(string choice)
    {
        switch (choice)
        {
            case "Hot":
                _burger.Add($"{choice.ToLower()} sauce");
                break;
            case "Sweet":
                _burger.Add($"{choice.ToLower()} sauce");
                break;
            case "Signature":
                _burger.Add($"{choice.ToLower()} sauce");
                break;
            case "Neither":
                _burger.Add("no sauce");
                break;
        }
    }

    public void GetPremadeBurger(string choice)
    {
        switch (choice)
        {
            case "Cheeseburger":
                _burger.GetCheeseBurger();
                break;
            case "Hamburger":
                _burger.GetHamburger();
                break;
            case "Signature burger":
                _burger.GetSignatureBurger();
                break;
        }
    }

    public Burger GetBurger()
    {
        var result = _burger;

        Reset();

        return result;
    }
}