namespace AutomaticMedicalSystem
{
    partial class ReportsFamilyDoctor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1 = new AutomaticMedicalSystem.DataSet1();
            this.REPORTFAMILYDOCTORSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.REPORTFAMILYDOCTORSTableAdapter = new AutomaticMedicalSystem.DataSet1TableAdapters.REPORTFAMILYDOCTORSTableAdapter();
            this.VFAMILYDOCTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VFAMILYDOCTORTableAdapter = new AutomaticMedicalSystem.DataSet1TableAdapters.VFAMILYDOCTORTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPORTFAMILYDOCTORSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VFAMILYDOCTORBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.REPORTFAMILYDOCTORSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AutomaticMedicalSystem.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1353, 644);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // REPORTFAMILYDOCTORSBindingSource
            // 
            this.REPORTFAMILYDOCTORSBindingSource.DataMember = "REPORTFAMILYDOCTORS";
            this.REPORTFAMILYDOCTORSBindingSource.DataSource = this.DataSet1;
            // 
            // REPORTFAMILYDOCTORSTableAdapter
            // 
            this.REPORTFAMILYDOCTORSTableAdapter.ClearBeforeFill = true;
            // 
            // VFAMILYDOCTORBindingSource
            // 
            this.VFAMILYDOCTORBindingSource.DataMember = "VFAMILYDOCTOR";
            this.VFAMILYDOCTORBindingSource.DataSource = this.DataSet1;
            // 
            // VFAMILYDOCTORTableAdapter
            // 
            this.VFAMILYDOCTORTableAdapter.ClearBeforeFill = true;
            // 
            // ReportsFamilyDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 644);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportsFamilyDoctor";
            this.Text = "Справка  врача специалиста";
            this.Load += new System.EventHandler(this.ReportsFamilyDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPORTFAMILYDOCTORSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VFAMILYDOCTORBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource REPORTFAMILYDOCTORSBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.REPORTFAMILYDOCTORSTableAdapter REPORTFAMILYDOCTORSTableAdapter;
        private System.Windows.Forms.BindingSource VFAMILYDOCTORBindingSource;
        private DataSet1TableAdapters.VFAMILYDOCTORTableAdapter VFAMILYDOCTORTableAdapter;
    }
}