namespace Tyuiu.KomarovaMV.Sprint6.Task6.V24
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonOK = new Button();
            textBoxHelp = new TextBox();
            SuspendLayout();
            // 
            // buttonOK
            // 
            buttonOK.BackColor = SystemColors.Info;
            buttonOK.Location = new Point(449, 197);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(55, 29);
            buttonOK.TabIndex = 0;
            buttonOK.Text = "Yes";
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.Click += buttonOK_Click;
            // 
            // textBoxHelp
            // 
            textBoxHelp.Location = new Point(12, 12);
            textBoxHelp.Multiline = true;
            textBoxHelp.Name = "textBoxHelp";
            textBoxHelp.ReadOnly = true;
            textBoxHelp.Size = new Size(488, 179);
            textBoxHelp.TabIndex = 1;
            textBoxHelp.Text = "Таск 0 выполнил  студент группы АСОиУБ-24-1 Комарова Маргарита Васильевна";
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 238);
            Controls.Add(textBoxHelp);
            Controls.Add(buttonOK);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAbout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOK;
        private TextBox textBoxHelp;
    }
}