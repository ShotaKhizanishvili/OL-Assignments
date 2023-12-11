namespace Burger_Builder;

public interface IBurgerBuilder
{
    void AddCheese();
    void AddPickles();
    void AddMeat(string choice);
    void AddSauce(string choice);
    void GetPremadeBurger(string choice);
}