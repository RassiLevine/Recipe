using CPUFramework;
using System.Configuration;
using System.Data;
using RecipeSystem;
namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        public frmRecipe()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            btnNew.Click += BtnNew_Click;
            gRecipe.CellDoubleClick += GRecipe_DoubleClick;
        }

        private void SearchForRecipe(string recipename)
        {
            DataTable dt = Recipe.Search(recipename);
            gRecipe.DataSource = dt;
            gRecipe.Columns["RecipeId"].Visible = false;
            gRecipe.AllowUserToAddRows = false;
        }

        private void ShowDetailForm(int rowindex)
        {
            int id = 0;
            if(rowindex > -1)
            {
                id = (int)gRecipe.Rows[rowindex].Cells["RecipeId"].Value;
            }
            frmPopup frm = new();
            frm.ShowForm(id);
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmPopup), id);
            }

        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchForRecipe(txtName.Text);
        }


        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowDetailForm(-1);
        }
        private void GRecipe_DoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowDetailForm(e.RowIndex);
        }

    }
}
