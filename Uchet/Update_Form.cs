using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Uchet
{
    public partial class Update_Form : Form
    {
        private readonly SqlConnection con;
        private readonly string k;
        public Update_Form(string[] prog, string connect)
        {
            InitializeComponent();
            con = new SqlConnection(connect);

            textBox4.Text = prog[0];
            textBox1.Text = prog[1];
            textBox2.Text = prog[2];
            k = prog[3];
            dateTimePicker1.Value = Convert.ToDateTime(prog[4]);
            dateTimePicker2.Value = Convert.ToDateTime(prog[5]);
            textBox3.Text = prog[6];
        }

        private void Update_Form_Load(object sender, System.EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Programs". При необходимости она может быть перемещена или удалена.
            programsTableAdapter.Fill(kazakovDataSet.Programs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.License". При необходимости она может быть перемещена или удалена.
            licenseTableAdapter.Fill(kazakovDataSet.License);
            comboBox1.SelectedValue = k;
            if (comboBox1.SelectedIndex > -1)
            {
                for (int i = 0; i < kazakovDataSet.License.Rows.Count; i++)
                {
                    if (kazakovDataSet.License.Rows[i][0].ToString() == comboBox1.SelectedValue.ToString())
                    {

                        dateTimePicker3.Value = DateTime.Today.AddYears(Convert.ToInt32(kazakovDataSet.License.Rows[i][2].ToString()));
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

                        dateTimePicker3.Value = DateTime.Today.AddYears(Convert.ToInt32(kazakovDataSet.License.Rows[i][2].ToString()));
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите лицензию");
            }
            else
            {
                SqlCommand com = new SqlCommand("Update Programs set license = " + Convert.ToInt32(comboBox1.SelectedValue) + ", expr_dat = '" + dateTimePicker3.Value + "' where prnum = " + Convert.ToInt32(textBox4.Text) + "", con);
                com.Connection.Open();
                com.ExecuteNonQuery();
                com = new SqlCommand("Update ProgUpd set upd = upd + 1 where Years = " + dateTimePicker2.Value.Year, con);
                com.ExecuteNonQuery();
                com = new SqlCommand("if not exists(select * from progupd where years = " + dateTimePicker3.Value.Year + ") insert into progupd values (" + dateTimePicker3.Value.Year + ",1,0) else update progupd set all_upd = all_upd+1 where years = " + dateTimePicker3.Value.Year, con);
                com.ExecuteNonQuery();
                com.Connection.Close();

                button1.Enabled = false;

                MessageBox.Show("Программа обновлена");
            }
        }
    }
}
