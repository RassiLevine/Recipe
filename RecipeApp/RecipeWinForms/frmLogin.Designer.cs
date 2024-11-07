namespace RecipeWinForms
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblMain = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            txtUserID = new TextBox();
            txtPassword = new TextBox();
            tblButtons = new TableLayoutPanel();
            btnLogin = new Button();
            btnCancel = new Button();
            tblMain.SuspendLayout();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(label1, 0, 0);
            tblMain.Controls.Add(label2, 0, 1);
            tblMain.Controls.Add(txtUserID, 1, 0);
            tblMain.Controls.Add(txtPassword, 1, 1);
            tblMain.Controls.Add(tblButtons, 1, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 105F));
            tblMain.Size = new Size(705, 137);
            tblMain.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 37);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txtUserID
            // 
            txtUserID.Dock = DockStyle.Fill;
            txtUserID.Location = new Point(100, 4);
            txtUserID.Margin = new Padding(4);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(601, 29);
            txtUserID.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Location = new Point(100, 41);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(601, 29);
            txtPassword.TabIndex = 3;
            // 
            // tblButtons
            // 
            tblButtons.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tblButtons.AutoSize = true;
            tblButtons.ColumnCount = 2;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblButtons.Controls.Add(btnLogin, 0, 0);
            tblButtons.Controls.Add(btnCancel, 1, 0);
            tblButtons.Location = new Point(493, 78);
            tblButtons.Margin = new Padding(4);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblButtons.Size = new Size(208, 40);
            tblButtons.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = true;
            btnLogin.Location = new Point(4, 4);
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(96, 32);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "OK";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.Location = new Point(108, 4);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(96, 32);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(705, 137);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmLogin";
            Text = "frmLogin";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label label1;
        private Label label2;
        private TextBox txtUserID;
        private TextBox txtPassword;
        private TableLayoutPanel tblButtons;
        private Button btnLogin;
        private Button btnCancel;
    }
}