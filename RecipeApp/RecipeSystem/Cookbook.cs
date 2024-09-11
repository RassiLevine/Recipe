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
            //DataTable dt = new DataTable();
            //SqlCommand cmd = SQLutility.GetSqlCommand("CookbookRecipeGet");
            //SQLutility.SetParamValue(cmd, "@CookbookId", cookbookid);
            //dt = SQLutility.GetDataTable(cmd);
            //return dt;

            SqlCommand cmd = SQLutility.GetSqlCommand("CookbookRecipeGet");
            cmd.Parameters["@CookbookId"].Value = cookbookid;
            DataTable dt = SQLutility.GetDataTable(cmd);
            return dt;

        }
    
        public static void Save(DataTable dtcookbook)
        {
            if (dtcookbook.Rows.Count == 0)
            {
                throw new Exception("cannot save cookbook, there are no rows in datatable");
            }
            DataRow r = dtcookbook.Rows[0];
            SQLutility.SaveDataRow(r, "CookbookUpdate");
        }

        public static void Delete(DataTable dtcookbook)
        {
            int id = (int)dtcookbook.Rows[0]["CookbookId"];
            SqlCommand cmd = SQLutility.GetSqlCommand("CookbookDelete");
            SQLutility.SetParamValue(cmd, "@CookbookId", id);
            SQLutility.ExecuteSQL(cmd);
        }
        public static void DeleteChild(int cookbookrecipeid)
        {
            SqlCommand cmd = SQLutility.GetSqlCommand("CookbookRecipeDelete");
            cmd.Parameters["@CookbookRecipeId"].Value = cookbookrecipeid;
            SQLutility.ExecuteSQL(cmd);
        }
    }
}
