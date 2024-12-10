namespace Tyuiu.KomarovaMV.Sprint6.Task6.V24
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTask = new Panel();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            buttonHelp = new Button();
            buttonDone = new Button();
            buttonOpen = new Button();
            panelIn = new Panel();
            groupBoxIn = new GroupBox();
            textBoxIn = new TextBox();
            panelOut = new Panel();
            splitter1 = new Splitter();
            groupBoxOut = new GroupBox();
            textBoxOut = new TextBox();
            openFileDialogTask = new OpenFileDialog();
            toolTipTask = new ToolTip(components);
            panelTask.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panelIn.SuspendLayout();
            groupBoxIn.SuspendLayout();
            panelOut.SuspendLayout();
            groupBoxOut.SuspendLayout();
            SuspendLayout();
            // 
            // panelTask
            // 
            panelTask.Controls.Add(groupBoxTask);
            panelTask.Controls.Add(buttonHelp);
            panelTask.Controls.Add(buttonDone);
            panelTask.Controls.Add(buttonOpen);
            panelTask.Dock = DockStyle.Top;
            panelTask.Location = new Point(0, 0);
            panelTask.Name = "panelTask";
            panelTask.Size = new Size(976, 170);
            panelTask.TabIndex = 0;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(12, 83);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(952, 81);
            groupBoxTask.TabIndex = 3;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Задание:";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(6, 16);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(940, 59);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(876, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(88, 65);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "?";
            toolTipTask.SetToolTip(buttonHelp, "Сведения о программе");
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.Enabled = false;
            buttonDone.Location = new Point(149, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(87, 65);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            toolTipTask.SetToolTip(buttonDone, "Выполнить");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(12, 12);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(94, 65);
            buttonOpen.TabIndex = 0;
            buttonOpen.Text = "Загрузить файл";
            toolTipTask.SetToolTip(buttonOpen, "Открыть файл\r\nВыберете файл\r\n");
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // panelIn
            // 
            panelIn.Controls.Add(groupBoxIn);
            panelIn.Dock = DockStyle.Left;
            panelIn.Location = new Point(0, 170);
            panelIn.Name = "panelIn";
            panelIn.Size = new Size(200, 390);
            panelIn.TabIndex = 1;
            // 
            // groupBoxIn
            // 
            groupBoxIn.Controls.Add(textBoxIn);
            groupBoxIn.Dock = DockStyle.Fill;
            groupBoxIn.Location = new Point(0, 0);
            groupBoxIn.Name = "groupBoxIn";
            groupBoxIn.Size = new Size(200, 390);
            groupBoxIn.TabIndex = 0;
            groupBoxIn.TabStop = false;
            groupBoxIn.Text = "Ввод:";
            // 
            // textBoxIn
            // 
            textBoxIn.Dock = DockStyle.Fill;
            textBoxIn.Location = new Point(3, 19);
            textBoxIn.Multiline = true;
            textBoxIn.Name = "textBoxIn";
            textBoxIn.Size = new Size(194, 368);
            textBoxIn.TabIndex = 0;
            // 
            // panelOut
            // 
            panelOut.Controls.Add(splitter1);
            panelOut.Controls.Add(groupBoxOut);
            panelOut.Dock = DockStyle.Fill;
            panelOut.Location = new Point(200, 170);
            panelOut.Name = "panelOut";
            panelOut.Size = new Size(776, 390);
            panelOut.TabIndex = 2;
            panelOut.Paint += panelOut_Paint;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 390);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // groupBoxOut
            // 
            groupBoxOut.Controls.Add(textBoxOut);
            groupBoxOut.Dock = DockStyle.Fill;
            groupBoxOut.Location = new Point(0, 0);
            groupBoxOut.Name = "groupBoxOut";
            groupBoxOut.Size = new Size(776, 390);
            groupBoxOut.TabIndex = 0;
            groupBoxOut.TabStop = false;
            groupBoxOut.Text = "Вывод:";
            // 
            // textBoxOut
            // 
            textBoxOut.Dock = DockStyle.Fill;
            textBoxOut.Location = new Point(3, 19);
            textBoxOut.Multiline = true;
            textBoxOut.Name = "textBoxOut";
            textBoxOut.Size = new Size(770, 368);
            textBoxOut.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // toolTipTask
            // 
            toolTipTask.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 560);
            Controls.Add(panelOut);
            Controls.Add(panelIn);
            Controls.Add(panelTask);
            Name = "FormMain";
            Text = "FormMain";
            panelTask.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panelIn.ResumeLayout(false);
            groupBoxIn.ResumeLayout(false);
            groupBoxIn.PerformLayout();
            panelOut.ResumeLayout(false);
            groupBoxOut.ResumeLayout(false);
            groupBoxOut.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTask;
        private Panel panelIn;
        private Panel panelOut;
        private Button buttonHelp;
        private Button buttonDone;
        private Button buttonOpen;
        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private TextBox textBoxIn;
        private TextBox textBoxOut;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTipTask;
        private GroupBox groupBoxIn;
        private Splitter splitter1;
        private GroupBox groupBoxOut;
    }
}
