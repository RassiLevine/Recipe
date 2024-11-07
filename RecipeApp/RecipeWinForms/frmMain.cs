using CPUWindowsFormFramework;

namespace RecipeWinForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.Shown += FrmMain_Shown;
            mnuDashboard.Click += MnuDashboard_Click;
            mnuRecipeList.Click += MnuList_Click;
            mnuNewRecipe.Click += MnuNewRecipe_Click;
            mnuMealsList.Click += MnuMealsList_Click;
            mnuCookbookList.Click += MnuCookbookList_Click;
            mnuNewCookbook.Click += MnuNewCookbook_Click;
            mnuClone.Click += MnuClone_Click;
            mnuEditData.Click += MnuEditData_Click;
            mnuAutoCreate.Click += MnuAutoCreate_Click;
            mnuTile.Click += MnuTile_Click;
            mnuCascade.Click += MnuCascade_Click;
        }

        private void FrmMain_Shown(object? sender, EventArgs e)
        {
            frmLogin f = new() { StartPosition = FormStartPosition.CenterParent };
            bool b = f.ShowLogin();
            if (b == false)
            {
                this.Close();
                Application.Exit();
                return;
            }
            OpenForm(typeof(frmDashboard));
        }

        public void OpenForm(Type frmtype, int pkvalue = 0)
        {
            bool b = WindowsFormsUtility.IsFormOpen(frmtype);

            if (b == false)
            {
                Form? frm = null;
                if (frmtype == typeof(frmDashboard))
                {
                    frmDashboard f = new();
                    frm = f;
                }
                else if (frmtype == typeof(frmRecipeList))
                {
                    frmRecipeList f = new();
                    frm = f;
                }
                else if(frmtype == typeof(frmCookbooksList))
                {
                    frmCookbooksList f = new();
                    frm = f; 
                }
                else if (frmtype == typeof(frmMealsList))
                {
                    frmMealsList f = new();
                    frm = f;
                }
                else if(frmtype == typeof(frmDataMaintenance))
                {
                    frmDataMaintenance f = new();
                    frm = f;
                }
                else if(frmtype == typeof(frmCloneRecipe))
                {
                    frmCloneRecipe f = new();
                    frm = f;
                }
                else if(frmtype == typeof(frmAutoCreateCookbook))
                {
                    frmAutoCreateCookbook f = new();
                    frm = f;
                }
                else if(frmtype == typeof(frmChangeRecipeStatus)){
                    frmChangeRecipeStatus f = new();
                    frm = f;
                    f.ShowStatusForm(pkvalue);
                }
                else if(frmtype == typeof(frmCookbookDetail))
                {
                    frmCookbookDetail f = new();
                    frm = f;
                    f.ShowCookbookDetailForm(pkvalue);
                }
                else if (frmtype == typeof(frmRecipeDetail))
                {
                    frmRecipeDetail f = new();
                    frm = f;
                    f.ShowForm(pkvalue);
                }
                if (frm != null)
                {
                    frm.MdiParent = this;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.FormClosed += Frm_FormClosed;
                    frm.TextChanged += Frm_TextChanged;
                    frm.Show();
                }
                    WindowsFormsUtility.SetupNav(tsMain);
            }
        }

        private void Frm_TextChanged(object? sender, EventArgs e)
        {
            WindowsFormsUtility.SetupNav(tsMain);
        }

        private void Frm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            WindowsFormsUtility.SetupNav(tsMain);
        }
        private void MnuDashboard_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }
        private void MnuList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeList));
        }
        private void MnuNewRecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeDetail));
        }
        private void MnuClone_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCloneRecipe));   
        }
        private void MnuMealsList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmMealsList));
        }
        private void MnuNewCookbook_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbookDetail));
        }

        private void MnuCookbookList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbooksList));
        }
        private void MnuEditData_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDataMaintenance));
        }
        private void MnuAutoCreate_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmAutoCreateCookbook));
        }
        private void MnuCascade_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void MnuTile_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

    }
}
