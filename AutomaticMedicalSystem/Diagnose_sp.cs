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
    public partial class Diagnose_sp : Form
    {
        public Diagnose_sp()
        {
            InitializeComponent();
        }

        private void dIAGNOSE_SP_DOCTORBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dIAGNOSE_SP_DOCTORBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Diagnose_sp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.VARCSPDOCTORRECORDS' table. You can move, or remove it, as needed.
            this.vARCSPDOCTORRECORDSTableAdapter.Fill(this.dataSet1.VARCSPDOCTORRECORDS);
            // TODO: This line of code loads data into the 'dataSet1.DIAGNOSE_SP_DOCTOR' table. You can move, or remove it, as needed.
            this.dIAGNOSE_SP_DOCTORTableAdapter.Fill(this.dataSet1.DIAGNOSE_SP_DOCTOR);

        }
    }
}
