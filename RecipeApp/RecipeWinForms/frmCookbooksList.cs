using CPUFramework;
using CPUWindowsFormFramework;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace RecipeWinForms
{
    public partial class frmCookbooksList : Form
    {
        public frmCookbooksList()
        {
            InitializeComponent();
            BindData();
            gCookbookList.CellContentClick += GCookbookList_CellContentClick;
            btnNew.Click += BtnNew_Click;
        }

        private void BindData()
        {
            SqlCommand cmd = SQLutility.GetSqlCommand("CookbookList");
            DataTable dt = SQLutility.GetDataTable(cmd);
            gCookbookList.DataSource = dt;
            WindowsFormsUtility.FormatGridForSearchResults(gCookbookList, "Cookbook");
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
                id = WindowsFormsUtility.GetIdFromGrid(gCookbookList, rowindex, "CookbookId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookDetail), id);
            }

        }

        private void GCookbookList_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ShowDetailForm(e.RowIndex);
            }
        }
        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowDetailForm(-1);
        }
    }
}
