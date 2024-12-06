namespace Tyuiu.KomarovaMV.Sprint6.Task1.V9
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
            ButtonHelp = new Button();
            ButtonDone = new Button();
            textBoxStart = new TextBox();
            textBoxStop = new TextBox();
            groupBoxWrite = new GroupBox();
            labelStop = new Label();
            labelStart = new Label();
            groupBoxTask = new GroupBox();
            pictureBoxTask = new PictureBox();
            labelTask = new Label();
            groupBoxResult = new GroupBox();
            textBoxResult = new TextBox();
            groupBoxWrite.SuspendLayout();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask).BeginInit();
            groupBoxResult.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonHelp
            // 
            ButtonHelp.BackColor = SystemColors.Highlight;
            ButtonHelp.Location = new Point(404, 366);
            ButtonHelp.Name = "ButtonHelp";
            ButtonHelp.Size = new Size(67, 61);
            ButtonHelp.TabIndex = 0;
            ButtonHelp.Text = "Справка";
            ButtonHelp.UseVisualStyleBackColor = false;
            ButtonHelp.Click += button1_Click;
            // 
            // ButtonDone
            // 
            ButtonDone.BackColor = SystemColors.Info;
            ButtonDone.Location = new Point(491, 366);
            ButtonDone.Name = "ButtonDone";
            ButtonDone.Size = new Size(119, 61);
            ButtonDone.TabIndex = 1;
            ButtonDone.Text = "Выполнить";
            ButtonDone.UseVisualStyleBackColor = false;
            ButtonDone.Click += ButtonDone_Click;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(51, 44);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(100, 23);
            textBoxStart.TabIndex = 2;
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(209, 44);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(100, 23);
            textBoxStop.TabIndex = 3;
            // 
            // groupBoxWrite
            // 
            groupBoxWrite.Controls.Add(labelStop);
            groupBoxWrite.Controls.Add(labelStart);
            groupBoxWrite.Controls.Add(textBoxStart);
            groupBoxWrite.Controls.Add(textBoxStop);
            groupBoxWrite.Location = new Point(31, 342);
            groupBoxWrite.Name = "groupBoxWrite";
            groupBoxWrite.Size = new Size(367, 95);
            groupBoxWrite.TabIndex = 4;
            groupBoxWrite.TabStop = false;
            groupBoxWrite.Text = "Введите значения:";
            // 
            // labelStop
            // 
            labelStop.AutoSize = true;
            labelStop.Location = new Point(209, 26);
            labelStop.Name = "labelStop";
            labelStop.Size = new Size(75, 15);
            labelStop.TabIndex = 5;
            labelStop.Text = "Конец шага:";
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(51, 26);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(83, 15);
            labelStart.TabIndex = 4;
            labelStart.Text = "Начало шага:";
            labelStart.Click += labelStart_Click;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(pictureBoxTask);
            groupBoxTask.Controls.Add(labelTask);
            groupBoxTask.Location = new Point(31, 33);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(427, 303);
            groupBoxTask.TabIndex = 6;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Задание:";
            // 
            // pictureBoxTask
            // 
            pictureBoxTask.ImageLocation = "C:\\Users\\PC\\Pictures\\Снимок экрана 2024-12-06 124354.png";
            pictureBoxTask.Location = new Point(27, 57);
            pictureBoxTask.Name = "pictureBoxTask";
            pictureBoxTask.Size = new Size(233, 40);
            pictureBoxTask.TabIndex = 1;
            pictureBoxTask.TabStop = false;
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(3, 19);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(286, 15);
            labelTask.TabIndex = 0;
            labelTask.Text = "Протабуировать функцию на заданном диапозоне";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(491, 33);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(286, 303);
            groupBoxResult.TabIndex = 0;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Результат:";
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Consolas", 10F);
            textBoxResult.Location = new Point(6, 22);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(277, 281);
            textBoxResult.TabIndex = 0;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxTask);
            Controls.Add(groupBoxWrite);
            Controls.Add(ButtonDone);
            Controls.Add(ButtonHelp);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 9 | Комарова М.В.";
            Load += MainForm_Load;
            groupBoxWrite.ResumeLayout(false);
            groupBoxWrite.PerformLayout();
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask).EndInit();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonHelp;
        private Button ButtonDone;
        private TextBox textBoxStart;
        private TextBox textBoxStop;
        private GroupBox groupBoxWrite;
        private Label labelStop;
        private Label labelStart;
        private GroupBox groupBoxTask;
        private GroupBox groupBoxResult;
        private TextBox textBoxResult;
        private PictureBox pictureBoxTask;
        private Label labelTask;
    }
}
