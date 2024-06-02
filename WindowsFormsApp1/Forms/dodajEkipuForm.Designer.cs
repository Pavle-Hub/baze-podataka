namespace WindowsFormsApp1.Forms
{
    partial class dodajEkipuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dodajEkipuForm));
            comboBox1 = new System.Windows.Forms.ComboBox();
            comboBox2 = new System.Windows.Forms.ComboBox();
            comboBox3 = new System.Windows.Forms.ComboBox();
            comboBox4 = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            dodajEkipuDugme = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(12, 107);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(192, 107);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(151, 28);
            comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new System.Drawing.Point(374, 107);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new System.Drawing.Size(151, 28);
            comboBox3.TabIndex = 2;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new System.Drawing.Point(554, 107);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new System.Drawing.Size(151, 28);
            comboBox4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(64, 84);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "Clan 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(242, 84);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 20);
            label2.TabIndex = 5;
            label2.Text = "Clan 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(419, 84);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(50, 20);
            label3.TabIndex = 6;
            label3.Text = "Clan 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(604, 84);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "Clan 4";
            // 
            // dodajEkipuDugme
            // 
            dodajEkipuDugme.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dodajEkipuDugme.Location = new System.Drawing.Point(275, 177);
            dodajEkipuDugme.Name = "dodajEkipuDugme";
            dodajEkipuDugme.Size = new System.Drawing.Size(159, 57);
            dodajEkipuDugme.TabIndex = 8;
            dodajEkipuDugme.Text = "Dodaj";
            dodajEkipuDugme.UseVisualStyleBackColor = false;
            dodajEkipuDugme.Click += dodajEkipuDugme_Click;
            // 
            // dodajEkipuForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(717, 270);
            Controls.Add(dodajEkipuDugme);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "dodajEkipuForm";
            Text = "dodajEkipuForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button dodajEkipuDugme;
    }
}