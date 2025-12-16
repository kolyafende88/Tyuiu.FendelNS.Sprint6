namespace Tyuiu.FendelNS.Sprint6.Task2.V15
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
            dataGridViewResult_PDA = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            fx = new DataGridViewTextBoxColumn();
            buttonDown_FNS = new Button();
            buttonQuestion_FNS = new Button();
            textBoxSV_FNS = new TextBox();
            textBoxStV_FNS = new TextBox();
            textBoxStartValue_FNS = new TextBox();
            textBoxStopValue_FNS = new TextBox();
            textBoxCondition_FNS = new TextBox();
            textBoxCond_FNS = new TextBox();
            textBoxRes_FNS = new TextBox();
            textBoxInPut_FNS = new TextBox();
            textBoxOutPut_FNS = new TextBox();
            pictureBoxFormula_FNS = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_PDA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_FNS).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewResult_PDA
            // 
            dataGridViewResult_PDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_PDA.Columns.AddRange(new DataGridViewColumn[] { X, fx });
            dataGridViewResult_PDA.Location = new Point(535, 28);
            dataGridViewResult_PDA.Margin = new Padding(3, 2, 3, 2);
            dataGridViewResult_PDA.Name = "dataGridViewResult_PDA";
            dataGridViewResult_PDA.ReadOnly = true;
            dataGridViewResult_PDA.RowHeadersVisible = false;
            dataGridViewResult_PDA.RowHeadersWidth = 51;
            dataGridViewResult_PDA.Size = new Size(155, 301);
            dataGridViewResult_PDA.TabIndex = 0;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 50;
            // 
            // fx
            // 
            fx.HeaderText = "f(x)";
            fx.MinimumWidth = 6;
            fx.Name = "fx";
            fx.ReadOnly = true;
            fx.Width = 125;
            // 
            // buttonDown_FNS
            // 
            buttonDown_FNS.BackColor = SystemColors.Info;
            buttonDown_FNS.Location = new Point(357, 250);
            buttonDown_FNS.Margin = new Padding(3, 2, 3, 2);
            buttonDown_FNS.Name = "buttonDown_FNS";
            buttonDown_FNS.Size = new Size(172, 79);
            buttonDown_FNS.TabIndex = 1;
            buttonDown_FNS.Text = "Вычислить";
            buttonDown_FNS.UseVisualStyleBackColor = false;
            buttonDown_FNS.Click += buttonDown_PDA_Click;
            // 
            // buttonQuestion_FNS
            // 
            buttonQuestion_FNS.BackColor = SystemColors.ActiveCaption;
            buttonQuestion_FNS.Location = new Point(279, 276);
            buttonQuestion_FNS.Margin = new Padding(3, 2, 3, 2);
            buttonQuestion_FNS.Name = "buttonQuestion_FNS";
            buttonQuestion_FNS.Size = new Size(73, 52);
            buttonQuestion_FNS.TabIndex = 2;
            buttonQuestion_FNS.Text = "Справка";
            buttonQuestion_FNS.UseVisualStyleBackColor = false;
            buttonQuestion_FNS.Click += buttonQuestion_PDA_Click;
            // 
            // textBoxSV_FNS
            // 
            textBoxSV_FNS.BackColor = SystemColors.Control;
            textBoxSV_FNS.BorderStyle = BorderStyle.None;
            textBoxSV_FNS.Location = new Point(10, 279);
            textBoxSV_FNS.Margin = new Padding(3, 2, 3, 2);
            textBoxSV_FNS.Name = "textBoxSV_FNS";
            textBoxSV_FNS.ReadOnly = true;
            textBoxSV_FNS.Size = new Size(109, 16);
            textBoxSV_FNS.TabIndex = 3;
            textBoxSV_FNS.Text = "Начало шага:";
            // 
            // textBoxStV_FNS
            // 
            textBoxStV_FNS.BackColor = SystemColors.Control;
            textBoxStV_FNS.BorderStyle = BorderStyle.None;
            textBoxStV_FNS.Location = new Point(139, 279);
            textBoxStV_FNS.Margin = new Padding(3, 2, 3, 2);
            textBoxStV_FNS.Name = "textBoxStV_FNS";
            textBoxStV_FNS.ReadOnly = true;
            textBoxStV_FNS.Size = new Size(109, 16);
            textBoxStV_FNS.TabIndex = 4;
            textBoxStV_FNS.Text = "Конец шага:";
            // 
            // textBoxStartValue_FNS
            // 
            textBoxStartValue_FNS.Location = new Point(10, 308);
            textBoxStartValue_FNS.Margin = new Padding(3, 2, 3, 2);
            textBoxStartValue_FNS.Name = "textBoxStartValue_FNS";
            textBoxStartValue_FNS.Size = new Size(110, 23);
            textBoxStartValue_FNS.TabIndex = 5;
            // 
            // textBoxStopValue_FNS
            // 
            textBoxStopValue_FNS.Location = new Point(139, 308);
            textBoxStopValue_FNS.Margin = new Padding(3, 2, 3, 2);
            textBoxStopValue_FNS.Name = "textBoxStopValue_FNS";
            textBoxStopValue_FNS.Size = new Size(110, 23);
            textBoxStopValue_FNS.TabIndex = 6;
            // 
            // textBoxCondition_FNS
            // 
            textBoxCondition_FNS.BackColor = SystemColors.Control;
            textBoxCondition_FNS.BorderStyle = BorderStyle.None;
            textBoxCondition_FNS.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxCondition_FNS.Location = new Point(10, 28);
            textBoxCondition_FNS.Margin = new Padding(3, 2, 3, 2);
            textBoxCondition_FNS.Multiline = true;
            textBoxCondition_FNS.Name = "textBoxCondition_FNS";
            textBoxCondition_FNS.ReadOnly = true;
            textBoxCondition_FNS.Size = new Size(354, 194);
            textBoxCondition_FNS.TabIndex = 7;
            textBoxCondition_FNS.Text = "Написать программу, которая выводит таблицу значений функции на заданном диапазоне:";
            // 
            // textBoxCond_FNS
            // 
            textBoxCond_FNS.BackColor = SystemColors.Control;
            textBoxCond_FNS.BorderStyle = BorderStyle.None;
            textBoxCond_FNS.Location = new Point(10, 8);
            textBoxCond_FNS.Margin = new Padding(3, 2, 3, 2);
            textBoxCond_FNS.Name = "textBoxCond_FNS";
            textBoxCond_FNS.ReadOnly = true;
            textBoxCond_FNS.Size = new Size(160, 16);
            textBoxCond_FNS.TabIndex = 8;
            textBoxCond_FNS.Text = "Условие";
            // 
            // textBoxRes_FNS
            // 
            textBoxRes_FNS.BackColor = SystemColors.Control;
            textBoxRes_FNS.BorderStyle = BorderStyle.None;
            textBoxRes_FNS.Location = new Point(535, 5);
            textBoxRes_FNS.Margin = new Padding(3, 2, 3, 2);
            textBoxRes_FNS.Name = "textBoxRes_FNS";
            textBoxRes_FNS.ReadOnly = true;
            textBoxRes_FNS.Size = new Size(155, 16);
            textBoxRes_FNS.TabIndex = 9;
            textBoxRes_FNS.Text = "Результат";
            // 
            // textBoxInPut_FNS
            // 
            textBoxInPut_FNS.BackColor = SystemColors.Control;
            textBoxInPut_FNS.BorderStyle = BorderStyle.None;
            textBoxInPut_FNS.Location = new Point(10, 233);
            textBoxInPut_FNS.Margin = new Padding(3, 2, 3, 2);
            textBoxInPut_FNS.Name = "textBoxInPut_FNS";
            textBoxInPut_FNS.ReadOnly = true;
            textBoxInPut_FNS.Size = new Size(109, 16);
            textBoxInPut_FNS.TabIndex = 10;
            textBoxInPut_FNS.Text = "Ввод данных:";
            // 
            // textBoxOutPut_FNS
            // 
            textBoxOutPut_FNS.BackColor = SystemColors.Control;
            textBoxOutPut_FNS.BorderStyle = BorderStyle.None;
            textBoxOutPut_FNS.Location = new Point(420, 5);
            textBoxOutPut_FNS.Margin = new Padding(3, 2, 3, 2);
            textBoxOutPut_FNS.Name = "textBoxOutPut_FNS";
            textBoxOutPut_FNS.ReadOnly = true;
            textBoxOutPut_FNS.Size = new Size(109, 16);
            textBoxOutPut_FNS.TabIndex = 11;
            textBoxOutPut_FNS.Text = "Вывод данных:";
            // 
            // pictureBoxFormula_FNS
            // 
            pictureBoxFormula_FNS.Image = Properties.Resources.photo_2025_12_17_02_41_11;
            pictureBoxFormula_FNS.Location = new Point(10, 87);
            pictureBoxFormula_FNS.Margin = new Padding(3, 2, 3, 2);
            pictureBoxFormula_FNS.Name = "pictureBoxFormula_FNS";
            pictureBoxFormula_FNS.Size = new Size(313, 35);
            pictureBoxFormula_FNS.TabIndex = 12;
            pictureBoxFormula_FNS.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(pictureBoxFormula_FNS);
            Controls.Add(textBoxOutPut_FNS);
            Controls.Add(textBoxInPut_FNS);
            Controls.Add(textBoxRes_FNS);
            Controls.Add(textBoxCond_FNS);
            Controls.Add(textBoxCondition_FNS);
            Controls.Add(textBoxStopValue_FNS);
            Controls.Add(textBoxStartValue_FNS);
            Controls.Add(textBoxStV_FNS);
            Controls.Add(textBoxSV_FNS);
            Controls.Add(buttonQuestion_FNS);
            Controls.Add(buttonDown_FNS);
            Controls.Add(dataGridViewResult_PDA);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 15 | Фендель Н. С.";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_PDA).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_FNS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewResult_PDA;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn fx;
        private Button buttonDown_FNS;
        private Button buttonQuestion_FNS;
        private TextBox textBoxSV_FNS;
        private TextBox textBoxStV_FNS;
        private TextBox textBoxStartValue_FNS;
        private TextBox textBoxStopValue_FNS;
        private TextBox textBoxCondition_FNS;
        private TextBox textBoxCond_FNS;
        private TextBox textBoxRes_FNS;
        private TextBox textBoxInPut_FNS;
        private TextBox textBoxOutPut_FNS;
        private PictureBox pictureBoxFormula_FNS;
    }
} 