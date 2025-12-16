namespace Tyuiu.FendelNS.Sprint6.Task4.V24
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelUp_FNS = new Panel();
            buttonSave_FNS = new Button();
            buttonResult_FNS = new Button();
            buttonInfo_FNS = new Button();
            groupBoxInPut_FNS = new GroupBox();
            labelStop_FNS = new Label();
            labelStart_FNS = new Label();
            textBoxStop_FNS = new TextBox();
            textBoxStart_FNS = new TextBox();
            groupBoxTask_FNS = new GroupBox();
            pictureBoxTask_FNS = new PictureBox();
            panelLeft_FNS = new Panel();
            groupBoxOutPut_FNS = new GroupBox();
            textBoxOutPut_FNS = new TextBox();
            panelFunc_FNS = new Panel();
            chartFunc_FNS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelUp_FNS.SuspendLayout();
            groupBoxInPut_FNS.SuspendLayout();
            groupBoxTask_FNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_FNS).BeginInit();
            panelLeft_FNS.SuspendLayout();
            groupBoxOutPut_FNS.SuspendLayout();
            panelFunc_FNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunc_FNS).BeginInit();
            SuspendLayout();
            // 
            // panelUp_FNS
            // 
            panelUp_FNS.BackColor = Color.FromArgb(224, 224, 224);
            panelUp_FNS.Controls.Add(buttonSave_FNS);
            panelUp_FNS.Controls.Add(buttonResult_FNS);
            panelUp_FNS.Controls.Add(buttonInfo_FNS);
            panelUp_FNS.Controls.Add(groupBoxInPut_FNS);
            panelUp_FNS.Controls.Add(groupBoxTask_FNS);
            panelUp_FNS.Dock = DockStyle.Top;
            panelUp_FNS.Location = new Point(0, 0);
            panelUp_FNS.Margin = new Padding(4, 3, 4, 3);
            panelUp_FNS.Name = "panelUp_FNS";
            panelUp_FNS.Size = new Size(944, 216);
            panelUp_FNS.TabIndex = 0;
            // 
            // buttonSave_FNS
            // 
            buttonSave_FNS.BackColor = Color.LightBlue;
            buttonSave_FNS.FlatStyle = FlatStyle.Flat;
            buttonSave_FNS.Location = new Point(734, 133);
            buttonSave_FNS.Margin = new Padding(4, 3, 4, 3);
            buttonSave_FNS.Name = "buttonSave_FNS";
            buttonSave_FNS.Size = new Size(184, 42);
            buttonSave_FNS.TabIndex = 3;
            buttonSave_FNS.Text = "Сохранить файл";
            buttonSave_FNS.UseVisualStyleBackColor = false;
            buttonSave_FNS.Click += buttonSave_SKE_Click;
            // 
            // buttonResult_FNS
            // 
            buttonResult_FNS.BackColor = Color.LightGreen;
            buttonResult_FNS.FlatStyle = FlatStyle.Flat;
            buttonResult_FNS.Location = new Point(734, 60);
            buttonResult_FNS.Margin = new Padding(4, 3, 4, 3);
            buttonResult_FNS.Name = "buttonResult_FNS";
            buttonResult_FNS.Size = new Size(184, 42);
            buttonResult_FNS.TabIndex = 3;
            buttonResult_FNS.Text = "Вычислить результат";
            buttonResult_FNS.UseVisualStyleBackColor = false;
            buttonResult_FNS.Click += buttonResult_SKE_Click;
            // 
            // buttonInfo_FNS
            // 
            buttonInfo_FNS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo_FNS.Location = new Point(853, 3);
            buttonInfo_FNS.Margin = new Padding(4, 3, 4, 3);
            buttonInfo_FNS.Name = "buttonInfo_FNS";
            buttonInfo_FNS.Size = new Size(88, 27);
            buttonInfo_FNS.TabIndex = 2;
            buttonInfo_FNS.Text = "Справка";
            buttonInfo_FNS.UseVisualStyleBackColor = true;
            buttonInfo_FNS.Click += buttonInfo_SKE_Click;
            // 
            // groupBoxInPut_FNS
            // 
            groupBoxInPut_FNS.Controls.Add(labelStop_FNS);
            groupBoxInPut_FNS.Controls.Add(labelStart_FNS);
            groupBoxInPut_FNS.Controls.Add(textBoxStop_FNS);
            groupBoxInPut_FNS.Controls.Add(textBoxStart_FNS);
            groupBoxInPut_FNS.Dock = DockStyle.Left;
            groupBoxInPut_FNS.Location = new Point(553, 0);
            groupBoxInPut_FNS.Margin = new Padding(4, 3, 4, 3);
            groupBoxInPut_FNS.Name = "groupBoxInPut_FNS";
            groupBoxInPut_FNS.Padding = new Padding(4, 3, 4, 3);
            groupBoxInPut_FNS.Size = new Size(156, 216);
            groupBoxInPut_FNS.TabIndex = 1;
            groupBoxInPut_FNS.TabStop = false;
            groupBoxInPut_FNS.Text = "Ввод Данных";
            // 
            // labelStop_FNS
            // 
            labelStop_FNS.AutoSize = true;
            labelStop_FNS.Location = new Point(7, 114);
            labelStop_FNS.Margin = new Padding(4, 0, 4, 0);
            labelStop_FNS.Name = "labelStop_FNS";
            labelStop_FNS.Size = new Size(72, 15);
            labelStop_FNS.TabIndex = 1;
            labelStop_FNS.Text = "Конец шага";
            // 
            // labelStart_FNS
            // 
            labelStart_FNS.AutoSize = true;
            labelStart_FNS.Location = new Point(7, 42);
            labelStart_FNS.Margin = new Padding(4, 0, 4, 0);
            labelStart_FNS.Name = "labelStart_FNS";
            labelStart_FNS.Size = new Size(69, 15);
            labelStart_FNS.TabIndex = 1;
            labelStart_FNS.Text = "Старт шага";
            // 
            // textBoxStop_FNS
            // 
            textBoxStop_FNS.Location = new Point(7, 133);
            textBoxStop_FNS.Margin = new Padding(4, 3, 4, 3);
            textBoxStop_FNS.Name = "textBoxStop_FNS";
            textBoxStop_FNS.Size = new Size(116, 23);
            textBoxStop_FNS.TabIndex = 0;
            // 
            // textBoxStart_FNS
            // 
            textBoxStart_FNS.Location = new Point(7, 60);
            textBoxStart_FNS.Margin = new Padding(4, 3, 4, 3);
            textBoxStart_FNS.Name = "textBoxStart_FNS";
            textBoxStart_FNS.Size = new Size(116, 23);
            textBoxStart_FNS.TabIndex = 0;
            // 
            // groupBoxTask_FNS
            // 
            groupBoxTask_FNS.Controls.Add(pictureBoxTask_FNS);
            groupBoxTask_FNS.Dock = DockStyle.Left;
            groupBoxTask_FNS.Location = new Point(0, 0);
            groupBoxTask_FNS.Margin = new Padding(4, 3, 4, 3);
            groupBoxTask_FNS.Name = "groupBoxTask_FNS";
            groupBoxTask_FNS.Padding = new Padding(4, 3, 4, 3);
            groupBoxTask_FNS.Size = new Size(553, 216);
            groupBoxTask_FNS.TabIndex = 0;
            groupBoxTask_FNS.TabStop = false;
            groupBoxTask_FNS.Text = "Условие";
            // 
            // pictureBoxTask_FNS
            // 
            pictureBoxTask_FNS.Dock = DockStyle.Fill;
            pictureBoxTask_FNS.Image = Properties.Resources.photo_2025_12_17_03_03_14;
            pictureBoxTask_FNS.Location = new Point(4, 19);
            pictureBoxTask_FNS.Margin = new Padding(4, 3, 4, 3);
            pictureBoxTask_FNS.Name = "pictureBoxTask_FNS";
            pictureBoxTask_FNS.Size = new Size(545, 194);
            pictureBoxTask_FNS.TabIndex = 0;
            pictureBoxTask_FNS.TabStop = false;
            // 
            // panelLeft_FNS
            // 
            panelLeft_FNS.Controls.Add(groupBoxOutPut_FNS);
            panelLeft_FNS.Dock = DockStyle.Left;
            panelLeft_FNS.Location = new Point(0, 216);
            panelLeft_FNS.Margin = new Padding(4, 3, 4, 3);
            panelLeft_FNS.Name = "panelLeft_FNS";
            panelLeft_FNS.Size = new Size(267, 317);
            panelLeft_FNS.TabIndex = 1;
            // 
            // groupBoxOutPut_FNS
            // 
            groupBoxOutPut_FNS.Controls.Add(textBoxOutPut_FNS);
            groupBoxOutPut_FNS.Dock = DockStyle.Fill;
            groupBoxOutPut_FNS.Location = new Point(0, 0);
            groupBoxOutPut_FNS.Margin = new Padding(4, 3, 4, 3);
            groupBoxOutPut_FNS.Name = "groupBoxOutPut_FNS";
            groupBoxOutPut_FNS.Padding = new Padding(4, 3, 4, 3);
            groupBoxOutPut_FNS.Size = new Size(267, 317);
            groupBoxOutPut_FNS.TabIndex = 0;
            groupBoxOutPut_FNS.TabStop = false;
            groupBoxOutPut_FNS.Text = "Вывод Данных";
            // 
            // textBoxOutPut_FNS
            // 
            textBoxOutPut_FNS.Dock = DockStyle.Fill;
            textBoxOutPut_FNS.Location = new Point(4, 19);
            textBoxOutPut_FNS.Margin = new Padding(4, 3, 4, 3);
            textBoxOutPut_FNS.Multiline = true;
            textBoxOutPut_FNS.Name = "textBoxOutPut_FNS";
            textBoxOutPut_FNS.ReadOnly = true;
            textBoxOutPut_FNS.ScrollBars = ScrollBars.Vertical;
            textBoxOutPut_FNS.Size = new Size(259, 295);
            textBoxOutPut_FNS.TabIndex = 0;
            // 
            // panelFunc_FNS
            // 
            panelFunc_FNS.Controls.Add(chartFunc_FNS);
            panelFunc_FNS.Dock = DockStyle.Fill;
            panelFunc_FNS.Location = new Point(267, 216);
            panelFunc_FNS.Margin = new Padding(4, 3, 4, 3);
            panelFunc_FNS.Name = "panelFunc_FNS";
            panelFunc_FNS.Size = new Size(677, 317);
            panelFunc_FNS.TabIndex = 2;
            // 
            // chartFunc_FNS
            // 
            chartFunc_FNS.Dock = DockStyle.Fill;
            chartArea1.Name = "ChartArea1";
            chartFunc_FNS.ChartAreas.Add(chartArea1);
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            chartFunc_FNS.Series.Add(series1);
            chartFunc_FNS.Location = new Point(0, 0);
            chartFunc_FNS.Margin = new Padding(4, 3, 4, 3);
            chartFunc_FNS.Name = "chartFunc_FNS";
            chartFunc_FNS.Size = new Size(677, 317);
            chartFunc_FNS.TabIndex = 0;
            chartFunc_FNS.Text = "chartFunc_FNS";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 533);
            Controls.Add(panelFunc_FNS);
            Controls.Add(panelLeft_FNS);
            Controls.Add(panelUp_FNS);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(960, 571);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 24  | Фендель Н. С.";
            panelUp_FNS.ResumeLayout(false);
            groupBoxInPut_FNS.ResumeLayout(false);
            groupBoxInPut_FNS.PerformLayout();
            groupBoxTask_FNS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_FNS).EndInit();
            panelLeft_FNS.ResumeLayout(false);
            groupBoxOutPut_FNS.ResumeLayout(false);
            groupBoxOutPut_FNS.PerformLayout();
            panelFunc_FNS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunc_FNS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelUp_FNS;
        private System.Windows.Forms.GroupBox groupBoxTask_FNS;
        private System.Windows.Forms.PictureBox pictureBoxTask_FNS;
        private System.Windows.Forms.Panel panelLeft_FNS;
        private System.Windows.Forms.GroupBox groupBoxOutPut_FNS;
        private System.Windows.Forms.TextBox textBoxOutPut_FNS;
        private System.Windows.Forms.Panel panelFunc_FNS;
        private System.Windows.Forms.Button buttonSave_FNS;
        private System.Windows.Forms.Button buttonResult_FNS;
        private System.Windows.Forms.Button buttonInfo_FNS;
        private System.Windows.Forms.GroupBox groupBoxInPut_FNS;
        private System.Windows.Forms.Label labelStop_FNS;
        private System.Windows.Forms.Label labelStart_FNS;
        private System.Windows.Forms.TextBox textBoxStop_FNS;
        private System.Windows.Forms.TextBox textBoxStart_FNS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc_FNS;
    }
}