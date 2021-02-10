
namespace Uchet
{
    partial class Change_Prep_Form_prep
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
            this.prepodavBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kazakovDataSet = new Uchet.KazakovDataSet();
            this.predmetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectdataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labhoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predmetTableAdapter = new Uchet.KazakovDataSetTableAdapters.PredmetTableAdapter();
            this.prepodavTableAdapter = new Uchet.KazakovDataSetTableAdapters.PrepodavTableAdapter();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new Uchet.KazakovDataSetTableAdapters.TeachersTableAdapter();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnumDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnamDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labhoursDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.prepodavBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kazakovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // prepodavBindingSource
            // 
            this.prepodavBindingSource.DataMember = "Prepodav";
            this.prepodavBindingSource.DataSource = this.kazakovDataSet;
            // 
            // kazakovDataSet
            // 
            this.kazakovDataSet.DataSetName = "KazakovDataSet";
            this.kazakovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // predmetBindingSource
            // 
            this.predmetBindingSource.DataMember = "Predmet";
            this.predmetBindingSource.DataSource = this.kazakovDataSet;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "tnum";
            this.dataGridViewTextBoxColumn1.HeaderText = "tnum";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "pnum";
            this.dataGridViewTextBoxColumn2.HeaderText = "pnum";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // specDataGridViewTextBoxColumn
            // 
            this.specDataGridViewTextBoxColumn.DataPropertyName = "spec";
            this.specDataGridViewTextBoxColumn.HeaderText = "spec";
            this.specDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.specDataGridViewTextBoxColumn.Name = "specDataGridViewTextBoxColumn";
            this.specDataGridViewTextBoxColumn.Width = 150;
            // 
            // SelectdataGridViewCheckBoxColumn1
            // 
            this.SelectdataGridViewCheckBoxColumn1.HeaderText = "Select";
            this.SelectdataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.SelectdataGridViewCheckBoxColumn1.Name = "SelectdataGridViewCheckBoxColumn1";
            this.SelectdataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectdataGridViewCheckBoxColumn1.Width = 150;
            // 
            // pnumDataGridViewTextBoxColumn
            // 
            this.pnumDataGridViewTextBoxColumn.DataPropertyName = "pnum";
            this.pnumDataGridViewTextBoxColumn.HeaderText = "pnum";
            this.pnumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pnumDataGridViewTextBoxColumn.Name = "pnumDataGridViewTextBoxColumn";
            this.pnumDataGridViewTextBoxColumn.Width = 150;
            // 
            // pnamDataGridViewTextBoxColumn
            // 
            this.pnamDataGridViewTextBoxColumn.DataPropertyName = "pnam";
            this.pnamDataGridViewTextBoxColumn.HeaderText = "pnam";
            this.pnamDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pnamDataGridViewTextBoxColumn.Name = "pnamDataGridViewTextBoxColumn";
            this.pnamDataGridViewTextBoxColumn.Width = 150;
            // 
            // labhoursDataGridViewTextBoxColumn
            // 
            this.labhoursDataGridViewTextBoxColumn.DataPropertyName = "lab_hours";
            this.labhoursDataGridViewTextBoxColumn.HeaderText = "lab_hours";
            this.labhoursDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.labhoursDataGridViewTextBoxColumn.Name = "labhoursDataGridViewTextBoxColumn";
            this.labhoursDataGridViewTextBoxColumn.Width = 150;
            // 
            // predmetTableAdapter
            // 
            this.predmetTableAdapter.ClearBeforeFill = true;
            // 
            // prepodavTableAdapter
            // 
            this.prepodavTableAdapter.ClearBeforeFill = true;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.kazakovDataSet;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
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
            this.tnumDataGridViewTextBoxColumn,
            this.pnumDataGridViewTextBoxColumn2});
            this.dataGridView4.DataSource = this.prepodavBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(852, 159);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.RowHeadersWidth = 62;
            this.dataGridView4.RowTemplate.Height = 28;
            this.dataGridView4.Size = new System.Drawing.Size(240, 150);
            this.dataGridView4.TabIndex = 25;
            // 
            // tnumDataGridViewTextBoxColumn
            // 
            this.tnumDataGridViewTextBoxColumn.DataPropertyName = "tnum";
            this.tnumDataGridViewTextBoxColumn.HeaderText = "tnum";
            this.tnumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tnumDataGridViewTextBoxColumn.Name = "tnumDataGridViewTextBoxColumn";
            this.tnumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pnumDataGridViewTextBoxColumn2
            // 
            this.pnumDataGridViewTextBoxColumn2.DataPropertyName = "pnum";
            this.pnumDataGridViewTextBoxColumn2.HeaderText = "pnum";
            this.pnumDataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.pnumDataGridViewTextBoxColumn2.Name = "pnumDataGridViewTextBoxColumn2";
            this.pnumDataGridViewTextBoxColumn2.ReadOnly = true;
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
            this.Select,
            this.pnumDataGridViewTextBoxColumn1,
            this.pnamDataGridViewTextBoxColumn1,
            this.labhoursDataGridViewTextBoxColumn1,
            this.specDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.predmetBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(51, 187);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(649, 245);
            this.dataGridView2.TabIndex = 24;
            // 
            // Select
            // 
            this.Select.FillWeight = 50F;
            this.Select.HeaderText = "Выбор";
            this.Select.MinimumWidth = 8;
            this.Select.Name = "Select";
            // 
            // pnumDataGridViewTextBoxColumn1
            // 
            this.pnumDataGridViewTextBoxColumn1.DataPropertyName = "pnum";
            this.pnumDataGridViewTextBoxColumn1.FillWeight = 50F;
            this.pnumDataGridViewTextBoxColumn1.HeaderText = "Код";
            this.pnumDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.pnumDataGridViewTextBoxColumn1.Name = "pnumDataGridViewTextBoxColumn1";
            // 
            // pnamDataGridViewTextBoxColumn1
            // 
            this.pnamDataGridViewTextBoxColumn1.DataPropertyName = "pnam";
            this.pnamDataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.pnamDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.pnamDataGridViewTextBoxColumn1.Name = "pnamDataGridViewTextBoxColumn1";
            // 
            // labhoursDataGridViewTextBoxColumn1
            // 
            this.labhoursDataGridViewTextBoxColumn1.DataPropertyName = "lab_hours";
            this.labhoursDataGridViewTextBoxColumn1.HeaderText = "Лабораторные, часы";
            this.labhoursDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.labhoursDataGridViewTextBoxColumn1.Name = "labhoursDataGridViewTextBoxColumn1";
            // 
            // specDataGridViewTextBoxColumn1
            // 
            this.specDataGridViewTextBoxColumn1.DataPropertyName = "spec";
            this.specDataGridViewTextBoxColumn1.HeaderText = "Специальность";
            this.specDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.specDataGridViewTextBoxColumn1.Name = "specDataGridViewTextBoxColumn1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 47);
            this.button2.TabIndex = 23;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(235, 104);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(147, 35);
            this.textBox8.TabIndex = 21;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(53, 104);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(146, 35);
            this.textBox7.TabIndex = 20;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(194, 42);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(141, 35);
            this.textBox6.TabIndex = 19;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(51, 43);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 35);
            this.textBox5.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(432, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 29);
            this.label9.TabIndex = 17;
            this.label9.Text = "Должность";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(231, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "Отчество";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Код";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Предмет";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Преподаватель"});
            this.comboBox1.Location = new System.Drawing.Point(437, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 37);
            this.comboBox1.TabIndex = 27;
            // 
            // Change_Prep_Form_prep
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(722, 553);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Change_Prep_Form_prep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить преподавателя";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Change_Prep_Form_prep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prepodavBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kazakovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn specDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectdataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labhoursDataGridViewTextBoxColumn;
        private KazakovDataSet kazakovDataSet;
        private System.Windows.Forms.BindingSource predmetBindingSource;
        private KazakovDataSetTableAdapters.PredmetTableAdapter predmetTableAdapter;
        private System.Windows.Forms.BindingSource prepodavBindingSource;
        private KazakovDataSetTableAdapters.PrepodavTableAdapter prepodavTableAdapter;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private KazakovDataSetTableAdapters.TeachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnumDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnamDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn labhoursDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn specDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}