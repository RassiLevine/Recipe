using CPUFramework;
using CPUWindowsFormFramework;
using Microsoft.SqlServer.Server;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RecipeWinForms
{
    public partial class frmAutoCreateCookbook : Form
    {
        BindingSource bindsource = new BindingSource();
        DataTable dtdStaff = new DataTable();
        public frmAutoCreateCookbook()
        {
            InitializeComponent();
            btnCreate.Click += BtnCreate_Click;
            BindData();
        }

        private void BindData()
        {
            dtdStaff = DataMaintenance.GetDataList("Staff");
            bindsource.DataSource = dtdStaff;
            DataTable dt = DataMaintenance.GetDataList("Staff");
            WindowsFormsUtility.SetListBinding(drpdwnStaffLastName, dtdStaff, dt, "Staff");

        }

        private void CreateCookbook()
        {
            Application.UseWaitCursor = true;
            try
            {
                SqlCommand cmd = SQLutility.GetSqlCommand("CreateCookbook");
                SQLutility.SetParamValue(cmd, "@StaffId", WindowsFormsUtility.GetIdFromComboBox(drpdwnStaffLastName));
                DataTable dt = SQLutility.GetDataTable(cmd);
                MessageBox.Show("Cookbook has been created.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Could not create cookbook." + ex.Message, "Recipe App");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            
        }

        private void BtnCreate_Click(object? sender, EventArgs e)
        {
            CreateCookbook();
        }
    }
}
