namespace AutomaticMedicalSystem
{
    partial class Arc_sp_doctor_records
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arc_sp_doctor_records));
            this.dataSet1 = new AutomaticMedicalSystem.DataSet1();
            this.aRC_SP_DOCTOR_RECORDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aRC_SP_DOCTOR_RECORDSTableAdapter = new AutomaticMedicalSystem.DataSet1TableAdapters.ARC_SP_DOCTOR_RECORDSTableAdapter();
            this.tableAdapterManager = new AutomaticMedicalSystem.DataSet1TableAdapters.TableAdapterManager();
            this.aRC_SP_DOCTOR_RECORDSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aRC_SP_DOCTOR_RECORDSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vARCFAMILYDOCTORRECORDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vARCFAMILYDOCTORRECORDSTableAdapter = new AutomaticMedicalSystem.DataSet1TableAdapters.VARCFAMILYDOCTORRECORDSTableAdapter();
            this.vSPECIALDOCTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vSPECIALDOCTORTableAdapter = new AutomaticMedicalSystem.DataSet1TableAdapters.VSPECIALDOCTORTableAdapter();
            this.aRC_SP_DOCTOR_RECORDSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ARC_FAMILY_DOCTOR_RECORDSID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DOCTORSID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRC_SP_DOCTOR_RECORDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRC_SP_DOCTOR_RECORDSBindingNavigator)).BeginInit();
            this.aRC_SP_DOCTOR_RECORDSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vARCFAMILYDOCTORRECORDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSPECIALDOCTORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRC_SP_DOCTOR_RECORDSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aRC_SP_DOCTOR_RECORDSBindingSource
            // 
            this.aRC_SP_DOCTOR_RECORDSBindingSource.DataMember = "ARC_SP_DOCTOR_RECORDS";
            this.aRC_SP_DOCTOR_RECORDSBindingSource.DataSource = this.dataSet1;
            // 
            // aRC_SP_DOCTOR_RECORDSTableAdapter
            // 
            this.aRC_SP_DOCTOR_RECORDSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ARC_FAMILY_DOCTOR_RECORDSTableAdapter = null;
            this.tableAdapterManager.ARC_SP_DOCTOR_RECORDSTableAdapter = this.aRC_SP_DOCTOR_RECORDSTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DEPARTMENTTableAdapter = null;
            this.tableAdapterManager.DIAGNOSE_FM_DOCTORTableAdapter = null;
            this.tableAdapterManager.DIAGNOSE_SP_DOCTORTableAdapter = null;
            this.tableAdapterManager.DOCTORSTableAdapter = null;
            this.tableAdapterManager.FAMILY_DOCTORTableAdapter = null;
            this.tableAdapterManager.PATIENTSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AutomaticMedicalSystem.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aRC_SP_DOCTOR_RECORDSBindingNavigator
            // 
            this.aRC_SP_DOCTOR_RECORDSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aRC_SP_DOCTOR_RECORDSBindingNavigator.BindingSource = this.aRC_SP_DOCTOR_RECORDSBindingSource;
            this.aRC_SP_DOCTOR_RECORDSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aRC_SP_DOCTOR_RECORDSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aRC_SP_DOCTOR_RECORDSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.aRC_SP_DOCTOR_RECORDSBindingNavigatorSaveItem});
            this.aRC_SP_DOCTOR_RECORDSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aRC_SP_DOCTOR_RECORDSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aRC_SP_DOCTOR_RECORDSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aRC_SP_DOCTOR_RECORDSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aRC_SP_DOCTOR_RECORDSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aRC_SP_DOCTOR_RECORDSBindingNavigator.Name = "aRC_SP_DOCTOR_RECORDSBindingNavigator";
            this.aRC_SP_DOCTOR_RECORDSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aRC_SP_DOCTOR_RECORDSBindingNavigator.Size = new System.Drawing.Size(1341, 25);
            this.aRC_SP_DOCTOR_RECORDSBindingNavigator.TabIndex = 0;
            this.aRC_SP_DOCTOR_RECORDSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // aRC_SP_DOCTOR_RECORDSBindingNavigatorSaveItem
            // 
            this.aRC_SP_DOCTOR_RECORDSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aRC_SP_DOCTOR_RECORDSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aRC_SP_DOCTOR_RECORDSBindingNavigatorSaveItem.Image")));
            this.aRC_SP_DOCTOR_RECORDSBindingNavigatorSaveItem.Name = "aRC_SP_DOCTOR_RECORDSBindingNavigatorSaveItem";
            this.aRC_SP_DOCTOR_RECORDSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.aRC_SP_DOCTOR_RECORDSBindingNavigatorSaveItem.Text = "Save Data";
            this.aRC_SP_DOCTOR_RECORDSBindingNavigatorSaveItem.Click += new System.EventHandler(this.aRC_SP_DOCTOR_RECORDSBindingNavigatorSaveItem_Click);
            // 
            // vARCFAMILYDOCTORRECORDSBindingSource
            // 
            this.vARCFAMILYDOCTORRECORDSBindingSource.DataMember = "VARCFAMILYDOCTORRECORDS";
            this.vARCFAMILYDOCTORRECORDSBindingSource.DataSource = this.dataSet1;
            // 
            // vARCFAMILYDOCTORRECORDSTableAdapter
            // 
            this.vARCFAMILYDOCTORRECORDSTableAdapter.ClearBeforeFill = true;
            // 
            // vSPECIALDOCTORBindingSource
            // 
            this.vSPECIALDOCTORBindingSource.DataMember = "VSPECIALDOCTOR";
            this.vSPECIALDOCTORBindingSource.DataSource = this.dataSet1;
            // 
            // vSPECIALDOCTORTableAdapter
            // 
            this.vSPECIALDOCTORTableAdapter.ClearBeforeFill = true;
            // 
            // aRC_SP_DOCTOR_RECORDSDataGridView
            // 
            this.aRC_SP_DOCTOR_RECORDSDataGridView.AllowUserToAddRows = false;
            this.aRC_SP_DOCTOR_RECORDSDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aRC_SP_DOCTOR_RECORDSDataGridView.AutoGenerateColumns = false;
            this.aRC_SP_DOCTOR_RECORDSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aRC_SP_DOCTOR_RECORDSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.ARC_FAMILY_DOCTOR_RECORDSID,
            this.Column1,
            this.Column2,
            this.Column3,
            this.dataGridViewTextBoxColumn4,
            this.DOCTORSID});
            this.aRC_SP_DOCTOR_RECORDSDataGridView.DataSource = this.aRC_SP_DOCTOR_RECORDSBindingSource;
            this.aRC_SP_DOCTOR_RECORDSDataGridView.Location = new System.Drawing.Point(4, 26);
            this.aRC_SP_DOCTOR_RECORDSDataGridView.Name = "aRC_SP_DOCTOR_RECORDSDataGridView";
            this.aRC_SP_DOCTOR_RECORDSDataGridView.Size = new System.Drawing.Size(1333, 593);
            this.aRC_SP_DOCTOR_RECORDSDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ARCDATE";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата записи к врачу специалисту";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ARC_FAMILY_DOCTOR_RECORDSID";
            this.dataGridViewTextBoxColumn3.DataSource = this.vARCFAMILYDOCTORRECORDSBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "ARCDATE";
            this.dataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата записи к семейному врачу";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "ID";
            // 
            // ARC_FAMILY_DOCTOR_RECORDSID
            // 
            this.ARC_FAMILY_DOCTOR_RECORDSID.DataPropertyName = "ARC_FAMILY_DOCTOR_RECORDSID";
            this.ARC_FAMILY_DOCTOR_RECORDSID.DataSource = this.vARCFAMILYDOCTORRECORDSBindingSource;
            this.ARC_FAMILY_DOCTOR_RECORDSID.DisplayMember = "FULL_NAME_PATIENT";
            this.ARC_FAMILY_DOCTOR_RECORDSID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ARC_FAMILY_DOCTOR_RECORDSID.HeaderText = "ФИО пациента";
            this.ARC_FAMILY_DOCTOR_RECORDSID.Name = "ARC_FAMILY_DOCTOR_RECORDSID";
            this.ARC_FAMILY_DOCTOR_RECORDSID.ValueMember = "ID";
            this.ARC_FAMILY_DOCTOR_RECORDSID.Width = 200;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ARC_FAMILY_DOCTOR_RECORDSID";
            this.Column1.DataSource = this.vARCFAMILYDOCTORRECORDSBindingSource;
            this.Column1.DisplayMember = "DATEBIRTH";
            this.Column1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column1.HeaderText = "Дата рождения";
            this.Column1.Name = "Column1";
            this.Column1.ValueMember = "ID";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ARC_FAMILY_DOCTOR_RECORDSID";
            this.Column2.DataSource = this.vARCFAMILYDOCTORRECORDSBindingSource;
            this.Column2.DisplayMember = "JURIDICAL_ADRESS_PATIENT";
            this.Column2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column2.HeaderText = "Место прописки";
            this.Column2.Name = "Column2";
            this.Column2.ValueMember = "ID";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ARC_FAMILY_DOCTOR_RECORDSID";
            this.Column3.DataSource = this.vARCFAMILYDOCTORRECORDSBindingSource;
            this.Column3.DisplayMember = "FULL_NAME_DOCTOR";
            this.Column3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column3.HeaderText = "Семейный врач";
            this.Column3.Name = "Column3";
            this.Column3.ValueMember = "ID";
            this.Column3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DOCTORSID";
            this.dataGridViewTextBoxColumn4.DataSource = this.vSPECIALDOCTORBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "FULL_NAME";
            this.dataGridViewTextBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn4.HeaderText = "ФИО врача специалиста";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "ID";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // DOCTORSID
            // 
            this.DOCTORSID.DataPropertyName = "DOCTORSID";
            this.DOCTORSID.DataSource = this.vSPECIALDOCTORBindingSource;
            this.DOCTORSID.DisplayMember = "EXPERIENCE";
            this.DOCTORSID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.DOCTORSID.HeaderText = "Квалификация врача специалиста";
            this.DOCTORSID.Name = "DOCTORSID";
            this.DOCTORSID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DOCTORSID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DOCTORSID.ValueMember = "ID";
            this.DOCTORSID.Width = 200;
            // 
            // Arc_sp_doctor_records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 644);
            this.Controls.Add(this.aRC_SP_DOCTOR_RECORDSDataGridView);
            this.Controls.Add(this.aRC_SP_DOCTOR_RECORDSBindingNavigator);
            this.Name = "Arc_sp_doctor_records";
            this.Text = "Запись к врачу специалисту";
            this.Load += new System.EventHandler(this.Arc_sp_doctor_records_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRC_SP_DOCTOR_RECORDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRC_SP_DOCTOR_RECORDSBindingNavigator)).EndInit();
            this.aRC_SP_DOCTOR_RECORDSBindingNavigator.ResumeLayout(false);
            this.aRC_SP_DOCTOR_RECORDSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vARCFAMILYDOCTORRECORDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSPECIALDOCTORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRC_SP_DOCTOR_RECORDSDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource aRC_SP_DOCTOR_RECORDSBindingSource;
        private DataSet1TableAdapters.ARC_SP_DOCTOR_RECORDSTableAdapter aRC_SP_DOCTOR_RECORDSTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aRC_SP_DOCTOR_RECORDSBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton aRC_SP_DOCTOR_RECORDSBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource vARCFAMILYDOCTORRECORDSBindingSource;
        private DataSet1TableAdapters.VARCFAMILYDOCTORRECORDSTableAdapter vARCFAMILYDOCTORRECORDSTableAdapter;
        private System.Windows.Forms.BindingSource vSPECIALDOCTORBindingSource;
        private DataSet1TableAdapters.VSPECIALDOCTORTableAdapter vSPECIALDOCTORTableAdapter;
        private System.Windows.Forms.DataGridView aRC_SP_DOCTOR_RECORDSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn ARC_FAMILY_DOCTOR_RECORDSID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn DOCTORSID;
    }
}