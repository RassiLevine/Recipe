namespace RecipeWinForms
{
    partial class frmMain
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
            mnuMenuStrip = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuDashboard = new ToolStripMenuItem();
            mnuRecipes = new ToolStripMenuItem();
            mnuRecipeList = new ToolStripMenuItem();
            mnuNewRecipe = new ToolStripMenuItem();
            mnuClone = new ToolStripMenuItem();
            mnuMeals = new ToolStripMenuItem();
            mnuMealsList = new ToolStripMenuItem();
            mnuCookbooks = new ToolStripMenuItem();
            mnuCookbookList = new ToolStripMenuItem();
            mnuNewCookbook = new ToolStripMenuItem();
            mnuAutoCreate = new ToolStripMenuItem();
            mnuDataMaint = new ToolStripMenuItem();
            mnuEditData = new ToolStripMenuItem();
            mnuWindows = new ToolStripMenuItem();
            tsMain = new ToolStrip();
            mnuTile = new ToolStripMenuItem();
            mnuCascade = new ToolStripMenuItem();
            mnuMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMenuStrip
            // 
            mnuMenuStrip.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuMenuStrip.Items.AddRange(new ToolStripItem[] { mnuFile, mnuRecipes, mnuMeals, mnuCookbooks, mnuDataMaint, mnuWindows });
            mnuMenuStrip.Location = new Point(0, 0);
            mnuMenuStrip.Name = "mnuMenuStrip";
            mnuMenuStrip.Size = new Size(1029, 29);
            mnuMenuStrip.TabIndex = 2;
            mnuMenuStrip.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuDashboard });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(46, 25);
            mnuFile.Text = "File";
            // 
            // mnuDashboard
            // 
            mnuDashboard.Name = "mnuDashboard";
            mnuDashboard.Size = new Size(156, 26);
            mnuDashboard.Text = "Dashboard";
            // 
            // mnuRecipes
            // 
            mnuRecipes.DropDownItems.AddRange(new ToolStripItem[] { mnuRecipeList, mnuNewRecipe, mnuClone });
            mnuRecipes.Name = "mnuRecipes";
            mnuRecipes.Size = new Size(75, 25);
            mnuRecipes.Text = "Recipes";
            // 
            // mnuRecipeList
            // 
            mnuRecipeList.Name = "mnuRecipeList";
            mnuRecipeList.Size = new Size(182, 26);
            mnuRecipeList.Text = "List";
            // 
            // mnuNewRecipe
            // 
            mnuNewRecipe.Name = "mnuNewRecipe";
            mnuNewRecipe.Size = new Size(182, 26);
            mnuNewRecipe.Text = "New Recipe";
            // 
            // mnuClone
            // 
            mnuClone.Name = "mnuClone";
            mnuClone.Size = new Size(182, 26);
            mnuClone.Text = "Clone a Recipe";
            // 
            // mnuMeals
            // 
            mnuMeals.DropDownItems.AddRange(new ToolStripItem[] { mnuMealsList });
            mnuMeals.Name = "mnuMeals";
            mnuMeals.Size = new Size(63, 25);
            mnuMeals.Text = "Meals";
            // 
            // mnuMealsList
            // 
            mnuMealsList.Name = "mnuMealsList";
            mnuMealsList.Size = new Size(104, 26);
            mnuMealsList.Text = "List";
            // 
            // mnuCookbooks
            // 
            mnuCookbooks.DropDownItems.AddRange(new ToolStripItem[] { mnuCookbookList, mnuNewCookbook, mnuAutoCreate });
            mnuCookbooks.Name = "mnuCookbooks";
            mnuCookbooks.Size = new Size(100, 25);
            mnuCookbooks.Text = "Cookbooks";
            // 
            // mnuCookbookList
            // 
            mnuCookbookList.Name = "mnuCookbookList";
            mnuCookbookList.Size = new Size(236, 26);
            mnuCookbookList.Text = "List";
            // 
            // mnuNewCookbook
            // 
            mnuNewCookbook.Name = "mnuNewCookbook";
            mnuNewCookbook.Size = new Size(236, 26);
            mnuNewCookbook.Text = "New Cookbook";
            // 
            // mnuAutoCreate
            // 
            mnuAutoCreate.Name = "mnuAutoCreate";
            mnuAutoCreate.Size = new Size(236, 26);
            mnuAutoCreate.Text = "Auto-create Cookbook";
            // 
            // mnuDataMaint
            // 
            mnuDataMaint.DropDownItems.AddRange(new ToolStripItem[] { mnuEditData });
            mnuDataMaint.Name = "mnuDataMaint";
            mnuDataMaint.Size = new Size(147, 25);
            mnuDataMaint.Text = "Data Maintenance";
            // 
            // mnuEditData
            // 
            mnuEditData.Name = "mnuEditData";
            mnuEditData.Size = new Size(180, 26);
            mnuEditData.Text = "Edit Data";
            // 
            // mnuWindows
            // 
            mnuWindows.DropDownItems.AddRange(new ToolStripItem[] { mnuTile, mnuCascade });
            mnuWindows.Name = "mnuWindows";
            mnuWindows.Size = new Size(87, 25);
            mnuWindows.Text = "Windows";
            // 
            // tsMain
            // 
            tsMain.Location = new Point(0, 29);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(1029, 25);
            tsMain.TabIndex = 3;
            tsMain.Text = "toolStrip1";
            // 
            // mnuTile
            // 
            mnuTile.Name = "mnuTile";
            mnuTile.Size = new Size(180, 26);
            mnuTile.Text = "Tile";
            // 
            // mnuCascade
            // 
            mnuCascade.Name = "mnuCascade";
            mnuCascade.Size = new Size(180, 26);
            mnuCascade.Text = "Cascade";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(tsMain);
            Controls.Add(mnuMenuStrip);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            MainMenuStrip = mnuMenuStrip;
            Margin = new Padding(4);
            Name = "frmMain";
            Text = "Main";
            mnuMenuStrip.ResumeLayout(false);
            mnuMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMenuStrip;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuDashboard;
        private ToolStripMenuItem mnuRecipes;
        private ToolStripMenuItem mnuRecipeList;
        private ToolStripMenuItem mnuNewRecipe;
        private ToolStripMenuItem mnuClone;
        private ToolStripMenuItem mnuMeals;
        private ToolStripMenuItem mnuMealsList;
        private ToolStripMenuItem mnuCookbooks;
        private ToolStripMenuItem mnuCookbookList;
        private ToolStripMenuItem mnuNewCookbook;
        private ToolStripMenuItem mnuAutoCreate;
        private ToolStripMenuItem mnuDataMaint;
        private ToolStripMenuItem mnuEditData;
        private ToolStripMenuItem mnuWindows;
        private ToolStrip tsMain;
        private ToolStripMenuItem mnuTile;
        private ToolStripMenuItem mnuCascade;
    }
}