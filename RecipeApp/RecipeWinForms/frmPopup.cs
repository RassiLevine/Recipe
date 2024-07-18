using CPUFramework;
using System.Data;
using CPUWindowsFormFramework;
using System.Diagnostics;
using System.Data.SqlClient;

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
            string sql = "select r.CuisineId, r.RecipeId, r.RecipeName, r.Calories, r.RecipeStatus, r.DateDraft, r.DatePublished from recipe r where r.RecipeId =" + recipeid.ToString();
            dtrecipe = SQLutility.GetDataTable(sql);
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtcuisine = SQLutility.GetDataTable("select c.CuisineId, c.CuisineType from Cuisine c"); //cuisinetype needs to be changed to cusine
            WindowsFormsUtility.SetListBinding(drpdwnCuisine,dtcuisine, dtrecipe, "Cuisine");
            WindowsFormsUtility.SetControlBinding(txtRecipeName, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtCalories, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtRecipeStatus, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtDateDraft, dtrecipe);
            this.Show();
        }

        private void Save()
        {
            SQLutility.DebugPrintDataTable(dtrecipe);
            DataRow r = dtrecipe.Rows[0];
            int id = (int)r["RecipeId"];
            string sql = "";

            if(id > 0)
            {
                sql = string.Join(Environment.NewLine,
                    $"update recipe set",
                    $"RecipeName = '{r["RecipeName"]}',",
                    $"Calories = '{r["Calories"]}',",
                    //$"RecipeStatus = '{r["RecipeStatus"]}',",
                    $"DateDraft = '{r["DateDraft"]}'",
                    //$"CuisineId = '{r["CuisineId"]}',",
                    $"CuisineType = '{r["CuisineType"]}'",
                    $"where RecipeId = '{r["RecipeId"]}'"
                    );
            }
            else
            {
                sql = "insert recipe(CusineId, RecipeName, Calories,  DateDraft)";
                sql += $"select '{r["CuisineId"]}','{r["RecipeName"]}', '{r["Calories"]}', '{r["DateDraft"]}'";
            }
            Debug.Print(sql);
            SQLutility.ExecuteSQL(sql);
        }

        private void Delete()
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            string sql = "delete recipe where r.RecipeId = " + id;
            SQLutility.ExecuteSQL(sql);
            this.Close();
        }
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            
        }

    }
}
