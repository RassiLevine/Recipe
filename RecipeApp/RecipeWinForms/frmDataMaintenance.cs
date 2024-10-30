using CPUFramework;
using CPUWindowsFormFramework;
using RecipeSystem;
using System.Data;
using System.Windows.Forms;

namespace RecipeWinForms
{

    public partial class frmDataMaintenance : Form
    {
        private enum TableTypeEnum { Staff, Cuisine, Ingredients, MeasurementType, Course }
        DataTable dtlist = new();
        TableTypeEnum currenttabletype = TableTypeEnum.Staff;
        string deletecolumnname = "del col";
        public frmDataMaintenance()
        {
            InitializeComponent();
            this.FormClosing += FrmDataMaintenance_FormClosing;
            SetupRadioButtons();
            BindData(TableTypeEnum.Staff);
            gData.CellContentClick += GData_CellContentClick;
        }

        private void BindData(TableTypeEnum tabletype)
        {
            currenttabletype = tabletype;
            dtlist = DataMaintenance.GetDataList(currenttabletype.ToString());
            gData.Columns.Clear();
            gData.DataSource = dtlist;
            WindowsFormsUtility.AddDeleteButtonToGrid(gData, deletecolumnname);
            WindowsFormsUtility.FormatGridForEdit(gData, currenttabletype.ToString());
        }

        private bool Save()
        {
            bool b = false;

            Application.UseWaitCursor = true;
            try
            {
                DataMaintenance.SaveDataList(dtlist, currenttabletype.ToString());
                b = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe App");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }

        private void Delete(int rowindex) {
            int id = WindowsFormsUtility.GetIdFromGrid(gData, rowindex, currenttabletype.ToString() + "Id");
            if (id != 0)
            {
                try
                {
                    DataMaintenance.DeleteRow(currenttabletype.ToString(), id);
                    BindData(currenttabletype);
                    DataMaintenance.GetDataList(currenttabletype.ToString());
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Recipe App");
                }
            }
            else if(id == 0 && rowindex < gData.Rows.Count)
            {
                gData.Rows.Remove(gData.Rows[rowindex]);
            }
        }

        private void SetupRadioButtons()
        {
            foreach (Control c in pnlRadioButtons.Controls)
            {
                if (c is RadioButton)
                {
                    c.Click += C_Click;
                    btnSave.Click += BtnSave_Click;
                   
                }
            }
            rdbUser.Tag = TableTypeEnum.Staff;
            rdbCuisine.Tag = TableTypeEnum.Cuisine;
            rdbIngredients.Tag = TableTypeEnum.Ingredients;
            rdbMeasurementType.Tag = TableTypeEnum.MeasurementType;
            rdbCourse.Tag = TableTypeEnum.Course;

        }
        private void C_Click(object? sender, EventArgs e)
        {
            if (sender is Control && ((Control)sender).Tag is TableTypeEnum)
            {
                BindData((TableTypeEnum)((Control)sender).Tag);
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void FrmDataMaintenance_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (SQLutility.TableHasChanges(dtlist) == true)
            {
                var response = MessageBox.Show($"Do you want to save changes to {this.Text} before closing?", "Recipe App", MessageBoxButtons.YesNoCancel);
                switch (response)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
        }

        private void GData_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            var cell = gData.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell is DataGridViewButtonCell)
            {
                Delete(e.RowIndex);
            }
        }

    }
}
