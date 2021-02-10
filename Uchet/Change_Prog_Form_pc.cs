using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Uchet
{
    public partial class Change_Prog_Form_pc : Form
    {
        //Создание временного подключения к БД
        private readonly SqlConnection con;
        private readonly string k;
        public Change_Prog_Form_pc(string[] pc, string connect)
        {
            InitializeComponent();
            con = new SqlConnection(connect);
            //Вставка данных в соответствующие поля
            textBox1.Text = pc[0];
            textBox2.Text = pc[1];
            k = pc[2];
        }

        private void Change_Prog_Form_pc_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.PC". При необходимости она может быть перемещена или удалена.
            pCTableAdapter.Fill(kazakovDataSet.PC);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Install". При необходимости она может быть перемещена или удалена.
            installTableAdapter.Fill(kazakovDataSet.Install);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Programs". При необходимости она может быть перемещена или удалена.
            programsTableAdapter.Fill(kazakovDataSet.Programs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Kabs". При необходимости она может быть перемещена или удалена.
            kabsTableAdapter.Fill(kazakovDataSet.Kabs);

            comboBox1.SelectedValue = k;
            label2.Text = "Сетевое имя, " + textBox2.Text.Length + "/" + kazakovDataSet.PC.PCnetColumn.MaxLength;

            //Фильтр ассоциации по данному ПК
            installBindingSource.Filter = "pc = " + Convert.ToInt32(textBox1.Text);

            if (installBindingSource.Count > 0)
            {
                int p = installBindingSource.Count;
                int[] pnum = new int[p];

                for (int i = 0; i < p; i++)
                {
                    pnum[i] = Convert.ToInt32(dataGridView3[0, i].Value);
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < p; j++)
                    {
                        if (dataGridView1[1, i].FormattedValue.ToString() == pnum[j].ToString())
                        {
                            dataGridView1[0, i].Value = 1;
                        }
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Заполните поля");
            }
            else
            {
                if (textBox2.Text.Length > kazakovDataSet.PC.PCnetColumn.MaxLength)
                {
                    MessageBox.Show("Присутствует переполнение полей");
                }
                else
                {
                    //Обновление ПК
                    SqlCommand com = new SqlCommand("Update PC Set pcnet = '" + textBox2.Text + "', kab = " + Convert.ToInt32(comboBox1.SelectedValue) + " where pcnum = " + Convert.ToInt32(textBox1.Text), con);
                    com.Connection.Open();
                    if (com.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Запись уже существует");
                    }
                    else
                    {
                        //Удаление всех записей ПК из ассоциации
                        com = new SqlCommand("Delete from Install where pc = " + Convert.ToInt32(textBox1.Text), con);
                        com.ExecuteNonQuery();
                        com.Connection.Close();

                        //Занесение в ассоциативную связь все отмеченные программы
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].FormattedValue) == true)
                            {
                                installTableAdapter.Insert(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value), Convert.ToInt32(textBox1.Text));
                            }
                        }

                        installTableAdapter.Fill(kazakovDataSet.Install);
                        MessageBox.Show("Запись изменена");
                    }
                }




            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label2.Text = "Сетевое имя, " + textBox2.Text.Length + "/" + kazakovDataSet.PC.PCnetColumn.MaxLength;
        }
    }
}
