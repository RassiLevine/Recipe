using CPUFramework;
namespace RecipeSystem
{
    public class DBmanager
    {
        //public static void SetConnectionString(string connectionstring)
        //{
        //    SQLutility.ConnectionString = connectionstring;
        //}
        public static void SetConnectionString(string connectionstring, bool tryopen, string userid = "", string password = "")
        {
            SQLutility.SetConnectionString(connectionstring, tryopen, userid, password);
        }

    }
}
