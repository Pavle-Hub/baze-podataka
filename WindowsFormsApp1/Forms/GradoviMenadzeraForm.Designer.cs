namespace WindowsFormsApp1.Forms
{
    partial class GradoviMenadzeraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradoviMenadzeraForm));
            listBox1 = new System.Windows.Forms.ListBox();
            DodajGradDugme = new System.Windows.Forms.Button();
            IzbrisiGradDugme = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new System.Drawing.Point(24, 42);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(245, 464);
            listBox1.TabIndex = 0;
            // 
            // DodajGradDugme
            // 
            DodajGradDugme.Location = new System.Drawing.Point(275, 91);
            DodajGradDugme.Name = "DodajGradDugme";
            DodajGradDugme.Size = new System.Drawing.Size(170, 77);
            DodajGradDugme.TabIndex = 1;
            DodajGradDugme.Text = "Dodaj grad";
            DodajGradDugme.UseVisualStyleBackColor = true;
            DodajGradDugme.Click += DodajGradDugme_Click;
            // 
            // IzbrisiGradDugme
            // 
            IzbrisiGradDugme.Location = new System.Drawing.Point(275, 189);
            IzbrisiGradDugme.Name = "IzbrisiGradDugme";
            IzbrisiGradDugme.Size = new System.Drawing.Size(170, 77);
            IzbrisiGradDugme.TabIndex = 2;
            IzbrisiGradDugme.Text = "Izbrisi grad";
            IzbrisiGradDugme.UseVisualStyleBackColor = true;
            IzbrisiGradDugme.Click += IzbrisiGradDugme_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(275, 429);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(170, 77);
            button3.TabIndex = 3;
            button3.Text = "Nazad";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(275, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(170, 27);
            textBox1.TabIndex = 4;
            // 
            // GradoviMenadzeraForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(474, 553);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(IzbrisiGradDugme);
            Controls.Add(DodajGradDugme);
            Controls.Add(listBox1);
            Name = "GradoviMenadzeraForm";
            Text = "GradoviMenadzeraForm";
            Load += GradoviMenadzeraForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button DodajGradDugme;
        private System.Windows.Forms.Button IzbrisiGradDugme;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
    }
}