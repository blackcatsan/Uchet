
namespace Uchet
{
    partial class Change_Prog_Form_prog
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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.licenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kazakovDataSet = new Uchet.KazakovDataSet();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pCnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCnetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kabDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pC1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labhoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predmetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.licenseTableAdapter = new Uchet.KazakovDataSetTableAdapters.LicenseTableAdapter();
            this.predmetTableAdapter = new Uchet.KazakovDataSetTableAdapters.PredmetTableAdapter();
            this.pC1TableAdapter = new Uchet.KazakovDataSetTableAdapters.PC1TableAdapter();
            this.pCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pCTableAdapter = new Uchet.KazakovDataSetTableAdapters.PCTableAdapter();
            this.programsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programsTableAdapter = new Uchet.KazakovDataSetTableAdapters.ProgramsTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.progDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.progDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progPredBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progPredTableAdapter = new Uchet.KazakovDataSetTableAdapters.ProgPredTableAdapter();
            this.installTableAdapter = new Uchet.KazakovDataSetTableAdapters.InstallTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.licenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kazakovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pC1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.installBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progPredBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(864, 60);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 35);
            this.dateTimePicker2.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(635, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 35);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.licenseBindingSource;
            this.comboBox1.DisplayMember = "lnam";
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(463, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 37);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.ValueMember = "lnum";
            // 
            // licenseBindingSource
            // 
            this.licenseBindingSource.DataMember = "License";
            this.licenseBindingSource.DataSource = this.kazakovDataSet;
            // 
            // kazakovDataSet
            // 
            this.kazakovDataSet.DataSetName = "KazakovDataSet";
            this.kazakovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1107, 60);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(144, 35);
            this.textBox5.TabIndex = 22;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(344, 60);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 35);
            this.textBox4.TabIndex = 21;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(175, 60);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 35);
            this.textBox3.TabIndex = 20;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1111, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 29);
            this.label8.TabIndex = 19;
            this.label8.Text = "Количество копий";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(865, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(322, 29);
            this.label7.TabIndex = 18;
            this.label7.Text = "Дата окончания лицензии";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(640, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "Дата установки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Лицензия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Версия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Наименование";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.pCnumDataGridViewTextBoxColumn,
            this.pCnetDataGridViewTextBoxColumn,
            this.knamDataGridViewTextBoxColumn,
            this.kabDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.pC1BindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(672, 128);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(591, 291);
            this.dataGridView3.TabIndex = 27;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Выбор";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // pCnumDataGridViewTextBoxColumn
            // 
            this.pCnumDataGridViewTextBoxColumn.DataPropertyName = "PCnum";
            this.pCnumDataGridViewTextBoxColumn.HeaderText = "Код";
            this.pCnumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pCnumDataGridViewTextBoxColumn.Name = "pCnumDataGridViewTextBoxColumn";
            // 
            // pCnetDataGridViewTextBoxColumn
            // 
            this.pCnetDataGridViewTextBoxColumn.DataPropertyName = "PCnet";
            this.pCnetDataGridViewTextBoxColumn.HeaderText = "Сетевое имя";
            this.pCnetDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pCnetDataGridViewTextBoxColumn.Name = "pCnetDataGridViewTextBoxColumn";
            // 
            // knamDataGridViewTextBoxColumn
            // 
            this.knamDataGridViewTextBoxColumn.DataPropertyName = "knam";
            this.knamDataGridViewTextBoxColumn.HeaderText = "Кабинет";
            this.knamDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.knamDataGridViewTextBoxColumn.Name = "knamDataGridViewTextBoxColumn";
            // 
            // kabDataGridViewTextBoxColumn
            // 
            this.kabDataGridViewTextBoxColumn.DataPropertyName = "Kab";
            this.kabDataGridViewTextBoxColumn.HeaderText = "Kab";
            this.kabDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kabDataGridViewTextBoxColumn.Name = "kabDataGridViewTextBoxColumn";
            this.kabDataGridViewTextBoxColumn.Visible = false;
            // 
            // pC1BindingSource
            // 
            this.pC1BindingSource.DataMember = "PC1";
            this.pC1BindingSource.DataSource = this.kazakovDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.pnumDataGridViewTextBoxColumn,
            this.pnamDataGridViewTextBoxColumn,
            this.labhoursDataGridViewTextBoxColumn,
            this.specDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.predmetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(645, 291);
            this.dataGridView1.TabIndex = 26;
            // 
            // Select
            // 
            this.Select.FillWeight = 50F;
            this.Select.HeaderText = "Выбор";
            this.Select.MinimumWidth = 8;
            this.Select.Name = "Select";
            // 
            // pnumDataGridViewTextBoxColumn
            // 
            this.pnumDataGridViewTextBoxColumn.DataPropertyName = "pnum";
            this.pnumDataGridViewTextBoxColumn.FillWeight = 50F;
            this.pnumDataGridViewTextBoxColumn.HeaderText = "Код";
            this.pnumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pnumDataGridViewTextBoxColumn.Name = "pnumDataGridViewTextBoxColumn";
            // 
            // pnamDataGridViewTextBoxColumn
            // 
            this.pnamDataGridViewTextBoxColumn.DataPropertyName = "pnam";
            this.pnamDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.pnamDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pnamDataGridViewTextBoxColumn.Name = "pnamDataGridViewTextBoxColumn";
            // 
            // labhoursDataGridViewTextBoxColumn
            // 
            this.labhoursDataGridViewTextBoxColumn.DataPropertyName = "lab_hours";
            this.labhoursDataGridViewTextBoxColumn.HeaderText = "Лабораторные, часы";
            this.labhoursDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.labhoursDataGridViewTextBoxColumn.Name = "labhoursDataGridViewTextBoxColumn";
            // 
            // specDataGridViewTextBoxColumn
            // 
            this.specDataGridViewTextBoxColumn.DataPropertyName = "spec";
            this.specDataGridViewTextBoxColumn.HeaderText = "Специальность";
            this.specDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.specDataGridViewTextBoxColumn.Name = "specDataGridViewTextBoxColumn";
            // 
            // predmetBindingSource
            // 
            this.predmetBindingSource.DataMember = "Predmet";
            this.predmetBindingSource.DataSource = this.kazakovDataSet;
            // 
            // licenseTableAdapter
            // 
            this.licenseTableAdapter.ClearBeforeFill = true;
            // 
            // predmetTableAdapter
            // 
            this.predmetTableAdapter.ClearBeforeFill = true;
            // 
            // pC1TableAdapter
            // 
            this.pC1TableAdapter.ClearBeforeFill = true;
            // 
            // pCBindingSource
            // 
            this.pCBindingSource.DataMember = "PC";
            this.pCBindingSource.DataSource = this.kazakovDataSet;
            // 
            // pCTableAdapter
            // 
            this.pCTableAdapter.ClearBeforeFill = true;
            // 
            // programsBindingSource
            // 
            this.programsBindingSource.DataMember = "Programs";
            this.programsBindingSource.DataSource = this.kazakovDataSet;
            // 
            // programsTableAdapter
            // 
            this.programsTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(611, 425);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 66);
            this.button3.TabIndex = 30;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToResizeColumns = false;
            this.dataGridView4.AllowUserToResizeRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.progDataGridViewTextBoxColumn1,
            this.pcDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.installBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(1020, 425);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.RowHeadersWidth = 62;
            this.dataGridView4.RowTemplate.Height = 28;
            this.dataGridView4.Size = new System.Drawing.Size(297, 150);
            this.dataGridView4.TabIndex = 29;
            this.dataGridView4.Visible = false;
            // 
            // progDataGridViewTextBoxColumn1
            // 
            this.progDataGridViewTextBoxColumn1.DataPropertyName = "prog";
            this.progDataGridViewTextBoxColumn1.HeaderText = "prog";
            this.progDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.progDataGridViewTextBoxColumn1.Name = "progDataGridViewTextBoxColumn1";
            this.progDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pcDataGridViewTextBoxColumn
            // 
            this.pcDataGridViewTextBoxColumn.DataPropertyName = "pc";
            this.pcDataGridViewTextBoxColumn.HeaderText = "pc";
            this.pcDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pcDataGridViewTextBoxColumn.Name = "pcDataGridViewTextBoxColumn";
            this.pcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // installBindingSource
            // 
            this.installBindingSource.DataMember = "Install";
            this.installBindingSource.DataSource = this.kazakovDataSet;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.progDataGridViewTextBoxColumn,
            this.predmDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.progPredBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(30, 425);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(297, 150);
            this.dataGridView2.TabIndex = 28;
            this.dataGridView2.Visible = false;
            // 
            // progDataGridViewTextBoxColumn
            // 
            this.progDataGridViewTextBoxColumn.DataPropertyName = "prog";
            this.progDataGridViewTextBoxColumn.HeaderText = "prog";
            this.progDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.progDataGridViewTextBoxColumn.Name = "progDataGridViewTextBoxColumn";
            this.progDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // predmDataGridViewTextBoxColumn
            // 
            this.predmDataGridViewTextBoxColumn.DataPropertyName = "predm";
            this.predmDataGridViewTextBoxColumn.HeaderText = "predm";
            this.predmDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.predmDataGridViewTextBoxColumn.Name = "predmDataGridViewTextBoxColumn";
            this.predmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // progPredBindingSource
            // 
            this.progPredBindingSource.DataMember = "ProgPred";
            this.progPredBindingSource.DataSource = this.kazakovDataSet;
            // 
            // progPredTableAdapter
            // 
            this.progPredTableAdapter.ClearBeforeFill = true;
            // 
            // installTableAdapter
            // 
            this.installTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(150, 35);
            this.textBox1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Код";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "Предмет";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(668, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 29);
            this.label9.TabIndex = 34;
            this.label9.Text = "ПК";
            // 
            // Change_Prog_Form_prog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1282, 514);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Change_Prog_Form_prog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить ПО";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Change_Prog_Form_prog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.licenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kazakovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pC1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.installBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progPredBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KazakovDataSet kazakovDataSet;
        private System.Windows.Forms.BindingSource licenseBindingSource;
        private KazakovDataSetTableAdapters.LicenseTableAdapter licenseTableAdapter;
        private System.Windows.Forms.BindingSource predmetBindingSource;
        private KazakovDataSetTableAdapters.PredmetTableAdapter predmetTableAdapter;
        private System.Windows.Forms.BindingSource pC1BindingSource;
        private KazakovDataSetTableAdapters.PC1TableAdapter pC1TableAdapter;
        private System.Windows.Forms.BindingSource pCBindingSource;
        private KazakovDataSetTableAdapters.PCTableAdapter pCTableAdapter;
        private System.Windows.Forms.BindingSource programsBindingSource;
        private KazakovDataSetTableAdapters.ProgramsTableAdapter programsTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource progPredBindingSource;
        private KazakovDataSetTableAdapters.ProgPredTableAdapter progPredTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn progDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn predmDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource installBindingSource;
        private KazakovDataSetTableAdapters.InstallTableAdapter installTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn progDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCnetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn knamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labhoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specDataGridViewTextBoxColumn;
    }
}