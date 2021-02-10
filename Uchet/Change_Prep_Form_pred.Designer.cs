
namespace Uchet
{
    partial class Change_Prep_Form_pred
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
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labhoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectdataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teachersTableAdapter = new Uchet.KazakovDataSetTableAdapters.TeachersTableAdapter();
            this.prepodavTableAdapter = new Uchet.KazakovDataSetTableAdapters.PrepodavTableAdapter();
            this.predmetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.predmetTableAdapter = new Uchet.KazakovDataSetTableAdapters.PredmetTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tnumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tfamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tnamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.prepodavBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kazakovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            this.teachersBindingSource.DataSource = this.kazakovDataSet;
            // 
            // specDataGridViewTextBoxColumn
            // 
            this.specDataGridViewTextBoxColumn.DataPropertyName = "spec";
            this.specDataGridViewTextBoxColumn.HeaderText = "spec";
            this.specDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.specDataGridViewTextBoxColumn.Name = "specDataGridViewTextBoxColumn";
            this.specDataGridViewTextBoxColumn.Width = 150;
            // 
            // labhoursDataGridViewTextBoxColumn
            // 
            this.labhoursDataGridViewTextBoxColumn.DataPropertyName = "lab_hours";
            this.labhoursDataGridViewTextBoxColumn.HeaderText = "lab_hours";
            this.labhoursDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.labhoursDataGridViewTextBoxColumn.Name = "labhoursDataGridViewTextBoxColumn";
            this.labhoursDataGridViewTextBoxColumn.Width = 150;
            // 
            // pnamDataGridViewTextBoxColumn
            // 
            this.pnamDataGridViewTextBoxColumn.DataPropertyName = "pnam";
            this.pnamDataGridViewTextBoxColumn.HeaderText = "pnam";
            this.pnamDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pnamDataGridViewTextBoxColumn.Name = "pnamDataGridViewTextBoxColumn";
            this.pnamDataGridViewTextBoxColumn.Width = 150;
            // 
            // pnumDataGridViewTextBoxColumn
            // 
            this.pnumDataGridViewTextBoxColumn.DataPropertyName = "pnum";
            this.pnumDataGridViewTextBoxColumn.HeaderText = "pnum";
            this.pnumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pnumDataGridViewTextBoxColumn.Name = "pnumDataGridViewTextBoxColumn";
            this.pnumDataGridViewTextBoxColumn.Width = 150;
            // 
            // SelectdataGridViewCheckBoxColumn1
            // 
            this.SelectdataGridViewCheckBoxColumn1.HeaderText = "Select";
            this.SelectdataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.SelectdataGridViewCheckBoxColumn1.Name = "SelectdataGridViewCheckBoxColumn1";
            this.SelectdataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectdataGridViewCheckBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "pnum";
            this.dataGridViewTextBoxColumn2.HeaderText = "pnum";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "tnum";
            this.dataGridViewTextBoxColumn1.HeaderText = "tnum";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // prepodavTableAdapter
            // 
            this.prepodavTableAdapter.ClearBeforeFill = true;
            // 
            // predmetBindingSource
            // 
            this.predmetBindingSource.DataMember = "Predmet";
            this.predmetBindingSource.DataSource = this.kazakovDataSet;
            // 
            // predmetTableAdapter
            // 
            this.predmetTableAdapter.ClearBeforeFill = true;
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
            this.tnumDataGridViewTextBoxColumn1,
            this.pnumDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.prepodavBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(850, 149);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 21;
            this.dataGridView3.Visible = false;
            // 
            // tnumDataGridViewTextBoxColumn1
            // 
            this.tnumDataGridViewTextBoxColumn1.DataPropertyName = "tnum";
            this.tnumDataGridViewTextBoxColumn1.HeaderText = "tnum";
            this.tnumDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.tnumDataGridViewTextBoxColumn1.Name = "tnumDataGridViewTextBoxColumn1";
            this.tnumDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pnumDataGridViewTextBoxColumn1
            // 
            this.pnumDataGridViewTextBoxColumn1.DataPropertyName = "pnum";
            this.pnumDataGridViewTextBoxColumn1.HeaderText = "pnum";
            this.pnumDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.pnumDataGridViewTextBoxColumn1.Name = "pnumDataGridViewTextBoxColumn1";
            this.pnumDataGridViewTextBoxColumn1.ReadOnly = true;
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
            this.tnumDataGridViewTextBoxColumn,
            this.tfamDataGridViewTextBoxColumn,
            this.tnamDataGridViewTextBoxColumn,
            this.totchDataGridViewTextBoxColumn,
            this.dolgDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.teachersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(56, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(649, 282);
            this.dataGridView1.TabIndex = 20;
            // 
            // Select
            // 
            this.Select.HeaderText = "Выбор";
            this.Select.MinimumWidth = 8;
            this.Select.Name = "Select";
            // 
            // tnumDataGridViewTextBoxColumn
            // 
            this.tnumDataGridViewTextBoxColumn.DataPropertyName = "tnum";
            this.tnumDataGridViewTextBoxColumn.HeaderText = "Код";
            this.tnumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tnumDataGridViewTextBoxColumn.Name = "tnumDataGridViewTextBoxColumn";
            // 
            // tfamDataGridViewTextBoxColumn
            // 
            this.tfamDataGridViewTextBoxColumn.DataPropertyName = "tfam";
            this.tfamDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.tfamDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tfamDataGridViewTextBoxColumn.Name = "tfamDataGridViewTextBoxColumn";
            // 
            // tnamDataGridViewTextBoxColumn
            // 
            this.tnamDataGridViewTextBoxColumn.DataPropertyName = "tnam";
            this.tnamDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.tnamDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tnamDataGridViewTextBoxColumn.Name = "tnamDataGridViewTextBoxColumn";
            // 
            // totchDataGridViewTextBoxColumn
            // 
            this.totchDataGridViewTextBoxColumn.DataPropertyName = "totch";
            this.totchDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.totchDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totchDataGridViewTextBoxColumn.Name = "totchDataGridViewTextBoxColumn";
            // 
            // dolgDataGridViewTextBoxColumn
            // 
            this.dolgDataGridViewTextBoxColumn.DataPropertyName = "dolg";
            this.dolgDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.dolgDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dolgDataGridViewTextBoxColumn.Name = "dolgDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 40);
            this.button1.TabIndex = 19;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(66, 125);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(165, 35);
            this.textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(241, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(464, 35);
            this.textBox2.TabIndex = 16;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 35);
            this.textBox1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Специальность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Часов лабораторных";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Наименование";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Код";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "Преподаватель";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "15.02.08",
            "13.02.11",
            "27.02.04",
            "18.02.07",
            "09.02.07",
            "09.02.05"});
            this.comboBox1.Location = new System.Drawing.Point(278, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 37);
            this.comboBox1.TabIndex = 23;
            // 
            // Change_Prep_Form_pred
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(723, 612);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Change_Prep_Form_pred";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить предмет";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Change_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prepodavBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kazakovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn specDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labhoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectdataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private KazakovDataSet kazakovDataSet;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private KazakovDataSetTableAdapters.TeachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.BindingSource prepodavBindingSource;
        private KazakovDataSetTableAdapters.PrepodavTableAdapter prepodavTableAdapter;
        private System.Windows.Forms.BindingSource predmetBindingSource;
        private KazakovDataSetTableAdapters.PredmetTableAdapter predmetTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tfamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dolgDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}