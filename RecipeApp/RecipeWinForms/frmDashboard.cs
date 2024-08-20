using RecipeSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            this.Activated += FrmDashboard_Activated;
            btnRecipeList.Click += BtnRecipeList_Click;
            btnCookbookList.Click += BtnCookbookList_Click;
            btnMealList.Click += BtnMealList_Click;

        }

        private void SetDashboardLabels(string numtype, Label lbl)
        {
            DataTable dt = DataMaintenance.GetDashboard();
            var rows = dt.Select($"Type = '{numtype}'");
            if(rows.Length > 0)
            {
                lbl.Text = rows[0]["Number"].ToString();
            }
        }

        private void ShowRecipeForm()
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeList));
            }
        }

        private void ShowCookbookForm()
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbooksList));
            }
        }
        private void ShowMealsForm()
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmMealsList));
            }
        }
        private void FrmDashboard_Activated(object? sender, EventArgs e)
        {
            SetDashboardLabels("Cookbooks", lblCookbooksNum);
            SetDashboardLabels("Meals", lblMealsNum);
            SetDashboardLabels("Recipes", lblRecipeNum);
        }
        private void BtnRecipeList_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm();
        }
        private void BtnCookbookList_Click(object? sender, EventArgs e)
        {
            ShowCookbookForm();
        }
        private void BtnMealList_Click(object? sender, EventArgs e)
        {
            ShowMealsForm();
        }
    }
}
