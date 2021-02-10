
namespace Uchet
{
    partial class Change_Prog_Form_pc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.kabsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kazakovDataSet = new Uchet.KazakovDataSet();
            this.kabsTableAdapter = new Uchet.KazakovDataSetTableAdapters.KabsTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.progDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.prnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prnamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exprdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programsTableAdapter = new Uchet.KazakovDataSetTableAdapters.ProgramsTableAdapter();
            this.installTableAdapter = new Uchet.KazakovDataSetTableAdapters.InstallTableAdapter();
            this.pCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pCTableAdapter = new Uchet.KazakovDataSetTableAdapters.PCTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kabsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kazakovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.installBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сетевое имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кабинет";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 35);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(202, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 35);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.kabsBindingSource;
            this.comboBox1.DisplayMember = "knam";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(413, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 37);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "knum";
            // 
            // kabsBindingSource
            // 
            this.kabsBindingSource.DataMember = "Kabs";
            this.kabsBindingSource.DataSource = this.kazakovDataSet;
            // 
            // kazakovDataSet
            // 
            this.kazakovDataSet.DataSetName = "KazakovDataSet";
            this.kazakovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kabsTableAdapter
            // 
            this.kabsTableAdapter.ClearBeforeFill = true;
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
            this.progDataGridViewTextBoxColumn,
            this.pcDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.installBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(781, 157);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 12;
            this.dataGridView3.Visible = false;
            // 
            // progDataGridViewTextBoxColumn
            // 
            this.progDataGridViewTextBoxColumn.DataPropertyName = "prog";
            this.progDataGridViewTextBoxColumn.HeaderText = "prog";
            this.progDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.progDataGridViewTextBoxColumn.Name = "progDataGridViewTextBoxColumn";
            this.progDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.prnumDataGridViewTextBoxColumn,
            this.prnamDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn,
            this.instdatDataGridViewTextBoxColumn,
            this.exprdatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.programsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(786, 275);
            this.dataGridView1.TabIndex = 11;
            // 
            // Select
            // 
            this.Select.HeaderText = "Выбор";
            this.Select.MinimumWidth = 8;
            this.Select.Name = "Select";
            // 
            // prnumDataGridViewTextBoxColumn
            // 
            this.prnumDataGridViewTextBoxColumn.DataPropertyName = "prnum";
            this.prnumDataGridViewTextBoxColumn.HeaderText = "Код";
            this.prnumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.prnumDataGridViewTextBoxColumn.Name = "prnumDataGridViewTextBoxColumn";
            // 
            // prnamDataGridViewTextBoxColumn
            // 
            this.prnamDataGridViewTextBoxColumn.DataPropertyName = "prnam";
            this.prnamDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.prnamDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.prnamDataGridViewTextBoxColumn.Name = "prnamDataGridViewTextBoxColumn";
            // 
            // versionDataGridViewTextBoxColumn
            // 
            this.versionDataGridViewTextBoxColumn.DataPropertyName = "version";
            this.versionDataGridViewTextBoxColumn.HeaderText = "Версия";
            this.versionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.versionDataGridViewTextBoxColumn.Name = "versionDataGridViewTextBoxColumn";
            // 
            // instdatDataGridViewTextBoxColumn
            // 
            this.instdatDataGridViewTextBoxColumn.DataPropertyName = "inst_dat";
            this.instdatDataGridViewTextBoxColumn.HeaderText = "Дата установки";
            this.instdatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.instdatDataGridViewTextBoxColumn.Name = "instdatDataGridViewTextBoxColumn";
            // 
            // exprdatDataGridViewTextBoxColumn
            // 
            this.exprdatDataGridViewTextBoxColumn.DataPropertyName = "expr_dat";
            this.exprdatDataGridViewTextBoxColumn.HeaderText = "Срок действия";
            this.exprdatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.exprdatDataGridViewTextBoxColumn.Name = "exprdatDataGridViewTextBoxColumn";
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
            // installTableAdapter
            // 
            this.installTableAdapter.ClearBeforeFill = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "ПО";
            // 
            // Change_Prog_Form_pc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(835, 564);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Change_Prog_Form_pc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить ПК";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Change_Prog_Form_pc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kabsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kazakovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.installBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private KazakovDataSet kazakovDataSet;
        private System.Windows.Forms.BindingSource kabsBindingSource;
        private KazakovDataSetTableAdapters.KabsTableAdapter kabsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource programsBindingSource;
        private KazakovDataSetTableAdapters.ProgramsTableAdapter programsTableAdapter;
        private System.Windows.Forms.BindingSource installBindingSource;
        private KazakovDataSetTableAdapters.InstallTableAdapter installTableAdapter;
        private System.Windows.Forms.BindingSource pCBindingSource;
        private KazakovDataSetTableAdapters.PCTableAdapter pCTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn progDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn prnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prnamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exprdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
    }
}