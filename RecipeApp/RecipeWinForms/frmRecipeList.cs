using CPUFramework;
using CPUWindowsFormFramework;
using System.Data;
using System.Data.SqlClient;

namespace RecipeWinForms
{
    public partial class frmRecipeList : Form
    {
        public frmRecipeList()
        {
            InitializeComponent();
            BindData();
            btnNewRecipe.Click += BtnNewRecipe_Click;
            gData.CellContentClick += GData_CellContentClick;
        }

        private void BindData()
        {
            SqlCommand cmd = SQLutility.GetSqlCommand("RecipeList");
            DataTable dt = SQLutility.GetDataTable(cmd);
            gData.DataSource = dt;
            WindowsFormsUtility.FormatGridForSearchResults(gData, "Recipe");
        }
        private void RefreshData()
        {
            BindData();
        }
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            RefreshData();
        }
        private void ShowDetailForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gData, rowindex, "RecipeId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmPopup), id);
            }

        }

        private void BtnNewRecipe_Click(object? sender, EventArgs e)
        {
            ShowDetailForm(-1);  
        }

        private void GData_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowDetailForm(e.RowIndex);
        }


    }
}
