namespace RecipeWinForms
{
    partial class frmCloneRecipe
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
            drpdwnRecipeName = new ComboBox();
            btnCloneRecipe = new Button();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblMain.Controls.Add(drpdwnRecipeName, 1, 1);
            tblMain.Controls.Add(btnCloneRecipe, 1, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4, 4, 4, 4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 5;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 28.5714283F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 28.5714283F));
            tblMain.Size = new Size(1029, 630);
            tblMain.TabIndex = 0;
            // 
            // drpdwnRecipeName
            // 
            drpdwnRecipeName.Dock = DockStyle.Bottom;
            drpdwnRecipeName.FormattingEnabled = true;
            drpdwnRecipeName.ItemHeight = 21;
            drpdwnRecipeName.Location = new Point(347, 237);
            drpdwnRecipeName.Margin = new Padding(4, 4, 4, 4);
            drpdwnRecipeName.Name = "drpdwnRecipeName";
            drpdwnRecipeName.Size = new Size(335, 29);
            drpdwnRecipeName.TabIndex = 0;
            // 
            // btnCloneRecipe
            // 
            btnCloneRecipe.BackColor = Color.FromArgb(255, 255, 128);
            btnCloneRecipe.Dock = DockStyle.Fill;
            btnCloneRecipe.Location = new Point(346, 363);
            btnCloneRecipe.Name = "btnCloneRecipe";
            btnCloneRecipe.Size = new Size(337, 84);
            btnCloneRecipe.TabIndex = 1;
            btnCloneRecipe.Text = "Clone Recipe";
            btnCloneRecipe.UseVisualStyleBackColor = false;
            // 
            // frmCloneRecipe
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmCloneRecipe";
            Text = "Hearty Hearth - Clone Recipe";
            tblMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private ComboBox drpdwnRecipeName;
        private Button btnCloneRecipe;
    }
}