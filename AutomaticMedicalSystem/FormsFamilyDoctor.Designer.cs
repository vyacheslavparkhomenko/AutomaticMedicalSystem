namespace AutomaticMedicalSystem
{
    partial class FormsFamilyDoctor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1 = new AutomaticMedicalSystem.DataSet1();
            this.VSPDIAGNOSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VSPDIAGNOSETableAdapter = new AutomaticMedicalSystem.DataSet1TableAdapters.VSPDIAGNOSETableAdapter();
            this.REPORTSPDOCTORSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.REPORTSPDOCTORSTableAdapter = new AutomaticMedicalSystem.DataSet1TableAdapters.REPORTSPDOCTORSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VSPDIAGNOSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPORTSPDOCTORSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.REPORTSPDOCTORSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AutomaticMedicalSystem.Report2.rdlc";
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
            // VSPDIAGNOSEBindingSource
            // 
            this.VSPDIAGNOSEBindingSource.DataMember = "VSPDIAGNOSE";
            this.VSPDIAGNOSEBindingSource.DataSource = this.DataSet1;
            // 
            // VSPDIAGNOSETableAdapter
            // 
            this.VSPDIAGNOSETableAdapter.ClearBeforeFill = true;
            // 
            // REPORTSPDOCTORSBindingSource
            // 
            this.REPORTSPDOCTORSBindingSource.DataMember = "REPORTSPDOCTORS";
            this.REPORTSPDOCTORSBindingSource.DataSource = this.DataSet1;
            // 
            // REPORTSPDOCTORSTableAdapter
            // 
            this.REPORTSPDOCTORSTableAdapter.ClearBeforeFill = true;
            // 
            // FormsFamilyDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 644);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormsFamilyDoctor";
            this.Text = "Справка врача-специалиста";
            this.Load += new System.EventHandler(this.FormsFamilyDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VSPDIAGNOSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.REPORTSPDOCTORSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VSPDIAGNOSEBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.VSPDIAGNOSETableAdapter VSPDIAGNOSETableAdapter;
        private System.Windows.Forms.BindingSource REPORTSPDOCTORSBindingSource;
        private DataSet1TableAdapters.REPORTSPDOCTORSTableAdapter REPORTSPDOCTORSTableAdapter;

    }
}