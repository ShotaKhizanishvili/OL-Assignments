using Dapper;
using Inventory_Management_System;
using Microsoft.Data.SqlClient;

var connectionString =
    "Server=DESKTOP-B96J4A8;Database=Inventory;Integrated Security=SSPI;Trusted_Connection=True;TrustServerCertificate=True";

await using var connection = new SqlConnection(connectionString);

await SeedCategoriesData(connection);

do
{
    Console.WriteLine("1. Perform CRUD operations on Products and Sales tables.\n" +
                      "2. Search for products by name.\n" +
                      "3. Filter sales by product.\n" +
                      "4. Total sales amount.\n" +
                      "5. Sales per product (quantity and total amount).\n" +
                      "6. Exit");
    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            {
                await PerformCrudOperations(connection);
                break;
            }
        case "2":
            {
                var products = await SearchProductByName(connection);
                PrintProducts(products);
                break;
            }
        case "3":
            {
                var sales = await FilterSalesByProductId(connection);
                PrintSales(sales);
                break;
            }
        case "4":
            {
                await CountTotalSales(connection);
                break;
            }
        case "5":
            {
                var salesInfo = await SalesPerProduct(connection);
                PrintSalesInfo(salesInfo);
                break;
            }
        case "6":
            {
                Console.WriteLine("Exiting application...");
                return;
            }
        default:
            {
                Console.WriteLine("Invalid operation, try again.");
                break;
            }
    }
} while (true);

static async Task SeedCategoriesData(SqlConnection sqlConnection)
{
    var countCategories = "select count(*) as RowsCount\nfrom Categories;";
    var categoriesCount = await sqlConnection.QueryFirstOrDefaultAsync<int>(countCategories);
    if (categoriesCount == 0)
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
        await sqlConnection.ExecuteAsync(query);
    }
}

#region CRUD operations on Products and Sales Tables

static async Task<List<Sale>> FilterSalesByProductId(SqlConnection sqlConnection)
{
    Console.WriteLine("Enter ProductId you want to select: ");
    var productId = Console.ReadLine();

    var query = "select * from Sales where ProductId = @ProductId";
    var sales = await sqlConnection.QueryAsync<Sale>(query, new { ProductId = productId });

    return sales.ToList();
}

static async Task<List<SalesInfo>> SalesPerProduct(SqlConnection sqlConnection)
{
    var query = "select P.Id as ProductId, P.Name as ProductName," +
                "S.Quantity, S.Quantity * P.Price as TotalAmount from Sales S\n" +
                "join Products P on S.ProductId = P.Id";
    var salesInfo = await sqlConnection.QueryAsync<SalesInfo>(query);

    return salesInfo.ToList();
}

static async Task CountTotalSales(SqlConnection sqlConnection)
{
    var query = "select count(*) as SalesCount\nfrom Sales";
    var amount = await sqlConnection.QueryFirstOrDefaultAsync<int>(query);

    Console.WriteLine($"Total Sales amount is {amount}");
}

static async Task<List<Product>> SearchProductByName(SqlConnection sqlConnection)
{
    Console.WriteLine("Enter name of product: ");
    var name = Console.ReadLine();

    var query = "select * from Products\n" +
                "where Name = @Name";
    var products = await sqlConnection.QueryAsync<Product>(query, new { Name = name });

    return products.ToList();
}

static async Task InsertProduct(SqlConnection sqlConnection, Product product)
{
    var query = "insert into Products(Name, Price, Stock, CategoryId)\n" +
                "values(@Name, @Price, @Stock, @CategoryId);";
    await sqlConnection.ExecuteAsync(query,
        new { product.Name, product.Price, product.Stock, product.CategoryId });
}

static async Task<List<Product>> SelectAllProducts(SqlConnection sqlConnection)
{
    var query = "select * from Products";
    var products = await sqlConnection.QueryAsync<Product>(query);
    return products.ToList();
}

static async Task UpdateProductById(SqlConnection sqlConnection, Product product)
{
    Console.Write("Enter Id of an entity you want to update: ");
    var id = Convert.ToInt32(Console.ReadLine());
    var queryUpdateProduct =
        "update Products\n    set Name = @Name, Price = @Price, Stock = @Stock, CategoryId = @CategoryId\n" +
        "where Id = @Id;";
    await sqlConnection.ExecuteAsync(queryUpdateProduct,
        new { product.Name, product.Price, product.Stock, product.CategoryId, id });
}

static async Task DeleteProductById(SqlConnection sqlConnection)
{
    Console.Write("Enter Id of an entity you want to delete: ");
    var id = Convert.ToInt32(Console.ReadLine());

    var query = "delete from Products where Id = @Id";
    await sqlConnection.ExecuteAsync(query, new { Id = id });
}

