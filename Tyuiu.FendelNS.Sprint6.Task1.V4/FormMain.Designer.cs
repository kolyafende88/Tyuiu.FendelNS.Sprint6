using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tyuiu.FendelNS.Sprint6.Task1.V4
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
            groupBoxRes_FNS = new GroupBox();
            textBoxRes_FNS = new TextBox();
            labelRes_FNS = new Label();
            groupBoxQuest_FNS = new GroupBox();
            labelText_FNS = new Label();
            groupBoxInput_FNS = new GroupBox();
            textBoxStop_FNS = new TextBox();
            textBoxStart_FNS = new TextBox();
            labelEnd_FNS = new Label();
            labelStart_FNS = new Label();
            buttonDone_FNS = new Button();
            buttonHeLP_FNS = new Button();
            groupBoxRes_FNS.SuspendLayout();
            groupBoxQuest_FNS.SuspendLayout();
            groupBoxInput_FNS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxRes_FNS
            // 
            groupBoxRes_FNS.Controls.Add(textBoxRes_FNS);
            groupBoxRes_FNS.Controls.Add(labelRes_FNS);
            groupBoxRes_FNS.Location = new Point(444, 9);
            groupBoxRes_FNS.Margin = new Padding(3, 2, 3, 2);
            groupBoxRes_FNS.Name = "groupBoxRes_FNS";
            groupBoxRes_FNS.Padding = new Padding(3, 2, 3, 2);
            groupBoxRes_FNS.Size = new Size(246, 320);
            groupBoxRes_FNS.TabIndex = 0;
            groupBoxRes_FNS.TabStop = false;
            groupBoxRes_FNS.Text = "Вывод данных";
            // 
            // textBoxRes_FNS
            // 
            textBoxRes_FNS.Font = new System.Drawing.Font("Consolas", 9F);
            textBoxRes_FNS.Location = new Point(5, 41);
            textBoxRes_FNS.Margin = new Padding(3, 2, 3, 2);
            textBoxRes_FNS.Multiline = true;
            textBoxRes_FNS.Name = "textBoxRes_FNS";
            textBoxRes_FNS.ReadOnly = true;
            textBoxRes_FNS.ScrollBars = ScrollBars.Vertical;
            textBoxRes_FNS.Size = new Size(236, 264);
            textBoxRes_FNS.TabIndex = 1;
            textBoxRes_FNS.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // labelRes_FNS
            // 
            labelRes_FNS.AutoSize = true;
            labelRes_FNS.Location = new Point(5, 17);
            labelRes_FNS.Name = "labelRes_FNS";
            labelRes_FNS.Size = new Size(60, 15);
            labelRes_FNS.TabIndex = 0;
            labelRes_FNS.Text = "Результат";
            // 
            // groupBoxQuest_FNS
            // 
            groupBoxQuest_FNS.Controls.Add(labelText_FNS);
            groupBoxQuest_FNS.Location = new Point(10, 9);
            groupBoxQuest_FNS.Margin = new Padding(3, 2, 3, 2);
            groupBoxQuest_FNS.Name = "groupBoxQuest_FNS";
            groupBoxQuest_FNS.Padding = new Padding(3, 2, 3, 2);
            groupBoxQuest_FNS.Size = new Size(386, 229);
            groupBoxQuest_FNS.TabIndex = 1;
            groupBoxQuest_FNS.TabStop = false;
            groupBoxQuest_FNS.Text = "Условие";
            // 
            // labelText_FNS
            // 
            labelText_FNS.AutoSize = true;
            labelText_FNS.Location = new Point(5, 17);
            labelText_FNS.Name = "labelText_FNS";
            labelText_FNS.Size = new Size(327, 30);
            labelText_FNS.TabIndex = 0;
            labelText_FNS.Text = "Протабулировать фуекцию sin(x) на заданном диапозоне.\r\nВвыести результат в виде таблицы";
            // 
            // groupBoxInput_FNS
            // 
            groupBoxInput_FNS.Controls.Add(textBoxStop_FNS);
            groupBoxInput_FNS.Controls.Add(textBoxStart_FNS);
            groupBoxInput_FNS.Controls.Add(labelEnd_FNS);
            groupBoxInput_FNS.Controls.Add(labelStart_FNS);
            groupBoxInput_FNS.Location = new Point(10, 235);
            groupBoxInput_FNS.Margin = new Padding(3, 2, 3, 2);
            groupBoxInput_FNS.Name = "groupBoxInput_FNS";
            groupBoxInput_FNS.Padding = new Padding(3, 2, 3, 2);
            groupBoxInput_FNS.Size = new Size(201, 94);
            groupBoxInput_FNS.TabIndex = 2;
            groupBoxInput_FNS.TabStop = false;
            groupBoxInput_FNS.Text = "Ввод данных";
            // 
            // textBoxStop_FNS
            // 
            textBoxStop_FNS.Location = new Point(101, 50);
            textBoxStop_FNS.Margin = new Padding(3, 2, 3, 2);
            textBoxStop_FNS.Name = "textBoxStop_FNS";
            textBoxStop_FNS.Size = new Size(80, 23);
            textBoxStop_FNS.TabIndex = 3;
            // 
            // textBoxStart_FNS
            // 
            textBoxStart_FNS.Location = new Point(5, 50);
            textBoxStart_FNS.Margin = new Padding(3, 2, 3, 2);
            textBoxStart_FNS.Name = "textBoxStart_FNS";
            textBoxStart_FNS.Size = new Size(75, 23);
            textBoxStart_FNS.TabIndex = 2;
            // 
            // labelEnd_FNS
            // 
            labelEnd_FNS.AutoSize = true;
            labelEnd_FNS.Location = new Point(101, 25);
            labelEnd_FNS.Name = "labelEnd_FNS";
            labelEnd_FNS.Size = new Size(72, 15);
            labelEnd_FNS.TabIndex = 1;
            labelEnd_FNS.Text = "Конец шага";
            // 
            // labelStart_FNS
            // 
            labelStart_FNS.AutoSize = true;
            labelStart_FNS.Location = new Point(5, 25);
            labelStart_FNS.Name = "labelStart_FNS";
            labelStart_FNS.Size = new Size(69, 15);
            labelStart_FNS.TabIndex = 0;
            labelStart_FNS.Text = "Старт шага";
            // 
            // buttonDone_FNS
            // 
            buttonDone_FNS.BackColor = Color.Lime;
            buttonDone_FNS.ForeColor = SystemColors.ActiveCaptionText;
            buttonDone_FNS.Location = new Point(332, 272);
            buttonDone_FNS.Margin = new Padding(3, 2, 3, 2);
            buttonDone_FNS.Name = "buttonDone_FNS";
            buttonDone_FNS.Size = new Size(110, 56);
            buttonDone_FNS.TabIndex = 3;
            buttonDone_FNS.Text = "Выполнить";
            buttonDone_FNS.UseVisualStyleBackColor = false;
            buttonDone_FNS.Click += button1_Click;
            // 
            // buttonHeLP_FNS
            // 
            buttonHeLP_FNS.BackColor = Color.DodgerBlue;
            buttonHeLP_FNS.Location = new Point(217, 272);
            buttonHeLP_FNS.Margin = new Padding(3, 2, 3, 2);
            buttonHeLP_FNS.Name = "buttonHeLP_FNS";
            buttonHeLP_FNS.Size = new Size(110, 56);
            buttonHeLP_FNS.TabIndex = 4;
            buttonHeLP_FNS.Text = "Справка";
            buttonHeLP_FNS.UseVisualStyleBackColor = false;
            buttonHeLP_FNS.Click += buttonHeLP_AAR_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(buttonHeLP_FNS);
            Controls.Add(buttonDone_FNS);
            Controls.Add(groupBoxInput_FNS);
            Controls.Add(groupBoxQuest_FNS);
            Controls.Add(groupBoxRes_FNS);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6|Таск1|Вариант 4|Фендель Н.С.";
            groupBoxRes_FNS.ResumeLayout(false);
            groupBoxRes_FNS.PerformLayout();
            groupBoxQuest_FNS.ResumeLayout(false);
            groupBoxQuest_FNS.PerformLayout();
            groupBoxInput_FNS.ResumeLayout(false);
            groupBoxInput_FNS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxRes_FNS;
        private Label labelText_FNS;
        private GroupBox groupBoxQuest_FNS;
        private GroupBox groupBoxInput_FNS;
        private Label labelEnd_FNS;
        private Label labelStart_FNS;
        private TextBox textBoxStart_FNS;
        private TextBox textBoxRes_FNS;
        private Label labelRes_FNS;
        private TextBox textBoxStop_FNS;
        private Button buttonDone_FNS;
        private Button buttonHeLP_FNS;
    }
}