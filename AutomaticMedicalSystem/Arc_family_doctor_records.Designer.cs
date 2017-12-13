namespace AutomaticMedicalSystem
{
    partial class Arc_family_doctor_records
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arc_family_doctor_records));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label aRCDATELabel;
            System.Windows.Forms.Label fAMILYDOCTORIDLabel;
            this.dataSet1 = new AutomaticMedicalSystem.DataSet1();
            this.aRC_FAMILY_DOCTOR_RECORDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aRC_FAMILY_DOCTOR_RECORDSTableAdapter = new AutomaticMedicalSystem.DataSet1TableAdapters.ARC_FAMILY_DOCTOR_RECORDSTableAdapter();
            this.tableAdapterManager = new AutomaticMedicalSystem.DataSet1TableAdapters.TableAdapterManager();
            this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vFAMILYDOCTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vFAMILYDOCTORTableAdapter = new AutomaticMedicalSystem.DataSet1TableAdapters.VFAMILYDOCTORTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.aRC_FAMILY_DOCTOR_RECORDSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.aRCDATEDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fAMILYDOCTORIDComboBox = new System.Windows.Forms.ComboBox();
            iDLabel = new System.Windows.Forms.Label();
            aRCDATELabel = new System.Windows.Forms.Label();
            fAMILYDOCTORIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRC_FAMILY_DOCTOR_RECORDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigator)).BeginInit();
            this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vFAMILYDOCTORBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aRC_FAMILY_DOCTOR_RECORDSDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aRC_FAMILY_DOCTOR_RECORDSBindingSource
            // 
            this.aRC_FAMILY_DOCTOR_RECORDSBindingSource.DataMember = "ARC_FAMILY_DOCTOR_RECORDS";
            this.aRC_FAMILY_DOCTOR_RECORDSBindingSource.DataSource = this.dataSet1;
            // 
            // aRC_FAMILY_DOCTOR_RECORDSTableAdapter
            // 
            this.aRC_FAMILY_DOCTOR_RECORDSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ARC_FAMILY_DOCTOR_RECORDSTableAdapter = this.aRC_FAMILY_DOCTOR_RECORDSTableAdapter;
            this.tableAdapterManager.ARC_SP_DOCTOR_RECORDSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DEPARTMENTTableAdapter = null;
            this.tableAdapterManager.DIAGNOSE_FM_DOCTORTableAdapter = null;
            this.tableAdapterManager.DIAGNOSE_SP_DOCTORTableAdapter = null;
            this.tableAdapterManager.DOCTORSTableAdapter = null;
            this.tableAdapterManager.FAMILY_DOCTORTableAdapter = null;
            this.tableAdapterManager.PATIENTSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AutomaticMedicalSystem.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aRC_FAMILY_DOCTOR_RECORDSBindingNavigator
            // 
            this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigator.BindingSource = this.aRC_FAMILY_DOCTOR_RECORDSBindingSource;
            this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigatorSaveItem});
            this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigator.Name = "aRC_FAMILY_DOCTOR_RECORDSBindingNavigator";
            this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigator.Size = new System.Drawing.Size(1349, 25);
            this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigator.TabIndex = 0;
            this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigator.Text = "bindingNavigator1";
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
            // aRC_FAMILY_DOCTOR_RECORDSBindingNavigatorSaveItem
            // 
            this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aRC_FAMILY_DOCTOR_RECORDSBindingNavigatorSaveItem.Image")));
            this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigatorSaveItem.Name = "aRC_FAMILY_DOCTOR_RECORDSBindingNavigatorSaveItem";
            this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigatorSaveItem.Text = "Save Data";
            this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigatorSaveItem.Click += new System.EventHandler(this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigatorSaveItem_Click_2);
            // 
            // vFAMILYDOCTORBindingSource
            // 
            this.vFAMILYDOCTORBindingSource.DataMember = "VFAMILYDOCTOR";
            this.vFAMILYDOCTORBindingSource.DataSource = this.dataSet1;
            // 
            // vFAMILYDOCTORTableAdapter
            // 
            this.vFAMILYDOCTORTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1349, 624);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.aRC_FAMILY_DOCTOR_RECORDSDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1341, 598);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // aRC_FAMILY_DOCTOR_RECORDSDataGridView
            // 
            this.aRC_FAMILY_DOCTOR_RECORDSDataGridView.AllowUserToAddRows = false;
            this.aRC_FAMILY_DOCTOR_RECORDSDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aRC_FAMILY_DOCTOR_RECORDSDataGridView.AutoGenerateColumns = false;
            this.aRC_FAMILY_DOCTOR_RECORDSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aRC_FAMILY_DOCTOR_RECORDSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.Column1,
            this.Column2,
            this.Column3});
            this.aRC_FAMILY_DOCTOR_RECORDSDataGridView.DataSource = this.aRC_FAMILY_DOCTOR_RECORDSBindingSource;
            this.aRC_FAMILY_DOCTOR_RECORDSDataGridView.Location = new System.Drawing.Point(0, 13);
            this.aRC_FAMILY_DOCTOR_RECORDSDataGridView.Name = "aRC_FAMILY_DOCTOR_RECORDSDataGridView";
            this.aRC_FAMILY_DOCTOR_RECORDSDataGridView.Size = new System.Drawing.Size(1341, 573);
            this.aRC_FAMILY_DOCTOR_RECORDSDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ARCDATE";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата записи";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FAMILYDOCTORID";
            this.Column1.DataSource = this.vFAMILYDOCTORBindingSource;
            this.Column1.DisplayMember = "FULL_NAME_PATIENT";
            this.Column1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column1.HeaderText = "ФИО пациента";
            this.Column1.Name = "Column1";
            this.Column1.ValueMember = "ID";
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FAMILYDOCTORID";
            this.Column2.DataSource = this.vFAMILYDOCTORBindingSource;
            this.Column2.DisplayMember = "DATEBIRTH";
            this.Column2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column2.HeaderText = "Дата рождения пациента";
            this.Column2.Name = "Column2";
            this.Column2.ValueMember = "ID";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "FAMILYDOCTORID";
            this.Column3.DataSource = this.vFAMILYDOCTORBindingSource;
            this.Column3.DisplayMember = "FULL_NAME_DOCTOR";
            this.Column3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column3.HeaderText = "ФИО семейного врача";
            this.Column3.Name = "Column3";
            this.Column3.ValueMember = "ID";
            this.Column3.Width = 300;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(fAMILYDOCTORIDLabel);
            this.tabPage2.Controls.Add(this.fAMILYDOCTORIDComboBox);
            this.tabPage2.Controls.Add(aRCDATELabel);
            this.tabPage2.Controls.Add(this.aRCDATEDateTimePicker);
            this.tabPage2.Controls.Add(iDLabel);
            this.tabPage2.Controls.Add(this.iDTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1341, 598);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // aRCDATEDateTimePicker
            // 
            this.aRCDATEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aRC_FAMILY_DOCTOR_RECORDSBindingSource, "ARCDATE", true));
            this.aRCDATEDateTimePicker.Location = new System.Drawing.Point(76, 45);
            this.aRCDATEDateTimePicker.Name = "aRCDATEDateTimePicker";
            this.aRCDATEDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.aRCDATEDateTimePicker.TabIndex = 3;
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(10, 22);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRC_FAMILY_DOCTOR_RECORDSBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(76, 19);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // aRCDATELabel
            // 
            aRCDATELabel.AutoSize = true;
            aRCDATELabel.Location = new System.Drawing.Point(9, 49);
            aRCDATELabel.Name = "aRCDATELabel";
            aRCDATELabel.Size = new System.Drawing.Size(61, 13);
            aRCDATELabel.TabIndex = 2;
            aRCDATELabel.Text = "ARCDATE:";
            // 
            // fAMILYDOCTORIDLabel
            // 
            fAMILYDOCTORIDLabel.AutoSize = true;
            fAMILYDOCTORIDLabel.Location = new System.Drawing.Point(5, 74);
            fAMILYDOCTORIDLabel.Name = "fAMILYDOCTORIDLabel";
            fAMILYDOCTORIDLabel.Size = new System.Drawing.Size(105, 13);
            fAMILYDOCTORIDLabel.TabIndex = 4;
            fAMILYDOCTORIDLabel.Text = "FAMILYDOCTORID:";
            // 
            // fAMILYDOCTORIDComboBox
            // 
            this.fAMILYDOCTORIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRC_FAMILY_DOCTOR_RECORDSBindingSource, "FAMILYDOCTORID", true));
            this.fAMILYDOCTORIDComboBox.DataSource = this.vFAMILYDOCTORBindingSource;
            this.fAMILYDOCTORIDComboBox.DisplayMember = "ID";
            this.fAMILYDOCTORIDComboBox.FormattingEnabled = true;
            this.fAMILYDOCTORIDComboBox.Location = new System.Drawing.Point(116, 71);
            this.fAMILYDOCTORIDComboBox.Name = "fAMILYDOCTORIDComboBox";
            this.fAMILYDOCTORIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.fAMILYDOCTORIDComboBox.TabIndex = 5;
            // 
            // Arc_family_doctor_records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 652);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigator);
            this.Name = "Arc_family_doctor_records";
            this.Text = "Записи к семейному врачу";
            this.Load += new System.EventHandler(this.Arc_family_doctor_records_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRC_FAMILY_DOCTOR_RECORDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigator)).EndInit();
            this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigator.ResumeLayout(false);
            this.aRC_FAMILY_DOCTOR_RECORDSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vFAMILYDOCTORBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aRC_FAMILY_DOCTOR_RECORDSDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource aRC_FAMILY_DOCTOR_RECORDSBindingSource;
        private DataSet1TableAdapters.ARC_FAMILY_DOCTOR_RECORDSTableAdapter aRC_FAMILY_DOCTOR_RECORDSTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aRC_FAMILY_DOCTOR_RECORDSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton aRC_FAMILY_DOCTOR_RECORDSBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource vFAMILYDOCTORBindingSource;
        private DataSet1TableAdapters.VFAMILYDOCTORTableAdapter vFAMILYDOCTORTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView aRC_FAMILY_DOCTOR_RECORDSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker aRCDATEDateTimePicker;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox fAMILYDOCTORIDComboBox;


    }
}