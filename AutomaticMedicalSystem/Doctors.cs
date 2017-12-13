using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;


namespace AutomaticMedicalSystem
{
    public partial class Doctors : Form
    {
        int k = 4;
        public Doctors()
        {
            InitializeComponent();
        }

        private void dOCTORSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dOCTORSBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            catch (OracleException exp)
            {
                MessageBox.Show("Код ошибки: " + exp.Code + "\n" +
                           "Сообщение: " + exp.Message);
            }
        }

        private void Doctors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.DEPARTMENT' table. You can move, or remove it, as needed.
            this.dEPARTMENTTableAdapter.Fill(this.dataSet1.DEPARTMENT);
            // TODO: This line of code loads data into the 'dataSet1.DOCTORS' table. You can move, or remove it, as needed.
            this.dOCTORSTableAdapter.Fill(this.dataSet1.DOCTORS);
            for (int i = 1; i < dOCTORSDataGridView.ColumnCount; i++)
            {
                dOCTORSDataGridView.Columns[i].Width = 300;
            }
            dOCTORSDataGridView.Columns[0].ReadOnly = true;
        }

        private void dOCTORSBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.dOCTORSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
        }
        

        private void set_max_id(ref int k)
        {
            DataGridViewCell cell = dOCTORSDataGridView.Rows[dOCTORSDataGridView.Rows.Count - 2].Cells[0];
            k = int.Parse(cell.Value.ToString());
        }

        private void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            MessageBox.Show("Произошла ошибка " + anError.Context.ToString());

            if (anError.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Не удалось сохранить изменения");
            }
            if (anError.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                MessageBox.Show("Значения в ячейке изменены");
            }
            if (anError.Context == DataGridViewDataErrorContexts.Parsing)
            {
                MessageBox.Show("Произошел непредвиденный сбой");
            }
            if (anError.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                MessageBox.Show("Ошибка при заполнении");
            }

            if ((anError.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[anError.RowIndex].ErrorText = "an error";
                view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                anError.ThrowException = false;
            }
            k--;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            set_max_id(ref k);
            k++;
            dOCTORSDataGridView.Rows[dOCTORSDataGridView.Rows.Count - 1].Cells[0].Value = k;
            k++;
        }

        private void dEPARTMENTIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dEPARTMENTIDLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
