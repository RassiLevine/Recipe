using CPUFramework;
using System.Configuration;
using System.Data;
namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        public frmRecipe()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            gRecipe.CellDoubleClick += GRecipe_DoubleClick;
        }
        private void SearchForRecipe(string recipename)
        {
            string sql = "select * from recipe r where r.recipename like '%" + recipename + "%'";
            DataTable dt = SQLutility.GetDataTable(sql);
            gRecipe.DataSource = dt;
            gRecipe.Columns["RecipeId"].Visible = false;
            gRecipe.AllowUserToAddRows = false;
        }

        private void ShowDetailForm(int rowindex)
        {
            int id = (int)gRecipe.Rows[rowindex].Cells["RecipeId"].Value;
            frmPopup frm = new();
            frm.ShowForm(id);
        }
    
        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchForRecipe(txtName.Text);
        }
        private void GRecipe_DoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowDetailForm(e.RowIndex);
        }

    }
}
