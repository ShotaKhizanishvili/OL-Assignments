namespace Burger_Builder;

public class BurgerBase
{
    protected List<string> Parts = new List<string>() { "bun", "lettuce" };

    public BurgerBase()
    {
    }

    public BurgerBase(List<string> parts)
    {
        Parts = parts;
    }

    public virtual string ListParts()
    {
        string str = String.Empty;
        for (int i = 0; i < this.Parts.Count; i++)
        {
            str += this.Parts[i] + ", ";
        }

        str = str.Remove(str.Length - 2);

        return "You ordered a burger with the following ingredients: " + str + "\n";
    }
}