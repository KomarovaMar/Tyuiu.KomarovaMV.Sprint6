namespace Tyuiu.KomarovaMV.Sprint6.Task0.V16
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
            GroupBox groupBoxResult;
            labelResult = new Label();
            textBoxResult = new TextBox();
            ButtonDone = new Button();
            ButtonHelp = new Button();
            pictureBoxCondition = new PictureBox();
            groupBoxCondition = new GroupBox();
            labelCondition = new Label();
            groupBoxWrite = new GroupBox();
            labelWrite = new Label();
            textBoxWrite = new TextBox();
            groupBoxResult = new GroupBox();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition).BeginInit();
            groupBoxCondition.SuspendLayout();
            groupBoxWrite.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(labelResult);
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(687, 336);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(239, 116);
            groupBoxResult.TabIndex = 0;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных:";
            groupBoxResult.Enter += groupBox2_Enter;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(61, 32);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(63, 15);
            labelResult.TabIndex = 1;
            labelResult.Text = "Результат:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(61, 50);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(100, 23);
            textBoxResult.TabIndex = 0;
            textBoxResult.Tag = "";
            textBoxResult.TextChanged += textBox1_TextChanged;
            // 
            // ButtonDone
            // 
            ButtonDone.Location = new Point(807, 498);
            ButtonDone.Name = "ButtonDone";
            ButtonDone.Size = new Size(103, 48);
            ButtonDone.TabIndex = 0;
            ButtonDone.Text = "Выполнить";
            ButtonDone.UseVisualStyleBackColor = true;
            ButtonDone.Click += ButtonDone_Click;
            // 
            // ButtonHelp
            // 
            ButtonHelp.Location = new Point(726, 498);
            ButtonHelp.Name = "ButtonHelp";
            ButtonHelp.Size = new Size(52, 48);
            ButtonHelp.TabIndex = 1;
            ButtonHelp.Text = "?";
            ButtonHelp.UseVisualStyleBackColor = true;
            ButtonHelp.Click += ButtonHelp_Click;
            // 
            // pictureBoxCondition
            // 
            pictureBoxCondition.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxCondition.ImageLocation = "C:\\Users\\PC\\source\\repos\\Tyuiu.KomarovaMV.Sprint6\\Tyuiu.KomarovaMV.Sprint6.Task0.V16\\Untitled.png";
            pictureBoxCondition.Location = new Point(730, 110);
            pictureBoxCondition.Name = "pictureBoxCondition";
            pictureBoxCondition.Size = new Size(106, 55);
            pictureBoxCondition.TabIndex = 2;
            pictureBoxCondition.TabStop = false;
            pictureBoxCondition.Click += pictureBox1_Click;
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(labelCondition);
            groupBoxCondition.Controls.Add(pictureBoxCondition);
            groupBoxCondition.Location = new Point(44, 56);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(882, 263);
            groupBoxCondition.TabIndex = 3;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Location = new Point(6, 33);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(684, 30);
            labelCondition.TabIndex = 7;
            labelCondition.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. Округлить до трёх знаков после запятой.\r\n\r\n";
            labelCondition.Click += labelCondition_Click;
            // 
            // groupBoxWrite
            // 
            groupBoxWrite.Controls.Add(labelWrite);
            groupBoxWrite.Controls.Add(textBoxWrite);
            groupBoxWrite.Location = new Point(44, 336);
            groupBoxWrite.Name = "groupBoxWrite";
            groupBoxWrite.Size = new Size(601, 116);
            groupBoxWrite.TabIndex = 0;
            groupBoxWrite.TabStop = false;
            groupBoxWrite.Text = "Ввод данных:";
            // 
            // labelWrite
            // 
            labelWrite.AutoSize = true;
            labelWrite.Location = new Point(177, 53);
            labelWrite.Name = "labelWrite";
            labelWrite.Size = new Size(88, 15);
            labelWrite.TabIndex = 4;
            labelWrite.Text = "Переменная х:";
            // 
            // textBoxWrite
            // 
            textBoxWrite.Location = new Point(271, 50);
            textBoxWrite.Name = "textBoxWrite";
            textBoxWrite.Size = new Size(100, 23);
            textBoxWrite.TabIndex = 3;
            textBoxWrite.TextChanged += textBoxWrite_TextChanged;
            textBoxWrite.KeyPress += textBoxWrite_KeyPress;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 558);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxWrite);
            Controls.Add(groupBoxCondition);
            Controls.Add(ButtonHelp);
            Controls.Add(ButtonDone);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 16 | Комарова М.В.";
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition).EndInit();
            groupBoxCondition.ResumeLayout(false);
            groupBoxCondition.PerformLayout();
            groupBoxWrite.ResumeLayout(false);
            groupBoxWrite.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonDone;
        private Button ButtonHelp;
        private PictureBox pictureBoxCondition;
        private GroupBox groupBoxCondition;
        private GroupBox groupBoxResult;
        private GroupBox groupBoxWrite;
        private TextBox textBoxResult;
        private TextBox textBoxWrite;
        private Label labelCondition;
        private Label labelResult;
        private Label labelWrite;
    }
}
