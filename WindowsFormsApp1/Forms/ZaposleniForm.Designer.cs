namespace WindowsFormsApp1.Forms
{
    partial class ZaposleniForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZaposleniForm));
            listBox1 = new System.Windows.Forms.ListBox();
            listBox2 = new System.Windows.Forms.ListBox();
            listBox3 = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            dodajObezbedjenje = new System.Windows.Forms.Button();
            izmeniObezbedjenje = new System.Windows.Forms.Button();
            izbrisiObezbedjenje = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            button9 = new System.Windows.Forms.Button();
            button10 = new System.Windows.Forms.Button();
            button11 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.Location = new System.Drawing.Point(11, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(387, 224);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            listBox2.FormattingEnabled = true;
            listBox2.Location = new System.Drawing.Point(11, 243);
            listBox2.Name = "listBox2";
            listBox2.Size = new System.Drawing.Size(387, 224);
            listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            listBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            listBox3.FormattingEnabled = true;
            listBox3.Location = new System.Drawing.Point(11, 472);
            listBox3.Name = "listBox3";
            listBox3.Size = new System.Drawing.Size(387, 224);
            listBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(455, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(209, 28);
            label1.TabIndex = 3;
            label1.Text = "Fizicko obezbedjenje";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(495, 243);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(135, 28);
            label2.TabIndex = 4;
            label2.Text = "Tehnicko lice";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(504, 472);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(106, 28);
            label3.TabIndex = 5;
            label3.Text = "Menadzer";
            // 
            // dodajObezbedjenje
            // 
            dodajObezbedjenje.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dodajObezbedjenje.Location = new System.Drawing.Point(517, 44);
            dodajObezbedjenje.Name = "dodajObezbedjenje";
            dodajObezbedjenje.Size = new System.Drawing.Size(94, 35);
            dodajObezbedjenje.TabIndex = 6;
            dodajObezbedjenje.Text = "Dodaj";
            dodajObezbedjenje.UseVisualStyleBackColor = false;
            dodajObezbedjenje.Click += dodajObezbedjenje_Click;
            // 
            // izmeniObezbedjenje
            // 
            izmeniObezbedjenje.BackColor = System.Drawing.SystemColors.ActiveCaption;
            izmeniObezbedjenje.Location = new System.Drawing.Point(517, 85);
            izmeniObezbedjenje.Name = "izmeniObezbedjenje";
            izmeniObezbedjenje.Size = new System.Drawing.Size(94, 35);
            izmeniObezbedjenje.TabIndex = 7;
            izmeniObezbedjenje.Text = "Izmeni";
            izmeniObezbedjenje.UseVisualStyleBackColor = false;
            izmeniObezbedjenje.Click += izmeniObezbedjenje_Click;
            // 
            // izbrisiObezbedjenje
            // 
            izbrisiObezbedjenje.BackColor = System.Drawing.SystemColors.ActiveCaption;
            izbrisiObezbedjenje.Location = new System.Drawing.Point(517, 125);
            izbrisiObezbedjenje.Name = "izbrisiObezbedjenje";
            izbrisiObezbedjenje.Size = new System.Drawing.Size(94, 35);
            izbrisiObezbedjenje.TabIndex = 8;
            izbrisiObezbedjenje.Text = "Izbrisi";
            izbrisiObezbedjenje.UseVisualStyleBackColor = false;
            izbrisiObezbedjenje.Click += izbrisiObezbedjenje_Click;
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button4.Location = new System.Drawing.Point(517, 275);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(94, 35);
            button4.TabIndex = 9;
            button4.Text = "Dodaj";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button5.Location = new System.Drawing.Point(517, 316);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(94, 35);
            button5.TabIndex = 10;
            button5.Text = "Izmeni";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button6.Location = new System.Drawing.Point(517, 357);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(94, 35);
            button6.TabIndex = 11;
            button6.Text = "Obrisi";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button7.Location = new System.Drawing.Point(517, 501);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(94, 35);
            button7.TabIndex = 12;
            button7.Text = "Dodaj";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button8.Location = new System.Drawing.Point(455, 541);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(94, 35);
            button8.TabIndex = 13;
            button8.Text = "Gradovi";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button9.Location = new System.Drawing.Point(584, 541);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(94, 35);
            button9.TabIndex = 14;
            button9.Text = "Izmeni";
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button10.Location = new System.Drawing.Point(517, 583);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(94, 35);
            button10.TabIndex = 15;
            button10.Text = "Izbrisi";
            button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            button11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button11.ForeColor = System.Drawing.SystemColors.ControlText;
            button11.Location = new System.Drawing.Point(455, 636);
            button11.Name = "button11";
            button11.Size = new System.Drawing.Size(223, 49);
            button11.TabIndex = 16;
            button11.Text = "Nazad";
            button11.UseVisualStyleBackColor = false;
            // 
            // ZaposleniForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(731, 925);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(izbrisiObezbedjenje);
            Controls.Add(izmeniObezbedjenje);
            Controls.Add(dodajObezbedjenje);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "ZaposleniForm";
            Text = "ZaposleniForm";
            Load += ZaposleniForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dodajObezbedjenje;
        private System.Windows.Forms.Button izmeniObezbedjenje;
        private System.Windows.Forms.Button izbrisiObezbedjenje;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}