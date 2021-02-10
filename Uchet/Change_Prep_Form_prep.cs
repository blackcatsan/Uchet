using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Uchet
{
    public partial class Change_Prep_Form_prep : Form
    {
        //Создание временного подключения к БД
        private readonly SqlConnection con;
        private readonly string k;
        public Change_Prep_Form_prep(string[] tnum, string connect)
        {
            InitializeComponent();
            con = new SqlConnection(connect);
            //Вставка данных в соответствующие поля
            textBox5.Text = tnum[0].ToString();
            textBox6.Text = tnum[1].ToString();
            textBox7.Text = tnum[2].ToString();
            textBox8.Text = tnum[3].ToString();
            k = tnum[4].ToString();

        }



        private void Change_Prep_Form_prep_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Teachers". При необходимости она может быть перемещена или удалена.
            teachersTableAdapter.Fill(kazakovDataSet.Teachers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Prepodav". При необходимости она может быть перемещена или удалена.
            prepodavTableAdapter.Fill(kazakovDataSet.Prepodav);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Predmet". При необходимости она может быть перемещена или удалена.
            predmetTableAdapter.Fill(kazakovDataSet.Predmet);

            comboBox1.SelectedItem = k;
            label6.Text = "Фамилия, " + textBox6.Text.Length + "/" + kazakovDataSet.Teachers.tfamColumn.MaxLength;
            label7.Text = "Имя, " + textBox7.Text.Length + "/" + kazakovDataSet.Teachers.tnamColumn.MaxLength;
            label8.Text = "Отчество, " + textBox8.Text.Length + "/" + kazakovDataSet.Teachers.totchColumn.MaxLength;

            //Фильтр ассоциации по данному преподавателю
            prepodavBindingSource.Filter = "tnum = " + Convert.ToInt32(textBox5.Text);

            if (prepodavBindingSource.Count > 0)
            {
                //Занесение в массив кодов предметов из ассоциативной таблицы
                int p = prepodavBindingSource.Count;
                int[] pnum = new int[p];
                for (int i = 0; i < p; i++)
                {
                    pnum[i] = Convert.ToInt32(dataGridView4[1, i].Value);
                }

                //Установка флажка в таблице DataGridView для предметов, которые ведет данный преподаватель
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    for (int j = 0; j < p; j++)
                    {
                        if (dataGridView2[1, i].FormattedValue.ToString() == pnum[j].ToString())
                        {
                            dataGridView2[0, i].Value = 1;
                        }
                    }
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Заполните поля");
            }
            else
            {
                if (textBox6.Text.Length > kazakovDataSet.Teachers.tfamColumn.MaxLength || textBox7.Text.Length > kazakovDataSet.Teachers.tnamColumn.MaxLength || textBox8.Text.Length > kazakovDataSet.Teachers.totchColumn.MaxLength)
                {
                    MessageBox.Show("Присутствует переполнение полей");
                }
                else
                {
                    //Обновление преподавателя
                    SqlCommand com = new SqlCommand("Update Teachers Set tfam = '" + textBox6.Text + "', tnam = '" + textBox7.Text + "', totch = '" + textBox8.Text + "', dolg = '" + comboBox1.SelectedItem.ToString() + "' where tnum = " + Convert.ToInt32(textBox5.Text), con);
                    com.Connection.Open();
                    if (com.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Запись уже существует");
                    }
                    else
                    {
                        //Удаление всех записей преподавателя из ассоциации
                        com = new SqlCommand("Delete from Prepodav where tnum = " + Convert.ToInt32(textBox5.Text), con);
                        com.ExecuteNonQuery();
                        com.Connection.Close();

                        //Занесение в ассоциативную связь все отмеченные предметы
                        for (int i = 0; i < dataGridView2.Rows.Count; i++)
                        {
                            if (Convert.ToBoolean(dataGridView2.Rows[i].Cells[0].FormattedValue) == true)
                            {
                                prepodavTableAdapter.Insert(Convert.ToInt32(textBox5.Text), Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value));
                            }
                        }

                        prepodavTableAdapter.Fill(kazakovDataSet.Prepodav);
                        MessageBox.Show("Запись изменена");
                    }
                }



            }


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            label6.Text = "Фамилия, " + textBox6.Text.Length + "/" + kazakovDataSet.Teachers.tfamColumn.MaxLength;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            label7.Text = "Имя, " + textBox7.Text.Length + "/" + kazakovDataSet.Teachers.tnamColumn.MaxLength;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            label8.Text = "Отчество, " + textBox8.Text.Length + "/" + kazakovDataSet.Teachers.totchColumn.MaxLength;
        }
    }
}
