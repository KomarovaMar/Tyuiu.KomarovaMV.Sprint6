namespace Tyuiu.KomarovaMV.Sprint6.Task5.V23
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelTask = new Panel();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            buttonHelp = new Button();
            buttonOpen = new Button();
            buttonDone = new Button();
            panelResult = new Panel();
            dataGridViewResult = new DataGridView();
            panelChart = new Panel();
            chartTask = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panelTask.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panelResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            panelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartTask).BeginInit();
            SuspendLayout();
            // 
            // panelTask
            // 
            panelTask.Controls.Add(groupBoxTask);
            panelTask.Controls.Add(buttonHelp);
            panelTask.Controls.Add(buttonOpen);
            panelTask.Controls.Add(buttonDone);
            panelTask.Dock = DockStyle.Top;
            panelTask.Location = new Point(0, 0);
            panelTask.Name = "panelTask";
            panelTask.Size = new Size(1033, 100);
            panelTask.TabIndex = 0;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(0, 0);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(678, 100);
            groupBoxTask.TabIndex = 5;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Задание:";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(3, 19);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(669, 75);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Прочитать данные из файла InPutFileTask5V23.txt. Вывести в dataGridView. Дан список из чисел. Вывести все числа, меньше 0. Построить диаграмму по этим значениям.";
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(684, 26);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(64, 51);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(765, 26);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(101, 51);
            buttonOpen.TabIndex = 3;
            buttonOpen.Text = "Открыть файл";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(881, 26);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(107, 51);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // panelResult
            // 
            panelResult.Controls.Add(dataGridViewResult);
            panelResult.Dock = DockStyle.Left;
            panelResult.Location = new Point(0, 100);
            panelResult.Name = "panelResult";
            panelResult.Size = new Size(200, 382);
            panelResult.TabIndex = 0;
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.ColumnHeadersVisible = false;
            dataGridViewResult.Dock = DockStyle.Fill;
            dataGridViewResult.Location = new Point(0, 0);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.ReadOnly = true;
            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.Size = new Size(200, 382);
            dataGridViewResult.TabIndex = 0;
            // 
            // panelChart
            // 
            panelChart.Controls.Add(chartTask);
            panelChart.Dock = DockStyle.Fill;
            panelChart.Location = new Point(0, 100);
            panelChart.Name = "panelChart";
            panelChart.Size = new Size(1033, 382);
            panelChart.TabIndex = 0;
            // 
            // chartTask
            // 
            chartArea1.Name = "ChartArea1";
            chartTask.ChartAreas.Add(chartArea1);
            chartTask.Dock = DockStyle.Right;
            chartTask.Location = new Point(0, 0);
            chartTask.Name = "chartTask";
            chartTask.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            chartTask.Series.Add(series1);
            chartTask.Size = new Size(1033, 382);
            chartTask.TabIndex = 0;
            chartTask.Text = "chart1";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(200, 100);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(11, 382);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 482);
            Controls.Add(splitter1);
            Controls.Add(panelResult);
            Controls.Add(panelChart);
            Controls.Add(panelTask);
            Name = "FormMain";
            Text = "Form1";
            panelTask.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panelResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            panelChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartTask).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTask;
        private Panel panelResult;
        private Panel panelChart;
        private Splitter splitter1;
        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private Button buttonHelp;
        private Button buttonOpen;
        private Button buttonDone;
        private DataGridView dataGridViewResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTask;
    }
}
