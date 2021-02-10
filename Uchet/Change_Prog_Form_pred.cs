using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Uchet
{
    public partial class Change_Prog_Form_pred : Form
    {
        //Создание временного подключения к БД
        private readonly SqlConnection con;
        private readonly string k;
        public Change_Prog_Form_pred(string[] pred, string connect)
        {
            InitializeComponent();
            con = new SqlConnection(connect);
            //Вставка данных в соответствующие поля
            textBox1.Text = pred[0];
            textBox2.Text = pred[1];
            textBox3.Text = pred[2];
            k = pred[3];
        }

        private void Change_Prog_Form_pred_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Predmet". При необходимости она может быть перемещена или удалена.
            predmetTableAdapter.Fill(kazakovDataSet.Predmet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.ProgPred". При необходимости она может быть перемещена или удалена.
            progPredTableAdapter.Fill(kazakovDataSet.ProgPred);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Programs". При необходимости она может быть перемещена или удалена.
            programsTableAdapter.Fill(kazakovDataSet.Programs);

            comboBox1.SelectedItem = k;
            label2.Text = "Наименование, " + textBox2.Text.Length + "/" + kazakovDataSet.Predmet.pnamColumn.MaxLength;

            //Фильтр ассоциации по данному предмету
            progPredBindingSource.Filter = "predm = " + Convert.ToInt32(textBox1.Text);
            if (progPredBindingSource.Count > 0)
            {
                //Занесение в массив кодов программ из ассоциативной таблицы
                int p = progPredBindingSource.Count;
                int[] prnum = new int[p];
                for (int i = 0; i < p; i++)
                {
                    prnum[i] = Convert.ToInt32(dataGridView3[0, i].Value);
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < p; j++)
                    {
                        if (dataGridView1[1, i].FormattedValue.ToString() == prnum[j].ToString())
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
                    MessageBox.Show("Присутствует переполнение полей");
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
                                    //Обновление предмета
                                    SqlCommand com = new SqlCommand("Update Predmet Set pnam = '" + textBox2.Text + "', lab_hours = " + Convert.ToInt32(textBox3.Text) + ", spec = '" + comboBox1.SelectedItem.ToString() + "' where pnum = " + Convert.ToInt32(textBox1.Text), con);
                                    com.Connection.Open();
                                    if (com.ExecuteNonQuery() == 1)
                                    {
                                        MessageBox.Show("Запись уже существует");
                                    }
                                    else
                                    {
                                        //Удаление всех записей предмета из ассоциации
                                        com = new SqlCommand("Delete from ProgPred where predm = " + Convert.ToInt32(textBox1.Text), con);
                                        com.ExecuteNonQuery();
                                        com.Connection.Close();

                                        //Занесение в ассоциативную связь все отмеченные программы
                                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                                        {
                                            if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].FormattedValue) == true)
                                            {
                                                progPredTableAdapter.Insert(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value), Convert.ToInt32(textBox1.Text));
                                            }
                                        }

                                        progPredTableAdapter.Fill(kazakovDataSet.ProgPred);
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
