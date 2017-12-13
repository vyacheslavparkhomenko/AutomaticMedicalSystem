namespace AutomaticMedicalSystem
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.пациентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контактныеДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.семейныйВрачToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.врачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отделенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диагнозыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.общийДиагнозToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диагнозВрачаспециалистаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записьКСемейномуВрачуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записьКВрачуспециалистуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выпискаСемейногоВрачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выпискаВрачаспециалистаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пациентыToolStripMenuItem,
            this.врачиToolStripMenuItem,
            this.отделенияToolStripMenuItem,
            this.диагнозыToolStripMenuItem,
            this.записиToolStripMenuItem,
            this.справкиToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1341, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // пациентыToolStripMenuItem
            // 
            this.пациентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.контактныеДанныеToolStripMenuItem,
            this.семейныйВрачToolStripMenuItem});
            this.пациентыToolStripMenuItem.Name = "пациентыToolStripMenuItem";
            this.пациентыToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.пациентыToolStripMenuItem.Text = "Пациенты";
            // 
            // контактныеДанныеToolStripMenuItem
            // 
            this.контактныеДанныеToolStripMenuItem.Name = "контактныеДанныеToolStripMenuItem";
            this.контактныеДанныеToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.контактныеДанныеToolStripMenuItem.Text = "Контактные данные";
            this.контактныеДанныеToolStripMenuItem.Click += new System.EventHandler(this.контактныеДанныеToolStripMenuItem_Click);
            // 
            // семейныйВрачToolStripMenuItem
            // 
            this.семейныйВрачToolStripMenuItem.Name = "семейныйВрачToolStripMenuItem";
            this.семейныйВрачToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.семейныйВрачToolStripMenuItem.Text = "Семейный врач";
            this.семейныйВрачToolStripMenuItem.Click += new System.EventHandler(this.семейныйВрачToolStripMenuItem_Click);
            // 
            // врачиToolStripMenuItem
            // 
            this.врачиToolStripMenuItem.Name = "врачиToolStripMenuItem";
            this.врачиToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.врачиToolStripMenuItem.Text = "Врачи";
            this.врачиToolStripMenuItem.Click += new System.EventHandler(this.врачиToolStripMenuItem_Click);
            // 
            // отделенияToolStripMenuItem
            // 
            this.отделенияToolStripMenuItem.Name = "отделенияToolStripMenuItem";
            this.отделенияToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.отделенияToolStripMenuItem.Text = "Отделения";
            this.отделенияToolStripMenuItem.Click += new System.EventHandler(this.отделенияToolStripMenuItem_Click);
            // 
            // диагнозыToolStripMenuItem
            // 
            this.диагнозыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.общийДиагнозToolStripMenuItem,
            this.диагнозВрачаспециалистаToolStripMenuItem});
            this.диагнозыToolStripMenuItem.Name = "диагнозыToolStripMenuItem";
            this.диагнозыToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.диагнозыToolStripMenuItem.Text = "Диагнозы";
            // 
            // общийДиагнозToolStripMenuItem
            // 
            this.общийДиагнозToolStripMenuItem.Name = "общийДиагнозToolStripMenuItem";
            this.общийДиагнозToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.общийДиагнозToolStripMenuItem.Text = "Общий диагноз";
            this.общийДиагнозToolStripMenuItem.Click += new System.EventHandler(this.общийДиагнозToolStripMenuItem_Click);
            // 
            // диагнозВрачаспециалистаToolStripMenuItem
            // 
            this.диагнозВрачаспециалистаToolStripMenuItem.Name = "диагнозВрачаспециалистаToolStripMenuItem";
            this.диагнозВрачаспециалистаToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.диагнозВрачаспециалистаToolStripMenuItem.Text = "Заключение врача-специалиста";
            this.диагнозВрачаспециалистаToolStripMenuItem.Click += new System.EventHandler(this.диагнозВрачаспециалистаToolStripMenuItem_Click);
            // 
            // записиToolStripMenuItem
            // 
            this.записиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.записьКСемейномуВрачуToolStripMenuItem,
            this.записьКВрачуспециалистуToolStripMenuItem});
            this.записиToolStripMenuItem.Name = "записиToolStripMenuItem";
            this.записиToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.записиToolStripMenuItem.Text = "Записи";
            // 
            // записьКСемейномуВрачуToolStripMenuItem
            // 
            this.записьКСемейномуВрачуToolStripMenuItem.Name = "записьКСемейномуВрачуToolStripMenuItem";
            this.записьКСемейномуВрачуToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.записьКСемейномуВрачуToolStripMenuItem.Text = "Запись к семейному врачу";
            this.записьКСемейномуВрачуToolStripMenuItem.Click += new System.EventHandler(this.записьКСемейномуВрачуToolStripMenuItem_Click);
            // 
            // записьКВрачуспециалистуToolStripMenuItem
            // 
            this.записьКВрачуспециалистуToolStripMenuItem.Name = "записьКВрачуспециалистуToolStripMenuItem";
            this.записьКВрачуспециалистуToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.записьКВрачуспециалистуToolStripMenuItem.Text = "Запись к врачу-специалисту";
            this.записьКВрачуспециалистуToolStripMenuItem.Click += new System.EventHandler(this.записьКВрачуспециалистуToolStripMenuItem_Click);
            // 
            // справкиToolStripMenuItem
            // 
            this.справкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выпискаСемейногоВрачаToolStripMenuItem,
            this.выпискаВрачаспециалистаToolStripMenuItem});
            this.справкиToolStripMenuItem.Name = "справкиToolStripMenuItem";
            this.справкиToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.справкиToolStripMenuItem.Text = "Справки";
            // 
            // выпискаСемейногоВрачаToolStripMenuItem
            // 
            this.выпискаСемейногоВрачаToolStripMenuItem.Name = "выпискаСемейногоВрачаToolStripMenuItem";
            this.выпискаСемейногоВрачаToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.выпискаСемейногоВрачаToolStripMenuItem.Text = "Выписка семейного врача";
            this.выпискаСемейногоВрачаToolStripMenuItem.Click += new System.EventHandler(this.выпискаСемейногоВрачаToolStripMenuItem_Click);
            // 
            // выпискаВрачаспециалистаToolStripMenuItem
            // 
            this.выпискаВрачаспециалистаToolStripMenuItem.Name = "выпискаВрачаспециалистаToolStripMenuItem";
            this.выпискаВрачаспециалистаToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.выпискаВрачаспециалистаToolStripMenuItem.Text = "Выписка врача-специалиста";
            this.выпискаВрачаспециалистаToolStripMenuItem.Click += new System.EventHandler(this.выпискаВрачаспециалистаToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 644);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Автоматизированная медицинская система";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem пациентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контактныеДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem семейныйВрачToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem врачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отделенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem диагнозыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem общийДиагнозToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem диагнозВрачаспециалистаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записьКСемейномуВрачуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записьКВрачуспециалистуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выпискаСемейногоВрачаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выпискаВрачаспециалистаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
    }
}

