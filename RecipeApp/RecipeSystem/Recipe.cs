using System.Data;
using System.Data.SqlClient;
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
            return SQLutility.GetDataTable("select cuisineid, cuisinetype from cuisine");
        }

        public static DataTable GetStaffList()
        {
            return SQLutility.GetDataTable("select * from staff");
        }

        public static DataTable LoadRecipe(int recipeid)
        {
            string sql = "select r.*, c.cuisineid, s.staffid from recipe r join cuisine c on r.cuisineid = c.cuisineid join staff s on r.staffid = s.staffid where r.RecipeId =" + recipeid.ToString();
            return SQLutility.GetDataTable(sql);
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
            SQLutility.SetParamValue(cmd, "@Recipeid", id);
            SQLutility.ExecuteSQL(cmd);
        }
    }
}
