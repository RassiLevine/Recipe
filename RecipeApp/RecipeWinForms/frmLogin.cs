using RecipeSystem;
using System.Configuration;
using RecipeWinForms.Properties;

namespace RecipeWinForms
{
    public partial class frmLogin : Form
    {
        bool loginsuccess = false;
        public frmLogin()
        {
            InitializeComponent();
            btnLogin.Click += BtnLogin_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        public bool ShowLogin()
        {
#if DEBUG
            this.Text = this.Text + " - DEV";
#endif
            txtUserID.Text = Settings.Default.userid;
            this.ShowDialog();
            return loginsuccess;
        }
        private void BtnLogin_Click(object? sender, EventArgs e)
        {
            try
            {
                string connstringkey = "";
#if DEBUG
                connstringkey = "devconn";

#else
                connstringkey = "liveconn";
#endif
                string connstring = ConfigurationManager.ConnectionStrings[connstringkey].ConnectionString;
                DBmanager.SetConnectionString(connstring, true, txtUserID.Text, txtPassword.Text);
                loginsuccess = true;
                Settings.Default.userid = txtUserID.Text;
                Settings.Default.Save();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Login.", Application.ProductName);
            }
        }
        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
