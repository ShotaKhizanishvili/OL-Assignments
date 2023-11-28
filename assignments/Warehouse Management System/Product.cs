namespace Warehouse_Management_System;

public class Product
{
    public string Name { get; set; }
    public Category Category { get; set; }
    public double PriceOfSingleUnit { get; set; }
    public int Quantity { get; set; }

    public Product(string name, double priceOfSingleUnit, int quantity, int category)
    {
        this.Name = name;
        this.PriceOfSingleUnit = priceOfSingleUnit;
        this.Quantity = quantity;
        this.Category = (Category)category;
    }


    #region Validations

    public static bool ProductValidation(Product product)
    {
        return ProductNameValidation(product)
               && ProductCategoryValidation(product)
               && PriceValidation(product.PriceOfSingleUnit)
               && QuantityValidation(product.Quantity);
    }

    public static bool ProductNameValidation(Product product)
    {
        if (product.Name == String.Empty)
        {
            return false;
        }

        if (product.Name.StartsWith(@"^\d"))
        {
            return false;
        }

        if (product.Name.Contains(' '))
        {
            return false;
        }

        if (product.Name.Length > 50)
        {
            return false;
        }

        if (Warehouse.ListAllProduct().Any(a => a.Name == product.Name))
        {
            return false;
        }

        return true;
    }

    public static bool ProductCategoryValidation(Product product)
    {
        if (product.Category == Category.None)
        {
            return false;
        }

        return true;
    }

    public static bool PriceValidation(double price)
    {
        if (price <= 0)
        {
            return false;
        }

        return true;
    }

    public static bool QuantityValidation(int quantity)
    {
        if (quantity < 0)
        {
            return false;
        }

        return true;
    }

    #endregion
}

public enum Category
{
    None,
    Food,
    Tech,
    SportsEquipment,
    Book,
    Other
}