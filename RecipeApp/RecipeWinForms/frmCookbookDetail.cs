using CPUFramework;
using CPUWindowsFormFramework;
using RecipeSystem;
using System.Data;

namespace RecipeWinForms
{

    public partial class frmCookbookDetail : Form
    {

        DataTable dtCookbook = new DataTable();
        DataTable dtCookbookrecipe = new DataTable();
        int cookbookid = 0;
        string deletecolumn = "del col";
        BindingSource bindsource = new BindingSource();
        public frmCookbookDetail()
        {
            InitializeComponent();
        }

        public void ShowCookbookDetailForm(int cookbookidval)
        {
            cookbookid = cookbookidval;
            dtCookbook = Cookbook.LoadCookbook(cookbookidval);
            this.Tag = cookbookid;
            bindsource.DataSource = dtCookbook;
            if(cookbookid == 0)
            {
                dtCookbook.Rows.Add();
            }
            DataTable dtstaff = Recipe.GetStaffList();
            WindowsFormsUtility.SetListBinding(drpdwnUserName, dtstaff, dtCookbook, "Staff");
            WindowsFormsUtility.SetControlBinding(txtCookbookName, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateCreated, bindsource);
            WindowsFormsUtility.SetControlBinding(txtPrice, bindsource);
            SetCheckBox();
            WindowsFormsUtility.SetControlBinding(chkActive, bindsource);
            this.Text = GetCookbookDesc();
            LoadRecipesForCookbook();
            SetButtonsEnabledBasedOnNewRecord();
        }

        private void LoadRecipesForCookbook()
        {
           dtCookbookrecipe = Cookbook.LoadCookbookRecipe(cookbookid);
           gRecipes.Columns.Clear();
            gRecipes.DataSource = dtCookbookrecipe;
            WindowsFormsUtility.AddComboBoxToGrid(gRecipes, DataMaintenance.GetDataList("Recipe"), "Recipe", "RecipeName");
            WindowsFormsUtility.AddDeleteButtonToGrid(gRecipes, deletecolumn);
            WindowsFormsUtility.FormatGridForSearchResults(gRecipes, "CookbookRecipe");

        }
        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = cookbookid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnSaveRecipe.Enabled = b;
        }
        private void SetCheckBox()
        {
            foreach(DataRow r in dtCookbook.Rows)
            {
                if (r["Active"] is true)
                {
                    chkActive.Checked = true;
                }
            }
        }
        private string GetCookbookDesc()
        {
            string value = "";
            int pkvalue = SQLutility.GetValueFromFirstRowAsInt(dtCookbook, "CookbookId");
            if(pkvalue > 0)
            {
                value = "Cookbook - " + SQLutility.GetValueFromFirstRowAsString(dtCookbook, "CookbookName");
            }
            return value;
        }
}
}