static async Task InsertSale(SqlConnection sqlConnection, Sale sale)
{
    var query = $"insert into Sales(ProductId, Quantity, SaleDate)" +
                $" values(@ProductId, @Quantity, @SaleDate);";
    await sqlConnection.ExecuteAsync(query, new { sale.ProductId, sale.Quantity, sale.SaleDate });
}

static async Task<List<Sale>> SelectAllSales(SqlConnection sqlConnection)
{
    var query = "select * from Sales;";
    var sales = await sqlConnection.QueryAsync<Sale>(query);
    return sales.ToList();
}

static async Task UpdateSaleById(SqlConnection sqlConnection)
{
    Console.WriteLine("Enter Id of an entity you want to update: ");
    var id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Quantity: ");
    var quantity = Convert.ToInt32(Console.ReadLine());
    var query = "update Sales\n" +
                "set Quantity = @Quantity\n" +
                "where id = @Id;";
    await sqlConnection.ExecuteAsync(query, new { Quantity = quantity, Id = id });
}

static async Task DeleteSaleById(SqlConnection sqlConnection)
{
    Console.Write("Enter Id of an entity you want to delete: ");
    var id = Convert.ToInt32(Console.ReadLine());

    var query = "delete from Sales where id = @Id";
    await sqlConnection.ExecuteAsync(query, new { Id = id });
}

#endregion

#region InputGetters

static Product GetProductInput()
{
    Console.WriteLine("Enter product's properties (Name, Price, Stock, CategoryId) separated with comma: ");
    var input = Console.ReadLine();

    if (input != null)
    {
        var inputParts = input.Split(',');
        var name = inputParts[0].Trim();
        var price = Convert.ToDecimal(inputParts[1].Trim());
        var stock = Convert.ToInt32(inputParts[2].Trim());
        var categoryId = Convert.ToInt32(inputParts[3].Trim());

        return new Product(name, price, stock, categoryId);
    }

    throw new ArgumentNullException(input, "Input can't be empty.");
}

static Sale GetSaleInput()
{
    Console.WriteLine("Enter sale's properties (ProductId, Quantity, SaleDate) separated with comma: ");
    var input = Console.ReadLine();

    if (input != null)
    {
        var inputParts = input.Split(',');
        var productId = Convert.ToInt32(inputParts[0]);
        var quantity = Convert.ToInt32(inputParts[1]);
        var saleDate = Convert.ToDateTime(inputParts[2]);

        return new Sale(productId, quantity, saleDate);
    }

    throw new ArgumentNullException(input, "Input can't be empty.");
}

#endregion

static async Task PerformCrudOperations(SqlConnection sqlConnection)
{
    Console.WriteLine("1. Create product.\n" +
                      "2. Print all products\n" +
                      "3. Update product by Id\n" +
                      "4. Delete product by Id\n" +
                      "5. Create sale\n" +
                      "6. Print all sales\n" +
                      "7. Update sale by Id\n" +
                      "8. Delete sale by Id\n");
    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            {
                await InsertProduct(sqlConnection, GetProductInput());
                break;
            }
        case "2":
            {
                var products = await SelectAllProducts(sqlConnection);
                PrintProducts(products);
                break;
            }
        case "3":
            {
                await UpdateProductById(sqlConnection, GetProductInput());
                break;
            }
        case "4":
            {
                await DeleteProductById(sqlConnection);
                break;
            }
        case "5":
            {
                await InsertSale(sqlConnection, GetSaleInput());
                break;
            }
        case "6":
            {
                var sales = await SelectAllSales(sqlConnection);
                PrintSales(sales);
                break;
            }
        case "7":
            {
                await UpdateSaleById(sqlConnection);
                break;
            }
        case "8":
            {
                await DeleteSaleById(sqlConnection);
                break;
            }

        default:
            {
                Console.WriteLine("Invalid operation, try again.");
                break;
            }
    }
}

#region PrintMethods

static void PrintSalesInfo(List<SalesInfo> salesInfo)
{
    foreach (var sale in salesInfo)
    {
        Console.WriteLine(
            $"ProductId: {sale.ProductId}, ProductName: {sale.ProductName}, Quantity: {sale.Quantity}, TotalAmount: {sale.TotalAmount}");
    }
}

static void PrintProducts(List<Product> products)
{
    foreach (var product in products)
    {
        Console.WriteLine(
            $"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}$, Stock: {product.Stock}, CategoryId: {product.CategoryId}");
    }
}

static void PrintSales(List<Sale> sales)
{
    foreach (var sale in sales)
    {
        Console.WriteLine(
            $"Id: {sale.Id}, ProductId: {sale.ProductId}, Quantity: {sale.Quantity}, SaleDate: {sale.SaleDate}");
    }
}

#endregion