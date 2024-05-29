namespace WindowsFormsApp1.Forms
{
    partial class dodajMenadzeraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dodajMenadzeraForm));
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            datumRodj = new System.Windows.Forms.DateTimePicker();
            comboBox1 = new System.Windows.Forms.ComboBox();
            ProslediMenadzera = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(163, 60);
            textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(141, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(163, 116);
            textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(141, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(163, 176);
            textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(141, 27);
            textBox3.TabIndex = 4;
            // 
            // datumRodj
            // 
            datumRodj.CustomFormat = "dd. MMM yyyy.";
            datumRodj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            datumRodj.Location = new System.Drawing.Point(163, 238);
            datumRodj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            datumRodj.Name = "datumRodj";
            datumRodj.Size = new System.Drawing.Size(141, 27);
            datumRodj.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "M", "Z" });
            comboBox1.Location = new System.Drawing.Point(163, 304);
            comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(141, 28);
            comboBox1.TabIndex = 17;
            // 
            // ProslediMenadzera
            // 
            ProslediMenadzera.Location = new System.Drawing.Point(128, 388);
            ProslediMenadzera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ProslediMenadzera.Name = "ProslediMenadzera";
            ProslediMenadzera.Size = new System.Drawing.Size(136, 49);
            ProslediMenadzera.TabIndex = 18;
            ProslediMenadzera.Text = "Prosledi";
            ProslediMenadzera.UseVisualStyleBackColor = true;
            ProslediMenadzera.Click += ProslediMenadzera_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(40, 63);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 20);
            label1.TabIndex = 19;
            label1.Text = "Maticni broj:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(95, 119);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(37, 20);
            label2.TabIndex = 20;
            label2.Text = "Ime:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(67, 179);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(65, 20);
            label3.TabIndex = 21;
            label3.Text = "Prezime:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(16, 243);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(116, 20);
            label6.TabIndex = 22;
            label6.Text = "Datum rodjenja:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(100, 307);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(32, 20);
            label4.TabIndex = 23;
            label4.Text = "Pol:";
            // 
            // dodajMenadzeraForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(394, 477);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ProslediMenadzera);
            Controls.Add(comboBox1);
            Controls.Add(datumRodj);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "dodajMenadzeraForm";
            Text = "dodajMenadzeraForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker datumRodj;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ProslediMenadzera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}