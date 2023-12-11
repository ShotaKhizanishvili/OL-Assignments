namespace Burger_Builder;

public class Burger
{
    private List<string> _parts = new List<string> { "bun", "lettuce" };

    public void Add(string part)
    {
        _parts.Add(part);
    }

    public void GetCheeseBurger()
    {
        _parts.AddRange(new List<string>() { "melted cheese", "pickles", "Hot sauce" });
    }

    public void GetHamburger()
    {
        _parts.AddRange(new List<string>() { "pickles", "beef", "sweet sauce" });
    }

    public void GetSignatureBurger()
    {
        _parts.AddRange(new List<string>() { "pickles", "chicken meat", "signature sauce" });
    }

    public string ListParts()
    {
        string str = String.Empty;
        for (int i = 0; i < _parts.Count; i++)
        {
            str += _parts[i] + ", ";
        }

        str = str.Remove(str.Length - 2);

        return "You ordered a burger with the following ingredients: " + str + "\n";
    }
}