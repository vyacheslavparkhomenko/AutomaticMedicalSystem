namespace AutomaticMedicalSystem
{
    partial class Departments
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
            System.Windows.Forms.Label nAMELabel;
            System.Windows.Forms.Label dIRECTORLabel;
            System.Windows.Forms.Label pHONELabel;
            System.Windows.Forms.Label pHONE_DIRECTORLabel;
            System.Windows.Forms.Label dATEWORKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departments));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dEPARTMENTDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPARTMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AutomaticMedicalSystem.DataSet1();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nAMETextBox = new System.Windows.Forms.TextBox();
            this.dIRECTORTextBox = new System.Windows.Forms.TextBox();
            this.pHONETextBox = new System.Windows.Forms.TextBox();
            this.pHONE_DIRECTORTextBox = new System.Windows.Forms.TextBox();
            this.dATEWORKTextBox = new System.Windows.Forms.TextBox();
            this.dEPARTMENTTableAdapter = new AutomaticMedicalSystem.DataSet1TableAdapters.DEPARTMENTTableAdapter();
            this.tableAdapterManager = new AutomaticMedicalSystem.DataSet1TableAdapters.TableAdapterManager();
            this.dEPARTMENTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dEPARTMENTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            iDLabel = new System.Windows.Forms.Label();
            nAMELabel = new System.Windows.Forms.Label();
            dIRECTORLabel = new System.Windows.Forms.Label();
            pHONELabel = new System.Windows.Forms.Label();
            pHONE_DIRECTORLabel = new System.Windows.Forms.Label();
            dATEWORKLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTBindingNavigator)).BeginInit();
            this.dEPARTMENTBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(24, 56);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "ID:";
            // 
            // nAMELabel
            // 
            nAMELabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            nAMELabel.AutoSize = true;
            nAMELabel.Location = new System.Drawing.Point(24, 82);
            nAMELabel.Name = "nAMELabel";
            nAMELabel.Size = new System.Drawing.Size(86, 13);
            nAMELabel.TabIndex = 2;
            nAMELabel.Text = "Наименование:";
            // 
            // dIRECTORLabel
            // 
            dIRECTORLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dIRECTORLabel.AutoSize = true;
            dIRECTORLabel.Location = new System.Drawing.Point(24, 108);
            dIRECTORLabel.Name = "dIRECTORLabel";
            dIRECTORLabel.Size = new System.Drawing.Size(75, 13);
            dIRECTORLabel.TabIndex = 4;
            dIRECTORLabel.Text = "Заведующий:";
            // 
            // pHONELabel
            // 
            pHONELabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            pHONELabel.AutoSize = true;
            pHONELabel.Location = new System.Drawing.Point(998, 53);
            pHONELabel.Name = "pHONELabel";
            pHONELabel.Size = new System.Drawing.Size(48, 13);
            pHONELabel.TabIndex = 6;
            pHONELabel.Text = "PHONE:";
            // 
            // pHONE_DIRECTORLabel
            // 
            pHONE_DIRECTORLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            pHONE_DIRECTORLabel.AutoSize = true;
            pHONE_DIRECTORLabel.Location = new System.Drawing.Point(998, 79);
            pHONE_DIRECTORLabel.Name = "pHONE_DIRECTORLabel";
            pHONE_DIRECTORLabel.Size = new System.Drawing.Size(107, 13);
            pHONE_DIRECTORLabel.TabIndex = 8;
            pHONE_DIRECTORLabel.Text = "PHONE DIRECTOR:";
            // 
            // dATEWORKLabel
            // 
            dATEWORKLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dATEWORKLabel.AutoSize = true;
            dATEWORKLabel.Location = new System.Drawing.Point(24, 134);
            dATEWORKLabel.Name = "dATEWORKLabel";
            dATEWORKLabel.Size = new System.Drawing.Size(78, 13);
            dATEWORKLabel.TabIndex = 10;
            dATEWORKLabel.Text = "Часы работы:";
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
            this.tabPage1.Controls.Add(this.dEPARTMENTDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1333, 611);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Таблица";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dEPARTMENTDataGridView
            // 
            this.dEPARTMENTDataGridView.AllowUserToAddRows = false;
            this.dEPARTMENTDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dEPARTMENTDataGridView.AutoGenerateColumns = false;
            this.dEPARTMENTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dEPARTMENTDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dEPARTMENTDataGridView.DataSource = this.dEPARTMENTBindingSource;
            this.dEPARTMENTDataGridView.Location = new System.Drawing.Point(0, 24);
            this.dEPARTMENTDataGridView.Name = "dEPARTMENTDataGridView";
            this.dEPARTMENTDataGridView.Size = new System.Drawing.Size(1333, 587);
            this.dEPARTMENTDataGridView.TabIndex = 0;
            this.dEPARTMENTDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dEPARTMENTDataGridView_CellContentClick);
            this.dEPARTMENTDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridView1_DataError);
            this.dEPARTMENTDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dEPARTMENTDataGridView_DefaultValuesNeeded);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Отделение";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DIRECTOR";
            this.dataGridViewTextBoxColumn3.HeaderText = "Заведующий";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PHONE";
            this.dataGridViewTextBoxColumn4.HeaderText = "Телефон отделения";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PHONE_DIRECTOR";
            this.dataGridViewTextBoxColumn5.HeaderText = "Телефон заведующего";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DATEWORK";
            this.dataGridViewTextBoxColumn6.HeaderText = "Режим работы";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dEPARTMENTBindingSource
            // 
            this.dEPARTMENTBindingSource.DataMember = "DEPARTMENT";
            this.dEPARTMENTBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(iDLabel);
            this.tabPage2.Controls.Add(this.iDTextBox);
            this.tabPage2.Controls.Add(nAMELabel);
            this.tabPage2.Controls.Add(this.nAMETextBox);
            this.tabPage2.Controls.Add(dIRECTORLabel);
            this.tabPage2.Controls.Add(this.dIRECTORTextBox);
            this.tabPage2.Controls.Add(pHONELabel);
            this.tabPage2.Controls.Add(this.pHONETextBox);
            this.tabPage2.Controls.Add(pHONE_DIRECTORLabel);
            this.tabPage2.Controls.Add(this.pHONE_DIRECTORTextBox);
            this.tabPage2.Controls.Add(dATEWORKLabel);
            this.tabPage2.Controls.Add(this.dATEWORKTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1333, 611);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Запись";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dEPARTMENTBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(137, 53);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(96, 20);
            this.iDTextBox.TabIndex = 1;
            // 
            // nAMETextBox
            // 
            this.nAMETextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nAMETextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dEPARTMENTBindingSource, "NAME", true));
            this.nAMETextBox.Location = new System.Drawing.Point(137, 79);
            this.nAMETextBox.Name = "nAMETextBox";
            this.nAMETextBox.Size = new System.Drawing.Size(197, 20);
            this.nAMETextBox.TabIndex = 3;
            // 
            // dIRECTORTextBox
            // 
            this.dIRECTORTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dIRECTORTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dIRECTORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dEPARTMENTBindingSource, "DIRECTOR", true));
            this.dIRECTORTextBox.Location = new System.Drawing.Point(137, 105);
            this.dIRECTORTextBox.Name = "dIRECTORTextBox";
            this.dIRECTORTextBox.Size = new System.Drawing.Size(197, 20);
            this.dIRECTORTextBox.TabIndex = 5;
            // 
            // pHONETextBox
            // 
            this.pHONETextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pHONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dEPARTMENTBindingSource, "PHONE", true));
            this.pHONETextBox.Location = new System.Drawing.Point(1111, 50);
            this.pHONETextBox.Name = "pHONETextBox";
            this.pHONETextBox.Size = new System.Drawing.Size(165, 20);
            this.pHONETextBox.TabIndex = 7;
            // 
            // pHONE_DIRECTORTextBox
            // 
            this.pHONE_DIRECTORTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pHONE_DIRECTORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dEPARTMENTBindingSource, "PHONE_DIRECTOR", true));
            this.pHONE_DIRECTORTextBox.Location = new System.Drawing.Point(1111, 76);
            this.pHONE_DIRECTORTextBox.Name = "pHONE_DIRECTORTextBox";
            this.pHONE_DIRECTORTextBox.Size = new System.Drawing.Size(165, 20);
            this.pHONE_DIRECTORTextBox.TabIndex = 9;
            // 
            // dATEWORKTextBox
            // 
            this.dATEWORKTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dATEWORKTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dATEWORKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dEPARTMENTBindingSource, "DATEWORK", true));
            this.dATEWORKTextBox.Location = new System.Drawing.Point(137, 131);
            this.dATEWORKTextBox.Name = "dATEWORKTextBox";
            this.dATEWORKTextBox.Size = new System.Drawing.Size(197, 20);
            this.dATEWORKTextBox.TabIndex = 11;
            // 
            // dEPARTMENTTableAdapter
            // 
            this.dEPARTMENTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ARC_FAMILY_DOCTOR_RECORDSTableAdapter = null;
            this.tableAdapterManager.ARC_SP_DOCTOR_RECORDSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DEPARTMENTTableAdapter = this.dEPARTMENTTableAdapter;
            this.tableAdapterManager.DIAGNOSE_FM_DOCTORTableAdapter = null;
            this.tableAdapterManager.DIAGNOSE_SP_DOCTORTableAdapter = null;
            this.tableAdapterManager.DOCTORSTableAdapter = null;
            this.tableAdapterManager.FAMILY_DOCTORTableAdapter = null;
            this.tableAdapterManager.PATIENTSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AutomaticMedicalSystem.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dEPARTMENTBindingNavigator
            // 
            this.dEPARTMENTBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dEPARTMENTBindingNavigator.BindingSource = this.dEPARTMENTBindingSource;
            this.dEPARTMENTBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dEPARTMENTBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dEPARTMENTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dEPARTMENTBindingNavigatorSaveItem});
            this.dEPARTMENTBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dEPARTMENTBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dEPARTMENTBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dEPARTMENTBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dEPARTMENTBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dEPARTMENTBindingNavigator.Name = "dEPARTMENTBindingNavigator";
            this.dEPARTMENTBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dEPARTMENTBindingNavigator.Size = new System.Drawing.Size(1341, 25);
            this.dEPARTMENTBindingNavigator.TabIndex = 1;
            this.dEPARTMENTBindingNavigator.Text = "bindingNavigator1";
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
            // dEPARTMENTBindingNavigatorSaveItem
            // 
            this.dEPARTMENTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dEPARTMENTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dEPARTMENTBindingNavigatorSaveItem.Image")));
            this.dEPARTMENTBindingNavigatorSaveItem.Name = "dEPARTMENTBindingNavigatorSaveItem";
            this.dEPARTMENTBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dEPARTMENTBindingNavigatorSaveItem.Text = "Save Data";
            this.dEPARTMENTBindingNavigatorSaveItem.Click += new System.EventHandler(this.dEPARTMENTBindingNavigatorSaveItem_Click_1);
            // 
            // Departments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 644);
            this.Controls.Add(this.dEPARTMENTBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.Name = "Departments";
            this.Text = "Отделения";
            this.Load += new System.EventHandler(this.Departments_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTBindingNavigator)).EndInit();
            this.dEPARTMENTBindingNavigator.ResumeLayout(false);
            this.dEPARTMENTBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dEPARTMENTBindingSource;
        private DataSet1TableAdapters.DEPARTMENTTableAdapter dEPARTMENTTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dEPARTMENTBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dEPARTMENTBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dEPARTMENTDataGridView;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nAMETextBox;
        private System.Windows.Forms.TextBox dIRECTORTextBox;
        private System.Windows.Forms.TextBox pHONETextBox;
        private System.Windows.Forms.TextBox pHONE_DIRECTORTextBox;
        private System.Windows.Forms.TextBox dATEWORKTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

    }
}