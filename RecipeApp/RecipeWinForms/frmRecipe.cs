using CPUWindowsFormFramework;
namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        public frmRecipe()
        {
            InitializeComponent();
            btnNew.Click += BtnNew_Click;
            gRecipe.CellDoubleClick += GRecipe_DoubleClick;
        }

        private void ShowDetailForm(int rowindex)
        {
            int id = 0;
            if(rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gRecipe, rowindex, "RecipeId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmPopup), id);
            }

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
