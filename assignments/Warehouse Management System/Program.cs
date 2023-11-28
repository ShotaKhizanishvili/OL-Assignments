using Warehouse_Management_System;

do
{
    Console.WriteLine("1.Product registration in the warehouse\n" +
                      "2.Change the quantity of registered products\n" +
                      "3.Change the price of registered products\n" +
                      "4.Remove Registered Product\n" +
                      "5.List all products");

    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            RegisterNewProduct();
            break;
        case "2":
            Warehouse.PrintAllProducts();
            ChangeQuantity();
            break;
        case "3":
            Warehouse.PrintAllProducts();
            ChangePrice();
            break;
        case "4":
            Warehouse.PrintAllProducts();
            RemoveProduct();
            break;
        case "5":
            Warehouse.PrintAllProducts();
            break;
        default:
            Console.WriteLine("Wrong input,enter number from 1 to 5");
            break;
    }
} while (true);

#region HelperMethods

void RegisterNewProduct()
{
    Console.WriteLine("Enter Product Properties\n" +
                      "Name, Price of a single unit, Quantity (separated by commas)");
    var input = Console.ReadLine();
    var properties = new List<string>(input.Split(','));
    Console.WriteLine("Select Category\n" +
                      "1.Food,\n2.Tech,\n3.SportsEquipment,\n4.Book,\n5.Other");
    properties.Add(Console.ReadLine());

    var product = new Product(properties[0], Convert.ToDouble(properties[1])
        , Convert.ToInt32(properties[2]), Convert.ToInt32(properties[3]));
    Warehouse.RegisterProduct(product);
    Console.WriteLine("Product added.");
}

void RemoveProduct()
{
    Console.WriteLine("Which product do you want to remove?(enter number)");
    var number = Console.ReadLine();
    Warehouse.DeleteProduct(Convert.ToInt32(number));
}

void ChangeQuantity()
{
    Console.Write("Enter product number and amount to add(separated by comma):");
    var input = Console.ReadLine();
    var inputArr = input.Split(',');
    Warehouse.ChangeProductQuantity(Convert.ToInt32(inputArr[0]), Convert.ToInt32(inputArr[1]));
}

void ChangePrice()
{
    Console.Write("Enter product number and price(separated by comma):");
    var input = Console.ReadLine();
    var inputArr = input.Split(',');
    Warehouse.ChangeProductPrice(Convert.ToInt32(inputArr[0]), Convert.ToInt32(inputArr[1]));
}

#endregion