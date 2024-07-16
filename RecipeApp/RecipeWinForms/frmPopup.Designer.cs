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
            lblNumIngredients = new Label();
            lblNumDirections = new Label();
            txtName = new TextBox();
            txtIng = new TextBox();
            txtDir = new TextBox();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.Controls.Add(lblName, 0, 0);
            tblMain.Controls.Add(lblNumIngredients, 0, 1);
            tblMain.Controls.Add(lblNumDirections, 0, 2);
            tblMain.Controls.Add(txtName, 1, 0);
            tblMain.Controls.Add(txtIng, 1, 1);
            tblMain.Controls.Add(txtDir, 1, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 3;
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
            lblName.Size = new Size(171, 35);
            lblName.TabIndex = 0;
            lblName.Text = "Recipe Name";
            // 
            // lblNumIngredients
            // 
            lblNumIngredients.AutoSize = true;
            lblNumIngredients.Dock = DockStyle.Fill;
            lblNumIngredients.Location = new Point(4, 35);
            lblNumIngredients.Margin = new Padding(4, 0, 4, 0);
            lblNumIngredients.Name = "lblNumIngredients";
            lblNumIngredients.Size = new Size(171, 35);
            lblNumIngredients.TabIndex = 1;
            lblNumIngredients.Text = "Number Of Ingredients";
            // 
            // lblNumDirections
            // 
            lblNumDirections.AutoSize = true;
            lblNumDirections.Location = new Point(4, 70);
            lblNumDirections.Margin = new Padding(4, 0, 4, 0);
            lblNumDirections.Name = "lblNumDirections";
            lblNumDirections.Size = new Size(160, 21);
            lblNumDirections.TabIndex = 2;
            lblNumDirections.Text = "Number of Directions";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(182, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(844, 29);
            txtName.TabIndex = 3;
            // 
            // txtIng
            // 
            txtIng.Dock = DockStyle.Fill;
            txtIng.Location = new Point(182, 38);
            txtIng.Name = "txtIng";
            txtIng.Size = new Size(844, 29);
            txtIng.TabIndex = 4;
            // 
            // txtDir
            // 
            txtDir.Dock = DockStyle.Fill;
            txtDir.Location = new Point(182, 73);
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(844, 29);
            txtDir.TabIndex = 5;
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
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblName;
        private Label lblNumIngredients;
        private Label lblNumDirections;
        private TextBox txtName;
        private TextBox txtIng;
        private TextBox txtDir;
    }
}