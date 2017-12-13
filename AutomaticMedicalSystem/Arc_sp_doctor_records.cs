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
    public partial class Arc_sp_doctor_records : Form
    {
        public Arc_sp_doctor_records()
        {
            InitializeComponent();
        }

        private void aRC_SP_DOCTOR_RECORDSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aRC_SP_DOCTOR_RECORDSBindingSource.EndEdit();
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

        private void Arc_sp_doctor_records_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.VSPECIALDOCTOR' table. You can move, or remove it, as needed.
            this.vSPECIALDOCTORTableAdapter.Fill(this.dataSet1.VSPECIALDOCTOR);
            // TODO: This line of code loads data into the 'dataSet1.VARCFAMILYDOCTORRECORDS' table. You can move, or remove it, as needed.
            this.vARCFAMILYDOCTORRECORDSTableAdapter.Fill(this.dataSet1.VARCFAMILYDOCTORRECORDS);
            // TODO: This line of code loads data into the 'dataSet1.ARC_SP_DOCTOR_RECORDS' table. You can move, or remove it, as needed.
            this.aRC_SP_DOCTOR_RECORDSTableAdapter.Fill(this.dataSet1.ARC_SP_DOCTOR_RECORDS);

        }
    }
}
