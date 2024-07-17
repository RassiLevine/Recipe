namespace RecipeWinForms
{
    partial class frmRecipe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblMain = new TableLayoutPanel();
            tblSearch = new TableLayoutPanel();
            lblName = new Label();
            txtName = new TextBox();
            btnSearch = new Button();
            gRecipe = new DataGridView();
            btnNew = new Button();
            tblMain.SuspendLayout();
            tblSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipe).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.Controls.Add(tblSearch, 0, 0);
            tblMain.Controls.Add(gRecipe, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 407F));
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
            // 
            // tblSearch
            // 
            tblSearch.ColumnCount = 4;
            tblSearch.ColumnStyles.Add(new ColumnStyle());
            tblSearch.ColumnStyles.Add(new ColumnStyle());
            tblSearch.ColumnStyles.Add(new ColumnStyle());
            tblSearch.ColumnStyles.Add(new ColumnStyle());
            tblSearch.Controls.Add(lblName, 0, 0);
            tblSearch.Controls.Add(txtName, 1, 0);
            tblSearch.Controls.Add(btnSearch, 2, 0);
            tblSearch.Controls.Add(btnNew, 3, 0);
            tblSearch.Dock = DockStyle.Fill;
            tblSearch.Location = new Point(3, 3);
            tblSearch.Name = "tblSearch";
            tblSearch.RowCount = 1;
            tblSearch.RowStyles.Add(new RowStyle());
            tblSearch.Size = new Size(797, 37);
            tblSearch.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(77, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Recipe Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(86, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(192, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // gRecipe
            // 
            gRecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gRecipe.Dock = DockStyle.Fill;
            gRecipe.Location = new Point(3, 46);
            gRecipe.Name = "gRecipe";
            gRecipe.Size = new Size(797, 401);
            gRecipe.TabIndex = 1;
            // 
            // btnNew
            // 
            btnNew.AutoSize = true;
            btnNew.Location = new Point(273, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 25);
            btnNew.TabIndex = 3;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "frmRecipe";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblSearch.ResumeLayout(false);
            tblSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblSearch;
        private Label lblName;
        private TextBox txtName;
        private Button btnSearch;
        private DataGridView gRecipe;
        private Button btnNew;
    }
}
