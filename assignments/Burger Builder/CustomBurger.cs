namespace Burger_Builder;

public class CustomBurger : BurgerBase
{
    public void Add(string part)
    {
        this.Parts.Add(part);
    }
}