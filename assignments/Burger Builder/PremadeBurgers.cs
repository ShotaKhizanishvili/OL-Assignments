namespace Burger_Builder;

public class PremadeBurgers : BurgerBase
{
    public Dictionary<string, BurgerBase> premadeBurgers = new Dictionary<string, BurgerBase>()
    {
        {
            "Cheeseburger",
            new BurgerBase(new List<string> { "bun", "melted cheese", "lettuce", "pickles", "hot sauce" })
        },
        {
            "Hamburger",
            new BurgerBase(new List<string> { "bun", "lettuce", "pickles", "beef", "sweet sauce" })
        },
        {
            "Signature Burger",
            new BurgerBase(new List<string> { "bun", "lettuce", "pickles", "chicken", "signature sauce" })
        }
    };
}