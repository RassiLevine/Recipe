using CPUFramework;
using System.Data;
using System.Data.SqlClient;

namespace RecipeSystem
{
    public class Cookbook
    {

        public static DataTable LoadCookbook(int cookbookid)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = SQLutility.GetSqlCommand("CookbookGet"); 
            SQLutility.SetParamValue(cmd, "@CookbookId", cookbookid);
            dt = SQLutility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable LoadCookbookRecipe(int cookbookid)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = SQLutility.GetSqlCommand("CookbookRecipeGet");
            SQLutility.SetParamValue(cmd, "@CookbookId", cookbookid);
            dt = SQLutility.GetDataTable(cmd);
            return dt;

        }
    }
}
