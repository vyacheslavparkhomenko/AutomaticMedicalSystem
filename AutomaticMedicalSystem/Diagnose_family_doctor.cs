using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomaticMedicalSystem
{
    public partial class Diagnose_family_doctor : Form
    {
        public Diagnose_family_doctor()
        {
            InitializeComponent();
        }

        private void dIAGNOSE_FM_DOCTORBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dIAGNOSE_FM_DOCTORBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Diagnose_family_doctor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.VARCFAMILYDOCTORRECORDS' table. You can move, or remove it, as needed.
            this.vARCFAMILYDOCTORRECORDSTableAdapter.Fill(this.dataSet1.VARCFAMILYDOCTORRECORDS);
            // TODO: This line of code loads data into the 'dataSet1.DIAGNOSE_FM_DOCTOR' table. You can move, or remove it, as needed.
            this.dIAGNOSE_FM_DOCTORTableAdapter.Fill(this.dataSet1.DIAGNOSE_FM_DOCTOR);

        }

        private void dIAGNOSE_FM_DOCTORBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.dIAGNOSE_FM_DOCTORBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }
    }
}
