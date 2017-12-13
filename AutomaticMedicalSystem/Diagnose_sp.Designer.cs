namespace AutomaticMedicalSystem
{
    partial class Diagnose_sp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diagnose_sp));
            System.Windows.Forms.Label iDLabel;
            this.dataSet1 = new AutomaticMedicalSystem.DataSet1();
            this.dIAGNOSE_SP_DOCTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIAGNOSE_SP_DOCTORTableAdapter = new AutomaticMedicalSystem.DataSet1TableAdapters.DIAGNOSE_SP_DOCTORTableAdapter();
            this.tableAdapterManager = new AutomaticMedicalSystem.DataSet1TableAdapters.TableAdapterManager();
            this.dIAGNOSE_SP_DOCTORBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dIAGNOSE_SP_DOCTORBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.dIAGNOSE_SP_DOCTORDataGridView = new System.Windows.Forms.DataGridView();
            this.vARCSPDOCTORRECORDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vARCSPDOCTORRECORDSTableAdapter = new AutomaticMedicalSystem.DataSet1TableAdapters.VARCSPDOCTORRECORDSTableAdapter();
            this.vARCSPDOCTORRECORDSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rECOMENDATIONTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ARCSPDOCTORID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            iDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIAGNOSE_SP_DOCTORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIAGNOSE_SP_DOCTORBindingNavigator)).BeginInit();
            this.dIAGNOSE_SP_DOCTORBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dIAGNOSE_SP_DOCTORDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vARCSPDOCTORRECORDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vARCSPDOCTORRECORDSBindingSource1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dIAGNOSE_SP_DOCTORBindingSource
            // 
            this.dIAGNOSE_SP_DOCTORBindingSource.DataMember = "DIAGNOSE_SP_DOCTOR";
            this.dIAGNOSE_SP_DOCTORBindingSource.DataSource = this.dataSet1;
            // 
            // dIAGNOSE_SP_DOCTORTableAdapter
            // 
            this.dIAGNOSE_SP_DOCTORTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ARC_FAMILY_DOCTOR_RECORDSTableAdapter = null;
            this.tableAdapterManager.ARC_SP_DOCTOR_RECORDSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DEPARTMENTTableAdapter = null;
            this.tableAdapterManager.DIAGNOSE_FM_DOCTORTableAdapter = null;
            this.tableAdapterManager.DIAGNOSE_SP_DOCTORTableAdapter = this.dIAGNOSE_SP_DOCTORTableAdapter;
            this.tableAdapterManager.DOCTORSTableAdapter = null;
            this.tableAdapterManager.FAMILY_DOCTORTableAdapter = null;
            this.tableAdapterManager.PATIENTSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AutomaticMedicalSystem.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dIAGNOSE_SP_DOCTORBindingNavigator
            // 
            this.dIAGNOSE_SP_DOCTORBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dIAGNOSE_SP_DOCTORBindingNavigator.BindingSource = this.dIAGNOSE_SP_DOCTORBindingSource;
            this.dIAGNOSE_SP_DOCTORBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dIAGNOSE_SP_DOCTORBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dIAGNOSE_SP_DOCTORBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dIAGNOSE_SP_DOCTORBindingNavigatorSaveItem});
            this.dIAGNOSE_SP_DOCTORBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dIAGNOSE_SP_DOCTORBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dIAGNOSE_SP_DOCTORBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dIAGNOSE_SP_DOCTORBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dIAGNOSE_SP_DOCTORBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dIAGNOSE_SP_DOCTORBindingNavigator.Name = "dIAGNOSE_SP_DOCTORBindingNavigator";
            this.dIAGNOSE_SP_DOCTORBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dIAGNOSE_SP_DOCTORBindingNavigator.Size = new System.Drawing.Size(1353, 25);
            this.dIAGNOSE_SP_DOCTORBindingNavigator.TabIndex = 0;
            this.dIAGNOSE_SP_DOCTORBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // dIAGNOSE_SP_DOCTORBindingNavigatorSaveItem
            // 
            this.dIAGNOSE_SP_DOCTORBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dIAGNOSE_SP_DOCTORBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dIAGNOSE_SP_DOCTORBindingNavigatorSaveItem.Image")));
            this.dIAGNOSE_SP_DOCTORBindingNavigatorSaveItem.Name = "dIAGNOSE_SP_DOCTORBindingNavigatorSaveItem";
            this.dIAGNOSE_SP_DOCTORBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dIAGNOSE_SP_DOCTORBindingNavigatorSaveItem.Text = "Save Data";
            this.dIAGNOSE_SP_DOCTORBindingNavigatorSaveItem.Click += new System.EventHandler(this.dIAGNOSE_SP_DOCTORBindingNavigatorSaveItem_Click);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(1, 31);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dIAGNOSE_SP_DOCTORBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(28, 28);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // dIAGNOSE_SP_DOCTORDataGridView
            // 
            this.dIAGNOSE_SP_DOCTORDataGridView.AllowUserToAddRows = false;
            this.dIAGNOSE_SP_DOCTORDataGridView.AutoGenerateColumns = false;
            this.dIAGNOSE_SP_DOCTORDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dIAGNOSE_SP_DOCTORDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.ARCSPDOCTORID,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dIAGNOSE_SP_DOCTORDataGridView.DataSource = this.dIAGNOSE_SP_DOCTORBindingSource;
            this.dIAGNOSE_SP_DOCTORDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dIAGNOSE_SP_DOCTORDataGridView.Location = new System.Drawing.Point(0, 25);
            this.dIAGNOSE_SP_DOCTORDataGridView.Name = "dIAGNOSE_SP_DOCTORDataGridView";
            this.dIAGNOSE_SP_DOCTORDataGridView.Size = new System.Drawing.Size(1353, 303);
            this.dIAGNOSE_SP_DOCTORDataGridView.TabIndex = 3;
            // 
            // vARCSPDOCTORRECORDSBindingSource
            // 
            this.vARCSPDOCTORRECORDSBindingSource.DataMember = "VARCSPDOCTORRECORDS";
            this.vARCSPDOCTORRECORDSBindingSource.DataSource = this.dataSet1;
            // 
            // vARCSPDOCTORRECORDSTableAdapter
            // 
            this.vARCSPDOCTORRECORDSTableAdapter.ClearBeforeFill = true;
            // 
            // vARCSPDOCTORRECORDSBindingSource1
            // 
            this.vARCSPDOCTORRECORDSBindingSource1.DataMember = "VARCSPDOCTORRECORDS";
            this.vARCSPDOCTORRECORDSBindingSource1.DataSource = this.dataSet1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 18);
            this.tabControl1.Location = new System.Drawing.Point(0, 363);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1341, 279);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1333, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Диагноз";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rECOMENDATIONTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1333, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Рекомендации";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dIAGNOSE_SP_DOCTORBindingSource, "DIAGNOSE", true));
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1327, 247);
            this.textBox1.TabIndex = 2;
            // 
            // rECOMENDATIONTextBox
            // 
            this.rECOMENDATIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dIAGNOSE_SP_DOCTORBindingSource, "RECOMENDATION", true));
            this.rECOMENDATIONTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rECOMENDATIONTextBox.Location = new System.Drawing.Point(3, 3);
            this.rECOMENDATIONTextBox.Multiline = true;
            this.rECOMENDATIONTextBox.Name = "rECOMENDATIONTextBox";
            this.rECOMENDATIONTextBox.Size = new System.Drawing.Size(1327, 247);
            this.rECOMENDATIONTextBox.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ARCSPDOCTORID";
            this.dataGridViewTextBoxColumn2.DataSource = this.vARCSPDOCTORRECORDSBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "ARCDATE";
            this.dataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата записи на прием";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "ID";
            // 
            // ARCSPDOCTORID
            // 
            this.ARCSPDOCTORID.DataPropertyName = "ARCSPDOCTORID";
            this.ARCSPDOCTORID.DataSource = this.vARCSPDOCTORRECORDSBindingSource;
            this.ARCSPDOCTORID.DisplayMember = "FULL_NAME_PATIENT";
            this.ARCSPDOCTORID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ARCSPDOCTORID.HeaderText = "ФИО пациента";
            this.ARCSPDOCTORID.Name = "ARCSPDOCTORID";
            this.ARCSPDOCTORID.ValueMember = "ID";
            this.ARCSPDOCTORID.Width = 300;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ARCSPDOCTORID";
            this.Column1.DataSource = this.vARCSPDOCTORRECORDSBindingSource;
            this.Column1.DisplayMember = "DATEBIRTH";
            this.Column1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column1.HeaderText = "Дата рождения";
            this.Column1.Name = "Column1";
            this.Column1.ValueMember = "ID";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ARCSPDOCTORID";
            this.Column2.DataSource = this.vARCSPDOCTORRECORDSBindingSource;
            this.Column2.DisplayMember = "JURIDICAL_ADRESS_PATIENT";
            this.Column2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column2.HeaderText = "Место прописки";
            this.Column2.Name = "Column2";
            this.Column2.ValueMember = "ID";
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ARCSPDOCTORID";
            this.Column3.DataSource = this.vARCSPDOCTORRECORDSBindingSource;
            this.Column3.DisplayMember = "FULL_NAME";
            this.Column3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column3.HeaderText = "ФИО врача";
            this.Column3.Name = "Column3";
            this.Column3.ValueMember = "ID";
            this.Column3.Width = 300;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ARCSPDOCTORID";
            this.Column4.DataSource = this.vARCSPDOCTORRECORDSBindingSource;
            this.Column4.DisplayMember = "EXPERIENCE";
            this.Column4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column4.HeaderText = "Квалификация";
            this.Column4.Name = "Column4";
            this.Column4.ValueMember = "ID";
            this.Column4.Width = 200;
            // 
            // Diagnose_sp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 644);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dIAGNOSE_SP_DOCTORDataGridView);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.dIAGNOSE_SP_DOCTORBindingNavigator);
            this.Name = "Diagnose_sp";
            this.Text = "Диагноз врача специалиста";
            this.Load += new System.EventHandler(this.Diagnose_sp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIAGNOSE_SP_DOCTORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIAGNOSE_SP_DOCTORBindingNavigator)).EndInit();
            this.dIAGNOSE_SP_DOCTORBindingNavigator.ResumeLayout(false);
            this.dIAGNOSE_SP_DOCTORBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dIAGNOSE_SP_DOCTORDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vARCSPDOCTORRECORDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vARCSPDOCTORRECORDSBindingSource1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dIAGNOSE_SP_DOCTORBindingSource;
        private DataSet1TableAdapters.DIAGNOSE_SP_DOCTORTableAdapter dIAGNOSE_SP_DOCTORTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dIAGNOSE_SP_DOCTORBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dIAGNOSE_SP_DOCTORBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.DataGridView dIAGNOSE_SP_DOCTORDataGridView;
        private System.Windows.Forms.BindingSource vARCSPDOCTORRECORDSBindingSource;
        private DataSet1TableAdapters.VARCSPDOCTORRECORDSTableAdapter vARCSPDOCTORRECORDSTableAdapter;
        private System.Windows.Forms.BindingSource vARCSPDOCTORRECORDSBindingSource1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox rECOMENDATIONTextBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn ARCSPDOCTORID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column4;
    }
}