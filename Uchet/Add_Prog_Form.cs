using System;
using System.Windows.Forms;

namespace Uchet
{
    public partial class Add_Prog_Form : Form
    {
        public Add_Prog_Form()
        {
            InitializeComponent();
        }



        private void Add_Prog_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.PC1". При необходимости она может быть перемещена или удалена.
            pC1TableAdapter.Fill(kazakovDataSet.PC1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Programs". При необходимости она может быть перемещена или удалена.
            programsTableAdapter.Fill(kazakovDataSet.Programs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Install". При необходимости она может быть перемещена или удалена.
            installTableAdapter.Fill(kazakovDataSet.Install);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.PC". При необходимости она может быть перемещена или удалена.
            pCTableAdapter.Fill(kazakovDataSet.PC);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Kabs". При необходимости она может быть перемещена или удалена.
            kabsTableAdapter.Fill(kazakovDataSet.Kabs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.ProgPred". При необходимости она может быть перемещена или удалена.
            progPredTableAdapter.Fill(kazakovDataSet.ProgPred);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Predmet". При необходимости она может быть перемещена или удалена.
            predmetTableAdapter.Fill(kazakovDataSet.Predmet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.License". При необходимости она может быть перемещена или удалена.
            licenseTableAdapter.Fill(kazakovDataSet.License);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Заполните обязательные поля");
            }
            else
            {
                if (textBox1.Text.Length > kazakovDataSet.License.lnamColumn.MaxLength)
                {
                    MessageBox.Show("Присутствует переполнение полей");
                }
                else
                {
                    int k = 0;
                    for (int i = 0; i < textBox2.Text.Length; i++)
                    {
                        if (char.IsDigit(textBox2.Text[i]))
                        {
                            k++;
                        }
                    }

                    if (k == textBox2.Text.Length)
                    {
                        try
                        {
                            Convert.ToInt32(textBox2.Text);
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
                                if (Convert.ToInt32(textBox2.Text) == 0)
                                {
                                    MessageBox.Show("Число слишком мало");
                                }
                                else
                                {
                                    if (licenseTableAdapter.Insert(0, textBox1.Text, Convert.ToInt32(textBox2.Text)) > 1)
                                    {
                                        licenseTableAdapter.Fill(kazakovDataSet.License);
                                        MessageBox.Show("Запись добавлена");

                                        //Очистка
                                        textBox1.Text = "";
                                        textBox2.Text = "";
                                    }
                                    else
                                    {
                                        MessageBox.Show("Запись уже существует");
                                    }
                                }
                            }

                        }
                        //Занесение данных в таблицу лицензий

                    }
                    else
                    {
                        MessageBox.Show("Введены неверные данные");
                    }
                }

            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "" || comboBox2.SelectedIndex < 0)
            {
                MessageBox.Show("Заполните обязательные поля");
            }
            else
            {
                if (textBox6.Text.Length > kazakovDataSet.PC.PCnetColumn.MaxLength)
                {
                    MessageBox.Show("Присутствует переполнение полей");
                }
                else
                {
                    //Занесение данных в таблицу ПК
                    if (pCTableAdapter.Insert(0, textBox6.Text, Convert.ToInt32(comboBox2.SelectedValue)) > 1)
                    {
                        pCTableAdapter.Fill(kazakovDataSet.PC);
                        MessageBox.Show("Запись добавлена");

                        //Очистка
                        textBox6.Text = "";
                        comboBox2.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Запись уже существует");
                    }
                }

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox3.Text == "" || textBox4.Text == "" || comboBox1.SelectedIndex < 0 || textBox5.Text == "")
            {
                MessageBox.Show("Заполните обязательные поля");
            }
            else
            {
                if (textBox3.Text.Length > kazakovDataSet.Programs.prnamColumn.MaxLength || textBox4.Text.Length > kazakovDataSet.Programs.versionColumn.MaxLength)
                {
                    MessageBox.Show("Присутствует переполнение полей");
                }
                else
                {
                    int k = 0;
                    for (int i = 0; i < textBox5.Text.Length; i++)
                    {
                        if (char.IsDigit(textBox5.Text[i]))
                        {
                            k++;
                        }
                    }

                    if (k == textBox5.Text.Length)
                    {
                        try
                        {
                            Convert.ToInt32(textBox5.Text);
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
                                if (Convert.ToInt32(textBox5.Text) == 0)
                                {
                                    MessageBox.Show("Число слишком мало");
                                }
                                else
                                {
                                    int m = 0;
                                    int n = 0;
                                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                                    {
                                        if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].FormattedValue) == true)
                                        {
                                            m++;
                                        }
                                    }

                                    for (int i = 0; i < dataGridView3.Rows.Count; i++)
                                    {
                                        if (Convert.ToBoolean(dataGridView3.Rows[i].Cells[0].FormattedValue) == true)
                                        {
                                            n++;
                                        }
                                    }

                                    if (m > 0 && n > 0)
                                    {
                                        //Занесение данных в таблицу программ
                                        if (programsTableAdapter.Insert(0, textBox3.Text, textBox4.Text, Convert.ToInt32(comboBox1.SelectedValue), dateTimePicker1.Value, dateTimePicker2.Value, Convert.ToInt32(textBox5.Text)) > 1)
                                        {
                                            programsTableAdapter.Fill(kazakovDataSet.Programs);

                                            int prnum = Convert.ToInt32(kazakovDataSet.Programs[kazakovDataSet.Programs.Count - 1][0]);
                                            //Добавление ассоциативных связей с выбранными предметами
                                            if (predmetBindingSource.Count > 0)
                                            {
                                                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                                                {
                                                    if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].FormattedValue) == true)
                                                    {
                                                        progPredTableAdapter.Insert(prnum, Convert.ToInt32(dataGridView1.Rows[i].Cells[1].FormattedValue));
                                                    }
                                                }

                                                progPredTableAdapter.Fill(kazakovDataSet.ProgPred);
                                            }

                                            //Добавление ассоциативных связей с выбранными ПК
                                            if (pCBindingSource.Count > 0)
                                            {
                                                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                                                {
                                                    if (Convert.ToBoolean(dataGridView3.Rows[i].Cells[0].FormattedValue) == true)
                                                    {
                                                        installTableAdapter.Insert(prnum, Convert.ToInt32(dataGridView3.Rows[i].Cells[1].FormattedValue));
                                                    }
                                                }
                                                installTableAdapter.Fill(kazakovDataSet.Install);

                                            }
                                            MessageBox.Show("Запись добавлена");

                                            //Очистка
                                            textBox3.Text = "";
                                            textBox4.Text = "";
                                            comboBox1.SelectedIndex = -1;
                                            textBox5.Text = "";
                                        }
                                        else
                                        {
                                            MessageBox.Show("Запись уже существует");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Выберите предмет и ПК");
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                for (int i = 0; i < kazakovDataSet.License.Rows.Count; i++)
                {
                    if (kazakovDataSet.License.Rows[i][0].ToString() == comboBox1.SelectedValue.ToString())
                    {
                        dateTimePicker2.Value = DateTime.Now;
                        dateTimePicker2.Value = dateTimePicker2.Value.AddYears(Convert.ToInt32(kazakovDataSet.License.Rows[i][2].ToString()));
                    }
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                comboBox1.SelectedIndex = -1;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "Тип лицензии, " + textBox1.Text.Length + "/" + kazakovDataSet.License.lnamColumn.MaxLength;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            label9.Text = "Сетевое имя ПК, " + textBox6.Text.Length + "/" + kazakovDataSet.PC.PCnetColumn.MaxLength;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "Наименование, " + textBox3.Text.Length + "/" + kazakovDataSet.Programs.prnamColumn.MaxLength;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label4.Text = "Версия, " + textBox4.Text.Length + "/" + kazakovDataSet.Programs.versionColumn.MaxLength;
        }
    }
}
