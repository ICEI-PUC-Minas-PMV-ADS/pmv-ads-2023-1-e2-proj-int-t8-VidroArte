using System.Data.SqlClient;
public static class DatabaseConnection
{
    //private static string connectionString = "Data Source=vidroarte.database.windows.net;Initial Catalog=vidroarte;User ID=vidroarte;Password='Jato@12345'";
    private static string connectionString = "Data Source=LAPTOP-B2EBJ1MT;Initial Catalog=vidroarte;Integrated Security=True";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}


