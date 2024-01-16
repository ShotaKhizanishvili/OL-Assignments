using Microsoft.Data.SqlClient;
using Dapper;
using Inventory_Management_System;

var connectionSring = "Server=LAPTOP-7R94G6ML;Database=Inventory;Integrated Security=SSPI;Trusted_Connection=True;TrustServerCertificate=True";

await using var connection = new SqlConnection(connectionSring);

var selectAllCategories = "select * from Categories";
var categories = await connection.QueryAsync<Categories>(selectAllCategories);
if (categories.Count() == 0)
{
    var query = "insert into Categories(Name, Description) " +
    "values('Electronics', 'Devices and gadgets like smartphones, laptops, and cameras.')," +
    "('Clothing','Apparel items including shirts, pants, and accessories.')," +
    "('Home Appliances','Household appliances like refrigerators, microwaves, and washing machines.')," +
    "('Books','Various genres of books, including fiction, non-fiction, and academic.')," +
    "('Sports & Fitness','Equipment and accessories for sports and fitness activities.')," +
    "('Groceries','Everyday items including food, beverages, and household essentials.')," +
    "('Health & Beauty','Products for personal care, wellness, and beauty.')," +
    "('Toys & Games','Children’s toys and games for all ages.')," +
    "('Automotive','Automobile accessories and car care products.');";
    await connection.ExecuteAsync(query);
}
var queryInsertProduct = "insert into Products(Name, Price, Stock, CategoryId)\n" +
        "values('PC', '1500', 5, 1);";
await connection.ExecuteAsync(queryInsertProduct);

var querySelectAllProducts = "select * from Products";
var products  = await connection.QueryAsync<Product>(querySelectAllProducts);
Console.WriteLine("Printing all products...");
foreach(var product in products)
{
    Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
}
// Search for products by name
Console.WriteLine("Searching for product named - PC");
var foundProduct = products.FirstOrDefault(x => x.Name == "PC");
Console.WriteLine($"Id: {foundProduct.Id}, Name: {foundProduct.Name}, Price: {foundProduct.Price}, Stock: {foundProduct.Stock}");

var queryUpdateProduct = "update Products\n" +
    "set Name = Laptop, Price = 2000, 6\n" +
    "where Id = 1";
await connection.ExecuteAsync(queryUpdateProduct);

//var queryDeleteProduct = "delete from Products where id = 1;";
//await connection.ExecuteAsync(queryDeleteProduct);

var queryInsertSale = $"insert into Sales(ProductId, Quantity, SaleDate)" +
    $" values(1, 3, {DateTime.Now});";
await connection.ExecuteAsync(queryInsertSale);

var queryUpdateSale = "update Sales\n" +
    "set Quantity = 5\n" +
    "where id = 1;";

//var queryDeleteSale = "delete from Sales where Id = 1";
//await connection.ExecuteAsync(queryDeleteSale);

var querySelectAllSales = "select * from Sales;";
var sales = await connection.QueryAsync<Sale>(querySelectAllSales);
Console.WriteLine("Printing Sales...");
foreach(var sale in sales)
{
    Console.WriteLine($"Id:{sale.Id}, ProductId:{sale.ProductId}, Quantity:{sale.Quantity}, SaleDate:{sale.SaleDate}");
}

Console.WriteLine($"Total sales count is {sales.Count()}");



return;