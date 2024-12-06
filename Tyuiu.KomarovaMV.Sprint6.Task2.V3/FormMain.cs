using Tyuiu.KomarovaMV.Sprint6.Task2.V3.Lib;
namespace Tyuiu.KomarovaMV.Sprint6.Task2.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart.Text);
                int stopStep = Convert.ToInt32(textBoxStop.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] array = new double[len];
                array = ds.GetMassFunction(startStep, stopStep);
                this.chartResult.Titles.Add("������ ������� F(x)");
                this.chartResult.ChartAreas[0].AxisX.Title = "��� �";
                this.chartResult.ChartAreas[0].AxisY.Title = "��� Y";
                for (int i = 0; i < len - 1; i++)
                {
                    this.dataGridView1.Rows.Add(Convert.ToString(startStep), Convert.ToString(array[i]));
                    this.chartResult.Series[0].Points.AddXY(startStep, array[i]);
                    startStep++;
                }
            }
            catch { MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonhelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 0 ��������  ������� ������ ������-24-1 �������� ��������� ����������", "���������", MessageBoxButtons.OK);
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Red;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Blue;
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = Color.Green;
        }
    }
}
