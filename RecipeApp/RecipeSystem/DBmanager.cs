using CPUFramework;
namespace RecipeSystem
{
    public class DBmanager
    {
        public static void SetConnectionString(string connectionstring)
        {
            SQLutility.ConnectionString = connectionstring;
        }
    }
}
