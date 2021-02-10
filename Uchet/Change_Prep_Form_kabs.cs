using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Uchet
{
    public partial class Change_Prep_Form_kabs : Form
    {
        //Создание временного подключения к БД
        private readonly SqlConnection con;
        private readonly string k;
        public Change_Prep_Form_kabs(string[] kab, string connect)
        {
            InitializeComponent();
            con = new SqlConnection(connect);
            //Занесение перенесенных данных в соответствующие поля
            textBox10.Text = kab[0].ToString();
            textBox11.Text = kab[1].ToString();
            k = kab[2];
        }



        private void Change_Prep_Form_kabs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Kabs". При необходимости она может быть перемещена или удалена.
            kabsTableAdapter.Fill(kazakovDataSet.Kabs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Teachers1". При необходимости она может быть перемещена или удалена.
            teachers1TableAdapter.Fill(kazakovDataSet.Teachers1);
            //Изменение текущего значения combobox
            comboBox1.SelectedValue = k;
            label11.Text = "Кабинет, " + textBox11.Text.Length + "/" + kazakovDataSet.Kabs.knamColumn.MaxLength;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Обновление выбранной записи измененными данными
            if (textBox11.Text == "" || comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Заполните поля");
            }
            else
            {
                if (textBox11.Text.Length > kazakovDataSet.Kabs.knamColumn.MaxLength)
                {
                    MessageBox.Show("Присутствует переполнение полей");
                }
                else
                {
                    SqlCommand com = new SqlCommand("Update Kabs set knam = '" + textBox11.Text + "', teach = " + Convert.ToInt32(comboBox1.SelectedValue) + " where knum = " + Convert.ToInt32(textBox10.Text), con);
                    com.Connection.Open();
                    if (com.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Запись уже существует");
                    }
                    else
                    {
                        com.Connection.Close();
                        MessageBox.Show("Запись изменена");
                    }
                }
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            label11.Text = "Кабинет, " + textBox11.Text.Length + "/" + kazakovDataSet.Kabs.knamColumn.MaxLength;
        }
    }
}
