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
    public partial class Patients : Form
    {
        int k = 2;
        public Patients()
        {
            InitializeComponent();
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.PATIENTS' table. You can move, or remove it, as needed.
            this.pATIENTSTableAdapter.Fill(this.dataSet1.PATIENTS);
            for (int i = 1; i < pATIENTSDataGridView.ColumnCount; i++)
            {
                pATIENTSDataGridView.Columns[i].Width = 300;
            }
            pATIENTSDataGridView.Columns[0].ReadOnly = true;
        }

        private void set_max_id(ref int k)
        {
            DataGridViewCell cell = pATIENTSDataGridView.Rows[pATIENTSDataGridView.Rows.Count - 2].Cells[0];
            k = int.Parse(cell.Value.ToString());
        }

        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            try
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
            }
            catch (NoNullAllowedException exp)
            {
                MessageBox.Show("Код ошибки:"+exp.Message);
            }
            k--;

        }

        private void pATIENTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.pATIENTSBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            catch (OracleException exp)
            {
                MessageBox.Show("Код ошибки: " + exp.Code + "\n" +
                           "Сообщение: " + exp.Message);
            }
            catch (NoNullAllowedException exp)
            {
                MessageBox.Show("Код ошибки:" + exp.Message);
            }
        }

        

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            set_max_id(ref k);
            k++;
            pATIENTSDataGridView.Rows[pATIENTSDataGridView.Rows.Count-1].Cells[0].Value = k;
            k++;
        }
    }
}
