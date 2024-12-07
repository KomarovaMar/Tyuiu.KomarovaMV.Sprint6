using Tyuiu.KomarovaMV.Sprint6.Task5.V23.Lib;
namespace Tyuiu.KomarovaMV.Sprint6.Task5.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\PC\Documents\InPutDataFileTask5V23.txt";
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewResult.ColumnCount = 2;
                dataGridViewResult.Columns[0].Width = 30;
                dataGridViewResult.Columns[0].Width = 50;
                this.chartTask.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartTask.ChartAreas[0].AxisY.Title = "Ось Y";
                chartTask.Series[0].Points.Clear();
                double[] x = new double[ds.len];
                double[] y = ds.LoadFromDataFile(path);
                for (int i = 0; i < y.Length; i++)
                {
                    dataGridViewResult.Rows.Add(Convert.ToString(i), Convert.ToString(y[i]));
                    chartTask.Series[0].Points.AddXY(i, y[i]);
                }

            }
            catch { MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил  студент группы АСОиУБ-24-1 Комарова Маргарита Васильевна", "Сообщение", MessageBoxButtons.OK);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
