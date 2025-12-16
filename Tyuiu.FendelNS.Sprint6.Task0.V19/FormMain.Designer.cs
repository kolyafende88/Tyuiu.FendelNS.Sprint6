namespace Tyuiu.FendelNS.Sprint6.Task0.V19
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
            backgroundWorker1_FNS = new System.ComponentModel.BackgroundWorker();
            groupBoxis1_FNS = new GroupBox();
            groupBoxis2_FNS = new GroupBox();
            pictureBoxis_FNS = new PictureBox();
            backgroundWorker2_FNS = new System.ComponentModel.BackgroundWorker();
            buttonis1_FNS = new Button();
            textBoxis1_FNS = new TextBox();
            textBoxis2_FNS = new TextBox();
            groupBoxis_FNS = new GroupBox();
            groupBoxis2_FNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxis_FNS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxis1_FNS
            // 
            groupBoxis1_FNS.Location = new Point(12, 12);
            groupBoxis1_FNS.Name = "groupBoxis1_FNS";
            groupBoxis1_FNS.Size = new Size(200, 19);
            groupBoxis1_FNS.TabIndex = 0;
            groupBoxis1_FNS.TabStop = false;
            groupBoxis1_FNS.Text = "Условие";
            groupBoxis1_FNS.Enter += groupBox1_Enter;
            // 
            // groupBoxis2_FNS
            // 
            groupBoxis2_FNS.Controls.Add(pictureBoxis_FNS);
            groupBoxis2_FNS.Location = new Point(0, 37);
            groupBoxis2_FNS.Name = "groupBoxis2_FNS";
            groupBoxis2_FNS.Size = new Size(428, 217);
            groupBoxis2_FNS.TabIndex = 1;
            groupBoxis2_FNS.TabStop = false;
            groupBoxis2_FNS.Text = "Вычислить по формуле";
            // 
            // pictureBoxis_FNS
            // 
            pictureBoxis_FNS.Image = Properties.Resources.unnamed;
            pictureBoxis_FNS.Location = new Point(12, 56);
            pictureBoxis_FNS.Name = "pictureBoxis_FNS";
            pictureBoxis_FNS.Size = new Size(251, 87);
            pictureBoxis_FNS.TabIndex = 8;
            pictureBoxis_FNS.TabStop = false;
            pictureBoxis_FNS.Click += pictureBoxis_EAD_Click;
            // 
            // buttonis1_FNS
            // 
            buttonis1_FNS.Location = new Point(517, 330);
            buttonis1_FNS.Name = "buttonis1_FNS";
            buttonis1_FNS.Size = new Size(106, 38);
            buttonis1_FNS.TabIndex = 4;
            buttonis1_FNS.Text = "ответ";
            buttonis1_FNS.UseVisualStyleBackColor = true;
            buttonis1_FNS.Click += buttonis1_EAD_Click;
            // 
            // textBoxis1_FNS
            // 
            textBoxis1_FNS.Location = new Point(517, 301);
            textBoxis1_FNS.Name = "textBoxis1_FNS";
            textBoxis1_FNS.Size = new Size(106, 23);
            textBoxis1_FNS.TabIndex = 5;
            // 
            // textBoxis2_FNS
            // 
            textBoxis2_FNS.Location = new Point(225, 330);
            textBoxis2_FNS.Name = "textBoxis2_FNS";
            textBoxis2_FNS.Size = new Size(100, 23);
            textBoxis2_FNS.TabIndex = 6;
            textBoxis2_FNS.TextChanged += textBoxis2_EAD_TextChanged;
            textBoxis2_FNS.KeyPress += textBoxis2_EAD_KeyPress;
            // 
            // groupBoxis_FNS
            // 
            groupBoxis_FNS.Location = new Point(213, 313);
            groupBoxis_FNS.Name = "groupBoxis_FNS";
            groupBoxis_FNS.Size = new Size(122, 11);
            groupBoxis_FNS.TabIndex = 7;
            groupBoxis_FNS.TabStop = false;
            groupBoxis_FNS.Text = "                 X";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 380);
            Controls.Add(groupBoxis_FNS);
            Controls.Add(textBoxis2_FNS);
            Controls.Add(textBoxis1_FNS);
            Controls.Add(buttonis1_FNS);
            Controls.Add(groupBoxis2_FNS);
            Controls.Add(groupBoxis1_FNS);
            Name = "FormMain";
            Text = "Form1";
            KeyPress += X_KeyPress;
            groupBoxis2_FNS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxis_FNS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1_FNS;
        private GroupBox groupBoxis1_FNS;
        private GroupBox groupBoxis2_FNS;
        private PictureBox pictureBoxis_FNS;
        private System.ComponentModel.BackgroundWorker backgroundWorker2_FNS;
        private Button buttonis1_FNS;
        private TextBox textBoxis1_FNS;
        private TextBox textBoxis2_FNS;
        private GroupBox groupBoxis_FNS;
    }
}