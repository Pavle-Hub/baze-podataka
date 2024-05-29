namespace WindowsFormsApp1.Forms
{
    partial class dodajTehnickoLiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dodajTehnickoLiceForm));
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            textBox5 = new System.Windows.Forms.TextBox();
            textBox6 = new System.Windows.Forms.TextBox();
            ProslediTehickoLice = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(151, 74);
            textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(136, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(151, 122);
            textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(136, 27);
            textBox3.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "M", "Z" });
            comboBox1.Location = new System.Drawing.Point(151, 171);
            comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(136, 28);
            comboBox1.TabIndex = 17;
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(151, 327);
            textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(136, 27);
            textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            textBox6.Location = new System.Drawing.Point(151, 272);
            textBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(136, 27);
            textBox6.TabIndex = 19;
            // 
            // ProslediTehickoLice
            // 
            ProslediTehickoLice.Location = new System.Drawing.Point(141, 387);
            ProslediTehickoLice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ProslediTehickoLice.Name = "ProslediTehickoLice";
            ProslediTehickoLice.Size = new System.Drawing.Size(136, 49);
            ProslediTehickoLice.TabIndex = 20;
            ProslediTehickoLice.Text = "Prosledi";
            ProslediTehickoLice.UseVisualStyleBackColor = true;
            ProslediTehickoLice.Click += ProslediTehickoLice_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(47, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 20);
            label1.TabIndex = 21;
            label1.Text = "Maticni broj:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(94, 77);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(37, 20);
            label2.TabIndex = 22;
            label2.Text = "Ime:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(74, 125);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(65, 20);
            label3.TabIndex = 23;
            label3.Text = "Prezime:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd. MMM yyyy.";
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new System.Drawing.Point(151, 221);
            dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(136, 27);
            dateTimePicker1.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(99, 174);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(32, 20);
            label4.TabIndex = 25;
            label4.Text = "Pol:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(25, 275);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(114, 20);
            label5.TabIndex = 26;
            label5.Text = "Strucna sprema:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(29, 226);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(116, 20);
            label6.TabIndex = 26;
            label6.Text = "Datum rodjenja:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(32, 330);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(107, 20);
            label7.TabIndex = 27;
            label7.Text = "Oblast tehnike:";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(151, 25);
            textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(136, 27);
            textBox1.TabIndex = 28;
            // 
            // dodajTehnickoLiceForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(394, 477);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ProslediTehickoLice);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "dodajTehnickoLiceForm";
            Text = "dodajTehnickoLiceForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button ProslediTehickoLice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
    }
}