using CPUFramework;
using CPUWindowsFormFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            this.Activated += FrmDashboard_Activated;

        }

        //private void BindData()
        //{
        //    SqlCommand cmd = SQLutility.GetSqlCommand("GetDashboard");
        //    DataTable dt = SQLutility.GetDataTable(cmd);
        //    gData.DataSource = dt;
        //}

        private void ShowForm()
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeList));
            }
        }
        private void GData_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowForm();
        }

        private void FrmDashboard_Activated(object? sender, EventArgs e)
        {
            //BindData();
        }
    }
}
