// ❌ Было:
// using static System.Net.Mime.MediaTypeNames;

using System.Windows.Forms;
using System.Xml.Linq;

namespace Tyuiu.FendelNS.Sprint6.Task6.V28
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
            pictureBoxProfilePicture_FNS = new PictureBox();
            buttonOk = new Button();
            labelDev_FNS = new Label();
            labelGroup_FNS = new Label();
            labelCSharp_FNS = new Label();
            labelTyuiu_FNS = new Label();
            label1 = new Label();
            labelInternalName_FNS = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfilePicture_FNS).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxProfilePicture_FNS
            // 
            pictureBoxProfilePicture_FNS.Image = Properties.Resources.photo_2025_12_17_04_54_41;
            pictureBoxProfilePicture_FNS.InitialImage = null;
            pictureBoxProfilePicture_FNS.Location = new Point(10, 9);
            pictureBoxProfilePicture_FNS.Margin = new Padding(3, 2, 3, 2);
            pictureBoxProfilePicture_FNS.Name = "pictureBoxProfilePicture_FNS";
            pictureBoxProfilePicture_FNS.Size = new Size(116, 152);
            pictureBoxProfilePicture_FNS.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProfilePicture_FNS.TabIndex = 0;
            pictureBoxProfilePicture_FNS.TabStop = false;
            // 
            // buttonOk
            // 
            buttonOk.FlatStyle = FlatStyle.Flat;
            buttonOk.Location = new Point(386, 139);
            buttonOk.Margin = new Padding(3, 2, 3, 2);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(82, 22);
            buttonOk.TabIndex = 1;
            buttonOk.Text = "Ок";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // labelDev_FNS
            // 
            labelDev_FNS.AutoSize = true;
            labelDev_FNS.Location = new Point(132, 9);
            labelDev_FNS.Name = "labelDev_FNS";
            labelDev_FNS.Size = new Size(159, 15);
            labelDev_FNS.TabIndex = 2;
            labelDev_FNS.Text = "Разработчик: Фендель Н. С.";
            // 
            // labelGroup_FNS
            // 
            labelGroup_FNS.AutoSize = true;
            labelGroup_FNS.Location = new Point(132, 24);
            labelGroup_FNS.Name = "labelGroup_FNS";
            labelGroup_FNS.Size = new Size(123, 15);
            labelGroup_FNS.TabIndex = 3;
            labelGroup_FNS.Text = "группа СМАРТБ-24-1";
            // 
            // labelCSharp_FNS
            // 
            labelCSharp_FNS.AutoSize = true;
            labelCSharp_FNS.Location = new Point(132, 47);
            labelCSharp_FNS.Name = "labelCSharp_FNS";
            labelCSharp_FNS.Size = new Size(303, 15);
            labelCSharp_FNS.TabIndex = 4;
            labelCSharp_FNS.Text = "Программа разработана в рамках изучения языка C#";
            // 
            // labelTyuiu_FNS
            // 
            labelTyuiu_FNS.AutoSize = true;
            labelTyuiu_FNS.Location = new Point(132, 71);
            labelTyuiu_FNS.Name = "labelTyuiu_FNS";
            labelTyuiu_FNS.Size = new Size(282, 15);
            labelTyuiu_FNS.TabIndex = 5;
            labelTyuiu_FNS.Text = "Тюменский индустриальный университет (с) 2024";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 86);
            label1.Name = "label1";
            label1.Size = new Size(264, 15);
            label1.TabIndex = 6;
            label1.Text = "Высшая школа цифровых технологий (с) 2024";
            // 
            // labelInternalName_FNS
            // 
            labelInternalName_FNS.AutoSize = true;
            labelInternalName_FNS.Location = new Point(132, 113);
            labelInternalName_FNS.Name = "labelInternalName_FNS";
            labelInternalName_FNS.Size = new Size(276, 15);
            labelInternalName_FNS.TabIndex = 7;
            labelInternalName_FNS.Text = "Внутреннее имя: Tyuiu.FendelNS.Sprint6.Task6.V28";
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 170);
            Controls.Add(labelInternalName_FNS);
            Controls.Add(label1);
            Controls.Add(labelTyuiu_FNS);
            Controls.Add(labelCSharp_FNS);
            Controls.Add(labelGroup_FNS);
            Controls.Add(labelDev_FNS);
            Controls.Add(buttonOk);
            Controls.Add(pictureBoxProfilePicture_FNS);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfilePicture_FNS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxProfilePicture_FNS;
        private Button buttonOk;
        private Label labelDev_FNS;
        private Label labelGroup_FNS;
        private Label labelCSharp_FNS;
        private Label labelTyuiu_FNS;
        private Label label1;
        private Label labelInternalName_FNS;
    }
}