namespace WindowsFormsApp1.Forms
{
    partial class VoziloForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoziloForm));
            listBox1 = new System.Windows.Forms.ListBox();
            dodajVozilo = new System.Windows.Forms.Button();
            izmeniVozilo = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            izbrisiVozilo = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.Location = new System.Drawing.Point(14, 195);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(619, 304);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox1.MouseDoubleClick += listBox1_MouseDoubleClick;
            // 
            // dodajVozilo
            // 
            dodajVozilo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dodajVozilo.Location = new System.Drawing.Point(14, 29);
            dodajVozilo.Name = "dodajVozilo";
            dodajVozilo.Size = new System.Drawing.Size(130, 113);
            dodajVozilo.TabIndex = 7;
            dodajVozilo.Text = "Dodaj";
            dodajVozilo.UseVisualStyleBackColor = false;
            dodajVozilo.Click += dodajVozilo_Click;
            // 
            // izmeniVozilo
            // 
            izmeniVozilo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            izmeniVozilo.Location = new System.Drawing.Point(150, 29);
            izmeniVozilo.Name = "izmeniVozilo";
            izmeniVozilo.Size = new System.Drawing.Size(138, 113);
            izmeniVozilo.TabIndex = 8;
            izmeniVozilo.Text = "Izmeni";
            izmeniVozilo.UseVisualStyleBackColor = false;
            izmeniVozilo.Click += izmeniVozilo_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            button1.Location = new System.Drawing.Point(442, 50);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(191, 71);
            button1.TabIndex = 10;
            button1.Text = "nazad";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // izbrisiVozilo
            // 
            izbrisiVozilo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            izbrisiVozilo.ForeColor = System.Drawing.SystemColors.ControlText;
            izbrisiVozilo.Location = new System.Drawing.Point(294, 29);
            izbrisiVozilo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            izbrisiVozilo.Name = "izbrisiVozilo";
            izbrisiVozilo.Size = new System.Drawing.Size(130, 113);
            izbrisiVozilo.TabIndex = 11;
            izbrisiVozilo.Text = "izbrisi";
            izbrisiVozilo.UseVisualStyleBackColor = false;
            izbrisiVozilo.Click += izbrisiVozilo_Click_1;
            // 
            // VoziloForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(647, 508);
            Controls.Add(izbrisiVozilo);
            Controls.Add(button1);
            Controls.Add(izmeniVozilo);
            Controls.Add(dodajVozilo);
            Controls.Add(listBox1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "VoziloForm";
            Text = "VoziloForm";
            Load += VoziloForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button dodajVozilo;
        private System.Windows.Forms.Button izmeniVozilo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button izbrisiVozilo;
    }
}