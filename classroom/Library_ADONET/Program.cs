using System.Data;
using Microsoft.Data.SqlClient;

var connectionString = "Server=DESKTOP-B96J4A8; Database=Library; Integrated Security=SSPI; TrustServerCertificate=True;";
    

await using var connection = new SqlConnection(connectionString);

await connection.OpenAsync();

var command = connection.CreateCommand();
command.CommandType = CommandType.Text;
command.CommandText = "select BookId, Title, AuthorId, YearPublished from Books where YearPublished>@YearPublished";
command.Parameters.AddWithValue("@YearPublished", 2003);

await using var reader = await command.ExecuteReaderAsync();
while (await reader.ReadAsync())
{
    Console.WriteLine($"BookId: {reader["BookId"]}, Title: {reader["Title"]}," +
                      $" AuthorId: {reader["AuthorId"]}, YearPublished: {reader["YearPublished"]}");
}

await connection.CloseAsync();

await connection.OpenAsync();

await using var insertConnection = new SqlConnection(connectionString);
var insertCommand = connection.CreateCommand();
insertCommand.CommandType = CommandType.Text;
insertCommand.CommandText = "insert into Books(Title,AuthorId,YearPublished)" +
                            "values(@Title, @AuthorId, @YearPublished)";
insertCommand.Parameters.AddWithValue("@Title", "BookTitle1234");
insertCommand.Parameters.AddWithValue("@AuthorId", 1);
insertCommand.Parameters.AddWithValue("@YearPublished", 1990);

await using var insertReader = await insertCommand.ExecuteReaderAsync();

await connection.CloseAsync();