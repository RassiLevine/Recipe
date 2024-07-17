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
            txtName = new TextBox();
            txtCalories = new TextBox();
            txtStatus = new TextBox();
            lblDateDraft = new Label();
            txtDateDraft = new TextBox();
            tblMain.SuspendLayout();
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
            tblMain.Controls.Add(txtName, 1, 0);
            tblMain.Controls.Add(txtCalories, 1, 1);
            tblMain.Controls.Add(txtStatus, 1, 2);
            tblMain.Controls.Add(lblDateDraft, 0, 3);
            tblMain.Controls.Add(txtDateDraft, 1, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
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
            lblName.Size = new Size(102, 35);
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
            lblCalories.Size = new Size(102, 35);
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
            lblStatus.Size = new Size(102, 35);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Status";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(113, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(913, 29);
            txtName.TabIndex = 3;
            // 
            // txtCalories
            // 
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Location = new Point(113, 38);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(913, 29);
            txtCalories.TabIndex = 4;
            // 
            // txtStatus
            // 
            txtStatus.Dock = DockStyle.Fill;
            txtStatus.Location = new Point(113, 73);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(913, 29);
            txtStatus.TabIndex = 5;
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
            txtDateDraft.Location = new Point(113, 108);
            txtDateDraft.Name = "txtDateDraft";
            txtDateDraft.Size = new Size(913, 29);
            txtDateDraft.TabIndex = 7;
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
        private Label lblCalories;
        private Label lblStatus;
        private TextBox txtName;
        private TextBox txtCalories;
        private TextBox txtStatus;
        private Label lblDateDraft;
        private TextBox txtDateDraft;
    }
}