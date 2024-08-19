namespace RecipeWinForms
{
    partial class frmDashboard
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
            lblHeader = new Label();
            tblListButtons = new TableLayoutPanel();
            btnRecipeList = new Button();
            btnMealList = new Button();
            btnCookbookList = new Button();
            lblAppDesc = new Label();
            lblType = new Label();
            lblNumber = new Label();
            lblRecipes = new Label();
            lblMeals = new Label();
            lblCookbooks = new Label();
            tblDashboard = new TableLayoutPanel();
            lblRecipeNum = new Label();
            lblMealsNum = new Label();
            lblCookbooksNum = new Label();
            tblMain.SuspendLayout();
            tblListButtons.SuspendLayout();
            tblDashboard.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.1292515F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.81341F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.0573368F));
            tblMain.Controls.Add(lblHeader, 1, 0);
            tblMain.Controls.Add(tblListButtons, 1, 3);
            tblMain.Controls.Add(lblAppDesc, 1, 1);
            tblMain.Controls.Add(tblDashboard, 1, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 28.5578747F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 42.8842468F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 2;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Dock = DockStyle.Fill;
            lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(188, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(376, 133);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Hearty Hearth Desktop App";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblListButtons
            // 
            tblListButtons.ColumnCount = 3;
            tblListButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblListButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblListButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblListButtons.Controls.Add(btnRecipeList, 0, 0);
            tblListButtons.Controls.Add(btnMealList, 1, 0);
            tblListButtons.Controls.Add(btnCookbookList, 2, 0);
            tblListButtons.Dock = DockStyle.Fill;
            tblListButtons.Location = new Point(188, 367);
            tblListButtons.Name = "tblListButtons";
            tblListButtons.RowCount = 1;
            tblListButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblListButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblListButtons.Size = new Size(376, 80);
            tblListButtons.TabIndex = 3;
            // 
            // btnRecipeList
            // 
            btnRecipeList.Dock = DockStyle.Fill;
            btnRecipeList.Location = new Point(3, 3);
            btnRecipeList.Name = "btnRecipeList";
            btnRecipeList.Size = new Size(119, 74);
            btnRecipeList.TabIndex = 0;
            btnRecipeList.Text = "Recipe List";
            btnRecipeList.UseVisualStyleBackColor = true;
            // 
            // btnMealList
            // 
            btnMealList.Dock = DockStyle.Fill;
            btnMealList.Location = new Point(128, 3);
            btnMealList.Name = "btnMealList";
            btnMealList.Size = new Size(119, 74);
            btnMealList.TabIndex = 1;
            btnMealList.Text = "Meal List";
            btnMealList.UseVisualStyleBackColor = true;
            // 
            // btnCookbookList
            // 
            btnCookbookList.Dock = DockStyle.Fill;
            btnCookbookList.Location = new Point(253, 3);
            btnCookbookList.Name = "btnCookbookList";
            btnCookbookList.Size = new Size(120, 74);
            btnCookbookList.TabIndex = 2;
            btnCookbookList.Text = "Cookbook List";
            btnCookbookList.UseVisualStyleBackColor = true;
            // 
            // lblAppDesc
            // 
            lblAppDesc.AutoSize = true;
            lblAppDesc.Dock = DockStyle.Fill;
            lblAppDesc.Location = new Point(188, 133);
            lblAppDesc.Name = "lblAppDesc";
            lblAppDesc.Size = new Size(376, 30);
            lblAppDesc.TabIndex = 4;
            lblAppDesc.Text = "Welcome to the Hearty Hearth Desktop app. In this app you can create recipes and cookbooks. You can also...";
            lblAppDesc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.BackColor = Color.Silver;
            lblType.Dock = DockStyle.Fill;
            lblType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblType.Location = new Point(3, 0);
            lblType.Name = "lblType";
            lblType.Size = new Size(182, 48);
            lblType.TabIndex = 0;
            lblType.Text = "Type";
            lblType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.BackColor = Color.Silver;
            lblNumber.Dock = DockStyle.Fill;
            lblNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumber.Location = new Point(191, 0);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(182, 48);
            lblNumber.TabIndex = 8;
            lblNumber.Text = "Number";
            lblNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecipes
            // 
            lblRecipes.AutoSize = true;
            lblRecipes.BackColor = SystemColors.Control;
            lblRecipes.Dock = DockStyle.Fill;
            lblRecipes.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecipes.Location = new Point(3, 48);
            lblRecipes.Name = "lblRecipes";
            lblRecipes.Size = new Size(182, 48);
            lblRecipes.TabIndex = 9;
            lblRecipes.Text = "Recipe";
            lblRecipes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMeals
            // 
            lblMeals.AutoSize = true;
            lblMeals.BackColor = SystemColors.Control;
            lblMeals.Dock = DockStyle.Fill;
            lblMeals.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMeals.Location = new Point(3, 96);
            lblMeals.Name = "lblMeals";
            lblMeals.Size = new Size(182, 49);
            lblMeals.TabIndex = 10;
            lblMeals.Text = "Meals";
            lblMeals.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCookbooks
            // 
            lblCookbooks.AutoSize = true;
            lblCookbooks.BackColor = SystemColors.Control;
            lblCookbooks.Dock = DockStyle.Fill;
            lblCookbooks.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCookbooks.Location = new Point(3, 145);
            lblCookbooks.Name = "lblCookbooks";
            lblCookbooks.Size = new Size(182, 50);
            lblCookbooks.TabIndex = 11;
            lblCookbooks.Text = "Cookbooks";
            lblCookbooks.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblDashboard
            // 
            tblDashboard.ColumnCount = 2;
            tblDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblDashboard.Controls.Add(lblCookbooksNum, 1, 3);
            tblDashboard.Controls.Add(lblMealsNum, 1, 2);
            tblDashboard.Controls.Add(lblRecipeNum, 1, 1);
            tblDashboard.Controls.Add(lblCookbooks, 0, 3);
            tblDashboard.Controls.Add(lblMeals, 0, 2);
            tblDashboard.Controls.Add(lblRecipes, 0, 1);
            tblDashboard.Controls.Add(lblNumber, 1, 0);
            tblDashboard.Controls.Add(lblType, 0, 0);
            tblDashboard.Dock = DockStyle.Fill;
            tblDashboard.Location = new Point(188, 166);
            tblDashboard.Name = "tblDashboard";
            tblDashboard.RowCount = 4;
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblDashboard.Size = new Size(376, 195);
            tblDashboard.TabIndex = 5;
            // 
            // lblRecipeNum
            // 
            lblRecipeNum.AutoSize = true;
            lblRecipeNum.BackColor = SystemColors.Control;
            lblRecipeNum.Dock = DockStyle.Fill;
            lblRecipeNum.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecipeNum.Location = new Point(191, 48);
            lblRecipeNum.Name = "lblRecipeNum";
            lblRecipeNum.Size = new Size(182, 48);
            lblRecipeNum.TabIndex = 12;
            lblRecipeNum.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMealsNum
            // 
            lblMealsNum.AutoSize = true;
            lblMealsNum.BackColor = SystemColors.Control;
            lblMealsNum.Dock = DockStyle.Fill;
            lblMealsNum.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMealsNum.Location = new Point(191, 96);
            lblMealsNum.Name = "lblMealsNum";
            lblMealsNum.Size = new Size(182, 49);
            lblMealsNum.TabIndex = 13;
            lblMealsNum.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCookbooksNum
            // 
            lblCookbooksNum.AutoSize = true;
            lblCookbooksNum.BackColor = SystemColors.Control;
            lblCookbooksNum.Dock = DockStyle.Fill;
            lblCookbooksNum.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCookbooksNum.Location = new Point(191, 145);
            lblCookbooksNum.Name = "lblCookbooksNum";
            lblCookbooksNum.Size = new Size(182, 50);
            lblCookbooksNum.TabIndex = 14;
            lblCookbooksNum.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "frmDashboard";
            Text = "Hearty Hearth - Dashboard";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblListButtons.ResumeLayout(false);
            tblDashboard.ResumeLayout(false);
            tblDashboard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblHeader;
        private TableLayoutPanel tblListButtons;
        private Button btnRecipeList;
        private Button btnMealList;
        private Button btnCookbookList;
        private Label lblAppDesc;
        private TableLayoutPanel tblDashboard;
        private Label lblRecipeNum;
        private Label lblCookbooks;
        private Label lblMeals;
        private Label lblRecipes;
        private Label lblNumber;
        private Label lblType;
        private Label lblCookbooksNum;
        private Label lblMealsNum;
    }
}