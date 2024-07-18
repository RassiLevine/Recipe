namespace RecipeWinForms
{
    partial class frmPopup
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
            lblName = new Label();
            lblCalories = new Label();
            lblStatus = new Label();
            txtRecipeName = new TextBox();
            txtCalories = new TextBox();
            txtRecipeStatus = new TextBox();
            lblDateDraft = new Label();
            txtDateDraft = new TextBox();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
            lblCuisine = new Label();
            lblStaff = new Label();
            tblButton = new TableLayoutPanel();
            btnDelete = new Button();
            btnSave = new Button();
            lblRecipePic = new Label();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            drpdwnCuisine = new ComboBox();
            drpdwnStaff = new ComboBox();
            txtRecipePic = new TextBox();
            tblMain.SuspendLayout();
            tblButton.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.Controls.Add(lblName, 0, 0);
            tblMain.Controls.Add(lblCalories, 0, 1);
            tblMain.Controls.Add(lblStatus, 0, 2);
            tblMain.Controls.Add(txtRecipeName, 1, 0);
            tblMain.Controls.Add(txtCalories, 1, 1);
            tblMain.Controls.Add(txtRecipeStatus, 1, 2);
            tblMain.Controls.Add(lblDateDraft, 0, 3);
            tblMain.Controls.Add(txtDateDraft, 1, 3);
            tblMain.Controls.Add(lblDatePublished, 0, 4);
            tblMain.Controls.Add(lblDateArchived, 0, 5);
            tblMain.Controls.Add(lblCuisine, 0, 6);
            tblMain.Controls.Add(lblStaff, 0, 7);
            tblMain.Controls.Add(tblButton, 1, 9);
            tblMain.Controls.Add(lblRecipePic, 0, 8);
            tblMain.Controls.Add(txtDatePublished, 1, 4);
            tblMain.Controls.Add(txtDateArchived, 1, 5);
            tblMain.Controls.Add(drpdwnCuisine, 1, 6);
            tblMain.Controls.Add(drpdwnStaff, 1, 7);
            tblMain.Controls.Add(txtRecipePic, 1, 8);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 10;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(1029, 630);
            tblMain.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Fill;
            lblName.Location = new Point(4, 0);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(112, 35);
            lblName.TabIndex = 0;
            lblName.Text = "Recipe Name";
            // 
            // lblCalories
            // 
            lblCalories.AutoSize = true;
            lblCalories.Dock = DockStyle.Fill;
            lblCalories.Location = new Point(4, 35);
            lblCalories.Margin = new Padding(4, 0, 4, 0);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(112, 35);
            lblCalories.TabIndex = 1;
            lblCalories.Text = "Calories";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Location = new Point(4, 70);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(112, 35);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Status";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(123, 3);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(916, 29);
            txtRecipeName.TabIndex = 3;
            // 
            // txtCalories
            // 
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Location = new Point(123, 38);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(916, 29);
            txtCalories.TabIndex = 4;
            // 
            // txtRecipeStatus
            // 
            txtRecipeStatus.Dock = DockStyle.Fill;
            txtRecipeStatus.Location = new Point(123, 73);
            txtRecipeStatus.Name = "txtRecipeStatus";
            txtRecipeStatus.Size = new Size(916, 29);
            txtRecipeStatus.TabIndex = 5;
            // 
            // lblDateDraft
            // 
            lblDateDraft.AutoSize = true;
            lblDateDraft.Location = new Point(3, 105);
            lblDateDraft.Name = "lblDateDraft";
            lblDateDraft.Size = new Size(77, 21);
            lblDateDraft.TabIndex = 6;
            lblDateDraft.Text = "DateDraft";
            // 
            // txtDateDraft
            // 
            txtDateDraft.Dock = DockStyle.Fill;
            txtDateDraft.Location = new Point(123, 108);
            txtDateDraft.Name = "txtDateDraft";
            txtDateDraft.Size = new Size(916, 29);
            txtDateDraft.TabIndex = 7;
            // 
            // lblDatePublished
            // 
            lblDatePublished.AutoSize = true;
            lblDatePublished.Location = new Point(3, 140);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(114, 21);
            lblDatePublished.TabIndex = 9;
            lblDatePublished.Text = "Date Published";
            // 
            // lblDateArchived
            // 
            lblDateArchived.AutoSize = true;
            lblDateArchived.Location = new Point(3, 175);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(107, 21);
            lblDateArchived.TabIndex = 10;
            lblDateArchived.Text = "Date Archived";
            // 
            // lblCuisine
            // 
            lblCuisine.AutoSize = true;
            lblCuisine.Location = new Point(3, 210);
            lblCuisine.Name = "lblCuisine";
            lblCuisine.Size = new Size(61, 21);
            lblCuisine.TabIndex = 11;
            lblCuisine.Text = "Cuisine";
            // 
            // lblStaff
            // 
            lblStaff.AutoSize = true;
            lblStaff.Location = new Point(3, 245);
            lblStaff.Name = "lblStaff";
            lblStaff.Size = new Size(104, 21);
            lblStaff.TabIndex = 12;
            lblStaff.Text = "Staff Member";
            // 
            // tblButton
            // 
            tblButton.ColumnCount = 2;
            tblButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tblButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tblButton.Controls.Add(btnDelete, 1, 0);
            tblButton.Controls.Add(btnSave, 0, 0);
            tblButton.Location = new Point(123, 318);
            tblButton.Name = "tblButton";
            tblButton.RowCount = 1;
            tblButton.RowStyles.Add(new RowStyle());
            tblButton.Size = new Size(916, 45);
            tblButton.TabIndex = 8;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(83, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 31);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.BackColor = Color.FromArgb(0, 192, 0);
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(74, 31);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // lblRecipePic
            // 
            lblRecipePic.AutoSize = true;
            lblRecipePic.Location = new Point(3, 280);
            lblRecipePic.Name = "lblRecipePic";
            lblRecipePic.Size = new Size(108, 21);
            lblRecipePic.TabIndex = 13;
            lblRecipePic.Text = "Recipe Picture";
            // 
            // txtDatePublished
            // 
            txtDatePublished.Dock = DockStyle.Fill;
            txtDatePublished.Location = new Point(123, 143);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.Size = new Size(916, 29);
            txtDatePublished.TabIndex = 14;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Dock = DockStyle.Fill;
            txtDateArchived.Location = new Point(123, 178);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.Size = new Size(916, 29);
            txtDateArchived.TabIndex = 15;
            // 
            // drpdwnCuisine
            // 
            drpdwnCuisine.FormattingEnabled = true;
            drpdwnCuisine.Location = new Point(123, 213);
            drpdwnCuisine.Name = "drpdwnCuisine";
            drpdwnCuisine.Size = new Size(167, 29);
            drpdwnCuisine.TabIndex = 16;
            // 
            // drpdwnStaff
            // 
            drpdwnStaff.FormattingEnabled = true;
            drpdwnStaff.Location = new Point(123, 248);
            drpdwnStaff.Name = "drpdwnStaff";
            drpdwnStaff.Size = new Size(167, 29);
            drpdwnStaff.TabIndex = 17;
            // 
            // txtRecipePic
            // 
            txtRecipePic.Dock = DockStyle.Fill;
            txtRecipePic.Location = new Point(123, 283);
            txtRecipePic.Name = "txtRecipePic";
            txtRecipePic.ReadOnly = true;
            txtRecipePic.Size = new Size(916, 29);
            txtRecipePic.TabIndex = 18;
            // 
            // frmPopup
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmPopup";
            Text = "frmPopup";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblButton.ResumeLayout(false);
            tblButton.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblName;
        private Label lblCalories;
        private Label lblStatus;
        private TextBox txtRecipeName;
        private TextBox txtCalories;
        private TextBox txtRecipeStatus;
        private Label lblDateDraft;
        private TextBox txtDateDraft;
        private TableLayoutPanel tblButton;
        private Button btnSave;
        private Button btnDelete;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private Label lblCuisine;
        private Label lblStaff;
        private Label lblRecipePic;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private ComboBox drpdwnCuisine;
        private ComboBox drpdwnStaff;
        private TextBox txtRecipePic;
    }
}