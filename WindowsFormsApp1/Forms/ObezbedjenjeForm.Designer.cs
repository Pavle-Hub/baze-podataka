namespace WindowsFormsApp1.Forms
{
    partial class ObezbedjenjeForm
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
            ProslediObezbedjenje = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox5 = new System.Windows.Forms.TextBox();
            textBox6 = new System.Windows.Forms.TextBox();
            datumRodj = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // ProslediObezbedjenje
            // 
            ProslediObezbedjenje.Location = new System.Drawing.Point(202, 299);
            ProslediObezbedjenje.Name = "ProslediObezbedjenje";
            ProslediObezbedjenje.Size = new System.Drawing.Size(119, 37);
            ProslediObezbedjenje.TabIndex = 0;
            ProslediObezbedjenje.Text = "Prosledi";
            ProslediObezbedjenje.UseVisualStyleBackColor = true;
            ProslediObezbedjenje.Click += ProslediObezbedjenje_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(154, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(154, 65);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(154, 100);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(100, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(154, 182);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(100, 23);
            textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Location = new System.Drawing.Point(154, 261);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(100, 23);
            textBox6.TabIndex = 6;
            // 
            // datumRodj
            // 
            datumRodj.Location = new System.Drawing.Point(154, 222);
            datumRodj.Name = "datumRodj";
            datumRodj.Size = new System.Drawing.Size(100, 23);
            datumRodj.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(74, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 15);
            label1.TabIndex = 8;
            label1.Text = "Maticni broj:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(112, 65);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(30, 15);
            label2.TabIndex = 9;
            label2.Text = "Ime:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(90, 103);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 15);
            label3.TabIndex = 10;
            label3.Text = "Prezime:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(50, 185);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(98, 15);
            label5.TabIndex = 12;
            label5.Text = "Borilacka vestina:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(50, 228);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(92, 15);
            label6.TabIndex = 13;
            label6.Text = "Datum rodjenja:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(50, 264);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(95, 15);
            label7.TabIndex = 14;
            label7.Text = "Redni broj ekipe:";
            label7.Click += label7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(112, 141);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(27, 15);
            label4.TabIndex = 15;
            label4.Text = "Pol:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "M", "Z" });
            comboBox1.Location = new System.Drawing.Point(154, 138);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(121, 23);
            comboBox1.TabIndex = 16;
            // 
            // ObezbedjenjeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(522, 358);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(datumRodj);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(ProslediObezbedjenje);
            Name = "ObezbedjenjeForm";
            Text = "ObezbedjenjeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button ProslediObezbedjenje;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DateTimePicker datumRodj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}