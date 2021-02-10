using System;
using System.Windows.Forms;

namespace Uchet
{
    public partial class Add_Sotr_Form : Form
    {
        public Add_Sotr_Form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            textBox2.Text = "";
            string[] s = new string[62];
            string k = "";
            for (int i = 65; i < 91; i++)
            {
                k += char.ConvertFromUtf32(i);
            }

            for (int i = 97; i < 123; i++)
            {
                k += char.ConvertFromUtf32(i);
            }

            for (int i = 0; i < k.Length; i++)
            {
                s[i] = k[i].ToString();
            }

            for (int i = 0; i < 10; i++)
            {
                s[52 + i] = i.ToString();
            }

            k = "";
            for (int i = 0; i < 16; i++)
            {
                textBox2.Text += s[r.Next(0, 62)];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Заполните обязательные поля");
            }
            else
            {
                if (textBox1.Text.Length > kazakovDataSet.Sotr.snamColumn.MaxLength)
                {
                    MessageBox.Show("Присутствует переполнение полей");
                }

                if (sotrTableAdapter.Insert(0, textBox1.Text, textBox2.Text, comboBox1.SelectedItem.ToString()) == 2)
                {
                    MessageBox.Show("Пользователь зарегистрирован");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    comboBox1.SelectedIndex = -1;
                }

                else
                {
                    MessageBox.Show("Пользователя уже зарегистрирован");
                }
            }
        }

        private void Add_Sotr_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Sotr". При необходимости она может быть перемещена или удалена.
            sotrTableAdapter.Fill(kazakovDataSet.Sotr);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "Логин, " + textBox1.Text.Length + "/" + kazakovDataSet.Sotr.snamColumn.MaxLength;
        }
    }
}
