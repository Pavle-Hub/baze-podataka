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
            proslediSmenu.Location = new System.Drawing.Point(90, 205);
            proslediSmenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            proslediSmenu.Name = "proslediSmenu";
            proslediSmenu.Size = new System.Drawing.Size(72, 43);
            proslediSmenu.TabIndex = 0;
            proslediSmenu.Text = "Prosledi";
            proslediSmenu.UseVisualStyleBackColor = true;
            proslediSmenu.Click += ProslediSmenu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(7, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(111, 20);
            label2.TabIndex = 4;
            label2.Text = "Vreme pocetka:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(28, 100);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(90, 20);
            label3.TabIndex = 5;
            label3.Text = "Vreme kraja:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(0, 158);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(121, 20);
            label4.TabIndex = 6;
            label4.Text = "Redni broj ekipe:";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(127, 155);
            textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(125, 27);
            textBox2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePicker1.Location = new System.Drawing.Point(127, 45);
            dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(125, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePicker2.Location = new System.Drawing.Point(127, 95);
            dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(125, 27);
            dateTimePicker2.TabIndex = 10;
            // 
            // dodajSmenuForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(269, 292);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(proslediSmenu);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "dodajSmenuForm";
            Text = "dodajSmenuForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button proslediSmenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}