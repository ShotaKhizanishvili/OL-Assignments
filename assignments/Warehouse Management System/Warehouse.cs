namespace Warehouse_Management_System;

public static class Warehouse
{
    private static List<Product> _products = new List<Product>();

    public static void RegisterProduct(Product product)
    {
        if (Product.ProductValidation(product))
        {
            _products.Add(product);
        }
        else
        {
            Console.WriteLine($"The product u are trying to add failed validation.");
        }
    }

    public static void ChangeProductPrice(int number, double newPrice)
    {
        if (Product.PriceValidation(newPrice))
        {
            Console.WriteLine("New price can't be 0 or less than 0.");
        }
        else
        {
            _products[number - 1].PriceOfSingleUnit = newPrice;
        }
    }

    public static void ChangeProductQuantity(int number, int amount)
    {
        if (Product.QuantityValidation(amount))
        {
            Console.WriteLine("Amount can't be 0 or less than 0.");
        }
        else
        {
            _products[number - 1].Quantity += amount;
        }
    }

    public static void DeleteProduct(int number)
    {
        _products.RemoveAt(number - 1);
    }

    public static List<Product> ListAllProduct()
    {
        return _products;
    }

    public static void PrintAllProducts()
    {
        for (int i = 0; i < _products.Count; i++)
        {
            Console.WriteLine($"{i + 1}. Name:{_products[i].Name},Category:{_products[i].Category}," +
                              $"Price:{_products[i].PriceOfSingleUnit}$,Quantity:{_products[i].Quantity}");
        }
    }
}