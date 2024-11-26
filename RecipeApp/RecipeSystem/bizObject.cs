using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class bizObject
    {
        string _tablename = "";
        string _getsproc = "";
        string _updatesproc = "";
        string _deletesproc = "";
        string _primarykeyname = "";
        string _primarykeyparamname = "";
        DataTable _datatable = new();
        

        public bizObject(string tablename)
        {
            _tablename = tablename;
            _getsproc = tablename + "Get";
            _updatesproc = tablename + "Update";
            _deletesproc = tablename + "Delete";
            _primarykeyname = tablename + "Id";
            _primarykeyparamname = "@" + _primarykeyname;
        }

        public  DataTable LoadRecipe(int recipeid)
        {
            SqlCommand cmd = SQLutility.GetSqlCommand(_getsproc);
            SQLutility.SetParamValue(cmd, _primarykeyparamname, recipeid);
            DataTable dt = SQLutility.GetDataTable(cmd);
            _datatable = dt;
            return dt;
        }

        public void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0][_primarykeyname];
            SqlCommand cmd = SQLutility.GetSqlCommand(_deletesproc);
            SQLutility.SetParamValue(cmd, _primarykeyparamname, id);
            SQLutility.ExecuteSQL(cmd);
        }

        public void Save(DataTable dtrecipe)
        {
            if (dtrecipe.Rows.Count == 0)
            {
                throw new Exception($"cannot save {_tablename}, there are no rows in datatable");
            }
            DataRow r = dtrecipe.Rows[0];
            SQLutility.SaveDataRow(r, _updatesproc);
        }
    }
}
