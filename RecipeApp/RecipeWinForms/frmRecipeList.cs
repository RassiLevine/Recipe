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
    public partial class frmRecipeList : Form
    {
        public frmRecipeList()
        {
            InitializeComponent();
            BindData();
            btnNewRecipe.Click += BtnNewRecipe_Click;
        }

        private void BindData()
        {
            SqlCommand cmd = SQLutility.GetSqlCommand("RecipeList");
            DataTable dt = SQLutility.GetDataTable(cmd);
            gData.DataSource = dt;
            WindowsFormsUtility.FormatGridForSearchResults(gData, "Recipe");
        }
        private void ShowDetailForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = (int)gData.Rows[rowindex].Cells["RecipeId"].Value;
            }
            frmPopup frm = new();
            frm.ShowForm(id);
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmPopup), id);
            }

        }

        private void BtnNewRecipe_Click(object? sender, EventArgs e)
        {
            ShowDetailForm(-1);  
        }


    }
}
