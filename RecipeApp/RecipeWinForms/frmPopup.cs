using CPUFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmPopup : Form
    {
        public frmPopup()
        {
            InitializeComponent();
        }
        public void ShowForm(int recipeid)
        {
            string sql = "select r.RecipeName, NumIngredients = count(distinct ri.ingredientId), NumDirections = count(distinct d.Direction)\r\nfrom recipe r\r\njoin Directions d\r\non r.RecipeId = d.RecipeId\r\njoin RecipeIngredient ri\r\non ri.RecipeId = r.RecipeId\r\nwhere r.RecipeId =" + recipeid.ToString() + "\r\ngroup by r.RecipeName";
            DataTable dt = SQLutility.GetDataTable(sql);
            txtName.DataBindings.Add("Text", dt, "RecipeName");
            txtIng.DataBindings.Add("Text", dt, "NumIngredients");
            txtDir.DataBindings.Add("Text", dt, "NumDirections");

            this.Show();
        }
    }
}
