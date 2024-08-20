using CPUFramework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class Directions
    {
        public static DataTable LoadByRecipeId(int recipeid)
        {
            SqlCommand cmd = SQLutility.GetSqlCommand("DirectionsGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            DataTable dt = SQLutility.GetDataTable(cmd);

            return dt;
        }
    }
}
