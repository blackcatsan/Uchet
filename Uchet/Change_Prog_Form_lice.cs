using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Uchet
{

    public partial class Change_Prog_Form_lice : Form
    {
        //Создание временного подключения к БД
        private readonly SqlConnection con;
        public Change_Prog_Form_lice(string[] lice, string connect)
        {
            InitializeComponent();
            con = new SqlConnection(connect);
            //Вставка данных в соответствующие поля
            textBox1.Text = lice[0];
            textBox2.Text = lice[1];
            textBox3.Text = lice[2];
        }

        private void Change_Prog_Form_lice_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.License". При необходимости она может быть перемещена или удалена.
            licenseTableAdapter.Fill(kazakovDataSet.License);
            label2.Text = "Тип лицензии, " + textBox2.Text.Length + "/" + kazakovDataSet.License.lnamColumn.MaxLength;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Заполните поля");
            }
            else
            {
                if (textBox2.Text.Length > kazakovDataSet.License.lnamColumn.MaxLength)
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
                                    //Обновление Лицензии
                                    SqlCommand com = new SqlCommand("Update License Set lnam = '" + textBox2.Text + "', dlit = '" + Convert.ToInt32(textBox3.Text) + "' where pcnum = " + Convert.ToInt32(textBox1.Text), con);
                                    com.Connection.Open();
                                    if (com.ExecuteNonQuery() == 1)
                                    {
                                        MessageBox.Show("Записьуже существует");
                                    }
                                    else
                                    {
                                        com.Connection.Close();
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
            label2.Text = "Тип лицензии, " + textBox2.Text.Length + "/" + kazakovDataSet.License.lnamColumn.MaxLength;
        }
    }
}
