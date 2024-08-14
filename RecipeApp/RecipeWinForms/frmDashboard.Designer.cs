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
            gData = new DataGridView();
            tblListButtons = new TableLayoutPanel();
            btnRecipeList = new Button();
            btnMealList = new Button();
            btnCookbookList = new Button();
            lblAppDesc = new Label();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            tblListButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.1292515F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.81341F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.0573368F));
            tblMain.Controls.Add(lblHeader, 1, 0);
            tblMain.Controls.Add(gData, 1, 2);
            tblMain.Controls.Add(tblListButtons, 1, 3);
            tblMain.Controls.Add(lblAppDesc, 1, 1);
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
            lblHeader.Size = new Size(376, 134);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Hearty Hearth Desktop App";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gData
            // 
            gData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            gData.BackgroundColor = SystemColors.Control;
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gData.Dock = DockStyle.Fill;
            gData.Location = new Point(188, 174);
            gData.Margin = new Padding(3, 10, 3, 3);
            gData.Name = "gData";
            gData.Size = new Size(376, 188);
            gData.TabIndex = 2;
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
            tblListButtons.Location = new Point(188, 368);
            tblListButtons.Name = "tblListButtons";
            tblListButtons.RowCount = 1;
            tblListButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblListButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblListButtons.Size = new Size(376, 79);
            tblListButtons.TabIndex = 3;
            // 
            // btnRecipeList
            // 
            btnRecipeList.Dock = DockStyle.Fill;
            btnRecipeList.Location = new Point(3, 3);
            btnRecipeList.Name = "btnRecipeList";
            btnRecipeList.Size = new Size(119, 73);
            btnRecipeList.TabIndex = 0;
            btnRecipeList.Text = "Recipe List";
            btnRecipeList.UseVisualStyleBackColor = true;
            // 
            // btnMealList
            // 
            btnMealList.Dock = DockStyle.Fill;
            btnMealList.Location = new Point(128, 3);
            btnMealList.Name = "btnMealList";
            btnMealList.Size = new Size(119, 73);
            btnMealList.TabIndex = 1;
            btnMealList.Text = "Meal List";
            btnMealList.UseVisualStyleBackColor = true;
            // 
            // btnCookbookList
            // 
            btnCookbookList.Dock = DockStyle.Fill;
            btnCookbookList.Location = new Point(253, 3);
            btnCookbookList.Name = "btnCookbookList";
            btnCookbookList.Size = new Size(120, 73);
            btnCookbookList.TabIndex = 2;
            btnCookbookList.Text = "Cookbook List";
            btnCookbookList.UseVisualStyleBackColor = true;
            // 
            // lblAppDesc
            // 
            lblAppDesc.AutoSize = true;
            lblAppDesc.Dock = DockStyle.Fill;
            lblAppDesc.Location = new Point(188, 134);
            lblAppDesc.Name = "lblAppDesc";
            lblAppDesc.Size = new Size(376, 30);
            lblAppDesc.TabIndex = 4;
            lblAppDesc.Text = "Welcome to the Hearty Hearth Desktop app. In this app you can create recipes and cookbooks. You can also...";
            lblAppDesc.TextAlign = ContentAlignment.MiddleCenter;
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
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            tblListButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblHeader;
        private DataGridView gData;
        private TableLayoutPanel tblListButtons;
        private Button btnRecipeList;
        private Button btnMealList;
        private Button btnCookbookList;
        private Label lblAppDesc;
    }
}