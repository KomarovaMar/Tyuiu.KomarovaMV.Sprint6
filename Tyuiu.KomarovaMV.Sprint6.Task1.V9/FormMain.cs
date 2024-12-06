using Tyuiu.KomarovaMV.Sprint6.Task1.V9.Lib;
namespace Tyuiu.KomarovaMV.Sprint6.Task1.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds=new DataService();
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил  студент группы АСОиУБ-24-1 Комарова Маргарита Васильевна", "Сообщение", MessageBoxButtons.OK);
        }

        private void ButtonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart.Text);
                int stopStep = Convert.ToInt32(textBoxStop.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] array = new double[len];
                array = ds.GetMassFunction(startStep, stopStep);
                textBoxResult.Text = "";
                textBoxResult.AppendText("+----------+----------+"+Environment.NewLine);
                textBoxResult.AppendText("|     X    |   F(X)   |" + Environment.NewLine);
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i<=len-1;i++)
                {
                    strLine = String.Format("| {0,5:d}    |  {1,5:f2}   |", startStep, array[i]);
                    textBoxResult.AppendText(strLine + Environment.NewLine);
                    startStep++;
                    textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
                }
            }
            catch 
            { MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void labelStart_Click(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
