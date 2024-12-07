namespace Tyuiu.KomarovaMV.Sprint6.Task4.V4
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
            labelStop = new Label();
            labelStart = new Label();
            textBoxStop = new TextBox();
            textBoxStart = new TextBox();
            buttonDone = new Button();
            buttonHelp = new Button();
            buttonSave = new Button();
            panelResult = new Panel();
            textBoxResult = new TextBox();
            panelChart = new Panel();
            chartTask = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panelTask.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panelResult.SuspendLayout();
            panelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartTask).BeginInit();
            SuspendLayout();
            // 
            // panelTask
            // 
            panelTask.Controls.Add(groupBoxTask);
            panelTask.Controls.Add(labelStop);
            panelTask.Controls.Add(labelStart);
            panelTask.Controls.Add(textBoxStop);
            panelTask.Controls.Add(textBoxStart);
            panelTask.Controls.Add(buttonDone);
            panelTask.Controls.Add(buttonHelp);
            panelTask.Controls.Add(buttonSave);
            panelTask.Dock = DockStyle.Top;
            panelTask.Location = new Point(0, 0);
            panelTask.Name = "panelTask";
            panelTask.Size = new Size(784, 100);
            panelTask.TabIndex = 0;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(0, 0);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(325, 100);
            groupBoxTask.TabIndex = 7;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие:";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(3, 22);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(316, 72);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Произвести табулирование f(x) на заданном диапазоне [-5; 5]";
            // 
            // labelStop
            // 
            labelStop.AutoSize = true;
            labelStop.Location = new Point(417, 23);
            labelStop.Name = "labelStop";
            labelStop.Size = new Size(72, 15);
            labelStop.TabIndex = 6;
            labelStop.Text = "Конец шага";
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(331, 23);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(80, 15);
            labelStart.TabIndex = 5;
            labelStart.Text = "Начало шага";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(417, 41);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(89, 23);
            textBoxStop.TabIndex = 4;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(331, 41);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(80, 23);
            textBoxStart.TabIndex = 3;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(684, 26);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(88, 51);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(514, 26);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(63, 51);
            buttonHelp.TabIndex = 0;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(593, 26);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(74, 51);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // panelResult
            // 
            panelResult.Controls.Add(textBoxResult);
            panelResult.Dock = DockStyle.Left;
            panelResult.Location = new Point(0, 100);
            panelResult.Name = "panelResult";
            panelResult.Size = new Size(270, 311);
            panelResult.TabIndex = 0;
            // 
            // textBoxResult
            // 
            textBoxResult.Dock = DockStyle.Fill;
            textBoxResult.Location = new Point(0, 0);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Horizontal;
            textBoxResult.Size = new Size(270, 311);
            textBoxResult.TabIndex = 0;
            // 
            // panelChart
            // 
            panelChart.BackColor = SystemColors.ButtonHighlight;
            panelChart.Controls.Add(chartTask);
            panelChart.Dock = DockStyle.Fill;
            panelChart.Location = new Point(0, 100);
            panelChart.Name = "panelChart";
            panelChart.Size = new Size(784, 311);
            panelChart.TabIndex = 0;
            // 
            // chartTask
            // 
            chartArea1.Name = "ChartArea1";
            chartTask.ChartAreas.Add(chartArea1);
            chartTask.Dock = DockStyle.Right;
            chartTask.Location = new Point(286, 0);
            chartTask.Name = "chartTask";
            chartTask.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            chartTask.Series.Add(series1);
            chartTask.Size = new Size(498, 311);
            chartTask.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(270, 100);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(10, 311);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(splitter1);
            Controls.Add(panelResult);
            Controls.Add(panelChart);
            Controls.Add(panelTask);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "+";
            panelTask.ResumeLayout(false);
            panelTask.PerformLayout();
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panelResult.ResumeLayout(false);
            panelResult.PerformLayout();
            panelChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartTask).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTask;
        private Panel panelResult;
        private Panel panelChart;
        private Label labelStop;
        private Label labelStart;
        private TextBox textBoxStop;
        private TextBox textBoxStart;
        private Button buttonDone;
        private Button buttonHelp;
        private Button buttonSave;
        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private TextBox textBoxResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTask;
        private Splitter splitter1;
    }
}
