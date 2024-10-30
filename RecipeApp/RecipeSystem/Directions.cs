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

        public static void SaveTable(DataTable dt, int directionid, int recipeid)
        {

            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            {int id = WindowsFormsUtility.GetIdFromGrid(gData, rowindex, currenttabletype.ToString() + "Id");
                r["DirectionsId"] = directionid;
                r["RecipeId"] = recipeid;
            }
            SQLutility.SaveDataTable(dt, "DirectionsUpdate");
        }

        public static void DeleteDirectionChild(int directionsid)
        {
            SqlCommand cmd = SQLutility.GetSqlCommand("DirectionsDelete");
            cmd.Parameters["@DirectionsId"].Value = directionsid;
            SQLutility.ExecuteSQL(cmd);
        }
    }
}
