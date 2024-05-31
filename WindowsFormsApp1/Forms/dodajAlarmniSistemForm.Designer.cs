namespace WindowsFormsApp1.Forms
{
    partial class dodajAlarmniSistemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dodajAlarmniSistemForm));
            checkBox1 = new System.Windows.Forms.CheckBox();
            checkBox2 = new System.Windows.Forms.CheckBox();
            checkBox3 = new System.Windows.Forms.CheckBox();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            textBox5 = new System.Windows.Forms.TextBox();
            textBox6 = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            textBox7 = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(222, 210);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(172, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Ultrazvucnicni Senzor";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new System.Drawing.Point(222, 240);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(214, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Detektor Toplotnog Odraza";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new System.Drawing.Point(222, 270);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new System.Drawing.Size(142, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Detektor Pokreta";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(222, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(136, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(222, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(136, 27);
            textBox2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd. MMM yyyy.";
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new System.Drawing.Point(222, 155);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(136, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(91, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(89, 20);
            label1.TabIndex = 6;
            label1.Text = "Proizvodjac:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(37, 95);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(143, 20);
            label2.TabIndex = 7;
            label2.Text = "Godina proizvodnje:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(53, 160);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(127, 20);
            label3.TabIndex = 8;
            label3.Text = "Datum instalacije:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(25, 237);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(155, 20);
            label4.TabIndex = 9;
            label4.Text = "Tip alarmnog sistema:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(91, 331);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(105, 23);
            label5.TabIndex = 10;
            label5.Text = "Ultrazvucni:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(355, 331);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(81, 23);
            label6.TabIndex = 11;
            label6.Text = "Toplotni:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(569, 331);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(155, 23);
            label7.TabIndex = 12;
            label7.Text = "Detektor pokreta:";
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(80, 404);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(125, 27);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(80, 486);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(125, 27);
            textBox4.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(91, 381);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(109, 20);
            label8.TabIndex = 15;
            label8.Text = "Min frekvencija";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(88, 463);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(112, 20);
            label9.TabIndex = 16;
            label9.Text = "Max frekvencija";
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(332, 404);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(125, 27);
            textBox5.TabIndex = 17;
            // 
            // textBox6
            // 
            textBox6.Location = new System.Drawing.Point(332, 486);
            textBox6.Name = "textBox6";
            textBox6.Size = new System.Drawing.Size(125, 27);
            textBox6.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(311, 381);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(163, 20);
            label10.TabIndex = 19;
            label10.Text = "Horizontalna rezolucija";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(332, 463);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(142, 20);
            label11.TabIndex = 20;
            label11.Text = "Vertikalna rezolucija";
            // 
            // textBox7
            // 
            textBox7.Location = new System.Drawing.Point(583, 433);
            textBox7.Name = "textBox7";
            textBox7.Size = new System.Drawing.Size(125, 27);
            textBox7.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(605, 411);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(78, 20);
            label12.TabIndex = 22;
            label12.Text = "Osetljivost";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button1.Location = new System.Drawing.Point(527, 37);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(181, 96);
            button1.TabIndex = 23;
            button1.Text = "Prosledi";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button2.Location = new System.Drawing.Point(527, 160);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(181, 61);
            button2.TabIndex = 24;
            button2.Text = "Nazad";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dodajAlarmniSistemForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(817, 568);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label12);
            Controls.Add(textBox7);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "dodajAlarmniSistemForm";
            Text = "dodajAlarmniSistemForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}