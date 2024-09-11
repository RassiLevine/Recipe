using CPUFramework;
using System.Data;
using CPUWindowsFormFramework;
using RecipeSystem;

namespace RecipeWinForms
{
    public partial class frmPopup : Form
    {
        DataTable dtrecipe = new DataTable();
        DataTable dtIngredients = new DataTable();
        DataTable dtDirections = new DataTable();
        BindingSource bindsource = new BindingSource();
        int recipeid = 0;
        string deletecolumn = "del col";
        public frmPopup()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnSaveChild.Click += BtnSaveChild_Click;
            btnChangeStatus.Click += BtnChangeStatus_Click;
        }

        public void ShowForm(int recipeidval)
        {
            recipeid = recipeidval;
            dtrecipe = Recipe.LoadRecipe(recipeid);
            this.Tag = recipeid;
            bindsource.DataSource = dtrecipe;
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtcuisine = Recipe.GetCuisineList();
            WindowsFormsUtility.SetListBinding(drpdwnCuisine, dtcuisine, dtrecipe, "Cuisine");
            drpdwnCuisine.DisplayMember = "CuisineType";
            DataTable dtstaff = Recipe.GetStaffList();
            WindowsFormsUtility.SetListBinding(drpdwnStaff, dtstaff, dtrecipe, "Staff");
            drpdwnStaff.DisplayMember = "StaffLastName";
            WindowsFormsUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormsUtility.SetControlBinding(txtCalories, bindsource);
            WindowsFormsUtility.SetControlBinding(txtRecipeStatus, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateDraft, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, bindsource);
            this.Text = GetRecipeDesc();
            LoadIngredients();
            LoadDirections();
            SetButtonsEnabledBasedOnNewRecord();

        }
        private void LoadIngredients()
        {
            dtIngredients = Ingredients.LoadByRecipeId(recipeid);
            gIngredients.Columns.Clear();
            gIngredients.DataSource = dtIngredients;
            WindowsFormsUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.GetDataList("Ingredients"), "Ingredients", "IngredientName");
            WindowsFormsUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.GetDataList("MeasurementType"), "MeasurementType", "MeasurementType");
            WindowsFormsUtility.AddDeleteButtonToGrid(gIngredients, deletecolumn);
            WindowsFormsUtility.FormatGridForEdit(gIngredients, "RecipeIngredients");
           
        }

        private void LoadDirections()
        {
            dtDirections = Directions.LoadByRecipeId(recipeid);
            gDirections.Columns.Clear();
            gDirections.DataSource = dtDirections;
            WindowsFormsUtility.AddDeleteButtonToGrid(gDirections, deletecolumn);
            WindowsFormsUtility.FormatGridForEdit(gDirections, "Directions");
        }
        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = recipeid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnSaveChild.Enabled = b;
        }
        private void Save()
        {
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtrecipe);
                Recipe.LoadRecipe(recipeid);
            }
            catch (Exception ex)
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
            var response = MessageBox.Show("Are you sure you want to delete this recipe?", "Recipe App", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtrecipe);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe App");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void SaveChild()
        {
            Application.UseWaitCursor = true;
            try
            {
                Ingredients.SaveTable(dtIngredients, recipeid);
                //save directions
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "RecipeApp");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }
        private string GetRecipeDesc()
        {
            string value = "New Recipe";
            int pkvalue = SQLutility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
            if (pkvalue > 0)
            {
                value = SQLutility.GetValueFromFirstRowAsString(dtrecipe, "RecipeName");
            }
            return value;
        }

        private void OpenStatusForm(int recipeid)
        {
            int id = 0;
            this.Tag = recipeid;
            id = recipeid;
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmChangeRecipeStatus), id);
            }
        }
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSaveChild_Click(object? sender, EventArgs e)
        {
            SaveChild();
        }

        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {
            OpenStatusForm(recipeid);  
        }

    }
}
