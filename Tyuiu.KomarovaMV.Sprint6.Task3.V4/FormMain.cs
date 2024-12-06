using Tyuiu.KomarovaMV.Sprint6.Task3.V4.Lib;
namespace Tyuiu.KomarovaMV.Sprint6.Task3.V4;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
    }
    DataService ds= new DataService();
    int[,] x = { { -14, -7, 18, 12, -20 }, { -2, -15, -19, -19, -3 }, { -18, -5, -10, 14, -17 }, { -1, 2, -10, 0, 11 }, { 6, -18, 0, 19, 16 } };
    private void buttonDone_Click(object sender, EventArgs e)
    {
        int[,] mtrx = ds.Calculate(x);
        int rows = mtrx.GetUpperBound(0) + 1;
        int cols=mtrx.Length/rows;

        dataGridViewMatrix.RowCount = rows;
        dataGridViewMatrix.ColumnCount = cols;
        for (int i = 0; i < cols; i++)
        {
            dataGridViewMatrix.Columns[i].Width = 25;
        }
        for (int i = 0;i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i,j]);
            }
        }
    }

    private void buttonHelp_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Таск 0 выполнил  студент группы АСОиУБ-24-1 Комарова Маргарита Васильевна", "Сообщение", MessageBoxButtons.OK);
    }
}
