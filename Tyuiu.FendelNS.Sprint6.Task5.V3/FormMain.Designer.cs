namespace Tyuiu.FendelNS.Sprint6.Task5.V3
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
            groupBoxCondition_FNS = new GroupBox();
            textBoxTask_FNS = new TextBox();
            groupBoxCondition2_FNS = new GroupBox();
            textBoxStopValue_FNS = new TextBox();
            textBoxCondStopVal_FNS = new TextBox();
            textBoxStartValue_FNS = new TextBox();
            textBoxCondStartVal_FNS = new TextBox();
            buttonDone_FNS = new Button();
            buttonHelp_FNS = new Button();
            buttonSave_FNS = new Button();
            groupBoxRes_FNS = new GroupBox();
            dataGridViewResult_FNS = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            chartFunction_FNS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxCondition_FNS.SuspendLayout();
            groupBoxCondition2_FNS.SuspendLayout();
            groupBoxRes_FNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_FNS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_FNS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_FNS
            // 
            groupBoxCondition_FNS.Controls.Add(textBoxTask_FNS);
            groupBoxCondition_FNS.Location = new Point(10, 9);
            groupBoxCondition_FNS.Margin = new Padding(3, 2, 3, 2);
            groupBoxCondition_FNS.Name = "groupBoxCondition_FNS";
            groupBoxCondition_FNS.Padding = new Padding(3, 2, 3, 2);
            groupBoxCondition_FNS.Size = new Size(434, 88);
            groupBoxCondition_FNS.TabIndex = 1;
            groupBoxCondition_FNS.TabStop = false;
            groupBoxCondition_FNS.Text = "Условие";
            // 
            // textBoxTask_FNS
            // 
            textBoxTask_FNS.BackColor = SystemColors.Control;
            textBoxTask_FNS.BorderStyle = BorderStyle.None;
            textBoxTask_FNS.ForeColor = SystemColors.ControlText;
            textBoxTask_FNS.Location = new Point(5, 20);
            textBoxTask_FNS.Margin = new Padding(3, 2, 3, 2);
            textBoxTask_FNS.Multiline = true;
            textBoxTask_FNS.Name = "textBoxTask_FNS";
            textBoxTask_FNS.Size = new Size(424, 78);
            textBoxTask_FNS.TabIndex = 1;
            textBoxTask_FNS.Text = "Прочитать данные из файла InPutFileTask5.txt. \r\nВывести в DataGridView все вещественные значения.\r\nПостроить диаграмму по этим значениям.";
            // 
            // groupBoxCondition2_FNS
            // 
            groupBoxCondition2_FNS.Controls.Add(textBoxStopValue_FNS);
            groupBoxCondition2_FNS.Controls.Add(textBoxCondStopVal_FNS);
            groupBoxCondition2_FNS.Controls.Add(textBoxStartValue_FNS);
            groupBoxCondition2_FNS.Controls.Add(textBoxCondStartVal_FNS);
            groupBoxCondition2_FNS.Location = new Point(471, 9);
            groupBoxCondition2_FNS.Margin = new Padding(3, 2, 3, 2);
            groupBoxCondition2_FNS.Name = "groupBoxCondition2_FNS";
            groupBoxCondition2_FNS.Padding = new Padding(3, 2, 3, 2);
            groupBoxCondition2_FNS.Size = new Size(279, 88);
            groupBoxCondition2_FNS.TabIndex = 2;
            groupBoxCondition2_FNS.TabStop = false;
            groupBoxCondition2_FNS.Text = "Ввод данных";
            // 
            // textBoxStopValue_FNS
            // 
            textBoxStopValue_FNS.Location = new Point(164, 53);
            textBoxStopValue_FNS.Margin = new Padding(3, 2, 3, 2);
            textBoxStopValue_FNS.Name = "textBoxStopValue_FNS";
            textBoxStopValue_FNS.Size = new Size(110, 23);
            textBoxStopValue_FNS.TabIndex = 3;
            textBoxStopValue_FNS.Text = "5";
            textBoxStopValue_FNS.KeyPress += textBoxStopValue_ATY_KeyPress;
            // 
            // textBoxCondStopVal_FNS
            // 
            textBoxCondStopVal_FNS.BackColor = SystemColors.Control;
            textBoxCondStopVal_FNS.BorderStyle = BorderStyle.None;
            textBoxCondStopVal_FNS.Location = new Point(177, 29);
            textBoxCondStopVal_FNS.Margin = new Padding(3, 2, 3, 2);
            textBoxCondStopVal_FNS.Name = "textBoxCondStopVal_FNS";
            textBoxCondStopVal_FNS.Size = new Size(109, 16);
            textBoxCondStopVal_FNS.TabIndex = 2;
            textBoxCondStopVal_FNS.Text = "Конец шага:";
            // 
            // textBoxStartValue_FNS
            // 
            textBoxStartValue_FNS.BackColor = SystemColors.Window;
            textBoxStartValue_FNS.Location = new Point(21, 53);
            textBoxStartValue_FNS.Margin = new Padding(3, 2, 3, 2);
            textBoxStartValue_FNS.Name = "textBoxStartValue_FNS";
            textBoxStartValue_FNS.Size = new Size(110, 23);
            textBoxStartValue_FNS.TabIndex = 1;
            textBoxStartValue_FNS.Text = "-5";
            textBoxStartValue_FNS.KeyPress += textBoxStartValue_ATY_KeyPress;
            // 
            // textBoxCondStartVal_FNS
            // 
            textBoxCondStartVal_FNS.BackColor = SystemColors.Control;
            textBoxCondStartVal_FNS.BorderStyle = BorderStyle.None;
            textBoxCondStartVal_FNS.Location = new Point(21, 29);
            textBoxCondStartVal_FNS.Margin = new Padding(3, 2, 3, 2);
            textBoxCondStartVal_FNS.Name = "textBoxCondStartVal_FNS";
            textBoxCondStartVal_FNS.Size = new Size(124, 16);
            textBoxCondStartVal_FNS.TabIndex = 0;
            textBoxCondStartVal_FNS.Text = "Старт шага:";
            // 
            // buttonDone_FNS
            // 
            buttonDone_FNS.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone_FNS.Location = new Point(780, 19);
            buttonDone_FNS.Margin = new Padding(3, 2, 3, 2);
            buttonDone_FNS.Name = "buttonDone_FNS";
            buttonDone_FNS.Size = new Size(117, 64);
            buttonDone_FNS.TabIndex = 6;
            buttonDone_FNS.Text = "Выполнить";
            buttonDone_FNS.UseVisualStyleBackColor = false;
            buttonDone_FNS.Click += buttonDone_ATY_Click;
            // 
            // buttonHelp_FNS
            // 
            buttonHelp_FNS.BackColor = Color.Blue;
            buttonHelp_FNS.Location = new Point(1082, 19);
            buttonHelp_FNS.Margin = new Padding(3, 2, 3, 2);
            buttonHelp_FNS.Name = "buttonHelp_FNS";
            buttonHelp_FNS.Size = new Size(140, 64);
            buttonHelp_FNS.TabIndex = 6;
            buttonHelp_FNS.Text = "Справка";
            buttonHelp_FNS.UseVisualStyleBackColor = false;
            buttonHelp_FNS.Click += buttonHelp_ATY_Click;
            // 
            // buttonSave_FNS
            // 
            buttonSave_FNS.BackColor = Color.FromArgb(128, 128, 255);
            buttonSave_FNS.Location = new Point(924, 19);
            buttonSave_FNS.Margin = new Padding(3, 2, 3, 2);
            buttonSave_FNS.Name = "buttonSave_FNS";
            buttonSave_FNS.Size = new Size(130, 65);
            buttonSave_FNS.TabIndex = 8;
            buttonSave_FNS.Text = "Открыть файл";
            buttonSave_FNS.UseVisualStyleBackColor = false;
            buttonSave_FNS.Click += buttonSave_ATY_Click;
            // 
            // groupBoxRes_FNS
            // 
            groupBoxRes_FNS.Controls.Add(dataGridViewResult_FNS);
            groupBoxRes_FNS.Controls.Add(dataGridView1);
            groupBoxRes_FNS.Controls.Add(chartFunction_FNS); // <-- добавлен Chart
            groupBoxRes_FNS.Location = new Point(16, 101);
            groupBoxRes_FNS.Margin = new Padding(3, 2, 3, 2);
            groupBoxRes_FNS.Name = "groupBoxRes_FNS";
            groupBoxRes_FNS.Padding = new Padding(3, 2, 3, 2);
            groupBoxRes_FNS.Size = new Size(1200, 350); // увеличен размер
            groupBoxRes_FNS.TabIndex = 7;
            groupBoxRes_FNS.TabStop = false;
            groupBoxRes_FNS.Text = "Вывод данных";
            // 
            // dataGridViewResult_FNS
            // 
            dataGridViewResult_FNS.BackgroundColor = SystemColors.Control;
            dataGridViewResult_FNS.BorderStyle = BorderStyle.None;
            dataGridViewResult_FNS.ColumnHeadersHeight = 29;
            dataGridViewResult_FNS.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewResult_FNS.Location = new Point(5, 26);
            dataGridViewResult_FNS.Margin = new Padding(3, 2, 3, 2);
            dataGridViewResult_FNS.Name = "dataGridViewResult_FNS";
            dataGridViewResult_FNS.RowHeadersVisible = false;
            dataGridViewResult_FNS.RowHeadersWidth = 51;
            dataGridViewResult_FNS.Size = new Size(279, 262);
            dataGridViewResult_FNS.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(340, 26);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(262, 141);
            dataGridView1.TabIndex = 0;
            // 
            // chartFunction_FNS
            // 
            chartFunction_FNS.BackColor = SystemColors.Control;
            chartFunction_FNS.BorderlineColor = SystemColors.Control;
            chartFunction_FNS.BorderSkin.PageColor = SystemColors.Control;
            chartFunction_FNS.Location = new Point(340, 175);
            chartFunction_FNS.Margin = new Padding(3, 2, 3, 2);
            chartFunction_FNS.Name = "chartFunction_FNS";
            chartArea1.Name = "ChartArea1";
            chartFunction_FNS.ChartAreas.Add(chartArea1);
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            chartFunction_FNS.Series.Add(series1);
            chartFunction_FNS.Size = new Size(600, 150);
            chartFunction_FNS.TabIndex = 2;
            chartFunction_FNS.Text = "chartFunction_FNS";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 462);
            Controls.Add(buttonSave_FNS);
            Controls.Add(groupBoxRes_FNS);
            Controls.Add(buttonHelp_FNS);
            Controls.Add(buttonDone_FNS);
            Controls.Add(groupBoxCondition2_FNS);
            Controls.Add(groupBoxCondition_FNS);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 3 | Фендель Н.С.";
            groupBoxCondition_FNS.ResumeLayout(false);
            groupBoxCondition_FNS.PerformLayout();
            groupBoxCondition2_FNS.ResumeLayout(false);
            groupBoxCondition2_FNS.PerformLayout();
            groupBoxRes_FNS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_FNS).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_FNS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_FNS;
        private TextBox textBoxTask_FNS;
        private GroupBox groupBoxCondition2_FNS;
        private TextBox textBoxCondStartVal_FNS;
        private TextBox textBoxStartValue_FNS;
        private Button buttonDone_FNS;
        private Button buttonHelp_FNS;
        private TextBox textBoxStopValue_FNS;
        private TextBox textBoxCondStopVal_FNS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_FNS; // <= Исправлено
        private Button buttonSave_FNS;
        private GroupBox groupBoxRes_FNS;
        private DataGridView dataGridViewResult_FNS;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridView dataGridView1;
    }
}