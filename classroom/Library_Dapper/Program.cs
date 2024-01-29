using Dapper;
using Microsoft.Data.SqlClient;

var connectionString =
    "Server=DESKTOP-B96J4A8; Database=Library; Integrated Security=SSPI; TrustServerCertificate=True;";

await using var connection = new SqlConnection(connectionString);

var query = "select BookId, Title, AuthorId, YearPublished from Books where YearPublished>@YearPublished";
var products = await connection.QueryAsync(query, new { YearPublished = 2003 });
foreach (var product in products)
{
    Console.WriteLine(
        $"BookId: {product.BookId}, Title: {product.Title}, AuthorId: {product.AuthorId}, YearPublished: {product.YearPublished}");
}

var insertQuery = "insert into Books(Title,AuthorId,YearPublished)" +
                  "values(@Title, @AuthorId, @YearPublished)";
await connection.ExecuteAsync(insertQuery, new { Title = "bookfromdapper", AuthorId = 2, YearPublished = 2020 });