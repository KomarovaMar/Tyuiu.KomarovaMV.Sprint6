namespace Tyuiu.KomarovaMV.Sprint6.Task2.V3
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
            groupBoxTask = new GroupBox();
            labelTask = new Label();
            pictureBoxTask = new PictureBox();
            groupBoxWrite = new GroupBox();
            textBoxStop = new TextBox();
            labelStart = new Label();
            labelStop = new Label();
            textBoxStart = new TextBox();
            groupBoxResult = new GroupBox();
            chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView1 = new DataGridView();
            ColumnX = new DataGridViewTextBoxColumn();
            ColumnF = new DataGridViewTextBoxColumn();
            buttonhelp = new Button();
            buttonDone = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask).BeginInit();
            groupBoxWrite.SuspendLayout();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(labelTask);
            groupBoxTask.Controls.Add(pictureBoxTask);
            groupBoxTask.Location = new Point(44, 29);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(411, 279);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Задание:";
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(6, 37);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(382, 15);
            labelTask.TabIndex = 3;
            labelTask.Text = "Написать программу, которая выводит таблицу значений функции:";
            // 
            // pictureBoxTask
            // 
            pictureBoxTask.ImageLocation = "C:\\Users\\PC\\Pictures\\Снимок экрана 2024-12-06 142403.png";
            pictureBoxTask.Location = new Point(44, 76);
            pictureBoxTask.Name = "pictureBoxTask";
            pictureBoxTask.Size = new Size(304, 37);
            pictureBoxTask.TabIndex = 2;
            pictureBoxTask.TabStop = false;
            // 
            // groupBoxWrite
            // 
            groupBoxWrite.Controls.Add(textBoxStop);
            groupBoxWrite.Controls.Add(labelStart);
            groupBoxWrite.Controls.Add(labelStop);
            groupBoxWrite.Controls.Add(textBoxStart);
            groupBoxWrite.Location = new Point(44, 340);
            groupBoxWrite.Name = "groupBoxWrite";
            groupBoxWrite.Size = new Size(348, 98);
            groupBoxWrite.TabIndex = 0;
            groupBoxWrite.TabStop = false;
            groupBoxWrite.Text = "Введите значения:";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(198, 49);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(100, 23);
            textBoxStop.TabIndex = 1;
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(51, 31);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(83, 15);
            labelStart.TabIndex = 3;
            labelStart.Text = "Начало шага:";
            // 
            // labelStop
            // 
            labelStop.AutoSize = true;
            labelStop.Location = new Point(198, 31);
            labelStop.Name = "labelStop";
            labelStop.Size = new Size(75, 15);
            labelStop.TabIndex = 4;
            labelStop.Text = "Конец шага:";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(51, 49);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(100, 23);
            textBoxStart.TabIndex = 0;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(chartResult);
            groupBoxResult.Controls.Add(dataGridView1);
            groupBoxResult.Location = new Point(470, 29);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(573, 305);
            groupBoxResult.TabIndex = 0;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Результат:";
            // 
            // chartResult
            // 
            chartArea1.Name = "ChartArea1";
            chartResult.ChartAreas.Add(chartArea1);
            chartResult.Location = new Point(245, 13);
            chartResult.Name = "chartResult";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            chartResult.Series.Add(series1);
            chartResult.Size = new Size(308, 266);
            chartResult.TabIndex = 1;
            chartResult.Text = "chartResult";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnX, ColumnF });
            dataGridView1.Location = new Point(6, 13);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(205, 286);
            dataGridView1.TabIndex = 0;
            // 
            // ColumnX
            // 
            ColumnX.HeaderText = "X";
            ColumnX.Name = "ColumnX";
            // 
            // ColumnF
            // 
            ColumnF.HeaderText = "F(X)";
            ColumnF.Name = "ColumnF";
            // 
            // buttonhelp
            // 
            buttonhelp.BackColor = SystemColors.GradientActiveCaption;
            buttonhelp.Location = new Point(470, 372);
            buttonhelp.Name = "buttonhelp";
            buttonhelp.Size = new Size(61, 54);
            buttonhelp.TabIndex = 0;
            buttonhelp.Text = "Справка";
            buttonhelp.UseVisualStyleBackColor = false;
            buttonhelp.Click += buttonhelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = SystemColors.HotTrack;
            buttonDone.Location = new Point(570, 372);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(164, 54);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseDown += buttonDone_MouseDown;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            buttonDone.MouseLeave += buttonDone_MouseLeave;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 476);
            Controls.Add(buttonhelp);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxWrite);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxTask);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 3 | Комарова М.В.";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask).EndInit();
            groupBoxWrite.ResumeLayout(false);
            groupBoxWrite.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private GroupBox groupBoxWrite;
        private GroupBox groupBoxResult;
        private Button buttonhelp;
        private Button buttonDone;
        private PictureBox pictureBoxTask;
        private TextBox textBoxStop;
        private Label labelStart;
        private Label labelStop;
        private TextBox textBoxStart;
        private Label labelTask;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnX;
        private DataGridViewTextBoxColumn ColumnF;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
    }
}
