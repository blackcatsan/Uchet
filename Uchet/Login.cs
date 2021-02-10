using System;

using System.Windows.Forms;

namespace Uchet
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (comboBox1.SelectedIndex < 0 || textBox1.Text == "")
            {
                MessageBox.Show("Введите данные для входа");
            }
            else
            {

                for (int i = 0; i < kazakovDataSet.Sotr.Rows.Count; i++)
                {
                    if (kazakovDataSet.Sotr.Rows[i][1].ToString() == comboBox1.Text.ToString() && kazakovDataSet.Sotr.Rows[i][2].ToString() == textBox1.Text.ToString())
                    {
                        Main f = new Main(kazakovDataSet.Sotr.Rows[i][3].ToString());
                        Hide();
                        f.Show();
                        k++;
                        break;
                    }
                }

                if (k != 1)
                {
                    MessageBox.Show("Пароль не верен");
                }
            }


        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Sotr". При необходимости она может быть перемещена или удалена.
            sotrTableAdapter.Fill(kazakovDataSet.Sotr);

        }


    }
}
