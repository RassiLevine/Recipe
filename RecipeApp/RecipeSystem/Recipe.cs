using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using CPUFramework;
namespace RecipeSystem
{
    public class Recipe
    {
        public static DataTable Search(string recipename)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLutility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@RecipeName"].Value = recipename;
            dt = SQLutility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetCuisineList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLutility.GetSqlCommand("CuisineGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLutility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetStaffList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLutility.GetSqlCommand("StaffGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLutility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable LoadRecipe(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLutility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLutility.GetDataTable(cmd);
            return dt;
        }

        public static void Save(DataTable dtrecipe)
        {
            //SQLutility.DebugPrintDataTable(dtrecipe);
            DataRow r = dtrecipe.Rows[0];
            int id = (int)r["RecipeId"];
            string sql = "";

            if (id > 0)
            {
                sql = string.Join(Environment.NewLine,
                    $"update recipe set",
                    $"RecipeName = '{r["RecipeName"]}',",
                    $"Calories = '{r["Calories"]}',",
                    $"DateDraft = '{r["DateDraft"]}',",
                    $"CuisineId = '{r["CuisineId"]}',",
                    $"StaffId = '{r["StaffId"]}'",
                    $"where RecipeId = '{r["RecipeId"]}'"
                    );
            }
            else
            {
                sql = "insert recipe(CuisineId, StaffId, RecipeName, Calories,  DateDraft)";
                sql += $"select '{r["CuisineId"]}', '{r["StaffId"]}', '{r["RecipeName"]}', '{r["Calories"]}', '{r["DateDraft"]}'";
            }
            //Debug.Print(sql);
            SQLutility.ExecuteSQL(sql);
        }

        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            string sql = "delete recipe where RecipeId = " + id;
            SQLutility.ExecuteSQL(sql);
        }
    }
}
