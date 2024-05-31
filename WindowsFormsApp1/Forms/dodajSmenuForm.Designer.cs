namespace WindowsFormsApp1.Forms
{
    partial class dodajSmenuForm
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
            proslediSmenu = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            SuspendLayout();
            // 
            // proslediSmenu
            // 
            proslediSmenu.Location = new System.Drawing.Point(111, 216);
            proslediSmenu.Name = "proslediSmenu";
            proslediSmenu.Size = new System.Drawing.Size(63, 32);
            proslediSmenu.TabIndex = 0;
            proslediSmenu.Text = "Prosledi";
            proslediSmenu.UseVisualStyleBackColor = true;
            proslediSmenu.Click += ProslediSmenu_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(105, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(110, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(39, 47);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 15);
            label1.TabIndex = 3;
            label1.Text = "ID_Smene:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 93);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(89, 15);
            label2.TabIndex = 4;
            label2.Text = "Vreme pocetka:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(29, 138);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(72, 15);
            label3.TabIndex = 5;
            label3.Text = "Vreme kraja:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 179);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(95, 15);
            label4.TabIndex = 6;
            label4.Text = "Redni broj ekipe:";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(105, 179);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(110, 23);
            textBox2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePicker1.Location = new System.Drawing.Point(105, 93);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(110, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePicker2.Location = new System.Drawing.Point(105, 132);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(110, 23);
            dateTimePicker2.TabIndex = 10;
            // 
            // dodajSmenuForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(283, 260);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(proslediSmenu);
            Name = "dodajSmenuForm";
            Text = "dodajSmenuForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button proslediSmenu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}