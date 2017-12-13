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
    public partial class FormsFamilyDoctor : Form
    {
        public FormsFamilyDoctor()
        {
            InitializeComponent();
        }

        private void FormsFamilyDoctor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.REPORTSPDOCTORS' table. You can move, or remove it, as needed.
            this.REPORTSPDOCTORSTableAdapter.Fill(this.DataSet1.REPORTSPDOCTORS);
            // TODO: This line of code loads data into the 'DataSet1.VSPDIAGNOSE' table. You can move, or remove it, as needed.
            this.VSPDIAGNOSETableAdapter.Fill(this.DataSet1.VSPDIAGNOSE);

            this.reportViewer1.RefreshReport();
        }
    }
}
