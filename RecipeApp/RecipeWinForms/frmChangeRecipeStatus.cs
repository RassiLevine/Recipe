using CPUFramework;
using CPUWindowsFormFramework;
using RecipeSystem;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace RecipeWinForms
{
    public partial class frmChangeRecipeStatus : Form
    {
        DataTable dtRecipestatus = new DataTable();
        BindingSource bindsource = new BindingSource();
        int recipeid = 0;
        public frmChangeRecipeStatus()
        {
            InitializeComponent();
            btnDraft.Click += BtnDraft_Click;
            btnPublish.Click += BtnPublish_Click;
            btnArchive.Click += BtnArchive_Click;
        }

        public void ShowStatusForm(int recipeidval)
        {
            recipeid = recipeidval;
            dtRecipestatus = Recipe.LoadRecipeStatus(recipeidval);
            this.Tag = recipeid;
            bindsource.DataSource = dtRecipestatus;

            WindowsFormsUtility.SetControlBinding(lblRecipeName, bindsource);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateDraft, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, bindsource);
        }

        private void SetStatus(TextBox status, TextBox txt1, TextBox txt2)
        {
            DateTime now = DateTime.Today;
            DataTable dt = new DataTable();
            SqlCommand cmd = SQLutility.GetSqlCommand("StatusUpdate");
            
            status.Text = now.ToString();
            //string formattedDate = now.ToString("yyyy-MM-dd HH:mm:ss");
            if(status == txtDateDraft)
            {
                txt1.Text = null;
                txt2.Text = null;
            }
            else if(status == txtDatePublished)
            {
                txt1.Text = null;
                if(txt2.Text == "")
                {
                    txt2.Text = now.ToString();
                }
                else
                {
                    txt2.Text = txt2.Text;
                }
            }
            else if(status == txtDateArchived)
            {
                if(txt1.Text == "")
                {
                    txt1.Text = now.ToString();
                }
                else
                {
                    txt1.Text = txt1.Text;
                }
                if(txt2.Text == "")
                {
                    MessageBox.Show("Cannot archive recipe before it is drafted.");
                    return;
                }
            }
            DateTime.TryParse(txtDatePublished.Text, out var datepub);
            DateTime.TryParse(txtDateArchived.Text, out var datearc);
            DateTime.TryParse(txtDateDraft.Text, out var datedraft);
            SQLutility.SetParamValue(cmd, "@RecipeId", recipeid);
            if(txtDateDraft.Text == "")
            {
                SQLutility.SetParamValue(cmd, "@DateDraft", now);
            }
            string pub = txtDatePublished.Text;
            SQLutility.SetParamValue(cmd, "@DateDraft", datedraft);
            SQLutility.SetParamValue(cmd, "@DatePublished", txtDatePublished.Text  == ""? DBNull.Value : datepub);
            SQLutility.SetParamValue(cmd, "@DateArchived", txtDateArchived.Text == "" ? DBNull.Value : datearc);
            dt = SQLutility.GetDataTable(cmd);
            dtRecipestatus = Recipe.LoadRecipeStatus(recipeid);
            bindsource.DataSource = dtRecipestatus;
        }

        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            SetStatus(txtDateDraft, txtDatePublished, txtDateArchived);
        }
        private void BtnArchive_Click(object? sender, EventArgs e)
        {
            SetStatus(txtDateArchived, txtDatePublished,  txtDateDraft);
        }

        private void BtnPublish_Click(object? sender, EventArgs e)
        {
            SetStatus(txtDatePublished, txtDateArchived, txtDateDraft);
        }

    }
}
