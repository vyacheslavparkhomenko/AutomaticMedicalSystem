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

namespace AutomaticMedicalSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            bool z = true;
            bool expected = true;
            string str = "31/60/2017";
            string pattern = @"/";
            string[] sub_str = Regex.Split(str, pattern);

            /*if (sub_str[0].CompareTo("31") <= 0 && sub_str[0].CompareTo("01") >= 0)
                z = true;
            else
                z = false;*/

            if (String.CompareOrdinal("00", sub_str[2]) < 0 && "13".CompareTo(sub_str[2]) <= 0)
                z &= true;
            else
                z &= false;
            /*if (Convert.ToInt32(sub_str[4])<0)
                z3=false;
            else
                z3=true;*/
            expected = z;
        }

        private void диагнозВрачаспециалистаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diagnose_sp ds = new Diagnose_sp();
            ds.MdiParent = this;
            ds.Show();
        }

        private void отделенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Departments d = new Departments();
            d.MdiParent = this;
            d.Show();
        }

        private void контактныеДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patients p = new Patients();
            p.MdiParent = this;
            p.Show();
        }

        private void врачиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doctors d = new Doctors();
            d.MdiParent = this;
            d.Show();
        }

        private void семейныйВрачToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FamilyDoctors f = new FamilyDoctors();
            f.MdiParent = this;
            f.Show();
        }

        private void записьКСемейномуВрачуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arc_family_doctor_records a = new Arc_family_doctor_records();
            a.MdiParent = this;
            a.Show();
        }

        private void записьКВрачуспециалистуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arc_sp_doctor_records asr=new Arc_sp_doctor_records();
            asr.MdiParent = this;
            asr.Show();
        }

        private void общийДиагнозToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diagnose_family_doctor df = new Diagnose_family_doctor();
            df.MdiParent = this;
            df.Show();
        }

        private void выпискаВрачаспециалистаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormsFamilyDoctor f = new FormsFamilyDoctor();
            f.MdiParent = this;
            f.Show();
        }

        private void выпискаСемейногоВрачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportsFamilyDoctor rpf = new ReportsFamilyDoctor();
            rpf.MdiParent = this;
            rpf.Show();
        }
    }
}
