using CPUFramework;
using System.Data;
using CPUWindowsFormFramework;
using System.Diagnostics;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using RecipeSystem;
using System.Security.Cryptography;

namespace RecipeWinForms
{
    public partial class frmPopup : Form
    {
        DataTable dtrecipe;
        public frmPopup()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }
        public void ShowForm(int recipeid)
        {

            dtrecipe = Recipe.LoadRecipe(recipeid);
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
            WindowsFormsUtility.SetControlBinding(txtRecipeName, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtCalories, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtRecipeStatus, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtDateDraft, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtRecipePic, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, dtrecipe);
            this.Show();
        }

        private void Save()
        {
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtrecipe);
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
            var response = MessageBox.Show("Are you sure you want to delete this recipe?","Recipe App", MessageBoxButtons.YesNo);
            if(response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtrecipe);
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
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        

    }
}
