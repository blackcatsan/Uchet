using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Uchet
{
    public partial class Main : Form
    {
        private string User;
        public Main(string u)
        {
            InitializeComponent();
            User = u;
        }

        private string connectionstring;
        // = "Data Source=WIN-AIP7CN6UDV7\\SQLEXPRESS;Initial Catalog=Kazakov;Integrated Security=True"

        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Install". При необходимости она может быть перемещена или удалена.
            installTableAdapter.Fill(kazakovDataSet.Install);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.ProgPred". При необходимости она может быть перемещена или удалена.
            progPredTableAdapter.Fill(kazakovDataSet.ProgPred);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Sotr". При необходимости она может быть перемещена или удалена.
            sotrTableAdapter.Fill(kazakovDataSet.Sotr);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.PC1". При необходимости она может быть перемещена или удалена.
            pC1TableAdapter.Fill(kazakovDataSet.PC1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.PC". При необходимости она может быть перемещена или удалена.
            pCTableAdapter.Fill(kazakovDataSet.PC);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.License". При необходимости она может быть перемещена или удалена.
            licenseTableAdapter.Fill(kazakovDataSet.License);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Programs". При необходимости она может быть перемещена или удалена.
            programsTableAdapter.Fill(kazakovDataSet.Programs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Prepodav". При необходимости она может быть перемещена или удалена.
            prepodavTableAdapter.Fill(kazakovDataSet.Prepodav);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Predmet". При необходимости она может быть перемещена или удалена.
            predmetTableAdapter.Fill(kazakovDataSet.Predmet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Kabs". При необходимости она может быть перемещена или удалена.
            kabsTableAdapter.Fill(kazakovDataSet.Kabs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Teachers". При необходимости она может быть перемещена или удалена.
            teachersTableAdapter.Fill(kazakovDataSet.Teachers);

            if (User == "Администратор")
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
                button9.Visible = true;
                button10.Visible = true;
                button11.Visible = true;
                button12.Visible = true;
                tabPage3.Parent = tabControl1;
            }
            else
            {
                tabPage3.Parent = null;
            }
            StreamReader sr = new StreamReader("Uchet.exe.config");
            while (!sr.ReadLine().Contains("<connectionStrings>"))
            {
                sr.ReadLine();
            }

            sr.ReadLine();
            string s = sr.ReadLine();
            s = s.Remove(0, 30);
            s = s.Remove(s.Length - 1);
            connectionstring = s;
        }

        private int pr = 0;
        private void Main_Activated(object sender, EventArgs e)
        {
            if (pr > 0)
            {
                //Обновление всех адаптеров таблиц при каждой фокусировке на форму
                // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Install". При необходимости она может быть перемещена или удалена.
                installTableAdapter.Fill(kazakovDataSet.Install);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.ProgPred". При необходимости она может быть перемещена или удалена.
                progPredTableAdapter.Fill(kazakovDataSet.ProgPred);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Sotr". При необходимости она может быть перемещена или удалена.
                sotrTableAdapter.Fill(kazakovDataSet.Sotr);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.PC1". При необходимости она может быть перемещена или удалена.
                pC1TableAdapter.Fill(kazakovDataSet.PC1);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.PC". При необходимости она может быть перемещена или удалена.
                pCTableAdapter.Fill(kazakovDataSet.PC);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.License". При необходимости она может быть перемещена или удалена.
                licenseTableAdapter.Fill(kazakovDataSet.License);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Programs". При необходимости она может быть перемещена или удалена.
                programsTableAdapter.Fill(kazakovDataSet.Programs);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Prepodav". При необходимости она может быть перемещена или удалена.
                prepodavTableAdapter.Fill(kazakovDataSet.Prepodav);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Predmet". При необходимости она может быть перемещена или удалена.
                predmetTableAdapter.Fill(kazakovDataSet.Predmet);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Kabs". При необходимости она может быть перемещена или удалена.
                kabsTableAdapter.Fill(kazakovDataSet.Kabs);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Teachers". При необходимости она может быть перемещена или удалена.
                teachersTableAdapter.Fill(kazakovDataSet.Teachers);

                for (int i = 0; i < dataGridView5.Rows.Count; i++)
                {
                    if (Convert.ToDateTime(dataGridView5.Rows[i].Cells[5].Value).Year == DateTime.Today.Year)
                    {
                        if (Convert.ToDateTime(dataGridView5.Rows[i].Cells[5].Value).Month - DateTime.Today.Month < 2 && Convert.ToDateTime(dataGridView5.Rows[i].Cells[5].Value).Month - DateTime.Today.Month >= 0)
                        {
                            dataGridView5.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        }
                        else
                            if (Convert.ToDateTime(dataGridView5.Rows[i].Cells[5].Value).Month - DateTime.Today.Month < 0)
                        {
                            dataGridView5.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                        }
                    }
                    else
                    {
                        if (Convert.ToDateTime(dataGridView5.Rows[i].Cells[5].Value).Year < DateTime.Today.Year)
                        {
                            dataGridView5.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                        }
                    }
                }
            }
        }

        #region Подсистема "Преподаватели"

        #region Добавление
        private void button1_Click(object sender, EventArgs e)
        {
            //Открытие формы добавления записей, относящихся к подсистеме "Преподаватели"
            Add_Prep_Form f = new Add_Prep_Form();
            f.Show();
            pr++;
        }
        #endregion

        #region Поиск методом выбора
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pr = 0;
            //Фильтр таблицы кабинетов
            if ((sender as DataGridView).SelectedCells.Count > 0)
            {
                int teach = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value);
                kabsBindingSource.Filter = "teach = " + teach;
                if (kabsBindingSource.Count == 0)
                {
                    MessageBox.Show("У выбранного преподавателя нет кабинетов, за которые он несет ответственность");
                }

                //фильтр ассоциативной таблицы
                prepodavBindingSource.Filter = "tnum = " + teach;
                int count = prepodavBindingSource.Count;
                //Создание строки фильтра для таблицы предметов и фильтрация
                string filt;
                if (count != 0)//если есть предметы у выбранного преподавателя
                {
                    filt = "(";
                    for (int i = 0; i < kazakovDataSet.Prepodav.Rows.Count; i++)
                    {
                        if (kazakovDataSet.Prepodav[i][0].ToString() == teach.ToString())
                        {
                            filt += Convert.ToInt32(kazakovDataSet.Prepodav[i][1]) + ", ";
                        }
                    }

                    filt = filt.Remove(filt.Length - 1 - 1);

                    predmetBindingSource.Filter = "pnum in " + filt + ")";
                }
                else
                {
                    predmetBindingSource.Filter = "pnum = 0";
                    MessageBox.Show("Данный преподаватель не ведет ни один предмет");

                }
            }
            else
            {
                MessageBox.Show("Преподаватель не выбран");
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pr = 0;
            //фильтр ассоциативной таблицы
            if ((sender as DataGridView).SelectedCells.Count > 0)
            {
                int pred = Convert.ToInt32(dataGridView2.Rows[dataGridView2.SelectedCells[0].RowIndex].Cells[0].Value);
                prepodavBindingSource.Filter = "pnum = " + pred;

                //Создание строки фильтра для таблицы преподавателей и фильтрация
                int count = prepodavBindingSource.Count;
                string filt;
                if (count != 0)// если выбранный предмет кто-то преподает
                {
                    filt = "(";
                    for (int i = 0; i < kazakovDataSet.Prepodav.Rows.Count; i++)
                    {
                        if (kazakovDataSet.Prepodav[i][1].ToString() == pred.ToString())
                        {
                            filt += Convert.ToInt32(kazakovDataSet.Prepodav[i][0]) + ", ";
                        }
                    }

                    filt = filt.Remove(filt.Length - 1 - 1);

                    teachersBindingSource.Filter = "tnum in " + filt + ")";
                }
                else
                {
                    teachersBindingSource.Filter = "tnum = 0";
                    MessageBox.Show("Данный предмет никто не преподает");
                }
            }
            else
            {
                MessageBox.Show("Предмет не выбран");
            }
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pr = 0;
            //Фильтр таблицы преподавателей по кабинету
            if ((sender as DataGridView).SelectedCells.Count > 0)
            {
                int prep = Convert.ToInt32(dataGridView3.Rows[dataGridView3.SelectedCells[0].RowIndex].Cells[2].Value);
                teachersBindingSource.Filter = "tnum = " + prep;
                if (teachersBindingSource.Count == 0)
                {
                    MessageBox.Show("За выбранный кабинет никто не отвечает");
                }
            }
            else
            {
                MessageBox.Show("Кабинет не выбран");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pr = 0;
            //Сброс всех созданных фильтров
            teachersBindingSource.RemoveFilter();
            predmetBindingSource.RemoveFilter();
            kabsBindingSource.RemoveFilter();
            prepodavBindingSource.RemoveFilter();
        }
        #endregion

        #region Поиск методом ввода
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pr = 0;
            //Очистка фильтра
            teachersBindingSource.RemoveFilter();
            if ((sender as TextBox).Text != "")
            {
                //Создание фильтра с кодами найденных преподавателей
                string filt = "(";
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    //Если ячейка содержит введенный текст
                    if (dataGridView1.Rows[i].Cells[1].FormattedValue.ToString().ToLower().StartsWith((sender as TextBox).Text.ToLower()))
                    {
                        filt += dataGridView1.Rows[i].Cells[0].FormattedValue + ", ";
                    }
                }
                //Если найдены преподаватели
                if (filt.Length > 1)
                {
                    filt = filt.Remove(filt.Length - 1 - 1);//Удаляет последнюю запятую и пробел
                }
                else
                {
                    filt = "(0";//вводим значение кода преподавателя, которого точно не будет
                }
                //Создание фильтра
                teachersBindingSource.Filter = "tnum in " + filt + ")";

                if (teachersBindingSource.Count == 0)
                {
                    MessageBox.Show("Преподаватели, содержащие в фамилии '" + (sender as TextBox).Text + "', не найдены");
                }
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            pr = 0;
            //Очистка фильтра
            kabsBindingSource.RemoveFilter();
            if ((sender as TextBox).Text != "")
            {
                //Создание фильтра с кодами найденных кабинетов
                string filt = "(";
                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                {
                    //Если ячейка содержит введенный текст
                    if (dataGridView3.Rows[i].Cells[1].FormattedValue.ToString().ToLower().StartsWith((sender as TextBox).Text.ToLower()))
                    {
                        filt += dataGridView3.Rows[i].Cells[0].FormattedValue + ", ";
                    }
                }
                //Если найдены преподаватели
                if (filt.Length > 1)
                {
                    filt = filt.Remove(filt.Length - 1 - 1);//Удаляет последнюю запятую и пробел
                }
                else
                {
                    filt = "(0";//вводим значение кода кабинета, которого точно не будет
                }
                //Создание фильтра
                kabsBindingSource.Filter = "knum in " + filt + ")";

                if (kabsBindingSource.Count == 0)
                {
                    MessageBox.Show("Кабинеты, содержащие '" + (sender as TextBox).Text + "', не найдены");
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            pr = 0;
            //Очистка фильтра
            predmetBindingSource.RemoveFilter();
            if ((sender as TextBox).Text != "")
            {
                if (textBox4.Text == "")
                {
                    //Создание фильтра с кодами найденных предметов
                    string filt = "(";
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        //Если ячейка содержит введенный текст
                        if (dataGridView2.Rows[i].Cells[1].FormattedValue.ToString().ToLower().StartsWith((sender as TextBox).Text.ToLower()))
                        {
                            filt += dataGridView2.Rows[i].Cells[0].FormattedValue + ", ";
                        }
                    }
                    //Если найдены предметы
                    if (filt.Length > 1)
                    {
                        filt = filt.Remove(filt.Length - 1 - 1);//Удаляет последнюю запятую и пробел
                    }
                    else
                    {
                        filt = "(0";//вводим значение кода предмета, которого точно не будет
                    }
                    //Создание фильтра
                    predmetBindingSource.Filter = "pnum in " + filt + ")";

                    if (predmetBindingSource.Count == 0)
                    {
                        MessageBox.Show("Предметы, содержащие '" + (sender as TextBox).Text + "', не найдены");
                    }
                }
                else
                {
                    //Создание фильтра с кодами найденных предметов
                    string filt = "(";
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        //Если ячейка содержит введенный текст
                        if (dataGridView2.Rows[i].Cells[1].FormattedValue.ToString().ToLower().StartsWith((sender as TextBox).Text.ToLower()) && dataGridView2.Rows[i].Cells[3].FormattedValue.ToString().ToLower().StartsWith(textBox4.Text.ToLower()))
                        {
                            filt += dataGridView2.Rows[i].Cells[0].FormattedValue + ", ";
                        }
                    }
                    //Если найдены предметы
                    if (filt.Length > 1)
                    {
                        filt = filt.Remove(filt.Length - 1 - 1);//Удаляет последнюю запятую и пробел
                    }
                    else
                    {
                        filt = "(0";//вводим значение кода предмета, которого точно не будет
                    }
                    //Создание фильтра
                    predmetBindingSource.Filter = "pnum in " + filt + ")";

                    if (predmetBindingSource.Count == 0)
                    {
                        MessageBox.Show("Предметы, содержащие '" + (sender as TextBox).Text + "' и в специальности, содержащей '" + textBox4.Text + "', не найдены");
                    }
                }

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            pr = 0;
            //Очистка фильтра
            predmetBindingSource.RemoveFilter();
            if ((sender as TextBox).Text != "")
            {
                if (textBox3.Text == "")
                {
                    //Создание фильтра с кодами найденных предметов
                    string filt = "(";
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        //Если ячейка содержит введенный текст
                        if (dataGridView2.Rows[i].Cells[3].FormattedValue.ToString().ToLower().StartsWith((sender as TextBox).Text.ToLower()))
                        {
                            filt += dataGridView2.Rows[i].Cells[0].FormattedValue + ", ";
                        }
                    }
                    //Если найдены предметы
                    if (filt.Length > 1)
                    {
                        filt = filt.Remove(filt.Length - 1 - 1);//Удаляет последнюю запятую и пробел
                    }
                    else
                    {
                        filt = "(0";//вводим значение кода предмета, которого точно не будет
                    }
                    //Создание фильтра
                    predmetBindingSource.Filter = "pnum in " + filt + ")";

                    if (predmetBindingSource.Count == 0)
                    {
                        MessageBox.Show("Предметы, содержащие '" + (sender as TextBox).Text + "', не найдены");
                    }
                }
                else
                {
                    //Создание фильтра с кодами найденных предметов
                    string filt = "(";
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        //Если ячейка содержит введенный текст
                        if (dataGridView2.Rows[i].Cells[3].FormattedValue.ToString().ToLower().StartsWith((sender as TextBox).Text.ToLower()) && dataGridView2.Rows[i].Cells[1].FormattedValue.ToString().ToLower().StartsWith(textBox4.Text.ToLower()))
                        {
                            filt += dataGridView2.Rows[i].Cells[0].FormattedValue + ", ";
                        }
                    }
                    //Если найдены предметы
                    if (filt.Length > 1)
                    {
                        filt = filt.Remove(filt.Length - 1 - 1);//Удаляет последнюю запятую и пробел
                    }
                    else
                    {
                        filt = "(0";//вводим значение кода предмета, которого точно не будет
                    }
                    //Создание фильтра
                    predmetBindingSource.Filter = "pnum in " + filt + ")";

                    if (predmetBindingSource.Count == 0)
                    {
                        MessageBox.Show("Предметы, содержащие '" + textBox3.Text + "' и в специальности, содержащей '" + (sender as TextBox).Text + "', не найдены");
                    }
                }

            }
        }
        #endregion

        #region Изменение
        private void button2_Click(object sender, EventArgs e)
        {

            //Вызов формы изменения выбранного предмета с переносом данных
            if (dataGridView2.SelectedCells.Count > 0)
            {
                string[] pnum = new string[dataGridView2.Columns.Count];

                for (int i = 0; i < dataGridView2.Columns.Count; i++)
                {
                    pnum[i] = dataGridView2.Rows[dataGridView2.SelectedCells[0].RowIndex].Cells[i].FormattedValue.ToString();
                }

                Change_Prep_Form_pred f = new Change_Prep_Form_pred(pnum, connectionstring);
                f.Show();
                pr++;
            }
            else
            {
                MessageBox.Show("Предмет не выбран");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Вызов формы изменения выбранного преподавателя с переносом данных
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string[] tnum = new string[dataGridView1.Columns.Count];


                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    tnum[i] = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[i].FormattedValue.ToString();
                }

                Change_Prep_Form_prep f = new Change_Prep_Form_prep(tnum, connectionstring);
                f.Show();
                pr++;
            }
            else
            {
                MessageBox.Show("Преподаватель не выбран");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Вызов формы изменения выбранного кабинета с переносом данных
            if (dataGridView3.SelectedCells.Count > 0)
            {
                string[] kab = new string[dataGridView3.Columns.Count];

                for (int i = 0; i < dataGridView3.Columns.Count; i++)
                {
                    kab[i] = dataGridView3.Rows[dataGridView3.SelectedCells[0].RowIndex].Cells[i].FormattedValue.ToString();
                }

                Change_Prep_Form_kabs f = new Change_Prep_Form_kabs(kab, connectionstring);
                f.Show();
                pr++;
            }
            else
            {
                MessageBox.Show("Кабинет не выбран");
            }
        }
        #endregion

        #region Экспорт
        private void button14_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Word.Application application = new Word.Application();
                Word.Document document = application.Documents.Add();
                document.Paragraphs[1].Range.Text = "Отчет по преподавателю: " + dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[1].Value + " " + dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[2].Value + " " + dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[3].Value;
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                document.Paragraphs.Add();

                string s = "";
                kabsBindingSource.Filter = "teach = " + Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value);
                for (int i = 0; i < kabsBindingSource.Count; i++)
                {
                    s += dataGridView3.Rows[i].Cells[1].Value.ToString() + ", ";
                }

                document.Paragraphs[2].Range.Text = "Кабинеты: " + s;
                document.Paragraphs[3].Range.Text = "Предметы:";
                document.Paragraphs.Add();
                Word.Range range = document.Paragraphs[4].Range;
                prepodavBindingSource.Filter = "tnum = " + Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value);
                int row = prepodavBindingSource.Count;
                int col = kazakovDataSet.Predmet.Columns.Count;
                document.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;

                range.Tables.Add(range, row + 1, col);

                Word.Table table = range.Tables[1];
                table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                for (int i = 0; i < col; i++)
                {
                    table.Rows[1].Cells[i + 1].Range.Text = dataGridView2.Columns[i].HeaderText;
                }

                string filt = "(";
                for (int i = 0; i < dataGridView4.Rows.Count; i++)
                {

                    filt += Convert.ToInt32(dataGridView4[1, i].Value) + ", ";

                }

                filt = filt.Remove(filt.Length - 1 - 1);

                predmetBindingSource.Filter = "pnum in " + filt + ")";

                for (int i = 0; i < col; i++)
                {
                    for (int j = 0; j < row; j++)
                    {
                        table.Rows[j + 2].Cells[i + 1].Range.Text = dataGridView2.Rows[j].Cells[i].Value.ToString();
                    }
                }

                predmetBindingSource.RemoveFilter();
                prepodavBindingSource.RemoveFilter();
                kabsBindingSource.RemoveFilter();

                application.Visible = true;
            }
            else
            {
                MessageBox.Show("Преподаватель не выбран");
            }
        }
        #endregion
        #endregion

        #region Подсистема "Программное обеспечение"
        #region Добавление
        private void button3_Click(object sender, EventArgs e)
        {
            //Вызов формыдобавления записей, относящихся к подсистеме "Программное обеспечение"
            Add_Prog_Form f = new Add_Prog_Form();
            f.Show();
            pr++;
        }
        #endregion

        #region Поиск методом выбора
        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Фильтр ассоциативных таблиц
            pr = 0;
            if ((sender as DataGridView).SelectedCells.Count > 0)
            {
                licenseBindingSource.Filter = "lnum = " + Convert.ToInt32(dataGridView5.Rows[dataGridView5.SelectedCells[0].RowIndex].Cells[3].Value);
                if (licenseBindingSource.Count == 0)
                {
                    licenseBindingSource.Filter = "lnum = 0";
                    MessageBox.Show("У данной программы отсутствует лицензия");
                }
                int prog = Convert.ToInt32(dataGridView5.Rows[dataGridView5.SelectedCells[0].RowIndex].Cells[0].Value);
                installBindingSource.Filter = "prog = " + prog;


                //Создание строки фильтра для таблицы ПК и фильтрация
                int count = installBindingSource.Count;
                string filt;
                if (count != 0)//Если программа установлена на ПК
                {
                    filt = "(";
                    for (int i = 0; i < dataGridView7.Rows.Count; i++)
                    {
                        filt += Convert.ToInt32(dataGridView7[1, i].Value) + ", ";
                    }

                    filt = filt.Remove(filt.Length - 1 - 1);

                    pC1BindingSource.Filter = "PCnum in " + filt + ")";
                }
                else
                {
                    MessageBox.Show("Данная программа нигде не установлена");
                }

                //Создание строки фильтра для таблицы предметов и фильтрация
                progPredBindingSource.Filter = "prog = " + prog;
                count = progPredBindingSource.Count;
                if (count != 0)//Если программа используется в предмете
                {
                    filt = "(";
                    for (int i = 0; i < dataGridView8.Rows.Count; i++)
                    {
                        filt += dataGridView8[1, i].FormattedValue + ", ";
                    }

                    filt = filt.Remove(filt.Length - 1 - 1);

                    predmetBindingSource.Filter = "pnum in " + filt + ")";
                }
                else
                {
                    predmetBindingSource.Filter = "pnum = 0";
                    MessageBox.Show("Данная программа нигде не используется");
                }
            }
            else
            {
                MessageBox.Show("Программа не выбрана");
            }
        }

        private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pr = 0;
            //Фильтр ассоциативной таблицы
            if ((sender as DataGridView).SelectedCells.Count > 0)
            {
                int pc = Convert.ToInt32(dataGridView6.Rows[dataGridView6.SelectedCells[0].RowIndex].Cells[0].Value);
                installBindingSource.Filter = "pc = " + pc;

                //Создание строки фильтра для таблицы программ и фильтрация
                int count = installBindingSource.Count;
                string filt;
                if (count != 0)//Если программа находится на данном ПК
                {
                    filt = "(";
                    for (int i = 0; i < dataGridView7.Rows.Count; i++)
                    {
                        filt += Convert.ToInt32(dataGridView7[0, i].Value) + ", ";
                    }

                    filt = filt.Remove(filt.Length - 1 - 1);

                    programsBindingSource.Filter = "Prnum in " + filt + ")";
                }
                else
                {
                    programsBindingSource.Filter = "prnum = 0";
                    MessageBox.Show("На данном ПК нет установленных программ");
                }
            }
            else
            {
                MessageBox.Show("ПК не выбран");
            }
        }

        private void dataGridView9_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pr = 0;
            //Фильтр ассоциативной таблицы
            if ((sender as DataGridView).SelectedCells.Count > 0)
            {
                int pred = Convert.ToInt32(dataGridView9.Rows[dataGridView9.SelectedCells[0].RowIndex].Cells[0].Value);
                progPredBindingSource.Filter = "predm = " + pred;

                //Создание строки фильтра для таблицы программ и фильтрация
                int count = progPredBindingSource.Count;
                string filt;
                if (count != 0)//Если программы используются в данном предмете
                {
                    filt = "(";
                    for (int i = 0; i < dataGridView8.Rows.Count; i++)
                    {
                        filt += Convert.ToInt32(dataGridView8[0, i].Value) + ", ";
                    }

                    filt = filt.Remove(filt.Length - 1 - 1);

                    programsBindingSource.Filter = "Prnum in " + filt + ")";
                }
                else
                {
                    programsBindingSource.Filter = "prnum = 0";
                    MessageBox.Show("У данного предмета нет установленных программ");
                }
            }
            else
            {
                MessageBox.Show("Предмет не выбран");
            }
        }

        private void dataGridView10_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pr = 0;
            //Фильтр таблицы ПО по лицензии
            if ((sender as DataGridView).SelectedCells.Count > 0)
            {
                int prog = Convert.ToInt32(dataGridView10.Rows[dataGridView10.SelectedCells[0].RowIndex].Cells[0].Value);
                programsBindingSource.Filter = "license = " + prog;
                if (programsBindingSource.Count == 0)
                {
                    MessageBox.Show("Нет программ с данной лицензией");
                }
            }
            else
            {
                MessageBox.Show("Лицензия не выбрана");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pr = 0;
            //Сброс всех установленных фильтров
            predmetBindingSource.RemoveFilter();
            progPredBindingSource.RemoveFilter();
            installBindingSource.RemoveFilter();
            pC1BindingSource.RemoveFilter();
            programsBindingSource.RemoveFilter();
            licenseBindingSource.RemoveFilter();
        }
        #endregion

        #region Поичк методом ввода
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            pr = 0;
            //Очистка фильтра
            programsBindingSource.RemoveFilter();
            if ((sender as TextBox).Text != "")
            {
                //Создание фильтра с кодами найденных кабинетов
                string filt = "(";
                for (int i = 0; i < dataGridView5.Rows.Count; i++)
                {
                    //Если ячейка содержит введенный текст
                    if (dataGridView5.Rows[i].Cells[1].FormattedValue.ToString().ToLower().StartsWith((sender as TextBox).Text.ToLower()))
                    {
                        filt += dataGridView5.Rows[i].Cells[0].FormattedValue + ", ";
                    }
                }
                //Если найдены преподаватели
                if (filt.Length > 1)
                {
                    filt = filt.Remove(filt.Length - 1 - 1);//Удаляет последнюю запятую и пробел
                }
                else
                {
                    filt = "(0";//вводим значение кода кабинета, которого точно не будет
                }
                //Создание фильтра
                programsBindingSource.Filter = "prnum in " + filt + ")";

                if (programsBindingSource.Count == 0)
                {
                    MessageBox.Show("Программы, содержащие '" + (sender as TextBox).Text + "', не найдены");
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            pr = 0;
            //Очистка фильтра
            licenseBindingSource.RemoveFilter();
            if ((sender as TextBox).Text != "")
            {
                //Создание фильтра с кодами найденных кабинетов
                string filt = "(";
                for (int i = 0; i < dataGridView10.Rows.Count; i++)
                {
                    //Если ячейка содержит введенный текст
                    if (dataGridView10.Rows[i].Cells[1].FormattedValue.ToString().ToLower().StartsWith((sender as TextBox).Text.ToLower()))
                    {
                        filt += dataGridView10.Rows[i].Cells[0].FormattedValue + ", ";
                    }
                }
                //Если найдены преподаватели
                if (filt.Length > 1)
                {
                    filt = filt.Remove(filt.Length - 1 - 1);//Удаляет последнюю запятую и пробел
                }
                else
                {
                    filt = "(0";//вводим значение кода кабинета, которого точно не будет
                }
                //Создание фильтра
                licenseBindingSource.Filter = "lnum in " + filt + ")";

                if (licenseBindingSource.Count == 0)
                {
                    MessageBox.Show("Лицензии, содержащие '" + (sender as TextBox).Text + "', не найдены");
                }
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            pr = 0;
            //Очистка фильтра
            pC1BindingSource.RemoveFilter();
            if ((sender as TextBox).Text != "")
            {
                //Создание фильтра с кодами найденных кабинетов
                string filt = "(";
                for (int i = 0; i < dataGridView6.Rows.Count; i++)
                {
                    //Если ячейка содержит введенный текст
                    if (dataGridView6.Rows[i].Cells[3].FormattedValue.ToString().ToLower().StartsWith((sender as TextBox).Text.ToLower()))
                    {
                        filt += dataGridView6.Rows[i].Cells[0].FormattedValue + ", ";
                    }
                }
                //Если найдены преподаватели
                if (filt.Length > 1)
                {
                    filt = filt.Remove(filt.Length - 1 - 1);//Удаляет последнюю запятую и пробел
                }
                else
                {
                    filt = "(0";//вводим значение кода кабинета, которого точно не будет
                }
                //Создание фильтра
                pC1BindingSource.Filter = "pcnum in " + filt + ")";

                if (pC1BindingSource.Count == 0)
                {
                    MessageBox.Show("ПК, содержащие '" + (sender as TextBox).Text + "', не найдены");
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            pr = 0;
            //Очистка фильтра
            predmetBindingSource.RemoveFilter();
            if ((sender as TextBox).Text != "")
            {
                if (textBox8.Text == "")
                {
                    //Создание фильтра с кодами найденных предметов
                    string filt = "(";
                    for (int i = 0; i < dataGridView9.Rows.Count; i++)
                    {
                        //Если ячейка содержит введенный текст
                        if (dataGridView9.Rows[i].Cells[1].FormattedValue.ToString().ToLower().StartsWith((sender as TextBox).Text.ToLower()))
                        {
                            filt += dataGridView9.Rows[i].Cells[0].FormattedValue + ", ";
                        }
                    }
                    //Если найдены предметы
                    if (filt.Length > 1)
                    {
                        filt = filt.Remove(filt.Length - 1 - 1);//Удаляет последнюю запятую и пробел
                    }
                    else
                    {
                        filt = "(0";//вводим значение кода предмета, которого точно не будет
                    }
                    //Создание фильтра
                    predmetBindingSource.Filter = "pnum in " + filt + ")";

                    if (predmetBindingSource.Count == 0)
                    {
                        MessageBox.Show("Предметы, содержащие '" + (sender as TextBox).Text + "', не найдены");
                    }
                }
                else
                {
                    //Создание фильтра с кодами найденных предметов
                    string filt = "(";
                    for (int i = 0; i < dataGridView9.Rows.Count; i++)
                    {
                        //Если ячейка содержит введенный текст
                        if (dataGridView9.Rows[i].Cells[1].FormattedValue.ToString().ToLower().StartsWith((sender as TextBox).Text.ToLower()) && dataGridView9.Rows[i].Cells[3].FormattedValue.ToString().ToLower().StartsWith(textBox8.Text.ToLower()))
                        {
                            filt += dataGridView9.Rows[i].Cells[0].FormattedValue + ", ";
                        }
                    }
                    //Если найдены предметы
                    if (filt.Length > 1)
                    {
                        filt = filt.Remove(filt.Length - 1 - 1);//Удаляет последнюю запятую и пробел
                    }
                    else
                    {
                        filt = "(0";//вводим значение кода предмета, которого точно не будет
                    }
                    //Создание фильтра
                    predmetBindingSource.Filter = "pnum in " + filt + ")";

                    if (predmetBindingSource.Count == 0)
                    {
                        MessageBox.Show("Предметы, содержащие '" + (sender as TextBox).Text + "' и в специальности, содержащей '" + textBox8.Text + "', не найдены");
                    }
                }

            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            pr = 0;
            //Очистка фильтра
            predmetBindingSource.RemoveFilter();
            if ((sender as TextBox).Text != "")
            {
                if (textBox7.Text == "")
                {
                    //Создание фильтра с кодами найденных предметов
                    string filt = "(";
                    for (int i = 0; i < dataGridView9.Rows.Count; i++)
                    {
                        //Если ячейка содержит введенный текст
                        if (dataGridView9.Rows[i].Cells[3].FormattedValue.ToString().ToLower().StartsWith((sender as TextBox).Text.ToLower()))
                        {
                            filt += dataGridView9.Rows[i].Cells[0].FormattedValue + ", ";
                        }
                    }
                    //Если найдены предметы
                    if (filt.Length > 1)
                    {
                        filt = filt.Remove(filt.Length - 1 - 1);//Удаляет последнюю запятую и пробел
                    }
                    else
                    {
                        filt = "(0";//вводим значение кода предмета, которого точно не будет
                    }
                    //Создание фильтра
                    predmetBindingSource.Filter = "pnum in " + filt + ")";

                    if (predmetBindingSource.Count == 0)
                    {
                        MessageBox.Show("Предметы, содержащие '" + (sender as TextBox).Text + "', не найдены");
                    }
                }
                else
                {
                    //Создание фильтра с кодами найденных предметов
                    string filt = "(";
                    for (int i = 0; i < dataGridView9.Rows.Count; i++)
                    {
                        //Если ячейка содержит введенный текст
                        if (dataGridView9.Rows[i].Cells[3].FormattedValue.ToString().ToLower().StartsWith((sender as TextBox).Text.ToLower()) && dataGridView9.Rows[i].Cells[1].FormattedValue.ToString().ToLower().StartsWith(textBox7.Text.ToLower()))
                        {
                            filt += dataGridView9.Rows[i].Cells[0].FormattedValue + ", ";
                        }
                    }
                    //Если найдены предметы
                    if (filt.Length > 1)
                    {
                        filt = filt.Remove(filt.Length - 1 - 1);//Удаляет последнюю запятую и пробел
                    }
                    else
                    {
                        filt = "(0";//вводим значение кода предмета, которого точно не будет
                    }
                    //Создание фильтра
                    predmetBindingSource.Filter = "pnum in " + filt + ")";

                    if (predmetBindingSource.Count == 0)
                    {
                        MessageBox.Show("Предметы, содержащие '" + textBox7.Text + "' и в специальности, содержащей '" + (sender as TextBox).Text + "', не найдены");
                    }
                }

            }
        }
        #endregion

        #region Изменение
        private void button7_Click(object sender, EventArgs e)
        {
            //Вызов формы изменения выбранной программы с переносом данных
            if (dataGridView5.SelectedCells.Count > 0)
            {
                string[] prog = new string[dataGridView5.Columns.Count];

                for (int i = 0; i < dataGridView5.Columns.Count; i++)
                {
                    prog[i] = dataGridView5.Rows[dataGridView5.SelectedCells[0].RowIndex].Cells[i].FormattedValue.ToString();
                }

                Change_Prog_Form_prog f = new Change_Prog_Form_prog(prog, connectionstring);
                f.Show();
                pr++;
            }
            else
            {
                MessageBox.Show("Программа не выбрана");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Вызов формы изменения выбранного предмета с переносом данных
            if (dataGridView9.SelectedCells.Count > 0)
            {
                string[] pred = new string[dataGridView9.Columns.Count];

                for (int i = 0; i < dataGridView9.Columns.Count; i++)
                {
                    pred[i] = dataGridView9.Rows[dataGridView9.SelectedCells[0].RowIndex].Cells[i].FormattedValue.ToString();
                }

                Change_Prog_Form_pred f = new Change_Prog_Form_pred(pred, connectionstring);
                f.Show();
                pr++;
            }
            else
            {
                MessageBox.Show("Предмет не выбран");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Вызов формы изменения выбранного ПК с переносом данных
            if (dataGridView6.SelectedCells.Count > 0)
            {
                string[] pc = new string[dataGridView6.Columns.Count];

                for (int i = 0; i < dataGridView6.Columns.Count; i++)
                {
                    pc[i] = dataGridView6.Rows[dataGridView6.SelectedCells[0].RowIndex].Cells[i].FormattedValue.ToString();
                }

                Change_Prog_Form_pc f = new Change_Prog_Form_pc(pc, connectionstring);
                f.Show();
                pr++;
            }
            else
            {
                MessageBox.Show("ПК не выбран");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Вызов формы изменения выбранной лицензии с переносом данных
            if (dataGridView10.SelectedCells.Count > 0)
            {
                string[] lice = new string[dataGridView10.Columns.Count];

                for (int i = 0; i < dataGridView10.Columns.Count; i++)
                {
                    lice[i] = dataGridView10.Rows[dataGridView10.SelectedCells[0].RowIndex].Cells[i].FormattedValue.ToString();
                }

                Change_Prog_Form_lice f = new Change_Prog_Form_lice(lice, connectionstring);
                f.Show();
                pr++;
            }
            else
            {
                MessageBox.Show("Лицензия не выбрана");
            }
        }
        #endregion

        #region Обновление по
        private void button12_Click(object sender, EventArgs e)
        {
            //Вызов формы Обновления выбранной программы с переносом данных
            if (dataGridView5.SelectedCells.Count > 0)
            {
                string[] prog = new string[dataGridView5.Columns.Count];

                for (int i = 0; i < dataGridView5.Columns.Count; i++)
                {
                    prog[i] = dataGridView5.Rows[dataGridView5.SelectedCells[0].RowIndex].Cells[i].FormattedValue.ToString();
                }
                DateTime s = Convert.ToDateTime(prog[5]);
                if ((s - DateTime.Today).Days > 30)
                {
                    MessageBox.Show("Программу обновлять не нужно");
                }
                else
                {
                    Update_Form f = new Update_Form(prog, connectionstring);
                    f.Show();
                    pr++;
                }

            }
            else
            {
                MessageBox.Show("Программа не выбрана");
            }
        }
        #endregion

        #region Проверка ПО
        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                for (int i = 0; i < dataGridView5.Rows.Count; i++)
                {
                    if (Convert.ToDateTime(dataGridView5.Rows[i].Cells[5].Value).Year == DateTime.Today.Year)
                    {
                        if (Convert.ToDateTime(dataGridView5.Rows[i].Cells[5].Value).Month - DateTime.Today.Month < 2 && Convert.ToDateTime(dataGridView5.Rows[i].Cells[5].Value).Month - DateTime.Today.Month >= 0)
                        {
                            dataGridView5.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        }
                        else
                            if (Convert.ToDateTime(dataGridView5.Rows[i].Cells[5].Value).Month - DateTime.Today.Month < 0)
                        {
                            dataGridView5.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                        }
                    }
                    else
                        if (Convert.ToDateTime(dataGridView5.Rows[i].Cells[5].Value).Year < DateTime.Today.Year)
                    {
                        dataGridView5.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                    }
                }
            }
        }
        #endregion

        #region Экспорт
        private void button15_Click(object sender, EventArgs e)
        {
            if (dataGridView5.Rows.Count > 0)
            {
                Word.Application application = new Word.Application();
                Word.Document document = application.Documents.Add();
                document.Paragraphs[1].Range.Text = "Отчет по ПО: " + dataGridView5.Rows[dataGridView5.SelectedCells[0].RowIndex].Cells[1].Value + " " + dataGridView5.Rows[dataGridView5.SelectedCells[0].RowIndex].Cells[2].Value;
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                document.Paragraphs.Add();

                string s = "";
                licenseBindingSource.Filter = "lnum = " + Convert.ToInt32(dataGridView5.Rows[dataGridView5.SelectedCells[0].RowIndex].Cells[3].Value);
                for (int i = 0; i < licenseBindingSource.Count; i++)
                {
                    s += dataGridView10.Rows[i].Cells[1].Value.ToString();
                }
                licenseBindingSource.RemoveFilter();
                document.Paragraphs[2].Range.Text = "Лицензия: " + s;
                document.Paragraphs[3].Range.Text = "Предметы:";
                document.Paragraphs.Add();
                Word.Range range = document.Paragraphs[4].Range;
                progPredBindingSource.Filter = "prog = " + Convert.ToInt32(dataGridView5.Rows[dataGridView5.SelectedCells[0].RowIndex].Cells[0].Value);
                int row = progPredBindingSource.Count;
                int col = kazakovDataSet.Predmet.Columns.Count;
                document.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;

                range.Tables.Add(range, row + 1, col);

                Word.Table table = range.Tables[1];
                table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                for (int i = 0; i < col; i++)
                {
                    table.Rows[1].Cells[i + 1].Range.Text = dataGridView9.Columns[i].HeaderText;
                }

                string filt = "(";
                for (int i = 0; i < dataGridView8.Rows.Count; i++)
                {

                    filt += Convert.ToInt32(dataGridView8[1, i].Value) + ", ";

                }

                if (filt.Length >= 2)
                {
                    filt = filt.Remove(filt.Length - 1 - 1);
                }
                else
                {
                    filt = "(0";
                }

                predmetBindingSource.Filter = "pnum in " + filt + ")";

                for (int i = 0; i < col; i++)
                {
                    for (int j = 0; j < row; j++)
                    {
                        table.Rows[j + 2].Cells[i + 1].Range.Text = dataGridView9.Rows[j].Cells[i].Value.ToString();
                    }
                }

                predmetBindingSource.RemoveFilter();
                progPredBindingSource.RemoveFilter();
                installBindingSource.Filter = "prog = " + Convert.ToInt32(dataGridView5.Rows[dataGridView5.SelectedCells[0].RowIndex].Cells[0].Value);
                row = installBindingSource.Count;
                col = kazakovDataSet.PC1.Columns.Count;
                document.Paragraphs.Add();
                document.Paragraphs.Add();
                Word.Range range1 = document.Paragraphs.Last.Range;
                range1.Text = "ПК";
                document.Paragraphs.Add();
                range1 = document.Paragraphs.Last.Range;
                range.Tables.Add(range1, row + 1, col - 1);

                table = range1.Tables[1];
                table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                for (int i = 0; i < col - 1; i++)
                {
                    if (i != 2)
                    {
                        table.Rows[1].Cells[i + 1].Range.Text = dataGridView6.Columns[i].HeaderText;
                    }
                    else
                    {
                        table.Rows[1].Cells[i + 1].Range.Text = dataGridView6.Columns[i + 1].HeaderText;
                    }
                }

                filt = "(";
                for (int i = 0; i < dataGridView7.Rows.Count; i++)
                {

                    filt += Convert.ToInt32(dataGridView7[1, i].Value) + ", ";

                }

                if (filt.Length >= 2)
                {
                    filt = filt.Remove(filt.Length - 1 - 1);
                }
                else
                {
                    filt = "(0";
                }

                pC1BindingSource.Filter = "pcnum in " + filt + ")";

                for (int i = 0; i < col - 1; i++)
                {
                    for (int j = 0; j < row; j++)
                    {
                        if (i != 2)
                        {
                            table.Rows[j + 2].Cells[i + 1].Range.Text = dataGridView6.Rows[j].Cells[i].Value.ToString();
                        }
                        else
                        {
                            table.Rows[j + 2].Cells[i + 1].Range.Text = dataGridView6.Rows[j].Cells[i + 1].Value.ToString();
                        }
                    }
                }
                progPredBindingSource.RemoveFilter();
                installBindingSource.RemoveFilter();
                pC1BindingSource.RemoveFilter();
                predmetBindingSource.RemoveFilter();
                application.Visible = true;
            }
            else
            {
                MessageBox.Show("Программа не выбрана");
            }
        }
        #endregion
        #endregion

        #region Подсистема "Сотрудники"

        #region Регистрация
        private void button13_Click(object sender, EventArgs e)
        {
            Add_Sotr_Form f = new Add_Sotr_Form();
            f.Show();
        }
        #endregion
        #endregion

        #region МЕНЮ

        #region МЕНЮ
        private void статистикаОбновленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stat_form f = new Stat_form();
            f.Show();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Install". При необходимости она может быть перемещена или удалена.
            installTableAdapter.Fill(kazakovDataSet.Install);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.ProgPred". При необходимости она может быть перемещена или удалена.
            progPredTableAdapter.Fill(kazakovDataSet.ProgPred);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Sotr". При необходимости она может быть перемещена или удалена.
            sotrTableAdapter.Fill(kazakovDataSet.Sotr);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.PC1". При необходимости она может быть перемещена или удалена.
            pC1TableAdapter.Fill(kazakovDataSet.PC1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.PC". При необходимости она может быть перемещена или удалена.
            pCTableAdapter.Fill(kazakovDataSet.PC);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.License". При необходимости она может быть перемещена или удалена.
            licenseTableAdapter.Fill(kazakovDataSet.License);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Programs". При необходимости она может быть перемещена или удалена.
            programsTableAdapter.Fill(kazakovDataSet.Programs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Prepodav". При необходимости она может быть перемещена или удалена.
            prepodavTableAdapter.Fill(kazakovDataSet.Prepodav);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Predmet". При необходимости она может быть перемещена или удалена.
            predmetTableAdapter.Fill(kazakovDataSet.Predmet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Kabs". При необходимости она может быть перемещена или удалена.
            kabsTableAdapter.Fill(kazakovDataSet.Kabs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.Teachers". При необходимости она может быть перемещена или удалена.
            teachersTableAdapter.Fill(kazakovDataSet.Teachers);


            for (int i = 0; i < dataGridView5.Rows.Count; i++)
            {
                if (Convert.ToDateTime(dataGridView5.Rows[i].Cells[5].Value).Year == DateTime.Today.Year)
                {
                    if (Convert.ToDateTime(dataGridView5.Rows[i].Cells[5].Value).Month - DateTime.Today.Month < 2 && Convert.ToDateTime(dataGridView5.Rows[i].Cells[5].Value).Month - DateTime.Today.Month >= 0)
                    {
                        dataGridView5.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        if (Convert.ToDateTime(dataGridView5.Rows[i].Cells[5].Value).Month - DateTime.Today.Month < 0)
                        {
                            dataGridView5.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                        }
                    }
                }
                else
                {
                    if (Convert.ToDateTime(dataGridView5.Rows[i].Cells[5].Value).Year < DateTime.Today.Year)
                    {
                        dataGridView5.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                    }
                }

            }
        }



        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {

            User = "";
            Close();

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region О программе
        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Курсовой проект МДК 4:" + Environment.NewLine + "Информационная система учета программного обеспечения цикловой комиссии" + Environment.NewLine + "Автор: Казаков Артем, студент группы ИП-41");
        }
        #endregion
        #endregion

        #region Закрытие формы
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            pr = 0;
            string a = MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo).ToString();
            if (a == "No")
            {
                e.Cancel = true;
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login f = new Login();
            f.Show();
        }
        #endregion
    }
}