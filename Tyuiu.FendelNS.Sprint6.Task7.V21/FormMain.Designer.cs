namespace Tyuiu.FendelNS.Sprint6.Task7.V21
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
            panelButtons_FNS = new Panel();
            buttonSaveFile_FNS = new Button();
            buttonAbout_FNS = new Button();
            buttonHelp_FNS = new Button();
            buttonDone_FNS = new Button();
            buttonOpenFile_FNS = new Button();
            panel2 = new Panel();
            groupBoxTask_FNS = new GroupBox();
            textBoxTask_FNS = new TextBox();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBoxInPut_FNS = new GroupBox();
            dataGridViewInPut_FNS = new DataGridView();
            groupBoxOutPut_FNS = new GroupBox();
            dataGridViewOutPut_FNS = new DataGridView();
            toolTip_FNS = new ToolTip(components);
            openFileDialog_FNS = new OpenFileDialog();
            saveFileDialog_FNS = new SaveFileDialog();
            panelButtons_FNS.SuspendLayout();
            groupBoxTask_FNS.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBoxInPut_FNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut_FNS).BeginInit();
            groupBoxOutPut_FNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_FNS).BeginInit();
            SuspendLayout();
            // 
            // panelButtons_FNS
            // 
            panelButtons_FNS.BorderStyle = BorderStyle.Fixed3D;
            panelButtons_FNS.Controls.Add(buttonSaveFile_FNS);
            panelButtons_FNS.Controls.Add(buttonAbout_FNS);
            panelButtons_FNS.Controls.Add(buttonHelp_FNS);
            panelButtons_FNS.Controls.Add(buttonDone_FNS);
            panelButtons_FNS.Controls.Add(buttonOpenFile_FNS);
            panelButtons_FNS.Controls.Add(panel2);
            panelButtons_FNS.Dock = DockStyle.Top;
            panelButtons_FNS.Location = new Point(0, 0);
            panelButtons_FNS.Name = "panelButtons_FNS";
            panelButtons_FNS.Size = new Size(800, 72);
            panelButtons_FNS.TabIndex = 1;
            // 
            // buttonSaveFile_FNS
            // 
            buttonSaveFile_FNS.BackColor = Color.Transparent;
            buttonSaveFile_FNS.BackgroundImageLayout = ImageLayout.Center;
            buttonSaveFile_FNS.Enabled = false;
            buttonSaveFile_FNS.Image = Properties.Resources.photo_2025_12_17_05_30_44;
            buttonSaveFile_FNS.Location = new Point(171, 3);
            buttonSaveFile_FNS.Name = "buttonSaveFile_FNS";
            buttonSaveFile_FNS.Size = new Size(78, 62);
            buttonSaveFile_FNS.TabIndex = 6;
            toolTip_FNS.SetToolTip(buttonSaveFile_FNS, "Сохранить обработанные данные в файл в формате CSV");
            buttonSaveFile_FNS.UseVisualStyleBackColor = false;
            buttonSaveFile_FNS.Click += buttonSaveFile_SBI_Click;
            buttonSaveFile_FNS.MouseEnter += buttonSaveFile_SBI_MouseEnter;
            // 
            // buttonAbout_FNS
            // 
            buttonAbout_FNS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAbout_FNS.BackColor = Color.Transparent;
            buttonAbout_FNS.BackgroundImageLayout = ImageLayout.Center;
            buttonAbout_FNS.Image = Properties.Resources.photo_2025_12_17_04_23_491;
            buttonAbout_FNS.Location = new Point(715, 3);
            buttonAbout_FNS.Name = "buttonAbout_FNS";
            buttonAbout_FNS.Size = new Size(78, 62);
            buttonAbout_FNS.TabIndex = 5;
            buttonAbout_FNS.UseVisualStyleBackColor = false;
            buttonAbout_FNS.Click += buttonAbout_SBI_Click;
            // 
            // buttonHelp_FNS
            // 
            buttonHelp_FNS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_FNS.BackColor = Color.Transparent;
            buttonHelp_FNS.BackgroundImageLayout = ImageLayout.Zoom;
            buttonHelp_FNS.Location = new Point(1311, 3);
            buttonHelp_FNS.Name = "buttonHelp_FNS";
            buttonHelp_FNS.Size = new Size(78, 62);
            buttonHelp_FNS.TabIndex = 4;
            buttonHelp_FNS.UseVisualStyleBackColor = false;
            // 
            // buttonDone_FNS
            // 
            buttonDone_FNS.BackColor = Color.Transparent;
            buttonDone_FNS.BackgroundImageLayout = ImageLayout.Center;
            buttonDone_FNS.Enabled = false;
            buttonDone_FNS.Image = Properties.Resources.photo_2025_12_17_04_23_58;
            buttonDone_FNS.Location = new Point(87, 3);
            buttonDone_FNS.Name = "buttonDone_FNS";
            buttonDone_FNS.Size = new Size(78, 62);
            buttonDone_FNS.TabIndex = 3;
            toolTip_FNS.SetToolTip(buttonDone_FNS, "Выполнить обработку данных");
            buttonDone_FNS.UseVisualStyleBackColor = false;
            buttonDone_FNS.Click += buttonDone_SBI_Click;
            buttonDone_FNS.MouseEnter += buttonDone_SBI_MouseEnter;
            // 
            // buttonOpenFile_FNS
            // 
            buttonOpenFile_FNS.BackColor = Color.Transparent;
            buttonOpenFile_FNS.BackgroundImageLayout = ImageLayout.Center;
            buttonOpenFile_FNS.Image = Properties.Resources.photo_2025_12_17_04_23_52;
            buttonOpenFile_FNS.Location = new Point(3, 3);
            buttonOpenFile_FNS.Name = "buttonOpenFile_FNS";
            buttonOpenFile_FNS.Size = new Size(78, 62);
            buttonOpenFile_FNS.TabIndex = 2;
            toolTip_FNS.SetToolTip(buttonOpenFile_FNS, "Открыть файл для обработки данных в формате CSV\r\n");
            buttonOpenFile_FNS.UseVisualStyleBackColor = false;
            buttonOpenFile_FNS.Click += buttonOpenFile_SBI_Click;
            buttonOpenFile_FNS.MouseEnter += buttonOpenFile_SBI_MouseEnter;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 76);
            panel2.TabIndex = 1;
            // 
            // groupBoxTask_FNS
            // 
            groupBoxTask_FNS.Controls.Add(textBoxTask_FNS);
            groupBoxTask_FNS.Dock = DockStyle.Fill;
            groupBoxTask_FNS.Location = new Point(5, 5);
            groupBoxTask_FNS.Name = "groupBoxTask_FNS";
            groupBoxTask_FNS.RightToLeft = RightToLeft.No;
            groupBoxTask_FNS.Size = new Size(790, 107);
            groupBoxTask_FNS.TabIndex = 2;
            groupBoxTask_FNS.TabStop = false;
            groupBoxTask_FNS.Text = "Условие:";
            // 
            // textBoxTask_FNS
            // 
            textBoxTask_FNS.BorderStyle = BorderStyle.None;
            textBoxTask_FNS.Dock = DockStyle.Fill;
            textBoxTask_FNS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_FNS.Location = new Point(3, 19);
            textBoxTask_FNS.Multiline = true;
            textBoxTask_FNS.Name = "textBoxTask_FNS";
            textBoxTask_FNS.ReadOnly = true;
            textBoxTask_FNS.Size = new Size(784, 85);
            textBoxTask_FNS.TabIndex = 0;
            textBoxTask_FNS.Text = resources.GetString("textBoxTask_FNS.Text");
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBoxTask_FNS);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 72);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(800, 117);
            panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBoxInPut_FNS, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBoxOutPut_FNS, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 189);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(3);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 261);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // groupBoxInPut_FNS
            // 
            groupBoxInPut_FNS.Controls.Add(dataGridViewInPut_FNS);
            groupBoxInPut_FNS.Dock = DockStyle.Fill;
            groupBoxInPut_FNS.Location = new Point(6, 6);
            groupBoxInPut_FNS.Name = "groupBoxInPut_FNS";
            groupBoxInPut_FNS.Size = new Size(391, 249);
            groupBoxInPut_FNS.TabIndex = 0;
            groupBoxInPut_FNS.TabStop = false;
            groupBoxInPut_FNS.Text = "Ввод:";
            // 
            // dataGridViewInPut_FNS
            // 
            dataGridViewInPut_FNS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInPut_FNS.ColumnHeadersVisible = false;
            dataGridViewInPut_FNS.Dock = DockStyle.Fill;
            dataGridViewInPut_FNS.Location = new Point(3, 19);
            dataGridViewInPut_FNS.Name = "dataGridViewInPut_FNS";
            dataGridViewInPut_FNS.RowHeadersVisible = false;
            dataGridViewInPut_FNS.Size = new Size(385, 227);
            dataGridViewInPut_FNS.TabIndex = 0;
            // 
            // groupBoxOutPut_FNS
            // 
            groupBoxOutPut_FNS.Controls.Add(dataGridViewOutPut_FNS);
            groupBoxOutPut_FNS.Dock = DockStyle.Fill;
            groupBoxOutPut_FNS.Location = new Point(403, 6);
            groupBoxOutPut_FNS.Name = "groupBoxOutPut_FNS";
            groupBoxOutPut_FNS.Size = new Size(391, 249);
            groupBoxOutPut_FNS.TabIndex = 1;
            groupBoxOutPut_FNS.TabStop = false;
            groupBoxOutPut_FNS.Text = "Вывод:";
            // 
            // dataGridViewOutPut_FNS
            // 
            dataGridViewOutPut_FNS.AllowUserToResizeRows = false;
            dataGridViewOutPut_FNS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPut_FNS.ColumnHeadersVisible = false;
            dataGridViewOutPut_FNS.Dock = DockStyle.Fill;
            dataGridViewOutPut_FNS.Location = new Point(3, 19);
            dataGridViewOutPut_FNS.Name = "dataGridViewOutPut_FNS";
            dataGridViewOutPut_FNS.RowHeadersVisible = false;
            dataGridViewOutPut_FNS.Size = new Size(385, 227);
            dataGridViewOutPut_FNS.TabIndex = 0;
            // 
            // toolTip_FNS
            // 
            toolTip_FNS.IsBalloon = true;
            // 
            // openFileDialog_FNS
            // 
            openFileDialog_FNS.FileName = "file.csv";
            // 
            // saveFileDialog_FNS
            // 
            saveFileDialog_FNS.FileName = "file.csv";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(panelButtons_FNS);
            MinimumSize = new Size(816, 489);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 21 | Фендель Н.С ";
            panelButtons_FNS.ResumeLayout(false);
            groupBoxTask_FNS.ResumeLayout(false);
            groupBoxTask_FNS.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBoxInPut_FNS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut_FNS).EndInit();
            groupBoxOutPut_FNS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_FNS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons_FNS;
        private Button buttonHelp_FNS;
        private Button buttonDone_FNS;
        private Button buttonOpenFile_FNS;
        private Panel panel2;
        private Button buttonAbout_FNS;
        private GroupBox groupBoxTask_FNS;
        private TextBox textBoxTask_FNS;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBoxInPut_FNS;
        private DataGridView dataGridViewInPut_FNS;
        private GroupBox groupBoxOutPut_FNS;
        private DataGridView dataGridViewOutPut_FNS;
        private Button buttonSaveFile_FNS;
        private ToolTip toolTip_FNS;
        private OpenFileDialog openFileDialog_FNS;
        private SaveFileDialog saveFileDialog_FNS;
    }
}