
namespace Uchet
{
    partial class Change_Prog_Form_pred
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.progDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progPredBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kazakovDataSet = new Uchet.KazakovDataSet();
            this.programsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.programsTableAdapter = new Uchet.KazakovDataSetTableAdapters.ProgramsTableAdapter();
            this.progPredTableAdapter = new Uchet.KazakovDataSetTableAdapters.ProgPredTableAdapter();
            this.predmetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.predmetTableAdapter = new Uchet.KazakovDataSetTableAdapters.PredmetTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.prnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prnamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exprdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progPredBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kazakovDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.predmDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.progPredBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(708, 170);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 21;
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
            // kazakovDataSet
            // 
            this.kazakovDataSet.DataSetName = "KazakovDataSet";
            this.kazakovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // programsBindingSource
            // 
            this.programsBindingSource.DataMember = "Programs";
            this.programsBindingSource.DataSource = this.kazakovDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 40);
            this.button1.TabIndex = 19;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(156, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 35);
            this.textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(365, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(379, 35);
            this.textBox2.TabIndex = 16;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 35);
            this.textBox1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Специальность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Часов лабораторных";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Наименование";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Код";
            // 
            // programsTableAdapter
            // 
            this.programsTableAdapter.ClearBeforeFill = true;
            // 
            // progPredTableAdapter
            // 
            this.progPredTableAdapter.ClearBeforeFill = true;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "ПО";
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(786, 310);
            this.dataGridView1.TabIndex = 23;
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
            this.comboBox1.Location = new System.Drawing.Point(365, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 37);
            this.comboBox1.TabIndex = 24;
            // 
            // Change_Prog_Form_pred
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(808, 587);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView3);
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
            this.Name = "Change_Prog_Form_pred";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить предмет";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Change_Prog_Form_pred_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progPredBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kazakovDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private KazakovDataSet kazakovDataSet;
        private System.Windows.Forms.BindingSource programsBindingSource;
        private KazakovDataSetTableAdapters.ProgramsTableAdapter programsTableAdapter;
        private System.Windows.Forms.BindingSource progPredBindingSource;
        private KazakovDataSetTableAdapters.ProgPredTableAdapter progPredTableAdapter;
        private System.Windows.Forms.BindingSource predmetBindingSource;
        private KazakovDataSetTableAdapters.PredmetTableAdapter predmetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn progDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn predmDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn prnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prnamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exprdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}