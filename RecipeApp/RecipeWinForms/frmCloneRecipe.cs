using CPUFramework;
using CPUWindowsFormFramework;
using RecipeSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmCloneRecipe : Form
    {
        BindingSource bindsource = new BindingSource();
        DataTable dtrecipename = new DataTable();
        public frmCloneRecipe()
        {
            InitializeComponent();
            BindData();
            btnCloneRecipe.Click += BtnCloneRecipe_Click;
        }

        private void BindData()
        {

            dtrecipename = DataMaintenance.GetDataList("Recipe");
            bindsource.DataSource = dtrecipename;
            DataTable dt = DataMaintenance.GetDataList("Recipe");
            WindowsFormsUtility.SetListBinding(drpdwnRecipeName, dtrecipename, dt, "Recipe");
        }

        private void Clone()
        {
            int id = WindowsFormsUtility.GetIdFromComboBox(drpdwnRecipeName);
            SqlCommand cmd = SQLutility.GetSqlCommand("CloneRecipe");
            SQLutility.SetParamValue(cmd, "@RecipeId", id);
            DataTable dt = SQLutility.GetDataTable(cmd);
            MessageBox.Show("Recipe has been cloned.");
        }
        private void BtnCloneRecipe_Click(object? sender, EventArgs e)
        {
            Clone();
        }
    }
}
