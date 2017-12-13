namespace AutomaticMedicalSystem
{
    partial class Patients
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label fULL_NAMELabel;
            System.Windows.Forms.Label dATEBIRTHLabel;
            System.Windows.Forms.Label jURIDICAL_ADRESSLabel;
            System.Windows.Forms.Label pHYSICAL_ADRESSLabel;
            System.Windows.Forms.Label pASSPORT_DATALabel;
            System.Windows.Forms.Label pHONESLabel;
            System.Windows.Forms.Label e_MAILLabel;
            System.Windows.Forms.Label wORKPLACELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pATIENTSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AutomaticMedicalSystem.DataSet1();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.fULL_NAMETextBox = new System.Windows.Forms.TextBox();
            this.dATEBIRTHDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.jURIDICAL_ADRESSTextBox = new System.Windows.Forms.TextBox();
            this.pHYSICAL_ADRESSTextBox = new System.Windows.Forms.TextBox();
            this.pASSPORT_DATATextBox = new System.Windows.Forms.TextBox();
            this.pHONESTextBox = new System.Windows.Forms.TextBox();
            this.e_MAILTextBox = new System.Windows.Forms.TextBox();
            this.wORKPLACETextBox = new System.Windows.Forms.TextBox();
            this.pATIENTSTableAdapter = new AutomaticMedicalSystem.DataSet1TableAdapters.PATIENTSTableAdapter();
            this.tableAdapterManager = new AutomaticMedicalSystem.DataSet1TableAdapters.TableAdapterManager();
            this.pATIENTSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pATIENTSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            iDLabel = new System.Windows.Forms.Label();
            fULL_NAMELabel = new System.Windows.Forms.Label();
            dATEBIRTHLabel = new System.Windows.Forms.Label();
            jURIDICAL_ADRESSLabel = new System.Windows.Forms.Label();
            pHYSICAL_ADRESSLabel = new System.Windows.Forms.Label();
            pASSPORT_DATALabel = new System.Windows.Forms.Label();
            pHONESLabel = new System.Windows.Forms.Label();
            e_MAILLabel = new System.Windows.Forms.Label();
            wORKPLACELabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTSBindingNavigator)).BeginInit();
            this.pATIENTSBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(18, 48);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "ID:";
            // 
            // fULL_NAMELabel
            // 
            fULL_NAMELabel.AutoSize = true;
            fULL_NAMELabel.Location = new System.Drawing.Point(18, 74);
            fULL_NAMELabel.Name = "fULL_NAMELabel";
            fULL_NAMELabel.Size = new System.Drawing.Size(37, 13);
            fULL_NAMELabel.TabIndex = 2;
            fULL_NAMELabel.Text = "ФИО:";
            // 
            // dATEBIRTHLabel
            // 
            dATEBIRTHLabel.AutoSize = true;
            dATEBIRTHLabel.Location = new System.Drawing.Point(18, 101);
            dATEBIRTHLabel.Name = "dATEBIRTHLabel";
            dATEBIRTHLabel.Size = new System.Drawing.Size(89, 13);
            dATEBIRTHLabel.TabIndex = 4;
            dATEBIRTHLabel.Text = "Дата рождения:";
            // 
            // jURIDICAL_ADRESSLabel
            // 
            jURIDICAL_ADRESSLabel.AutoSize = true;
            jURIDICAL_ADRESSLabel.Location = new System.Drawing.Point(418, 45);
            jURIDICAL_ADRESSLabel.Name = "jURIDICAL_ADRESSLabel";
            jURIDICAL_ADRESSLabel.Size = new System.Drawing.Size(93, 13);
            jURIDICAL_ADRESSLabel.TabIndex = 6;
            jURIDICAL_ADRESSLabel.Text = "Место прописки:";
            // 
            // pHYSICAL_ADRESSLabel
            // 
            pHYSICAL_ADRESSLabel.AutoSize = true;
            pHYSICAL_ADRESSLabel.Location = new System.Drawing.Point(418, 70);
            pHYSICAL_ADRESSLabel.Name = "pHYSICAL_ADRESSLabel";
            pHYSICAL_ADRESSLabel.Size = new System.Drawing.Size(178, 13);
            pHYSICAL_ADRESSLabel.TabIndex = 8;
            pHYSICAL_ADRESSLabel.Text = "Фактическое место проживания:";
            // 
            // pASSPORT_DATALabel
            // 
            pASSPORT_DATALabel.AutoSize = true;
            pASSPORT_DATALabel.Location = new System.Drawing.Point(18, 143);
            pASSPORT_DATALabel.Name = "pASSPORT_DATALabel";
            pASSPORT_DATALabel.Size = new System.Drawing.Size(126, 13);
            pASSPORT_DATALabel.TabIndex = 10;
            pASSPORT_DATALabel.Text = "Серия номер паспорта:";
            // 
            // pHONESLabel
            // 
            pHONESLabel.AutoSize = true;
            pHONESLabel.Location = new System.Drawing.Point(18, 204);
            pHONESLabel.Name = "pHONESLabel";
            pHONESLabel.Size = new System.Drawing.Size(108, 13);
            pHONESLabel.TabIndex = 12;
            pHONESLabel.Text = "Номера телефонов:";
            // 
            // e_MAILLabel
            // 
            e_MAILLabel.AutoSize = true;
            e_MAILLabel.Location = new System.Drawing.Point(418, 201);
            e_MAILLabel.Name = "e_MAILLabel";
            e_MAILLabel.Size = new System.Drawing.Size(111, 13);
            e_MAILLabel.TabIndex = 14;
            e_MAILLabel.Text = "Электронный адрес:";
            // 
            // wORKPLACELabel
            // 
            wORKPLACELabel.AutoSize = true;
            wORKPLACELabel.Location = new System.Drawing.Point(418, 143);
            wORKPLACELabel.Name = "wORKPLACELabel";
            wORKPLACELabel.Size = new System.Drawing.Size(82, 13);
            wORKPLACELabel.TabIndex = 16;
            wORKPLACELabel.Text = "Место работы:";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(70, 25);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1341, 644);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tabPage1.Controls.Add(this.pATIENTSDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1333, 611);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Таблица";
            // 
            // pATIENTSDataGridView
            // 
            this.pATIENTSDataGridView.AllowUserToAddRows = false;
            this.pATIENTSDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pATIENTSDataGridView.AutoGenerateColumns = false;
            this.pATIENTSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pATIENTSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.pATIENTSDataGridView.DataSource = this.pATIENTSBindingSource;
            this.pATIENTSDataGridView.Location = new System.Drawing.Point(0, 24);
            this.pATIENTSDataGridView.Name = "pATIENTSDataGridView";
            this.pATIENTSDataGridView.Size = new System.Drawing.Size(1333, 587);
            this.pATIENTSDataGridView.TabIndex = 0;
            this.pATIENTSDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridView1_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FULL_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DATEBIRTH";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "JURIDICAL_ADRESS";
            this.dataGridViewTextBoxColumn4.HeaderText = "Место прописки";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PHYSICAL_ADRESS";
            this.dataGridViewTextBoxColumn5.HeaderText = "Место проживания";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PASSPORT_DATA";
            this.dataGridViewTextBoxColumn6.HeaderText = "Номер серия паспорта";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PHONES";
            this.dataGridViewTextBoxColumn7.HeaderText = "Номера телефонов";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "E_MAIL";
            this.dataGridViewTextBoxColumn8.HeaderText = "E_MAIL";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "WORKPLACE";
            this.dataGridViewTextBoxColumn9.HeaderText = "Место работы";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // pATIENTSBindingSource
            // 
            this.pATIENTSBindingSource.DataMember = "PATIENTS";
            this.pATIENTSBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tabPage2.Controls.Add(iDLabel);
            this.tabPage2.Controls.Add(this.iDTextBox);
            this.tabPage2.Controls.Add(fULL_NAMELabel);
            this.tabPage2.Controls.Add(this.fULL_NAMETextBox);
            this.tabPage2.Controls.Add(dATEBIRTHLabel);
            this.tabPage2.Controls.Add(this.dATEBIRTHDateTimePicker);
            this.tabPage2.Controls.Add(jURIDICAL_ADRESSLabel);
            this.tabPage2.Controls.Add(this.jURIDICAL_ADRESSTextBox);
            this.tabPage2.Controls.Add(pHYSICAL_ADRESSLabel);
            this.tabPage2.Controls.Add(this.pHYSICAL_ADRESSTextBox);
            this.tabPage2.Controls.Add(pASSPORT_DATALabel);
            this.tabPage2.Controls.Add(this.pASSPORT_DATATextBox);
            this.tabPage2.Controls.Add(pHONESLabel);
            this.tabPage2.Controls.Add(this.pHONESTextBox);
            this.tabPage2.Controls.Add(e_MAILLabel);
            this.tabPage2.Controls.Add(this.e_MAILTextBox);
            this.tabPage2.Controls.Add(wORKPLACELabel);
            this.tabPage2.Controls.Add(this.wORKPLACETextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1333, 611);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Запись";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTSBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(150, 45);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDTextBox.TabIndex = 1;
            // 
            // fULL_NAMETextBox
            // 
            this.fULL_NAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTSBindingSource, "FULL_NAME", true));
            this.fULL_NAMETextBox.Location = new System.Drawing.Point(150, 71);
            this.fULL_NAMETextBox.Name = "fULL_NAMETextBox";
            this.fULL_NAMETextBox.Size = new System.Drawing.Size(200, 20);
            this.fULL_NAMETextBox.TabIndex = 3;
            // 
            // dATEBIRTHDateTimePicker
            // 
            this.dATEBIRTHDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pATIENTSBindingSource, "DATEBIRTH", true));
            this.dATEBIRTHDateTimePicker.Location = new System.Drawing.Point(150, 97);
            this.dATEBIRTHDateTimePicker.Name = "dATEBIRTHDateTimePicker";
            this.dATEBIRTHDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dATEBIRTHDateTimePicker.TabIndex = 5;
            // 
            // jURIDICAL_ADRESSTextBox
            // 
            this.jURIDICAL_ADRESSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTSBindingSource, "JURIDICAL_ADRESS", true));
            this.jURIDICAL_ADRESSTextBox.Location = new System.Drawing.Point(599, 42);
            this.jURIDICAL_ADRESSTextBox.Name = "jURIDICAL_ADRESSTextBox";
            this.jURIDICAL_ADRESSTextBox.Size = new System.Drawing.Size(200, 20);
            this.jURIDICAL_ADRESSTextBox.TabIndex = 7;
            // 
            // pHYSICAL_ADRESSTextBox
            // 
            this.pHYSICAL_ADRESSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTSBindingSource, "PHYSICAL_ADRESS", true));
            this.pHYSICAL_ADRESSTextBox.Location = new System.Drawing.Point(599, 67);
            this.pHYSICAL_ADRESSTextBox.Name = "pHYSICAL_ADRESSTextBox";
            this.pHYSICAL_ADRESSTextBox.Size = new System.Drawing.Size(200, 20);
            this.pHYSICAL_ADRESSTextBox.TabIndex = 9;
            // 
            // pASSPORT_DATATextBox
            // 
            this.pASSPORT_DATATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTSBindingSource, "PASSPORT_DATA", true));
            this.pASSPORT_DATATextBox.Location = new System.Drawing.Point(150, 143);
            this.pASSPORT_DATATextBox.Name = "pASSPORT_DATATextBox";
            this.pASSPORT_DATATextBox.Size = new System.Drawing.Size(200, 20);
            this.pASSPORT_DATATextBox.TabIndex = 11;
            // 
            // pHONESTextBox
            // 
            this.pHONESTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTSBindingSource, "PHONES", true));
            this.pHONESTextBox.Location = new System.Drawing.Point(150, 201);
            this.pHONESTextBox.Name = "pHONESTextBox";
            this.pHONESTextBox.Size = new System.Drawing.Size(200, 20);
            this.pHONESTextBox.TabIndex = 13;
            // 
            // e_MAILTextBox
            // 
            this.e_MAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTSBindingSource, "E_MAIL", true));
            this.e_MAILTextBox.Location = new System.Drawing.Point(599, 201);
            this.e_MAILTextBox.Name = "e_MAILTextBox";
            this.e_MAILTextBox.Size = new System.Drawing.Size(200, 20);
            this.e_MAILTextBox.TabIndex = 15;
            // 
            // wORKPLACETextBox
            // 
            this.wORKPLACETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pATIENTSBindingSource, "WORKPLACE", true));
            this.wORKPLACETextBox.Location = new System.Drawing.Point(599, 143);
            this.wORKPLACETextBox.Name = "wORKPLACETextBox";
            this.wORKPLACETextBox.Size = new System.Drawing.Size(200, 20);
            this.wORKPLACETextBox.TabIndex = 17;
            // 
            // pATIENTSTableAdapter
            // 
            this.pATIENTSTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.FAMILY_DOCTORTableAdapter = null;
            this.tableAdapterManager.PATIENTSTableAdapter = this.pATIENTSTableAdapter;
            this.tableAdapterManager.UpdateOrder = AutomaticMedicalSystem.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pATIENTSBindingNavigator
            // 
            this.pATIENTSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pATIENTSBindingNavigator.BindingSource = this.pATIENTSBindingSource;
            this.pATIENTSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pATIENTSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pATIENTSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pATIENTSBindingNavigatorSaveItem});
            this.pATIENTSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pATIENTSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pATIENTSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pATIENTSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pATIENTSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pATIENTSBindingNavigator.Name = "pATIENTSBindingNavigator";
            this.pATIENTSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pATIENTSBindingNavigator.Size = new System.Drawing.Size(1341, 25);
            this.pATIENTSBindingNavigator.TabIndex = 1;
            this.pATIENTSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // pATIENTSBindingNavigatorSaveItem
            // 
            this.pATIENTSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pATIENTSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pATIENTSBindingNavigatorSaveItem.Image")));
            this.pATIENTSBindingNavigatorSaveItem.Name = "pATIENTSBindingNavigatorSaveItem";
            this.pATIENTSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pATIENTSBindingNavigatorSaveItem.Text = "Save Data";
            this.pATIENTSBindingNavigatorSaveItem.Click += new System.EventHandler(this.pATIENTSBindingNavigatorSaveItem_Click);
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 644);
            this.Controls.Add(this.pATIENTSBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.Name = "Patients";
            this.Text = "Пациенты";
            this.Load += new System.EventHandler(this.Patients_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTSBindingNavigator)).EndInit();
            this.pATIENTSBindingNavigator.ResumeLayout(false);
            this.pATIENTSBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pATIENTSBindingSource;
        private DataSet1TableAdapters.PATIENTSTableAdapter pATIENTSTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pATIENTSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pATIENTSBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pATIENTSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox fULL_NAMETextBox;
        private System.Windows.Forms.DateTimePicker dATEBIRTHDateTimePicker;
        private System.Windows.Forms.TextBox jURIDICAL_ADRESSTextBox;
        private System.Windows.Forms.TextBox pHYSICAL_ADRESSTextBox;
        private System.Windows.Forms.TextBox pASSPORT_DATATextBox;
        private System.Windows.Forms.TextBox pHONESTextBox;
        private System.Windows.Forms.TextBox e_MAILTextBox;
        private System.Windows.Forms.TextBox wORKPLACETextBox;

    }
}