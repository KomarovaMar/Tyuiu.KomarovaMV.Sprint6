using Tyuiu.KomarovaMV.Sprint6.Task0.V16.Lib;
namespace Tyuiu.KomarovaMV.Sprint6.Task0.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxWrite.Text)));
            }
            catch { MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void labelCondition_Click(object sender, EventArgs e)
        {

        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил  студент группы АСОиУБ-24-1 Комарова Маргарита Васильевна", "Сообщение", MessageBoxButtons.OK);
        }

        private void textBoxWrite_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxWrite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar<=47 || e.KeyChar >= 65) && (e.KeyChar != 0) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}
