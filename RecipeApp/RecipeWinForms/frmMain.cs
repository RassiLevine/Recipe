using CPUFramework;
using CPUWindowsFormFramework;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;

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
            mnuClone.Click += MnuClone_Click;
        }

        private void FrmMain_Shown(object? sender, EventArgs e)
        {
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
                else if (frmtype == typeof(frmPopup))
                {
                    frmPopup f = new();
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
            OpenForm(typeof(frmPopup));
        }
        private void MnuClone_Click(object? sender, EventArgs e)
        {
            
        }
    }
}
