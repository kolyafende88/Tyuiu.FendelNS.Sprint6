namespace Tyuiu.FendelNS.Sprint6.Task6.V28
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
            buttonHelp_FNS = new Button();
            buttonExecute_FNS = new Button();
            groupBoxTask_FNS = new GroupBox();
            textBoxTask_FNS = new TextBox();
            labelInput_FNS = new Label();
            labelInputFileName = new Label();
            textBoxIn_FNS = new TextBox();
            labelOutput_FNS = new Label();
            textBoxOut_FNS = new TextBox();
            openFileDialogTask_FNS = new OpenFileDialog();
            toolTip_FNS = new ToolTip(components);
            buttonOpenFile_FNS = new Button();
            panelButtons_FNS.SuspendLayout();
            groupBoxTask_FNS.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtons_FNS
            // 
            panelButtons_FNS.AutoSize = true;
            panelButtons_FNS.BackColor = SystemColors.Control;
            panelButtons_FNS.BorderStyle = BorderStyle.Fixed3D;
            panelButtons_FNS.Controls.Add(buttonHelp_FNS);
            panelButtons_FNS.Controls.Add(buttonExecute_FNS);
            panelButtons_FNS.Controls.Add(buttonOpenFile_FNS);
            panelButtons_FNS.Dock = DockStyle.Top;
            panelButtons_FNS.Location = new Point(0, 0);
            panelButtons_FNS.Margin = new Padding(3, 2, 3, 2);
            panelButtons_FNS.Name = "panelButtons_FNS";
            panelButtons_FNS.Size = new Size(702, 60);
            panelButtons_FNS.TabIndex = 0;
            // 
            // buttonHelp_FNS
            // 
            buttonHelp_FNS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_FNS.FlatStyle = FlatStyle.Popup;
            buttonHelp_FNS.Image = Properties.Resources.photo_2025_12_17_04_23_49;
            buttonHelp_FNS.Location = new Point(617, 2);
            buttonHelp_FNS.Margin = new Padding(3, 2, 3, 2);
            buttonHelp_FNS.Name = "buttonHelp_FNS";
            buttonHelp_FNS.Size = new Size(79, 52);
            buttonHelp_FNS.TabIndex = 2;
            toolTip_FNS.SetToolTip(buttonHelp_FNS, "О программе");
            buttonHelp_FNS.UseVisualStyleBackColor = true;
            buttonHelp_FNS.Click += buttonHelp_GAE_Click;
            // 
            // buttonExecute_FNS
            // 
            buttonExecute_FNS.Enabled = false;
            buttonExecute_FNS.FlatStyle = FlatStyle.Popup;
            buttonExecute_FNS.Image = Properties.Resources.photo_2025_12_17_04_23_58;
            buttonExecute_FNS.Location = new Point(87, 2);
            buttonExecute_FNS.Margin = new Padding(3, 2, 3, 2);
            buttonExecute_FNS.Name = "buttonExecute_FNS";
            buttonExecute_FNS.Size = new Size(79, 52);
            buttonExecute_FNS.TabIndex = 1;
            toolTip_FNS.SetToolTip(buttonExecute_FNS, "Выполнить");
            buttonExecute_FNS.UseVisualStyleBackColor = true;
            buttonExecute_FNS.Click += buttonExecute_GAE_Click;
            // 
            // groupBoxTask_FNS
            // 
            groupBoxTask_FNS.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxTask_FNS.AutoSize = true;
            groupBoxTask_FNS.Controls.Add(textBoxTask_FNS);
            groupBoxTask_FNS.Location = new Point(10, 64);
            groupBoxTask_FNS.Margin = new Padding(3, 2, 3, 2);
            groupBoxTask_FNS.Name = "groupBoxTask_FNS";
            groupBoxTask_FNS.Padding = new Padding(3, 2, 3, 2);
            groupBoxTask_FNS.Size = new Size(679, 92);
            groupBoxTask_FNS.TabIndex = 1;
            groupBoxTask_FNS.TabStop = false;
            groupBoxTask_FNS.Text = "Условие";
            // 
            // textBoxTask_FNS
            // 
            textBoxTask_FNS.Dock = DockStyle.Fill;
            textBoxTask_FNS.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_FNS.Location = new Point(3, 18);
            textBoxTask_FNS.Margin = new Padding(3, 2, 3, 2);
            textBoxTask_FNS.Multiline = true;
            textBoxTask_FNS.Name = "textBoxTask_FNS";
            textBoxTask_FNS.ReadOnly = true;
            textBoxTask_FNS.Size = new Size(673, 72);
            textBoxTask_FNS.TabIndex = 0;
            textBoxTask_FNS.Text = resources.GetString("textBoxTask_FNS.Text");
            // 
            // labelInput_FNS
            // 
            labelInput_FNS.AutoSize = true;
            labelInput_FNS.Location = new Point(10, 159);
            labelInput_FNS.Name = "labelInput_FNS";
            labelInput_FNS.Size = new Size(36, 15);
            labelInput_FNS.TabIndex = 2;
            labelInput_FNS.Text = "Ввод:";
            // 
            // labelInputFileName
            // 
            labelInputFileName.AutoSize = true;
            labelInputFileName.Location = new Point(56, 159);
            labelInputFileName.Name = "labelInputFileName";
            labelInputFileName.Size = new Size(0, 15);
            labelInputFileName.TabIndex = 3;
            // 
            // textBoxIn_FNS
            // 
            textBoxIn_FNS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxIn_FNS.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxIn_FNS.Location = new Point(13, 176);
            textBoxIn_FNS.Margin = new Padding(3, 2, 3, 2);
            textBoxIn_FNS.Multiline = true;
            textBoxIn_FNS.Name = "textBoxIn_FNS";
            textBoxIn_FNS.ScrollBars = ScrollBars.Vertical;
            textBoxIn_FNS.Size = new Size(370, 221);
            textBoxIn_FNS.TabIndex = 4;
            // 
            // labelOutput_FNS
            // 
            labelOutput_FNS.AutoSize = true;
            labelOutput_FNS.Location = new Point(388, 159);
            labelOutput_FNS.Name = "labelOutput_FNS";
            labelOutput_FNS.Size = new Size(45, 15);
            labelOutput_FNS.TabIndex = 5;
            labelOutput_FNS.Text = "Вывод:";
            // 
            // textBoxOut_FNS
            // 
            textBoxOut_FNS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxOut_FNS.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxOut_FNS.Location = new Point(388, 176);
            textBoxOut_FNS.Margin = new Padding(3, 2, 3, 2);
            textBoxOut_FNS.Multiline = true;
            textBoxOut_FNS.Name = "textBoxOut_FNS";
            textBoxOut_FNS.ScrollBars = ScrollBars.Vertical;
            textBoxOut_FNS.Size = new Size(302, 221);
            textBoxOut_FNS.TabIndex = 6;
            // 
            // openFileDialogTask_FNS
            // 
            openFileDialogTask_FNS.FileName = "InPutDataFileTask6V28.txt";
            // 
            // toolTip_FNS
            // 
            toolTip_FNS.ToolTipIcon = ToolTipIcon.Info;
            toolTip_FNS.ToolTipTitle = "Подсказка";
            // 
            // buttonOpenFile_FNS
            // 
            buttonOpenFile_FNS.FlatStyle = FlatStyle.Popup;
            buttonOpenFile_FNS.Image = (Image)resources.GetObject("buttonOpenFile_FNS.Image");
            buttonOpenFile_FNS.Location = new Point(3, 2);
            buttonOpenFile_FNS.Margin = new Padding(3, 2, 3, 2);
            buttonOpenFile_FNS.Name = "buttonOpenFile_FNS";
            buttonOpenFile_FNS.Size = new Size(79, 52);
            buttonOpenFile_FNS.TabIndex = 0;
            toolTip_FNS.SetToolTip(buttonOpenFile_FNS, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpenFile_FNS.UseVisualStyleBackColor = true;
            buttonOpenFile_FNS.Click += buttonOpenFile_GAE_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 405);
            Controls.Add(textBoxOut_FNS);
            Controls.Add(labelOutput_FNS);
            Controls.Add(textBoxIn_FNS);
            Controls.Add(labelInputFileName);
            Controls.Add(labelInput_FNS);
            Controls.Add(groupBoxTask_FNS);
            Controls.Add(panelButtons_FNS);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(718, 383);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 28 | Фендель Н С.";
            panelButtons_FNS.ResumeLayout(false);
            groupBoxTask_FNS.ResumeLayout(false);
            groupBoxTask_FNS.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelButtons_FNS;
        private Button buttonExecute_FNS;
        private Button buttonHelp_FNS;
        private GroupBox groupBoxTask_FNS;
        private TextBox textBoxTask_FNS;
        private Label labelInput_FNS;
        private Label labelInputFileName;
        private TextBox textBoxIn_FNS;
        private Label labelOutput_FNS;
        private TextBox textBoxOut_FNS;
        private OpenFileDialog openFileDialogTask_FNS;
        private ToolTip toolTip_FNS;
        private Button buttonOpenFile_FNS;
    }
}
