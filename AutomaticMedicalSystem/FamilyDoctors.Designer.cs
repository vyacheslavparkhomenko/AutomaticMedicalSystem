namespace AutomaticMedicalSystem
{
    partial class FamilyDoctors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FamilyDoctors));
            this.dataSet1 = new AutomaticMedicalSystem.DataSet1();
            this.fAMILY_DOCTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fAMILY_DOCTORTableAdapter = new AutomaticMedicalSystem.DataSet1TableAdapters.FAMILY_DOCTORTableAdapter();
            this.tableAdapterManager = new AutomaticMedicalSystem.DataSet1TableAdapters.TableAdapterManager();
            this.fAMILY_DOCTORBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.fAMILY_DOCTORBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fAMILY_DOCTORDataGridView = new System.Windows.Forms.DataGridView();
            this.vFAMILYDOCTORRECORDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vFAMILYDOCTORRECORDSTableAdapter = new AutomaticMedicalSystem.DataSet1TableAdapters.VFAMILYDOCTORRECORDSTableAdapter();
            this.pATIENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pATIENTSTableAdapter = new AutomaticMedicalSystem.DataSet1TableAdapters.PATIENTSTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PATIENTSID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DOCTORSID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fAMILY_DOCTORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fAMILY_DOCTORBindingNavigator)).BeginInit();
            this.fAMILY_DOCTORBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fAMILY_DOCTORDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vFAMILYDOCTORRECORDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fAMILY_DOCTORBindingSource
            // 
            this.fAMILY_DOCTORBindingSource.DataMember = "FAMILY_DOCTOR";
            this.fAMILY_DOCTORBindingSource.DataSource = this.dataSet1;
            // 
            // fAMILY_DOCTORTableAdapter
            // 
            this.fAMILY_DOCTORTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ARC_FAMILY_DOCTOR_RECORDSTableAdapter = null;
            this.tableAdapterManager.ARC_SP_DOCTOR_RECORDSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DEPARTMENTTableAdapter = null;
            this.tableAdapterManager.DIAGNOSE_FM_DOCTORTableAdapter = null;
            this.tableAdapterManager.DIAGNOSE_SP_DOCTORTableAdapter = null;
            this.tableAdapterManager.DOCTORSTableAdapter = null;
            this.tableAdapterManager.FAMILY_DOCTORTableAdapter = this.fAMILY_DOCTORTableAdapter;
            this.tableAdapterManager.PATIENTSTableAdapter = this.pATIENTSTableAdapter;
            this.tableAdapterManager.UpdateOrder = AutomaticMedicalSystem.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fAMILY_DOCTORBindingNavigator
            // 
            this.fAMILY_DOCTORBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fAMILY_DOCTORBindingNavigator.BindingSource = this.fAMILY_DOCTORBindingSource;
            this.fAMILY_DOCTORBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fAMILY_DOCTORBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fAMILY_DOCTORBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.fAMILY_DOCTORBindingNavigatorSaveItem});
            this.fAMILY_DOCTORBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fAMILY_DOCTORBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fAMILY_DOCTORBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fAMILY_DOCTORBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fAMILY_DOCTORBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fAMILY_DOCTORBindingNavigator.Name = "fAMILY_DOCTORBindingNavigator";
            this.fAMILY_DOCTORBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fAMILY_DOCTORBindingNavigator.Size = new System.Drawing.Size(1341, 25);
            this.fAMILY_DOCTORBindingNavigator.TabIndex = 0;
            this.fAMILY_DOCTORBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // fAMILY_DOCTORBindingNavigatorSaveItem
            // 
            this.fAMILY_DOCTORBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fAMILY_DOCTORBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fAMILY_DOCTORBindingNavigatorSaveItem.Image")));
            this.fAMILY_DOCTORBindingNavigatorSaveItem.Name = "fAMILY_DOCTORBindingNavigatorSaveItem";
            this.fAMILY_DOCTORBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.fAMILY_DOCTORBindingNavigatorSaveItem.Text = "Save Data";
            this.fAMILY_DOCTORBindingNavigatorSaveItem.Click += new System.EventHandler(this.fAMILY_DOCTORBindingNavigatorSaveItem_Click_1);
            // 
            // fAMILY_DOCTORDataGridView
            // 
            this.fAMILY_DOCTORDataGridView.AllowUserToAddRows = false;
            this.fAMILY_DOCTORDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fAMILY_DOCTORDataGridView.AutoGenerateColumns = false;
            this.fAMILY_DOCTORDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fAMILY_DOCTORDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.PATIENTSID,
            this.Column1,
            this.dataGridViewTextBoxColumn3,
            this.DOCTORSID});
            this.fAMILY_DOCTORDataGridView.DataSource = this.fAMILY_DOCTORBindingSource;
            this.fAMILY_DOCTORDataGridView.Location = new System.Drawing.Point(0, 24);
            this.fAMILY_DOCTORDataGridView.Name = "fAMILY_DOCTORDataGridView";
            this.fAMILY_DOCTORDataGridView.Size = new System.Drawing.Size(1333, 593);
            this.fAMILY_DOCTORDataGridView.TabIndex = 1;
            // 
            // vFAMILYDOCTORRECORDSBindingSource
            // 
            this.vFAMILYDOCTORRECORDSBindingSource.DataMember = "VFAMILYDOCTORRECORDS";
            this.vFAMILYDOCTORRECORDSBindingSource.DataSource = this.dataSet1;
            // 
            // vFAMILYDOCTORRECORDSTableAdapter
            // 
            this.vFAMILYDOCTORRECORDSTableAdapter.ClearBeforeFill = true;
            // 
            // pATIENTSBindingSource
            // 
            this.pATIENTSBindingSource.DataMember = "PATIENTS";
            this.pATIENTSBindingSource.DataSource = this.dataSet1;
            // 
            // pATIENTSTableAdapter
            // 
            this.pATIENTSTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PATIENTSID";
            this.dataGridViewTextBoxColumn2.DataSource = this.pATIENTSBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "FULL_NAME";
            this.dataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО пациента";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ID";
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // PATIENTSID
            // 
            this.PATIENTSID.DataPropertyName = "PATIENTSID";
            this.PATIENTSID.DataSource = this.pATIENTSBindingSource;
            this.PATIENTSID.DisplayMember = "DATEBIRTH";
            this.PATIENTSID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.PATIENTSID.HeaderText = "Дата рождения";
            this.PATIENTSID.Name = "PATIENTSID";
            this.PATIENTSID.ValueMember = "ID";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PATIENTSID";
            this.Column1.DataSource = this.pATIENTSBindingSource;
            this.Column1.DisplayMember = "JURIDICAL_ADRESS";
            this.Column1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column1.HeaderText = "Место прописки";
            this.Column1.Name = "Column1";
            this.Column1.ValueMember = "ID";
            this.Column1.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DOCTORSID";
            this.dataGridViewTextBoxColumn3.DataSource = this.vFAMILYDOCTORRECORDSBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "FULL_NAME";
            this.dataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn3.HeaderText = "ФИО семейного врача";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "ID";
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // DOCTORSID
            // 
            this.DOCTORSID.DataPropertyName = "DOCTORSID";
            this.DOCTORSID.DataSource = this.vFAMILYDOCTORRECORDSBindingSource;
            this.DOCTORSID.DisplayMember = "EXPERIENCE";
            this.DOCTORSID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.DOCTORSID.HeaderText = "Квалификация";
            this.DOCTORSID.Name = "DOCTORSID";
            this.DOCTORSID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DOCTORSID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DOCTORSID.ValueMember = "ID";
            this.DOCTORSID.Width = 200;
            // 
            // FamilyDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 644);
            this.Controls.Add(this.fAMILY_DOCTORDataGridView);
            this.Controls.Add(this.fAMILY_DOCTORBindingNavigator);
            this.Name = "FamilyDoctors";
            this.Text = "Семейные врачи";
            this.Load += new System.EventHandler(this.FamilyDoctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fAMILY_DOCTORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fAMILY_DOCTORBindingNavigator)).EndInit();
            this.fAMILY_DOCTORBindingNavigator.ResumeLayout(false);
            this.fAMILY_DOCTORBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fAMILY_DOCTORDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vFAMILYDOCTORRECORDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource fAMILY_DOCTORBindingSource;
        private DataSet1TableAdapters.FAMILY_DOCTORTableAdapter fAMILY_DOCTORTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fAMILY_DOCTORBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton fAMILY_DOCTORBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView fAMILY_DOCTORDataGridView;
        private System.Windows.Forms.BindingSource vFAMILYDOCTORRECORDSBindingSource;
        private DataSet1TableAdapters.VFAMILYDOCTORRECORDSTableAdapter vFAMILYDOCTORRECORDSTableAdapter;
        private DataSet1TableAdapters.PATIENTSTableAdapter pATIENTSTableAdapter;
        private System.Windows.Forms.BindingSource pATIENTSBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn PATIENTSID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn DOCTORSID;

    }
}