using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OracleClient;

namespace AutomaticMedicalSystem
{
    /// <summary>
    /// Форма для вывода информации об отделах амбулатории
    /// </summary>
    public partial class Departments : Form
    {
        /// <summary>
        /// <value>Переменная хранящая уникальное значение для автоинкремента</value>
        /// </summary>
        int k=64;
        
        /// <summary>
        /// Конструктор формы
        /// </summary>
        public Departments()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод вставки новых данных в таблицу формы
        /// </summary>
        /// <param name="sender">Объект приема сигналов</param>
        /// <param name="e">Объект реагирования на изменения на форме</param>
        private void dEPARTMENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dEPARTMENTBindingSource.EndEdit();
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

        private void dEPARTMENTBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.dEPARTMENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }


       

        public int max_id(ref int k)
        {
            int cell = 67;
            k = cell;
            return k;
        }

        /// <summary>
        /// Загрузка компонентов на форме
        /// </summary>
        public void Departments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.DEPARTMENT' table. You can move, or remove it, as needed.
            this.dEPARTMENTTableAdapter.Fill(this.dataSet1.DEPARTMENT);
            set_width_column();
            set_max_id(ref k);
        }

        /// <summary>
        /// Метод установления ширины столбцов
        /// </summary>
        /// <returns>Значение ширины 3 столбца DataGridView</returns>
        public int set_width_column()
        {
            for (int i = 1; i < dEPARTMENTDataGridView.ColumnCount; i++)
            {
                dEPARTMENTDataGridView.Columns[i].Width = 300;
            }
            dEPARTMENTDataGridView.Columns[0].ReadOnly = true;
            return dEPARTMENTDataGridView.Columns[2].Width;
        }
        
        /// <summary>
        /// Метод нахождения максимального значения в первой колонке
        /// </summary>
        /// <param name="k">Первое сгенерированное значение</param>
        /// <returns>Измененный параметр k равный максимальному</returns>
        public int set_max_id(ref int k)
        {
            DataGridViewCell cell = dEPARTMENTDataGridView.Rows[dEPARTMENTDataGridView.Rows.Count - 2].Cells[0];
            k = int.Parse(cell.Value.ToString());
            return k;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dEPARTMENTDataGridView_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {

        }

        /// <summary>
        /// Метод проверки на правильность введенных данных
        /// </summary>
        /// <param name="sender">прием сигналов с формы</param>
        /// <param name="anError">объект хранения стандартных ошибок</param>
        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            MessageBox.Show("Произошла ошибка " + anError.Context.ToString());

            ///<summary>
            ///При нажатии на кнопку не удалось сохранить изменения
            ///</summary>
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

            ///<summary>
            ///Вывод поля DataGridView в котором произошла непредвиденная ошибка
            ///</summary>
            if ((anError.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[anError.RowIndex].ErrorText = "an error";
                view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                anError.ThrowException = false;
            }
            k--;
        }

        public int select_id()
        {
            max_id(ref k);
            k++;
            //dEPARTMENTDataGridView.Rows[dEPARTMENTDataGridView.Rows.Count - 1].Cells[0].Value = k;
            //iDTextBox.Text = Convert.ToString(k);
            k++;
            return k;
        }

        public void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            set_max_id(ref k);
            k++;
            dEPARTMENTDataGridView.Rows[dEPARTMENTDataGridView.Rows.Count-1].Cells[0].Value = k;
            //iDTextBox.Text = Convert.ToString(k);
            k++;
        }

        private void dEPARTMENTDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
