namespace RecipeWinForms
{
    partial class frmCookbookDetail
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
            lblCookbookName = new Label();
            lblActive = new Label();
            lblPrice = new Label();
            lblUser = new Label();
            btnSave = new Button();
            tblMain = new TableLayoutPanel();
            btnDelete = new Button();
            txtCookbookName = new TextBox();
            drpdwnUserName = new ComboBox();
            tblPrice = new TableLayoutPanel();
            txtPrice = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblDateCreated = new Label();
            txtDateCreated = new TextBox();
            chkActive = new CheckBox();
            gRecipes = new DataGridView();
            btnSaveRecipe = new Button();
            tblMain.SuspendLayout();
            tblPrice.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipes).BeginInit();
            SuspendLayout();
            // 
            // lblCookbookName
            // 
            lblCookbookName.Anchor = AnchorStyles.Left;
            lblCookbookName.AutoSize = true;
            lblCookbookName.Location = new Point(3, 71);
            lblCookbookName.Name = "lblCookbookName";
            lblCookbookName.Size = new Size(127, 21);
            lblCookbookName.TabIndex = 1;
            lblCookbookName.Text = "Cookbook Name";
            lblCookbookName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblActive
            // 
            lblActive.Anchor = AnchorStyles.Left;
            lblActive.AutoSize = true;
            lblActive.Location = new Point(3, 218);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(52, 21);
            lblActive.TabIndex = 4;
            lblActive.Text = "Active";
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Left;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(3, 165);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(44, 21);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Price";
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Left;
            lblUser.AutoSize = true;
            lblUser.Location = new Point(3, 106);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(42, 21);
            lblUser.TabIndex = 2;
            lblUser.Text = "User";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 192, 0);
            btnSave.Location = new Point(4, 4);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(127, 56);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(btnDelete, 1, 0);
            tblMain.Controls.Add(lblUser, 0, 2);
            tblMain.Controls.Add(lblCookbookName, 0, 1);
            tblMain.Controls.Add(btnSave, 0, 0);
            tblMain.Controls.Add(txtCookbookName, 1, 1);
            tblMain.Controls.Add(drpdwnUserName, 1, 2);
            tblMain.Controls.Add(lblPrice, 0, 3);
            tblMain.Controls.Add(lblActive, 0, 4);
            tblMain.Controls.Add(tblPrice, 1, 3);
            tblMain.Controls.Add(chkActive, 1, 4);
            tblMain.Controls.Add(gRecipes, 1, 5);
            tblMain.Controls.Add(btnSaveRecipe, 0, 5);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 6;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.Size = new Size(1029, 630);
            tblMain.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(139, 4);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(127, 56);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // txtCookbookName
            // 
            txtCookbookName.Anchor = AnchorStyles.Left;
            txtCookbookName.Location = new Point(138, 67);
            txtCookbookName.Name = "txtCookbookName";
            txtCookbookName.Size = new Size(300, 29);
            txtCookbookName.TabIndex = 5;
            // 
            // drpdwnUserName
            // 
            drpdwnUserName.Anchor = AnchorStyles.Left;
            drpdwnUserName.FormattingEnabled = true;
            drpdwnUserName.Location = new Point(138, 102);
            drpdwnUserName.Name = "drpdwnUserName";
            drpdwnUserName.Size = new Size(300, 29);
            drpdwnUserName.TabIndex = 6;
            // 
            // tblPrice
            // 
            tblPrice.ColumnCount = 2;
            tblPrice.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.9774771F));
            tblPrice.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.02252F));
            tblPrice.Controls.Add(txtPrice, 0, 0);
            tblPrice.Controls.Add(tableLayoutPanel1, 1, 0);
            tblPrice.Dock = DockStyle.Fill;
            tblPrice.Location = new Point(138, 137);
            tblPrice.Name = "tblPrice";
            tblPrice.RowCount = 1;
            tblPrice.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblPrice.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblPrice.Size = new Size(888, 78);
            tblPrice.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Left;
            txtPrice.Location = new Point(3, 24);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(111, 29);
            txtPrice.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 403F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(lblDateCreated, 0, 0);
            tableLayoutPanel1.Controls.Add(txtDateCreated, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(136, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30.5555553F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 69.44444F));
            tableLayoutPanel1.Size = new Size(749, 72);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lblDateCreated
            // 
            lblDateCreated.AutoSize = true;
            lblDateCreated.Location = new Point(3, 0);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(103, 21);
            lblDateCreated.TabIndex = 0;
            lblDateCreated.Text = "Date Created:";
            // 
            // txtDateCreated
            // 
            txtDateCreated.BackColor = Color.Silver;
            txtDateCreated.Location = new Point(3, 25);
            txtDateCreated.Name = "txtDateCreated";
            txtDateCreated.ReadOnly = true;
            txtDateCreated.Size = new Size(100, 29);
            txtDateCreated.TabIndex = 1;
            // 
            // chkActive
            // 
            chkActive.Anchor = AnchorStyles.Left;
            chkActive.AutoSize = true;
            chkActive.Location = new Point(138, 221);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(15, 14);
            chkActive.TabIndex = 8;
            chkActive.UseVisualStyleBackColor = true;
            // 
            // gRecipes
            // 
            gRecipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gRecipes.Dock = DockStyle.Fill;
            gRecipes.Location = new Point(138, 242);
            gRecipes.Name = "gRecipes";
            gRecipes.Size = new Size(888, 385);
            gRecipes.TabIndex = 9;
            // 
            // btnSaveRecipe
            // 
            btnSaveRecipe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSaveRecipe.BackColor = Color.FromArgb(0, 192, 0);
            btnSaveRecipe.Location = new Point(35, 242);
            btnSaveRecipe.Name = "btnSaveRecipe";
            btnSaveRecipe.Size = new Size(97, 40);
            btnSaveRecipe.TabIndex = 10;
            btnSaveRecipe.Text = "Save";
            btnSaveRecipe.UseVisualStyleBackColor = false;
            // 
            // frmCookbookDetail
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmCookbookDetail";
            Text = "Cookbook";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblPrice.ResumeLayout(false);
            tblPrice.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblCookbookName;
        private Label lblActive;
        private Label lblPrice;
        private Label lblUser;
        private Button btnSave;
        private TableLayoutPanel tblMain;
        private Button btnDelete;
        private TextBox txtCookbookName;
        private ComboBox drpdwnUserName;
        private TableLayoutPanel tblPrice;
        private TextBox txtPrice;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblDateCreated;
        private TextBox txtDateCreated;
        private CheckBox chkActive;
        private DataGridView gRecipes;
        private Button btnSaveRecipe;
    }
}