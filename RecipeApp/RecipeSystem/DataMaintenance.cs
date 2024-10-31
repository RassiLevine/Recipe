using CPUFramework;
using System.Data.SqlClient;
using System.Data;
namespace RecipeSystem
{
    public class DataMaintenance
    {
        public static DataTable GetDataList(string tablename, bool includeblank = false)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLutility.GetSqlCommand(tablename + "Get");
            SQLutility.SetParamValue(cmd, "@All", 1);
            if (includeblank == true)
            {
                SQLutility.SetParamValue(cmd, "@IncludeBlank", includeblank);
            }
            dt = SQLutility.GetDataTable(cmd); 
            return dt;
        }

        public static void SaveDataList(DataTable dt, string tablename)
        {
            SQLutility.SaveDataTable(dt, tablename + "Update");
        }
        public static void DeleteRow(string tablename, int id)
        {
            SqlCommand cmd = SQLutility.GetSqlCommand(tablename + "Delete");
            SQLutility.SetParamValue(cmd, $"@{tablename}Id", id);
            SQLutility.ExecuteSQL(cmd);
        }

        public static DataTable GetDashboard()
        {
            SqlCommand cmd = SQLutility.GetSqlCommand("DashboardGet");
            return SQLutility.GetDataTable(cmd);
        }
    }
}
