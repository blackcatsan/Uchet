using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Uchet
{
    public partial class Change_Prog_Form_prog : Form
    {

        //Создание временного подключения к БД
        private readonly SqlConnection con;
        private readonly string k;
        public Change_Prog_Form_prog(string[] prog, string connect)
        {
            InitializeComponent();
            con = new SqlConnection(connect);
            //Вставка данных в соответствующие поля
            textBox1.Text = prog[0];
            textBox3.Text = prog[1];
            textBox4.Text = prog[2];
            k = prog[3];
            dateTimePicker1.Value = Convert.ToDateTime(prog[4]);
            dateTimePicker2.Value = Convert.ToDateTime(prog[5]);
            textBox5.Text = prog[6];
        }


        private void Change_Prog_Form_prog_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Install". При необходимости она может быть перемещена или удалена.
            installTableAdapter.Fill(kazakovDataSet.Install);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.ProgPred". При необходимости она может быть перемещена или удалена.
            progPredTableAdapter.Fill(kazakovDataSet.ProgPred);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Programs". При необходимости она может быть перемещена или удалена.
            programsTableAdapter.Fill(kazakovDataSet.Programs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.PC". При необходимости она может быть перемещена или удалена.
            pCTableAdapter.Fill(kazakovDataSet.PC);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.PC1". При необходимости она может быть перемещена или удалена.
            pC1TableAdapter.Fill(kazakovDataSet.PC1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Predmet". При необходимости она может быть перемещена или удалена.
            predmetTableAdapter.Fill(kazakovDataSet.Predmet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.License". При необходимости она может быть перемещена или удалена.
            licenseTableAdapter.Fill(kazakovDataSet.License);
            comboBox1.SelectedValue = k;
            label3.Text = "Наименование, " + textBox3.Text.Length + "/" + kazakovDataSet.Programs.prnamColumn.MaxLength;
            label4.Text = "Версия, " + textBox4.Text.Length + "/" + kazakovDataSet.Programs.versionColumn.MaxLength;

            //Фильтр ассоциации по данной программе
            progPredBindingSource.Filter = "prog = " + Convert.ToInt32(textBox1.Text);

            if (progPredBindingSource.Count > 0)
            {
                //Занесение в массив кодов предметов из ассоциативной таблицы
                int p = progPredBindingSource.Count;
                int[] pnum = new int[p];
                for (int i = 0; i < p; i++)
                {
                    pnum[i] = Convert.ToInt32(dataGridView2[1, i].Value);
                }

                //Установка флажка в таблице DataGridView для предметов, в которых используется данная программа
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

            //Фильтр ассоциации по данной программе
            installBindingSource.Filter = "prog = " + Convert.ToInt32(textBox1.Text);

            if (installBindingSource.Count > 0)
            {
                //Занесение в массив кодов ПК из ассоциативной таблицы
                int pc = installBindingSource.Count;
                int[] pcnum = new int[pc];
                for (int i = 0; i < pc; i++)
                {
                    pcnum[i] = Convert.ToInt32(dataGridView4[1, i].Value);
                }

                //Установка флажка в таблице DataGridView для ПК, на которых установлена программа
                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                {
                    for (int j = 0; j < pc; j++)
                    {
                        if (dataGridView3[1, i].FormattedValue.ToString() == pcnum[j].ToString())
                        {
                            dataGridView3[0, i].Value = 1;
                        }
                    }
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Заполните поля");
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
                                    //Обновление программы
                                    SqlCommand com = new SqlCommand("Update Programs Set prnam = '" + textBox3.Text + "', version = '" + textBox4.Text + "', license = " + Convert.ToInt32(comboBox1.SelectedValue) + ", inst_dat = '" + dateTimePicker1.Value + "', expr_dat = '" + dateTimePicker2.Value + "', value = " + Convert.ToInt32(textBox5.Text) + " where prnum = " + Convert.ToInt32(textBox1.Text), con);
                                    com.Connection.Open();
                                    if (com.ExecuteNonQuery() == 1)
                                    {
                                        MessageBox.Show("Такая запись уже существует");
                                    }
                                    else
                                    {
                                        //Удаление всех записей программы из ассоциации
                                        com = new SqlCommand("Delete from ProgPred where prog = " + Convert.ToInt32(textBox1.Text), con);
                                        com.ExecuteNonQuery();

                                        //Занесение в ассоциативную связь все отмеченные предметы
                                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                                        {
                                            if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].FormattedValue) == true)
                                            {
                                                progPredTableAdapter.Insert(Convert.ToInt32(textBox1.Text), Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value));
                                            }
                                        }

                                        progPredTableAdapter.Fill(kazakovDataSet.ProgPred);

                                        //Удаление всех записей программы из ассоциации
                                        com = new SqlCommand("Delete from Install where prog = " + Convert.ToInt32(textBox1.Text), con);
                                        com.ExecuteNonQuery();
                                        com.Connection.Close();

                                        //Занесение в ассоциативную связь все отмеченные ПК
                                        for (int i = 0; i < dataGridView3.Rows.Count; i++)
                                        {
                                            if (Convert.ToBoolean(dataGridView3.Rows[i].Cells[0].FormattedValue) == true)
                                            {
                                                installTableAdapter.Insert(Convert.ToInt32(textBox1.Text), Convert.ToInt32(dataGridView3.Rows[i].Cells[1].Value));
                                            }
                                        }

                                        installTableAdapter.Fill(kazakovDataSet.Install);
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
