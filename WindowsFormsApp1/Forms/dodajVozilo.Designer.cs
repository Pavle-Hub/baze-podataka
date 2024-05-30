namespace WindowsFormsApp1.Forms
{
    partial class dodajVozilo
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
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            textBox5 = new System.Windows.Forms.TextBox();
            datumRodj = new System.Windows.Forms.DateTimePicker();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ProslediMenadzera = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            comboBox2 = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(117, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(124, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(117, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(124, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(117, 67);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(124, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(117, 96);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(124, 23);
            textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(117, 125);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(124, 23);
            textBox5.TabIndex = 7;
            // 
            // datumRodj
            // 
            datumRodj.CustomFormat = "dd. MMM yyyy.";
            datumRodj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            datumRodj.Location = new System.Drawing.Point(229, 217);
            datumRodj.Name = "datumRodj";
            datumRodj.Size = new System.Drawing.Size(124, 23);
            datumRodj.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd. MMM yyyy.";
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new System.Drawing.Point(99, 217);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(124, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // ProslediMenadzera
            // 
            ProslediMenadzera.Location = new System.Drawing.Point(117, 262);
            ProslediMenadzera.Name = "ProslediMenadzera";
            ProslediMenadzera.Size = new System.Drawing.Size(140, 37);
            ProslediMenadzera.TabIndex = 19;
            ProslediMenadzera.Text = "Prosledi";
            ProslediMenadzera.UseVisualStyleBackColor = true;
            ProslediMenadzera.Click += ProslediVozilo_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(11, 223);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(82, 15);
            label6.TabIndex = 23;
            label6.Text = "Datum od-do:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(63, 133);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(33, 15);
            label1.TabIndex = 24;
            label1.Text = "Boja:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(22, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 15);
            label2.TabIndex = 25;
            label2.Text = "Proizvodjac:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(49, 46);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(44, 15);
            label3.TabIndex = 26;
            label3.Text = "Model:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(17, 191);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(79, 15);
            label4.TabIndex = 27;
            label4.Text = "Id reg. centra:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(67, 75);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(26, 15);
            label5.TabIndex = 28;
            label5.Text = "Tip:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(26, 104);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(70, 15);
            label7.TabIndex = 29;
            label7.Text = "Registracija:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(3, 162);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(95, 15);
            label8.TabIndex = 30;
            label8.Text = "Redni broj ekipe:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(117, 159);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(121, 23);
            comboBox1.TabIndex = 31;
            comboBox1.SelectedIndexChanged += VoziloDialog_Load;
            comboBox1.TextUpdate += VoziloDialog_Load;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(117, 188);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(121, 23);
            comboBox2.TabIndex = 32;
            comboBox2.DropDown += comboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox2.SelectionChangeCommitted += comboBox1_SelectedIndexChanged;
            comboBox2.TextUpdate += VoziloDialog_Load;
            comboBox2.SelectedValueChanged += comboBox1_SelectedIndexChanged;
            // 
            // dodajVozilo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(380, 339);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(ProslediMenadzera);
            Controls.Add(dateTimePicker1);
            Controls.Add(datumRodj);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "dodajVozilo";
            Text = "dodajVozilo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DateTimePicker datumRodj;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button ProslediMenadzera;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}