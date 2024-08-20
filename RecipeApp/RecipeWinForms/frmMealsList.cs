using CPUFramework;
using CPUWindowsFormFramework;
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
    public partial class frmMealsList : Form
    {
        public frmMealsList()
        {
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            SqlCommand cmd = SQLutility.GetSqlCommand("MealsList");
            DataTable dt = SQLutility.GetDataTable(cmd);
            gMeals.DataSource = dt;
            WindowsFormsUtility.FormatGridForSearchResults(gMeals, "Meals");
        }
    }
}
