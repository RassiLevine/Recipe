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
        public static int cookbookid = 0;
        string deletecolumn = "del col";
        BindingSource bindsource = new BindingSource();
        public frmCookbookDetail()
        {
            InitializeComponent();
            this.Shown += FrmCookbookDetail_Shown;
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnSaveRecipe.Click += BtnSaveRecipe_Click;
            gRecipes.CellContentClick += GRecipes_CellContentClick;
        }
        private void FrmCookbookDetail_Shown(object? sender, EventArgs e)
        {
            LoadRecipesForCookbook();
            WindowsFormsUtility.FormatGridForEdit(gRecipes, "CookbookRecipe");
        }

        public void ShowCookbookDetailForm(int cookbookidval)
        {
            cookbookid = cookbookidval;
            dtCookbook = RecipeSystem.Cookbook.LoadCookbook(cookbookidval);
            this.Tag = cookbookid;
            bindsource.DataSource = dtCookbook;
            if(cookbookid == 0)
            {
                dtCookbook.Rows.Add();
            }
            DataTable dtstaff = DataMaintenance.GetDataList("Staff");
            WindowsFormsUtility.SetListBinding(drpdwnUserName, dtstaff, dtCookbook, "Staff");
            WindowsFormsUtility.SetControlBinding(txtCookbookName, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateCreated, bindsource);
            WindowsFormsUtility.SetControlBinding(txtPrice, bindsource);
            WindowsFormsUtility.SetControlBinding(chkActive, bindsource);
            SetCheckBox();
            this.Text = GetCookbookDesc();
            LoadRecipesForCookbook();
            SetButtonsEnabledBasedOnNewRecord();
        }

            private void LoadRecipesForCookbook()
        {
            dtCookbookrecipe = RecipeSystem.Cookbook.LoadCookbookRecipe(cookbookid);
           gRecipes.Columns.Clear();
            gRecipes.DataSource = dtCookbookrecipe;
            WindowsFormsUtility.AddComboBoxToGrid(gRecipes, DataMaintenance.GetDataList("Recipe"), "Recipe", "RecipeName");
            WindowsFormsUtility.AddDeleteButtonToGrid(gRecipes, deletecolumn);
            WindowsFormsUtility.FormatGridForEdit(gRecipes, "CookbookRecipe");

        }
        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = cookbookid == 0 ? false : true;
            btnDelete.Enabled = b;
            //btnSaveRecipe.Enabled = b;
        }
        private void SetCheckBox()
        {
            foreach(DataRow r in dtCookbook.Rows)
            {
                if (r["Active"] is true)
                {
                    chkActive.Checked = true;
                }
                if(chkActive.Checked == true)
                {
                    r["Active"] = true;
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

        private void Save()
        {
            Application.UseWaitCursor = true;
            try
            {
                RecipeSystem.Cookbook.Save(dtCookbook, "Cookbook", cookbookid);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe App");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this cookbook?", "Recipe App", MessageBoxButtons.YesNo);
            if(response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                RecipeSystem.Cookbook.Delete(dtCookbook);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe App");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }
        private void DeleteRecipeInCookbook(int rowIndex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gRecipes, rowIndex, "CookbookRecipeId");
            if (id > 0)
            {
                try
                {
                    RecipeSystem.Cookbook.DeleteChild(id);
                    LoadRecipesForCookbook();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Recipe App");
                }
            }
            else if (id < gRecipes.Rows.Count)
            {
                gRecipes.Rows.RemoveAt(rowIndex);
            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
        private void BtnSaveRecipe_Click(object? sender, EventArgs e)
        {
             SaveRecipe();
        }
        private void SaveRecipe()
        {
            try
            {
                if (IsAnyRowWithData() == true)
                {
                    RecipeSystem.Cookbook.SaveRecipe(dtCookbookrecipe,Cookbook.newcookbookid);
                }
                else
                {
                    MessageBox.Show("Cannot save cookbook because there are no recipes.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot save recipe.");
            }
        }
        private bool IsAnyRowWithData()
        {
            foreach(DataGridViewRow row in gRecipes.Rows)
            {
                bool IsRowEmpty = true;
                foreach(DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && !string.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {
                        IsRowEmpty = false;
                        break;
                    }
                }
                if(IsRowEmpty == false)
                {
                    return true;
                }
            }
            return false;
        }
        private void GRecipes_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            var cell = gRecipes.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell is DataGridViewButtonCell)
            {
                if(IsAnyRowWithData() == true)
                {
                    DeleteRecipeInCookbook(e.RowIndex);
                    gRecipes.DataSource = dtCookbookrecipe;
                }
                else
                {
                    MessageBox.Show("Cannot delete recipe.");
                }

            }
        }
    }
}
