using System;
using System.Windows.Forms;

namespace Uchet
{
    public partial class Add_Prep_Form : Form
    {
        public Add_Prep_Form()
        {
            InitializeComponent();

        }

        private void Add_Form_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Prepodav". При необходимости она может быть перемещена или удалена.
            prepodavTableAdapter.Fill(kazakovDataSet.Prepodav);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Teachers1". При необходимости она может быть перемещена или удалена.
            teachers1TableAdapter.Fill(kazakovDataSet.Teachers1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Teachers". При необходимости она может быть перемещена или удалена.
            teachersTableAdapter.Fill(kazakovDataSet.Teachers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Predmet". При необходимости она может быть перемещена или удалена.
            predmetTableAdapter.Fill(kazakovDataSet.Predmet);
            kabsTableAdapter.Fill(kazakovDataSet.Kabs);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Добавление преподавателя

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox2.SelectedIndex < 0)
            {
                MessageBox.Show("Заполните обязательные поля");
            }
            else
            {
                if (textBox1.Text.Length > kazakovDataSet.Teachers.tfamColumn.MaxLength || textBox2.Text.Length > kazakovDataSet.Teachers.tnamColumn.MaxLength || textBox3.Text.Length > kazakovDataSet.Teachers.totchColumn.MaxLength)
                {
                    MessageBox.Show("Произошло переполнение полей");
                }
                else
                {
                    int m = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].FormattedValue) == true)
                        {
                            //Занесение связей в ассоциативную таблицу
                            m++;
                        }
                    }

                    if (m > 0)
                    {
                        if (teachersTableAdapter.Insert(0, textBox1.Text, textBox2.Text, textBox3.Text, comboBox2.SelectedItem.ToString()) > 1)
                        {
                            teachersTableAdapter.Fill(kazakovDataSet.Teachers);

                            //Выбор преподаваемых им предметов с использованием Checkbox в datagridview
                            int k;
                            k = kazakovDataSet.Teachers.Count;
                            k = kazakovDataSet.Teachers[k - 1].tnum;
                            if (predmetBindingSource.Count > 0)
                            {
                                for (int i = 0; i < predmetBindingSource.Count; i++)
                                {
                                    if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].FormattedValue) == true)
                                    {
                                        //Занесение связей в ассоциативную таблицу
                                        prepodavTableAdapter.Insert(k, Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value));
                                    }
                                }
                                //Обновление ассоциативной таблицы
                                prepodavTableAdapter.Fill(kazakovDataSet.Prepodav);
                            }
                            //Обновление виртуальной таблицы
                            teachers1TableAdapter.Fill(kazakovDataSet.Teachers1);
                            MessageBox.Show("Запись добавлена");

                            //Очистка
                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox3.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("Запись уже существует");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Выберите предметы, которые ведет преподаватель");
                    }
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "" || textBox6.Text == "" || comboBox3.SelectedIndex < 0)
            {
                MessageBox.Show("Заполните обязательные поля");
            }
            else
            {
                if (textBox5.Text.Length > kazakovDataSet.Predmet.pnamColumn.MaxLength)
                {
                    MessageBox.Show("Произошло переполнение полей");
                }
                else
                {
                    int k = 0;
                    for (int i = 0; i < textBox6.Text.Length; i++)
                    {
                        if (char.IsDigit(textBox6.Text[i]))
                        {
                            k++;
                        }
                    }

                    if (k == textBox6.Text.Length)
                    {
                        try
                        {
                            Convert.ToInt32(textBox6.Text);
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
                                if (Convert.ToInt32(textBox6.Text) == 0)
                                {
                                    MessageBox.Show("Число слишком мало");
                                }
                                else
                                {
                                    //Внесение данных в таблицу Предмет
                                    if (predmetTableAdapter.Insert(0, textBox5.Text, Convert.ToInt32(textBox6.Text), comboBox3.SelectedItem.ToString()) > 1)
                                    {
                                        predmetTableAdapter.Fill(kazakovDataSet.Predmet);
                                        MessageBox.Show("Запись добавлена");

                                        //Очистка
                                        textBox5.Text = "";
                                        textBox6.Text = "";



                                    }
                                    else
                                    {
                                        MessageBox.Show("Запись уже существует");
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "" || comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Заполните поля");
            }
            else
            {
                if (textBox8.Text.Length > kazakovDataSet.Kabs.knamColumn.MaxLength)
                {
                    MessageBox.Show("Присутствует переполнение полей");
                }
                else
                {
                    //Занесение данных в таблицу Кабинет
                    if (kabsTableAdapter.Insert(0, textBox8.Text, Convert.ToInt32(comboBox1.SelectedValue)) > 1)
                    {
                        kabsTableAdapter.Fill(kazakovDataSet.Kabs);
                        MessageBox.Show("Запись добавлена");

                        //Очистка
                        textBox8.Text = "";
                        comboBox1.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Запись уже существует");
                    }
                }

            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            label5.Text = "Наименование, " + textBox5.Text.Length + "/" + kazakovDataSet.Predmet.pnamColumn.MaxLength;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "Фамилия, " + textBox1.Text.Length + "/" + kazakovDataSet.Teachers.tfamColumn.MaxLength;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label2.Text = "Имя, " + textBox2.Text.Length + "/" + kazakovDataSet.Teachers.tnamColumn.MaxLength;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "Отчество, " + textBox3.Text.Length + "/" + kazakovDataSet.Teachers.totchColumn.MaxLength;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            label8.Text = "Кабинет, " + textBox8.Text.Length + "/" + kazakovDataSet.Kabs.knamColumn.MaxLength;
        }
    }
}
