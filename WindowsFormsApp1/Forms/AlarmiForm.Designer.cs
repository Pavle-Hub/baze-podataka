namespace WindowsFormsApp1.Forms
{
    partial class AlarmiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmiForm));
            listBox1 = new System.Windows.Forms.ListBox();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            dodajAlarmDugme = new System.Windows.Forms.Button();
            izmeniAlarmDugme = new System.Windows.Forms.Button();
            obrisiAlarmDugme = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.Location = new System.Drawing.Point(11, 32);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(321, 544);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox1.MouseDoubleClick += listBox1_MouseDoubleClick;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button2.Location = new System.Drawing.Point(370, 97);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(250, 59);
            button2.TabIndex = 2;
            button2.Text = "Prikaži alarme detekcije pokreta";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button3.Location = new System.Drawing.Point(370, 162);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(250, 59);
            button3.TabIndex = 3;
            button3.Text = "Prikaži ultrazvučne alarme";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            button4.Location = new System.Drawing.Point(370, 519);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(250, 57);
            button4.TabIndex = 4;
            button4.Text = "Nazad";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dodajAlarmDugme
            // 
            dodajAlarmDugme.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dodajAlarmDugme.Location = new System.Drawing.Point(370, 275);
            dodajAlarmDugme.Name = "dodajAlarmDugme";
            dodajAlarmDugme.Size = new System.Drawing.Size(250, 60);
            dodajAlarmDugme.TabIndex = 5;
            dodajAlarmDugme.Text = "Dodaj";
            dodajAlarmDugme.UseVisualStyleBackColor = false;
            dodajAlarmDugme.Click += dodajAlarmDugme_Click;
            // 
            // izmeniAlarmDugme
            // 
            izmeniAlarmDugme.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            izmeniAlarmDugme.Location = new System.Drawing.Point(370, 341);
            izmeniAlarmDugme.Name = "izmeniAlarmDugme";
            izmeniAlarmDugme.Size = new System.Drawing.Size(250, 60);
            izmeniAlarmDugme.TabIndex = 6;
            izmeniAlarmDugme.Text = "Izmeni";
            izmeniAlarmDugme.UseVisualStyleBackColor = false;
            izmeniAlarmDugme.Click += izmeniAlarmDugme_Click;
            // 
            // obrisiAlarmDugme
            // 
            obrisiAlarmDugme.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            obrisiAlarmDugme.Location = new System.Drawing.Point(370, 407);
            obrisiAlarmDugme.Name = "obrisiAlarmDugme";
            obrisiAlarmDugme.Size = new System.Drawing.Size(250, 60);
            obrisiAlarmDugme.TabIndex = 7;
            obrisiAlarmDugme.Text = "Obrisi";
            obrisiAlarmDugme.UseVisualStyleBackColor = false;
            obrisiAlarmDugme.Click += obrisiAlarmDugme_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button1.Location = new System.Drawing.Point(370, 32);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(250, 59);
            button1.TabIndex = 1;
            button1.Text = "Prikaži toplotne alarme";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AlarmiForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(656, 597);
            Controls.Add(obrisiAlarmDugme);
            Controls.Add(izmeniAlarmDugme);
            Controls.Add(dodajAlarmDugme);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "AlarmiForm";
            Text = "AlarmiForm";
            Load += AlarmiForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button dodajAlarmDugme;
        private System.Windows.Forms.Button izmeniAlarmDugme;
        private System.Windows.Forms.Button obrisiAlarmDugme;
        private System.Windows.Forms.Button button1;
    }
}