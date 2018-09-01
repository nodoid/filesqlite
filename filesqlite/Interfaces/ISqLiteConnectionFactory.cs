using SQLite;
namespace mvvmlight.Interfaces
{
    public interface ISqLiteConnectionFactory
    {
        SQLiteConnection GetConnection();
    }
}
