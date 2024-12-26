using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using CPUFramework;
namespace RecipeSystem
{
    public class Recipe
    {
        public static DataTable LoadRecipe(int recipeid)
        {
            SqlCommand cmd = SQLutility.GetSqlCommand("RecipeGet");
            SQLutility.SetParamValue(cmd, "@RecipeId", recipeid);
            DataTable dt = SQLutility.GetDataTable(cmd);
            return dt;
        }
        public static DataTable LoadRecipeByCuisine(int cuisineid)
        {
            SqlCommand cmd = SQLutility.GetSqlCommand("CuisineRecipeGet");
            SQLutility.SetParamValue(cmd, "@CuisineId", cuisineid);
            DataTable dt = SQLutility.GetDataTable(cmd);
            return dt;
        }
        public static DataTable LoadRecipeStatus(int recipeid)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = SQLutility.GetSqlCommand("StatusGet");
            SQLutility.SetParamValue(cmd, "@RecipeId", recipeid);
            dt = SQLutility.GetDataTable(cmd);
            return dt;
        }
        public static void Save(DataTable dtrecipe) 
        {
            if (dtrecipe.Rows.Count == 0)
            {
                throw new Exception("cannot save recipe, there are no rows in datatable");
            }
            DataRow r = dtrecipe.Rows[0];
            SQLutility.SaveDataRow(r, "RecipeUpdate");
            
        }

        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            SqlCommand cmd = SQLutility.GetSqlCommand("RecipeDelete");
            SQLutility.SetParamValue(cmd, "@RecipeId", id);
            SQLutility.ExecuteSQL(cmd);
        }

        public static DataTable GetRecipeListDataTable()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLutility.GetSqlCommand("RecipeList");
            dt = SQLutility.GetDataTable(cmd);
            return dt;
        }

    }
}
