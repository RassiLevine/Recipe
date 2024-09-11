namespace RecipeWinForms
{
    partial class frmAutoCreateCookbook
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
            drpdwnStaffLastName = new ComboBox();
            btnCreate = new Button();
            tblMain = new TableLayoutPanel();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // drpdwnStaffLastName
            // 
            drpdwnStaffLastName.Dock = DockStyle.Bottom;
            drpdwnStaffLastName.FormattingEnabled = true;
            drpdwnStaffLastName.ItemHeight = 21;
            drpdwnStaffLastName.Location = new Point(347, 237);
            drpdwnStaffLastName.Margin = new Padding(4);
            drpdwnStaffLastName.Name = "drpdwnStaffLastName";
            drpdwnStaffLastName.Size = new Size(335, 29);
            drpdwnStaffLastName.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(255, 255, 128);
            btnCreate.Dock = DockStyle.Fill;
            btnCreate.Location = new Point(346, 363);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(337, 84);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create Cookbook";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblMain.Controls.Add(drpdwnStaffLastName, 1, 1);
            tblMain.Controls.Add(btnCreate, 1, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 5;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 28.5714283F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 28.5714283F));
            tblMain.Size = new Size(1029, 630);
            tblMain.TabIndex = 1;
            // 
            // frmAutoCreateCookbook
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmAutoCreateCookbook";
            Text = "Hearty Hearth - Auto-create Cookbook";
            tblMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox drpdwnStaffLastName;
        private Button btnCreate;
        private TableLayoutPanel tblMain;
    }
}