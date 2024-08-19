using CPUFramework;
using System.Data.SqlClient;
using System.Data;

namespace RecipeWinForms
{
    public class Ingredients
    {

        public static DataTable LoadByRecipeId(int recipeid)
        {
            SqlCommand cmd = SQLutility.GetSqlCommand("RecipeIngredientsGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            DataTable dt = SQLutility.GetDataTable(cmd);

            return dt;
        }

        public static void SaveTable(DataTable dt, int recipeingredientid)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            {
                r["RecipeIngredientId"] = recipeingredientid;
            }
            SQLutility.SaveDataTable(dt, "IngredientUpdate");
        }
        

        //public static void Delete(int medalpresidentid)
        //{
        //    SqlCommand cmd = SQLutility.GetSqlCommand("PresidentMedalDelete");
        //    cmd.Parameters["@MedalPresidentId"].Value = medalpresidentid;
        //    SQLutility.ExecuteSQL(cmd);
        //}
    }
}
