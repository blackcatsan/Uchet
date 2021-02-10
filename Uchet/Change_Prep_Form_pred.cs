using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Uchet
{



    public partial class Change_Prep_Form_pred : Form
    {
        //Создание временного подключения к БД
        private readonly SqlConnection con;
        private readonly string k;

        public Change_Prep_Form_pred(string[] pnum, string connect)
        {
            InitializeComponent();
            con = new SqlConnection(connect);
            //Занесение данных в соответствующие поля
            textBox1.Text = pnum[0].ToString();
            textBox2.Text = pnum[1].ToString();
            textBox3.Text = pnum[2].ToString();
            k = pnum[3].ToString();

        }




        private void Change_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Predmet". При необходимости она может быть перемещена или удалена.
            predmetTableAdapter.Fill(kazakovDataSet.Predmet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Prepodav". При необходимости она может быть перемещена или удалена.
            prepodavTableAdapter.Fill(kazakovDataSet.Prepodav);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Teachers". При необходимости она может быть перемещена или удалена.
            teachersTableAdapter.Fill(kazakovDataSet.Teachers);

            comboBox1.SelectedItem = k;
            label2.Text = "Наименование, " + textBox2.Text.Length + "/" + kazakovDataSet.Predmet.pnamColumn.MaxLength;

            //Фильтр ассоциативной связи по предмету
            prepodavBindingSource.Filter = "pnum = " + Convert.ToInt32(textBox1.Text);

            if (prepodavBindingSource.Count > 0)
            {
                //Занесение в массив кодов преподавателей из ассоциативной таблицы
                int t = prepodavBindingSource.Count;
                int[] tnum = new int[t];
                for (int i = 0; i < t; i++)
                {
                    tnum[i] = Convert.ToInt32(dataGridView3[0, i].Value);
                }

                //Установка флажка в таблице DataGridView для преподавателей, которые ведут данный предмет
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < t; j++)
                    {
                        if (dataGridView1[1, i].FormattedValue.ToString() == tnum[j].ToString())
                        {
                            dataGridView1[0, i].Value = 1;
                        }
                    }
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Заполните поля");
            }
            else
            {
                if (textBox2.Text.Length > kazakovDataSet.Predmet.pnamColumn.MaxLength)
                {
                    MessageBox.Show("присутствует переполнение полей");
                }
                else
                {
                    int k = 0;
                    for (int i = 0; i < textBox3.Text.Length; i++)
                    {
                        if (char.IsDigit(textBox3.Text[i]))
                        {
                            k++;
                        }
                    }

                    if (k == textBox3.Text.Length)
                    {
                        try
                        {
                            Convert.ToInt32(textBox3.Text);
                        }
                        catch
                        {
                            MessageBox.Show("Слишком большое число");
                            k = -5;
                        }
                        finally
                        {
                            if (k > 0)
                            {
                                if (Convert.ToInt32(textBox3.Text) == 0)
                                {
                                    MessageBox.Show("Число слишком мало");
                                }
                                else
                                {
                                    SqlCommand com = new SqlCommand("Update Predmet Set pnam = '" + textBox2.Text + "', lab_hours = " + Convert.ToInt32(textBox3.Text) + ", spec = '" + comboBox1.SelectedItem.ToString() + "' where pnum = " + Convert.ToInt32(textBox1.Text), con);
                                    com.Connection.Open();
                                    if (com.ExecuteNonQuery() == 1)
                                    {
                                        MessageBox.Show("Запись уже существует");
                                    }
                                    else
                                    {
                                        //Удаление всех записей предмета из ассоциации
                                        com = new SqlCommand("Delete from Prepodav where pnum = " + Convert.ToInt32(textBox1.Text), con);

                                        com.ExecuteNonQuery();
                                        com.Connection.Close();

                                        //Занесение в ассоциативную связь всех отмеченных преподавателей
                                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                                        {
                                            if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].FormattedValue) == true)
                                            {
                                                prepodavTableAdapter.Insert(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value), Convert.ToInt32(textBox1.Text));
                                            }
                                        }

                                        prepodavTableAdapter.Fill(kazakovDataSet.Prepodav);
                                        MessageBox.Show("Запись изменена");
                                    }
                                }
                            }

                        }


                    }
                    else
                    {
                        MessageBox.Show("Введены неверные данные");
                    }
                }

            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label2.Text = "Наименование, " + textBox2.Text.Length + "/" + kazakovDataSet.Predmet.pnamColumn.MaxLength;
        }
    }
}
