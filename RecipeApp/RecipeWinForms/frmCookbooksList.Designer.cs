namespace RecipeWinForms
{
    partial class frmCookbooksList
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
            btnNew = new Button();
            gCookbookList = new DataGridView();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gCookbookList).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblMain.Controls.Add(btnNew, 0, 0);
            tblMain.Controls.Add(gCookbookList, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 86F));
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(3, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(129, 57);
            btnNew.TabIndex = 0;
            btnNew.Text = "New Cookbook";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // gCookbookList
            // 
            gCookbookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gCookbookList.Dock = DockStyle.Fill;
            gCookbookList.Location = new Point(3, 66);
            gCookbookList.Name = "gCookbookList";
            gCookbookList.Size = new Size(794, 381);
            gCookbookList.TabIndex = 1;
            // 
            // frmCookbooksList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "frmCookbooksList";
            Text = "Cookbooks";
            tblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gCookbookList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnNew;
        private DataGridView gCookbookList;
    }
}