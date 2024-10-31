namespace RecipeWinForms
{
    partial class frmDataMaintenance
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
            rdbCuisine = new RadioButton();
            tblMain = new TableLayoutPanel();
            btnSave = new Button();
            pnlRadioButtons = new FlowLayoutPanel();
            rdbUser = new RadioButton();
            rdbIngredients = new RadioButton();
            rdbMeasurementType = new RadioButton();
            rdbCourse = new RadioButton();
            gData = new DataGridView();
            tblMain.SuspendLayout();
            pnlRadioButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            SuspendLayout();
            // 
            // rdbCuisine
            // 
            rdbCuisine.AutoSize = true;
            rdbCuisine.Location = new Point(3, 28);
            rdbCuisine.Name = "rdbCuisine";
            rdbCuisine.Size = new Size(69, 19);
            rdbCuisine.TabIndex = 1;
            rdbCuisine.Text = "Cuisines";
            rdbCuisine.UseVisualStyleBackColor = true;
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77F));
            tblMain.Controls.Add(btnSave, 0, 0);
            tblMain.Controls.Add(pnlRadioButtons, 0, 1);
            tblMain.Controls.Add(gData, 1, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 85.55556F));
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.Dock = DockStyle.Fill;
            btnSave.Location = new Point(4, 4);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(176, 32);
            btnSave.TabIndex = 0;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // pnlRadioButtons
            // 
            pnlRadioButtons.Controls.Add(rdbUser);
            pnlRadioButtons.Controls.Add(rdbCuisine);
            pnlRadioButtons.Controls.Add(rdbIngredients);
            pnlRadioButtons.Controls.Add(rdbMeasurementType);
            pnlRadioButtons.Controls.Add(rdbCourse);
            pnlRadioButtons.Dock = DockStyle.Fill;
            pnlRadioButtons.FlowDirection = FlowDirection.TopDown;
            pnlRadioButtons.Location = new Point(3, 43);
            pnlRadioButtons.Name = "pnlRadioButtons";
            pnlRadioButtons.Size = new Size(178, 404);
            pnlRadioButtons.TabIndex = 1;
            // 
            // rdbUser
            // 
            rdbUser.AutoSize = true;
            rdbUser.Checked = true;
            rdbUser.Location = new Point(3, 3);
            rdbUser.Name = "rdbUser";
            rdbUser.Size = new Size(53, 19);
            rdbUser.TabIndex = 0;
            rdbUser.TabStop = true;
            rdbUser.Text = "Users";
            rdbUser.UseVisualStyleBackColor = true;
            // 
            // rdbIngredients
            // 
            rdbIngredients.AutoSize = true;
            rdbIngredients.Location = new Point(3, 53);
            rdbIngredients.Name = "rdbIngredients";
            rdbIngredients.Size = new Size(84, 19);
            rdbIngredients.TabIndex = 2;
            rdbIngredients.Text = "Ingredients";
            rdbIngredients.UseVisualStyleBackColor = true;
            // 
            // rdbMeasurementType
            // 
            rdbMeasurementType.AutoSize = true;
            rdbMeasurementType.Location = new Point(3, 78);
            rdbMeasurementType.Name = "rdbMeasurementType";
            rdbMeasurementType.Size = new Size(103, 19);
            rdbMeasurementType.TabIndex = 3;
            rdbMeasurementType.Text = "Measurements";
            rdbMeasurementType.UseVisualStyleBackColor = true;
            // 
            // rdbCourse
            // 
            rdbCourse.AutoSize = true;
            rdbCourse.Location = new Point(3, 103);
            rdbCourse.Name = "rdbCourse";
            rdbCourse.Size = new Size(67, 19);
            rdbCourse.TabIndex = 4;
            rdbCourse.Text = "Courses";
            rdbCourse.UseVisualStyleBackColor = true;
            // 
            // gData
            // 
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gData.Dock = DockStyle.Fill;
            gData.Location = new Point(187, 43);
            gData.Name = "gData";
            gData.Size = new Size(610, 404);
            gData.TabIndex = 2;
            // 
            // frmDataMaintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "frmDataMaintenance";
            Text = "Data Maintenance";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            pnlRadioButtons.ResumeLayout(false);
            pnlRadioButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton rdbCuisine;
        private TableLayoutPanel tblMain;
        private Button btnSave;
        private FlowLayoutPanel pnlRadioButtons;
        private RadioButton rdbUser;
        private RadioButton rdbIngredients;
        private RadioButton rdbMeasurementType;
        private RadioButton rdbCourse;
        private DataGridView gData;
    }
}