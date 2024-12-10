using Tyuiu.KomarovaMV.Sprint6.Task6.V24.Lib;
namespace Tyuiu.KomarovaMV.Sprint6.Task6.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
        private void buttonDone_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxIn.Text = File.ReadAllText(openFilePath);
            groupBoxIn.Text = groupBoxIn.Text + " " + openFileDialogTask.FileName;
            buttonDone.Enabled = true;

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void panelOut_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
