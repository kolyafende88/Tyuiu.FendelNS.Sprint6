namespace Tyuiu.FendelNS.Sprint6.Task3.V27
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
            textBoxInfo_FNS = new TextBox();
            dataGridViewMatrix_FNS = new DataGridView();
            buttonResult_FNS = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_FNS).BeginInit();
            SuspendLayout();
            // 
            // textBoxInfo_FNS
            // 
            textBoxInfo_FNS.Location = new Point(13, 13);
            textBoxInfo_FNS.Multiline = true;
            textBoxInfo_FNS.Name = "textBoxInfo_FNS";
            textBoxInfo_FNS.Size = new Size(300, 436);
            textBoxInfo_FNS.TabIndex = 0;
            textBoxInfo_FNS.Text = "Дана матрица 5х5\r\n  9    13  -14   23    1\r\n15  -17    21   25    23\r\n-4    29  -20  -10    14\r\n27   33    12    33   -12\r\n18   -9    -5     6     3\r\nСортировать 4-ый столбик в порядке возрастания";
            // 
            // dataGridViewMatrix_FNS
            // 
            dataGridViewMatrix_FNS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_FNS.Location = new Point(319, 13);
            dataGridViewMatrix_FNS.Name = "dataGridViewMatrix_FNS";
            dataGridViewMatrix_FNS.Size = new Size(469, 326);
            dataGridViewMatrix_FNS.TabIndex = 1;
            // 
            // buttonResult_FNS
            // 
            buttonResult_FNS.Location = new Point(561, 403);
            buttonResult_FNS.Name = "buttonResult_FNS";
            buttonResult_FNS.Size = new Size(227, 35);
            buttonResult_FNS.TabIndex = 2;
            buttonResult_FNS.Text = "Выполнить";
            buttonResult_FNS.UseVisualStyleBackColor = true;
            buttonResult_FNS.Click += buttonResult_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonResult_FNS);
            Controls.Add(dataGridViewMatrix_FNS);
            Controls.Add(textBoxInfo_FNS);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_FNS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInfo_FNS;
        private DataGridView dataGridViewMatrix_FNS;
        private Button buttonResult_FNS;
    }
}