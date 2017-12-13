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
    public partial class Arc_family_doctor_records : Form
    {
        public Arc_family_doctor_records()
        {
            InitializeComponent();
        }

        private void aRC_FAMILY_DOCTOR_RECORDSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aRC_FAMILY_DOCTOR_RECORDSBindingSource.EndEdit();
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

        private void Arc_family_doctor_records_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.VFAMILYDOCTOR' table. You can move, or remove it, as needed.
            this.vFAMILYDOCTORTableAdapter.Fill(this.dataSet1.VFAMILYDOCTOR);
            // TODO: This line of code loads data into the 'dataSet1.ARC_FAMILY_DOCTOR_RECORDS' table. You can move, or remove it, as needed.
            this.aRC_FAMILY_DOCTOR_RECORDSTableAdapter.Fill(this.dataSet1.ARC_FAMILY_DOCTOR_RECORDS);
            // TODO: This line of code loads data into the 'dataSet1.VFAMILYDOCTOR' table. You can move, or remove it, as needed.
            this.vFAMILYDOCTORTableAdapter.Fill(this.dataSet1.VFAMILYDOCTOR);
            // TODO: This line of code loads data into the 'dataSet1.ARC_FAMILY_DOCTOR_RECORDS' table. You can move, or remove it, as needed.
            this.aRC_FAMILY_DOCTOR_RECORDSTableAdapter.Fill(this.dataSet1.ARC_FAMILY_DOCTOR_RECORDS);
            // TODO: This line of code loads data into the 'dataSet1.VFAMILYDOCTOR' table. You can move, or remove it, as needed.
            this.vFAMILYDOCTORTableAdapter.Fill(this.dataSet1.VFAMILYDOCTOR);
            // TODO: This line of code loads data into the 'dataSet1.ARC_FAMILY_DOCTOR_RECORDS' table. You can move, or remove it, as needed.
            this.aRC_FAMILY_DOCTOR_RECORDSTableAdapter.Fill(this.dataSet1.ARC_FAMILY_DOCTOR_RECORDS);

        }

        private void aRC_FAMILY_DOCTOR_RECORDSBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.aRC_FAMILY_DOCTOR_RECORDSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void aRC_FAMILY_DOCTOR_RECORDSBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.aRC_FAMILY_DOCTOR_RECORDSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }
    }
}
