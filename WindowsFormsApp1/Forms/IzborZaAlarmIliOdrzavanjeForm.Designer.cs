﻿namespace WindowsFormsApp1.Forms
{
    partial class IzborZaAlarmIliOdrzavanjeForm
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
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button1.Location = new System.Drawing.Point(109, 21);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(165, 72);
            button1.TabIndex = 0;
            button1.Text = "Alarm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button2.Location = new System.Drawing.Point(109, 125);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(165, 72);
            button2.TabIndex = 1;
            button2.Text = "Odrzavanje";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button3.Location = new System.Drawing.Point(109, 228);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(165, 72);
            button3.TabIndex = 2;
            button3.Text = "Objekat za alarm";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // IzborZaAlarmIliOdrzavanjeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(380, 323);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "IzborZaAlarmIliOdrzavanjeForm";
            Text = "IzborZaAlarmIliOdrzavanjeForm";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}