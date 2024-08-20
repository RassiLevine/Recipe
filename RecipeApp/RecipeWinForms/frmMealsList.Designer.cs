namespace RecipeWinForms
{
    partial class frmMealsList
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
            gMeals = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gMeals).BeginInit();
            SuspendLayout();
            // 
            // gMeals
            // 
            gMeals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gMeals.Dock = DockStyle.Fill;
            gMeals.Location = new Point(0, 0);
            gMeals.Name = "gMeals";
            gMeals.Size = new Size(1029, 630);
            gMeals.TabIndex = 0;
            // 
            // frmMealsList
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(gMeals);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmMealsList";
            Text = "Meals";
            ((System.ComponentModel.ISupportInitialize)gMeals).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gMeals;
    }
}