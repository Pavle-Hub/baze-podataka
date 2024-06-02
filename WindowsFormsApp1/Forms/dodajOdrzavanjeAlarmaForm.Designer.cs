namespace WindowsFormsApp1.Forms
{
    partial class dodajOdrzavanjeAlarmaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dodajOdrzavanjeAlarmaForm));
            textBox1 = new System.Windows.Forms.TextBox();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            proslediDugme = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(116, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(150, 27);
            textBox1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd. MMM yyyy.";
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new System.Drawing.Point(12, 134);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(150, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd. MMM yyyy.";
            dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new System.Drawing.Point(210, 134);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(150, 27);
            dateTimePicker2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            label1.Location = new System.Drawing.Point(98, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(188, 20);
            label1.TabIndex = 4;
            label1.Text = "Maticni broj tehnickog lica:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(259, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(0, 20);
            label2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            label3.Location = new System.Drawing.Point(46, 111);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 20);
            label3.TabIndex = 6;
            label3.Text = "Datum od:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            label4.Location = new System.Drawing.Point(247, 111);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(79, 20);
            label4.TabIndex = 7;
            label4.Text = "Datum do:";
            // 
            // proslediDugme
            // 
            proslediDugme.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            proslediDugme.Location = new System.Drawing.Point(116, 182);
            proslediDugme.Name = "proslediDugme";
            proslediDugme.Size = new System.Drawing.Size(150, 52);
            proslediDugme.TabIndex = 8;
            proslediDugme.Text = "Prosledi";
            proslediDugme.UseVisualStyleBackColor = false;
            proslediDugme.Click += proslediDugme_Click;
            // 
            // dodajOdrzavanjeAlarmaForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(382, 269);
            Controls.Add(proslediDugme);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Name = "dodajOdrzavanjeAlarmaForm";
            Text = "dodajOdrzavanjeAlarmaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button proslediDugme;
    }
}