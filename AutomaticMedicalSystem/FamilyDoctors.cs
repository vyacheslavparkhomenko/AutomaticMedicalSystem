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
    public partial class FamilyDoctors : Form
    {
        public FamilyDoctors()
        {
            InitializeComponent();
        }

        private void fAMILY_DOCTORBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fAMILY_DOCTORBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void FamilyDoctors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.PATIENTS' table. You can move, or remove it, as needed.
            this.pATIENTSTableAdapter.Fill(this.dataSet1.PATIENTS);
            // TODO: This line of code loads data into the 'dataSet1.VFAMILYDOCTORRECORDS' table. You can move, or remove it, as needed.
            this.vFAMILYDOCTORRECORDSTableAdapter.Fill(this.dataSet1.VFAMILYDOCTORRECORDS);
            // TODO: This line of code loads data into the 'dataSet1.FAMILY_DOCTOR' table. You can move, or remove it, as needed.
            this.fAMILY_DOCTORTableAdapter.Fill(this.dataSet1.FAMILY_DOCTOR);
        }

        private void fAMILY_DOCTORBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.fAMILY_DOCTORBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }
    }
}
