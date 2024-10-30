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

        public static void SaveTable(DataTable dt, int recipeid, int recipeingredientid)
        {
            
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            {
                r["RecipeId"] = recipeid;
                r["RecipeIngredientId"] = recipeingredientid; 
            }
            SQLutility.SaveDataTable(dt, "RecipeIngredientUpdate");
        }

        public static void DeleteIngredientChild(int recipeingredientid)
        {
            SqlCommand cmd = SQLutility.GetSqlCommand("RecipeIngredientDelete");
            cmd.Parameters["@RecipeIngredientId"].Value = recipeingredientid;
            SQLutility.ExecuteSQL(cmd);
        }
    }
}
