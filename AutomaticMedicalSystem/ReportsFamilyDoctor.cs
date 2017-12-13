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
    public partial class ReportsFamilyDoctor : Form
    {
        public ReportsFamilyDoctor()
        {
            InitializeComponent();
        }

        private void ReportsFamilyDoctor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.VFAMILYDOCTOR' table. You can move, or remove it, as needed.
            this.VFAMILYDOCTORTableAdapter.Fill(this.DataSet1.VFAMILYDOCTOR);
            // TODO: This line of code loads data into the 'DataSet1.REPORTFAMILYDOCTORS' table. You can move, or remove it, as needed.
            this.REPORTFAMILYDOCTORSTableAdapter.Fill(this.DataSet1.REPORTFAMILYDOCTORS);

            this.reportViewer1.RefreshReport();
        }
    }
}
