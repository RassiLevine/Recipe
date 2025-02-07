﻿using CPUFramework;
using CPUWindowsFormFramework;
using RecipeSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmCloneRecipe : Form
    {
        BindingSource bindsource = new BindingSource();
        DataTable dtrecipename = new DataTable();
        int clonedrecipeid = 0;
        public frmCloneRecipe()
        {
            InitializeComponent();
            BindData();
            btnCloneRecipe.Click += BtnCloneRecipe_Click;
        }

        private void BindData()
        {

            dtrecipename = DataMaintenance.GetDataList("Recipe");
            bindsource.DataSource = dtrecipename;
            DataTable dt = DataMaintenance.GetDataList("Recipe");
            WindowsFormsUtility.SetListBinding(drpdwnRecipeName, dtrecipename, dt, "Recipe");
        }

        public static DataTable DataListOrderedByPK()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLutility.GetSqlCommand("RecipeListOrderedByPK");
            dt = SQLutility.GetDataTable(cmd);
            return dt;
        }
        private void Clone()
        {
            int id = WindowsFormsUtility.GetIdFromComboBox(drpdwnRecipeName);
            int clonedid = 0;
            SqlCommand cmd = SQLutility.GetSqlCommand("CloneRecipe");
            SQLutility.SetParamValue(cmd, "@RecipeId", id);
            DataTable dt = SQLutility.GetDataTable(cmd);
            var newid = dt.Rows[0]["RecipeId"];
            if (newid != DBNull.Value)
            {
                clonedid = Convert.ToInt32(newid);
            }
            MessageBox.Show("Recipe has been cloned.");
            
            ShowDetailForm(clonedid);
            this.Close();


        }

        private void ShowDetailForm(int id)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeDetail), id);
            }

        }
        private void BtnCloneRecipe_Click(object? sender, EventArgs e)
        {
            Clone();
        }
    }
}
