namespace RecipeWinForms
{
    partial class frmChangeRecipeStatus
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
            lblRecipeName = new Label();
            lblCurrentStat = new Label();
            lblRecipeStatus = new Label();
            tblDates = new TableLayoutPanel();
            lblDateDrafted = new Label();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
            lblStatusDate = new Label();
            txtDateDraft = new TextBox();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            tblbuttons = new TableLayoutPanel();
            btnDraft = new Button();
            btnPublish = new Button();
            btnArchive = new Button();
            tblMain.SuspendLayout();
            tblDates.SuspendLayout();
            tblbuttons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(lblCurrentStat, 0, 1);
            tblMain.Controls.Add(lblRecipeStatus, 1, 1);
            tblMain.Controls.Add(tblDates, 0, 2);
            tblMain.Controls.Add(tblbuttons, 0, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            tblMain.SetColumnSpan(lblRecipeName, 2);
            lblRecipeName.Dock = DockStyle.Fill;
            lblRecipeName.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecipeName.Location = new Point(3, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(794, 112);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentStat
            // 
            lblCurrentStat.AutoSize = true;
            lblCurrentStat.Dock = DockStyle.Fill;
            lblCurrentStat.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentStat.Location = new Point(3, 112);
            lblCurrentStat.Name = "lblCurrentStat";
            lblCurrentStat.Size = new Size(394, 112);
            lblCurrentStat.TabIndex = 1;
            lblCurrentStat.Text = "Current Status:";
            lblCurrentStat.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.Dock = DockStyle.Fill;
            lblRecipeStatus.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRecipeStatus.Location = new Point(403, 112);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(394, 112);
            lblRecipeStatus.TabIndex = 2;
            lblRecipeStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblDates
            // 
            tblDates.ColumnCount = 4;
            tblMain.SetColumnSpan(tblDates, 2);
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblDates.Controls.Add(lblDateDrafted, 1, 0);
            tblDates.Controls.Add(lblDatePublished, 2, 0);
            tblDates.Controls.Add(lblDateArchived, 3, 0);
            tblDates.Controls.Add(lblStatusDate, 0, 1);
            tblDates.Controls.Add(txtDateDraft, 1, 1);
            tblDates.Controls.Add(txtDatePublished, 2, 1);
            tblDates.Controls.Add(txtDateArchived, 3, 1);
            tblDates.Dock = DockStyle.Fill;
            tblDates.Location = new Point(3, 227);
            tblDates.Name = "tblDates";
            tblDates.RowCount = 2;
            tblDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDates.Size = new Size(794, 106);
            tblDates.TabIndex = 3;
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.AutoSize = true;
            lblDateDrafted.Dock = DockStyle.Fill;
            lblDateDrafted.Font = new Font("Segoe UI", 12F);
            lblDateDrafted.Location = new Point(201, 0);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(192, 53);
            lblDateDrafted.TabIndex = 0;
            lblDateDrafted.Text = "Drafted";
            lblDateDrafted.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblDatePublished
            // 
            lblDatePublished.AutoSize = true;
            lblDatePublished.Dock = DockStyle.Fill;
            lblDatePublished.Font = new Font("Segoe UI", 12F);
            lblDatePublished.Location = new Point(399, 0);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(192, 53);
            lblDatePublished.TabIndex = 1;
            lblDatePublished.Text = "Published";
            lblDatePublished.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblDateArchived
            // 
            lblDateArchived.AutoSize = true;
            lblDateArchived.Dock = DockStyle.Fill;
            lblDateArchived.Font = new Font("Segoe UI", 12F);
            lblDateArchived.Location = new Point(597, 0);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(194, 53);
            lblDateArchived.TabIndex = 2;
            lblDateArchived.Text = "Archived";
            lblDateArchived.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblStatusDate
            // 
            lblStatusDate.AutoSize = true;
            lblStatusDate.Dock = DockStyle.Fill;
            lblStatusDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatusDate.Location = new Point(3, 53);
            lblStatusDate.Name = "lblStatusDate";
            lblStatusDate.Size = new Size(192, 53);
            lblStatusDate.TabIndex = 3;
            lblStatusDate.Text = "Status Dates";
            lblStatusDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtDateDraft
            // 
            txtDateDraft.BorderStyle = BorderStyle.FixedSingle;
            txtDateDraft.Dock = DockStyle.Fill;
            txtDateDraft.Font = new Font("Segoe UI", 12F);
            txtDateDraft.Location = new Point(201, 56);
            txtDateDraft.Multiline = true;
            txtDateDraft.Name = "txtDateDraft";
            txtDateDraft.Size = new Size(192, 47);
            txtDateDraft.TabIndex = 4;
            txtDateDraft.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDatePublished
            // 
            txtDatePublished.BorderStyle = BorderStyle.FixedSingle;
            txtDatePublished.Dock = DockStyle.Fill;
            txtDatePublished.Font = new Font("Segoe UI", 12F);
            txtDatePublished.Location = new Point(399, 56);
            txtDatePublished.Multiline = true;
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.Size = new Size(192, 47);
            txtDatePublished.TabIndex = 5;
            txtDatePublished.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDateArchived
            // 
            txtDateArchived.BorderStyle = BorderStyle.FixedSingle;
            txtDateArchived.Dock = DockStyle.Fill;
            txtDateArchived.Font = new Font("Segoe UI", 12F);
            txtDateArchived.Location = new Point(597, 56);
            txtDateArchived.Multiline = true;
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.Size = new Size(194, 47);
            txtDateArchived.TabIndex = 6;
            txtDateArchived.TextAlign = HorizontalAlignment.Center;
            // 
            // tblbuttons
            // 
            tblbuttons.ColumnCount = 7;
            tblMain.SetColumnSpan(tblbuttons, 2);
            tblbuttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tblbuttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tblbuttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tblbuttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tblbuttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tblbuttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tblbuttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tblbuttons.Controls.Add(btnDraft, 1, 1);
            tblbuttons.Controls.Add(btnPublish, 3, 1);
            tblbuttons.Controls.Add(btnArchive, 5, 1);
            tblbuttons.Dock = DockStyle.Fill;
            tblbuttons.Location = new Point(3, 339);
            tblbuttons.Name = "tblbuttons";
            tblbuttons.RowCount = 3;
            tblbuttons.RowStyles.Add(new RowStyle(SizeType.Percent, 25.2873554F));
            tblbuttons.RowStyles.Add(new RowStyle(SizeType.Percent, 74.71265F));
            tblbuttons.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblbuttons.Size = new Size(794, 108);
            tblbuttons.TabIndex = 4;
            // 
            // btnDraft
            // 
            btnDraft.Dock = DockStyle.Fill;
            btnDraft.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDraft.Location = new Point(116, 25);
            btnDraft.Name = "btnDraft";
            btnDraft.Size = new Size(107, 59);
            btnDraft.TabIndex = 0;
            btnDraft.Text = "Draft";
            btnDraft.UseVisualStyleBackColor = true;
            // 
            // btnPublish
            // 
            btnPublish.Dock = DockStyle.Fill;
            btnPublish.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPublish.Location = new Point(342, 25);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(107, 59);
            btnPublish.TabIndex = 1;
            btnPublish.Text = "Publish";
            btnPublish.UseVisualStyleBackColor = true;
            // 
            // btnArchive
            // 
            btnArchive.Dock = DockStyle.Fill;
            btnArchive.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnArchive.Location = new Point(568, 25);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(107, 59);
            btnArchive.TabIndex = 2;
            btnArchive.Text = "Archive";
            btnArchive.UseVisualStyleBackColor = true;
            // 
            // frmChangeRecipeStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "frmChangeRecipeStatus";
            Text = "Recipe Status";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblDates.ResumeLayout(false);
            tblDates.PerformLayout();
            tblbuttons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblRecipeName;
        private Label lblCurrentStat;
        private Label lblRecipeStatus;
        private TableLayoutPanel tblDates;
        private Label lblDateDrafted;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private Label lblStatusDate;
        private TextBox txtDateDraft;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private TableLayoutPanel tblbuttons;
        private Button btnDraft;
        private Button btnPublish;
        private Button btnArchive;
    }
}