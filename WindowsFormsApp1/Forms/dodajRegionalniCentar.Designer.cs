namespace WindowsFormsApp1.Forms
{
    partial class dodajRegionalniCentar
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
            textBox1 = new System.Windows.Forms.TextBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(29, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(225, 27);
            textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(29, 175);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(225, 28);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(114, 63);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(55, 20);
            label1.TabIndex = 2;
            label1.Text = "Adresa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(103, 152);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "Menadzer";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(67, 245);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(140, 57);
            button1.TabIndex = 4;
            button1.Text = "Prosledi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dodajRegionalniCentar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(295, 343);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Name = "dodajRegionalniCentar";
            Text = "dodajRegionalniCentar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}