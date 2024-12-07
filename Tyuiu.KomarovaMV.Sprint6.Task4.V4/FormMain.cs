using System.Linq.Expressions;
using Tyuiu.KomarovaMV.Sprint6.Task4.V4.Lib;
namespace Tyuiu.KomarovaMV.Sprint6.Task4.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart.Text);
                int stop = Convert.ToInt32(textBoxStop.Text);
                int len = ds.GetMassFunction(start, stop).Length;
                double[] array = ds.GetMassFunction(start, stop);
                this.chartTask.Titles.Add("������ ������� F(x)");
                this.chartTask.ChartAreas[0].AxisX.Title = "��� �";
                this.chartTask.ChartAreas[0].AxisY.Title = "��� Y";
                textBoxResult.Text = "";
                chartTask.Series[0].Points.Clear();
                for (int i = 0; i < len - 1; i++)
                {

                    this.chartTask.Series[0].Points.AddXY(start, array[i]);
                    textBoxResult.AppendText(array[i] + Environment.NewLine);
                    start++;
                }

            }
            catch { MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 0 ��������  ������� ������ ������-24-1 �������� ��������� ����������", "���������", MessageBoxButtons.OK);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult.Text);
                DialogResult dr = MessageBox.Show("���� " + path + " ������� ��������!\n ������� ���?", "���������", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch { MessageBox.Show("����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
