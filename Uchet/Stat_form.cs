using System;
using System.Windows.Forms;
using exel = Microsoft.Office.Interop.Excel;

namespace Uchet
{
    public partial class Stat_form : Form
    {
        public Stat_form()
        {
            InitializeComponent();
        }

        private void Stat_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kazakovDataSet.ProgUpd". При необходимости она может быть перемещена или удалена.
            progUpdTableAdapter.Fill(kazakovDataSet.ProgUpd);
            if (progUpdBindingSource.Count == 0)
            {
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Определите границы поиска");
            }
            else
            {
                int m = 0;
                int n = 0;
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    if (char.IsDigit(textBox1.Text[i]))
                    {
                        m++;
                    }
                }
                for (int i = 0; i < textBox2.Text.Length; i++)
                {
                    if (char.IsDigit(textBox2.Text[i]))
                    {
                        n++;
                    }
                }
                if (m < textBox1.Text.Length || n < textBox2.Text.Length)
                {
                    MessageBox.Show("Введены неверные года");
                }
                else
                {
                    try
                    {
                        Convert.ToInt32(textBox2.Text);
                        Convert.ToInt32(textBox1.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Слишком большое число");
                        m = -5;
                    }
                    finally
                    {
                        if (m > 0)
                        {

                            chart1.Series[0].Points.Clear();
                            chart1.Series[1].Points.Clear();
                            for (int i = 0; i < kazakovDataSet.ProgUpd.Rows.Count; i++)
                            {
                                if (Convert.ToInt32(kazakovDataSet.ProgUpd.Rows[i][0]) >= Convert.ToInt32(textBox1.Text) && Convert.ToInt32(kazakovDataSet.ProgUpd.Rows[i][0]) <= Convert.ToInt32(textBox2.Text))
                                {
                                    chart1.Series[0].Points.AddXY(Convert.ToInt32(kazakovDataSet.ProgUpd.Rows[i][0]), Convert.ToInt32(kazakovDataSet.ProgUpd.Rows[i][1]));
                                    chart1.Series[1].Points.AddXY(Convert.ToInt32(kazakovDataSet.ProgUpd.Rows[i][0]), Convert.ToInt32(kazakovDataSet.ProgUpd.Rows[i][2]));
                                }
                            }
                            if (chart1.Series[0].Points.Count == 0 && chart1.Series[1].Points.Count == 0)
                            {
                                button3.Enabled = false;
                                MessageBox.Show("В этих границах информация отсутствует");
                            }

                        }

                    }

                }



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            for (int i = 0; i < kazakovDataSet.ProgUpd.Rows.Count; i++)
            {
                chart1.Series[0].Points.AddXY(Convert.ToInt32(kazakovDataSet.ProgUpd.Rows[i][0]), Convert.ToInt32(kazakovDataSet.ProgUpd.Rows[i][1]));
                chart1.Series[1].Points.AddXY(Convert.ToInt32(kazakovDataSet.ProgUpd.Rows[i][0]), Convert.ToInt32(kazakovDataSet.ProgUpd.Rows[i][2]));
            }
            if (chart1.Series[0].Points.Count == 0)
            {
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            exel.Application application = new exel.Application();
            exel.Sheets sheets;
            exel.Worksheet worksheet;
            exel.Range cells;
            application.SheetsInNewWorkbook = 1;
            application.Workbooks.Add(Type.Missing);
            sheets = application.ActiveWorkbook.Sheets;
            worksheet = (exel.Worksheet)sheets.get_Item(1);
            worksheet.Name = "Статистика обновления";
            worksheet.Activate();
            int row = chart1.Series[0].Points.Count;
            int col = chart1.Series.Count;

            for (int i = 0; i < row; i++)
            {
                cells = (exel.Range)worksheet.Cells[i + 1, 1];
                cells.Value2 = chart1.Series[0].Points[i].XValue + " г";
            }

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    cells = (exel.Range)worksheet.Cells[j + 1, i + 2];
                    cells.Value2 = chart1.Series[i].Points[j].YValues;
                }
            }

            string cur = "c" + (row);
            cells = worksheet.get_Range("a1", cur.ToString());
            cells.Select();

            exel.Chart chart = (exel.Chart)application.Charts.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            chart.Activate();
            chart.Select(Type.Missing);

            application.ActiveChart.PlotBy = exel.XlRowCol.xlColumns;


            application.ActiveChart.HasTitle = true;
            application.ActiveChart.ChartTitle.Text = "Обновления";

            application.ActiveChart.HasLegend = true;
            application.ActiveChart.Legend.Position = exel.XlLegendPosition.xlLegendPositionBottom;
            application.ActiveChart.SeriesCollection(1).Name = "Требуется обновить";
            application.ActiveChart.SeriesCollection(2).Name = "Обновлено";


            application.ActiveChart.ChartType = exel.XlChartType.xlColumnClustered;
            application.ActiveChart.Location(exel.XlChartLocation.xlLocationAsObject, "Статистика обновления");

            application.ActiveChart.ApplyDataLabels(exel.XlDataLabelsType.xlDataLabelsShowValue, false, true, false, false, false, false, true, false, true);
            application.Visible = true;
        }
    }
}
