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
            tblChildButton = new TableLayoutPanel();
            tabIngDir = new TabControl();
            tabIng = new TabPage();
            gIngredients = new DataGridView();
            tabDir = new TabPage();
            gDirections = new DataGridView();
            btnSaveChild = new Button();
            lblStatusDates = new Label();
            txtRecipeName = new TextBox();
            lblStatus = new Label();
            lblCuisine = new Label();
            lblStaff = new Label();
            drpdwnCuisine = new ComboBox();
            tblStatus = new TableLayoutPanel();
            lblDrafted = new Label();
            lblPublished = new Label();
            lblArchived = new Label();
            txtDateDraft = new TextBox();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            tblButtons = new TableLayoutPanel();
            btnSave = new Button();
            btnDelete = new Button();
            txtRecipeStatus = new TextBox();
            drpdwnStaff = new ComboBox();
            txtCalories = new TextBox();
            tblMain.SuspendLayout();
            tblChildButton.SuspendLayout();
            tabIngDir.SuspendLayout();
            tabIng.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredients).BeginInit();
            tabDir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gDirections).BeginInit();
            tblStatus.SuspendLayout();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 4;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblMain.Controls.Add(lblName, 0, 1);
            tblMain.Controls.Add(lblCalories, 0, 2);
            tblMain.Controls.Add(tblChildButton, 1, 10);
            tblMain.Controls.Add(lblStatusDates, 0, 3);
            tblMain.Controls.Add(txtRecipeName, 1, 1);
            tblMain.Controls.Add(lblStatus, 0, 4);
            tblMain.Controls.Add(lblCuisine, 0, 7);
            tblMain.Controls.Add(lblStaff, 0, 8);
            tblMain.Controls.Add(drpdwnCuisine, 1, 7);
            tblMain.Controls.Add(tblStatus, 1, 3);
            tblMain.Controls.Add(tblButtons, 1, 0);
            tblMain.Controls.Add(txtRecipeStatus, 1, 4);
            tblMain.Controls.Add(drpdwnStaff, 1, 8);
            tblMain.Controls.Add(txtCalories, 1, 2);
            tblMain.Location = new Point(85, -1);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 11;
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
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(956, 633);
            tblMain.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Fill;
            lblName.Location = new Point(4, 62);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(107, 35);
            lblName.TabIndex = 0;
            lblName.Text = "Recipe Name";
            // 
            // lblCalories
            // 
            lblCalories.AutoSize = true;
            lblCalories.Dock = DockStyle.Fill;
            lblCalories.Location = new Point(4, 97);
            lblCalories.Margin = new Padding(4, 0, 4, 0);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(107, 35);
            lblCalories.TabIndex = 1;
            lblCalories.Text = "Calories";
            // 
            // tblChildButton
            // 
            tblChildButton.ColumnCount = 2;
            tblChildButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 83F));
            tblChildButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 77F));
            tblChildButton.Controls.Add(tabIngDir, 0, 1);
            tblChildButton.Controls.Add(btnSaveChild, 0, 0);
            tblChildButton.Dock = DockStyle.Left;
            tblChildButton.Location = new Point(118, 304);
            tblChildButton.Name = "tblChildButton";
            tblChildButton.RowCount = 2;
            tblChildButton.RowStyles.Add(new RowStyle());
            tblChildButton.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblChildButton.Size = new Size(838, 326);
            tblChildButton.TabIndex = 8;
            // 
            // tabIngDir
            // 
            tblChildButton.SetColumnSpan(tabIngDir, 2);
            tabIngDir.Controls.Add(tabIng);
            tabIngDir.Controls.Add(tabDir);
            tabIngDir.Dock = DockStyle.Fill;
            tabIngDir.Location = new Point(3, 42);
            tabIngDir.Name = "tabIngDir";
            tabIngDir.SelectedIndex = 0;
            tabIngDir.Size = new Size(832, 281);
            tabIngDir.TabIndex = 2;
            // 
            // tabIng
            // 
            tabIng.Controls.Add(gIngredients);
            tabIng.Location = new Point(4, 30);
            tabIng.Name = "tabIng";
            tabIng.Padding = new Padding(3);
            tabIng.Size = new Size(824, 247);
            tabIng.TabIndex = 0;
            tabIng.Text = "Ingredients";
            tabIng.UseVisualStyleBackColor = true;
            // 
            // gIngredients
            // 
            gIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gIngredients.Dock = DockStyle.Fill;
            gIngredients.Location = new Point(3, 3);
            gIngredients.Name = "gIngredients";
            gIngredients.Size = new Size(818, 241);
            gIngredients.TabIndex = 0;
            // 
            // tabDir
            // 
            tabDir.Controls.Add(gDirections);
            tabDir.Location = new Point(4, 24);
            tabDir.Name = "tabDir";
            tabDir.Padding = new Padding(3);
            tabDir.Size = new Size(824, 283);
            tabDir.TabIndex = 1;
            tabDir.Text = "Directions";
            tabDir.UseVisualStyleBackColor = true;
            // 
            // gDirections
            // 
            gDirections.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gDirections.Dock = DockStyle.Fill;
            gDirections.Location = new Point(3, 3);
            gDirections.Name = "gDirections";
            gDirections.Size = new Size(818, 277);
            gDirections.TabIndex = 0;
            // 
            // btnSaveChild
            // 
            btnSaveChild.BackColor = Color.FromArgb(0, 192, 0);
            btnSaveChild.Dock = DockStyle.Fill;
            btnSaveChild.Location = new Point(3, 3);
            btnSaveChild.Name = "btnSaveChild";
            btnSaveChild.Size = new Size(77, 33);
            btnSaveChild.TabIndex = 3;
            btnSaveChild.Text = "Save";
            btnSaveChild.UseVisualStyleBackColor = false;
            // 
            // lblStatusDates
            // 
            lblStatusDates.Anchor = AnchorStyles.Left;
            lblStatusDates.AutoSize = true;
            lblStatusDates.Location = new Point(4, 153);
            lblStatusDates.Margin = new Padding(4, 0, 4, 0);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(95, 21);
            lblStatusDates.TabIndex = 2;
            lblStatusDates.Text = "Status Dates";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Location = new Point(118, 65);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(529, 29);
            txtRecipeName.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(3, 196);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(109, 21);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Current Status";
            // 
            // lblCuisine
            // 
            lblCuisine.AutoSize = true;
            lblCuisine.Location = new Point(3, 231);
            lblCuisine.Name = "lblCuisine";
            lblCuisine.Size = new Size(61, 21);
            lblCuisine.TabIndex = 11;
            lblCuisine.Text = "Cuisine";
            // 
            // lblStaff
            // 
            lblStaff.AutoSize = true;
            lblStaff.Location = new Point(3, 266);
            lblStaff.Name = "lblStaff";
            lblStaff.Size = new Size(42, 21);
            lblStaff.TabIndex = 12;
            lblStaff.Text = "User";
            // 
            // drpdwnCuisine
            // 
            drpdwnCuisine.FormattingEnabled = true;
            drpdwnCuisine.Location = new Point(118, 234);
            drpdwnCuisine.Name = "drpdwnCuisine";
            drpdwnCuisine.Size = new Size(167, 29);
            drpdwnCuisine.TabIndex = 16;
            // 
            // tblStatus
            // 
            tblStatus.ColumnCount = 3;
            tblStatus.ColumnStyles.Add(new ColumnStyle());
            tblStatus.ColumnStyles.Add(new ColumnStyle());
            tblStatus.ColumnStyles.Add(new ColumnStyle());
            tblStatus.Controls.Add(lblDrafted, 0, 0);
            tblStatus.Controls.Add(lblPublished, 1, 0);
            tblStatus.Controls.Add(lblArchived, 2, 0);
            tblStatus.Controls.Add(txtDateDraft, 0, 1);
            tblStatus.Controls.Add(txtDatePublished, 1, 1);
            tblStatus.Controls.Add(txtDateArchived, 2, 1);
            tblStatus.Dock = DockStyle.Fill;
            tblStatus.Location = new Point(118, 135);
            tblStatus.Name = "tblStatus";
            tblStatus.RowCount = 2;
            tblStatus.RowStyles.Add(new RowStyle());
            tblStatus.RowStyles.Add(new RowStyle());
            tblStatus.Size = new Size(916, 58);
            tblStatus.TabIndex = 18;
            // 
            // lblDrafted
            // 
            lblDrafted.Anchor = AnchorStyles.Left;
            lblDrafted.AutoSize = true;
            lblDrafted.Location = new Point(3, 0);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(62, 21);
            lblDrafted.TabIndex = 0;
            lblDrafted.Text = "Drafted";
            lblDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPublished
            // 
            lblPublished.Anchor = AnchorStyles.Left;
            lblPublished.AutoSize = true;
            lblPublished.Location = new Point(104, 0);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(78, 21);
            lblPublished.TabIndex = 1;
            lblPublished.Text = "Published";
            lblPublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblArchived
            // 
            lblArchived.Anchor = AnchorStyles.Left;
            lblArchived.AutoSize = true;
            lblArchived.Location = new Point(198, 0);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(71, 21);
            lblArchived.TabIndex = 2;
            lblArchived.Text = "Archived";
            lblArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDateDraft
            // 
            txtDateDraft.BackColor = SystemColors.ControlDark;
            txtDateDraft.Dock = DockStyle.Fill;
            txtDateDraft.Location = new Point(3, 24);
            txtDateDraft.Name = "txtDateDraft";
            txtDateDraft.ReadOnly = true;
            txtDateDraft.Size = new Size(95, 29);
            txtDateDraft.TabIndex = 3;
            // 
            // txtDatePublished
            // 
            txtDatePublished.BackColor = SystemColors.ControlDark;
            txtDatePublished.Dock = DockStyle.Fill;
            txtDatePublished.Location = new Point(104, 24);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.ReadOnly = true;
            txtDatePublished.Size = new Size(88, 29);
            txtDatePublished.TabIndex = 4;
            // 
            // txtDateArchived
            // 
            txtDateArchived.BackColor = SystemColors.ControlDark;
            txtDateArchived.Location = new Point(198, 24);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.ReadOnly = true;
            txtDateArchived.Size = new Size(81, 29);
            txtDateArchived.TabIndex = 5;
            // 
            // tblButtons
            // 
            tblButtons.AutoSize = true;
            tblButtons.ColumnCount = 2;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblButtons.Controls.Add(btnSave, 0, 0);
            tblButtons.Controls.Add(btnDelete, 1, 0);
            tblButtons.Location = new Point(118, 3);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblButtons.Size = new Size(200, 56);
            tblButtons.TabIndex = 19;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.BackColor = Color.FromArgb(0, 192, 0);
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 50);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(103, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 50);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // txtRecipeStatus
            // 
            txtRecipeStatus.BackColor = SystemColors.ControlDark;
            txtRecipeStatus.Location = new Point(118, 199);
            txtRecipeStatus.Name = "txtRecipeStatus";
            txtRecipeStatus.ReadOnly = true;
            txtRecipeStatus.Size = new Size(182, 29);
            txtRecipeStatus.TabIndex = 5;
            // 
            // drpdwnStaff
            // 
            drpdwnStaff.FormattingEnabled = true;
            drpdwnStaff.Location = new Point(118, 269);
            drpdwnStaff.Name = "drpdwnStaff";
            drpdwnStaff.Size = new Size(167, 29);
            drpdwnStaff.TabIndex = 17;
            // 
            // txtCalories
            // 
            txtCalories.Location = new Point(118, 100);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(529, 29);
            txtCalories.TabIndex = 4;
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
            Text = "New Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblChildButton.ResumeLayout(false);
            tabIngDir.ResumeLayout(false);
            tabIng.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gIngredients).EndInit();
            tabDir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gDirections).EndInit();
            tblStatus.ResumeLayout(false);
            tblStatus.PerformLayout();
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblName;
        private Label lblCalories;
        private Label lblStatusDates;
        private TextBox txtRecipeName;
        private TextBox txtCalories;
        private TextBox txtRecipeStatus;
        private Label lblStatus;
        private TableLayoutPanel tblChildButton;
        private Button btnSave;
        private Button btnDelete;
        private Label lblCuisine;
        private Label lblStaff;
        private ComboBox drpdwnCuisine;
        private ComboBox drpdwnStaff;
        private TableLayoutPanel tblStatus;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
        private TextBox txtDateDraft;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private TabControl tabIngDir;
        private TabPage tabIng;
        private DataGridView gIngredients;
        private TabPage tabDir;
        private DataGridView gDirections;
        private TableLayoutPanel tblButtons;
        private Button btnSaveChild;
    }
}