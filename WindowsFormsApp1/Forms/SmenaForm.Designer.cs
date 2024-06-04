namespace WindowsFormsApp1.Forms
{
    partial class SmenaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmenaForm));
            dodajSmenu = new System.Windows.Forms.Button();
            izbrisiSmenu = new System.Windows.Forms.Button();
            listBoxSmena = new System.Windows.Forms.ListBox();
            izmeniSmenu = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // dodajSmenu
            // 
            dodajSmenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dodajSmenu.Location = new System.Drawing.Point(398, 43);
            dodajSmenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dodajSmenu.Name = "dodajSmenu";
            dodajSmenu.Size = new System.Drawing.Size(178, 56);
            dodajSmenu.TabIndex = 0;
            dodajSmenu.Text = "Dodaj";
            dodajSmenu.UseVisualStyleBackColor = false;
            dodajSmenu.Click += dodajSmenu_Click;
            // 
            // izbrisiSmenu
            // 
            izbrisiSmenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            izbrisiSmenu.Location = new System.Drawing.Point(398, 107);
            izbrisiSmenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            izbrisiSmenu.Name = "izbrisiSmenu";
            izbrisiSmenu.Size = new System.Drawing.Size(178, 56);
            izbrisiSmenu.TabIndex = 1;
            izbrisiSmenu.Text = "Izbrisi";
            izbrisiSmenu.UseVisualStyleBackColor = false;
            izbrisiSmenu.Click += izbrisiSmenu_Click;
            // 
            // listBoxSmena
            // 
            listBoxSmena.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            listBoxSmena.FormattingEnabled = true;
            listBoxSmena.Location = new System.Drawing.Point(24, 32);
            listBoxSmena.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listBoxSmena.Name = "listBoxSmena";
            listBoxSmena.Size = new System.Drawing.Size(354, 424);
            listBoxSmena.TabIndex = 2;
            listBoxSmena.MouseDoubleClick += listBoxSmena_MouseDoubleClick;
            // 
            // izmeniSmenu
            // 
            izmeniSmenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            izmeniSmenu.Location = new System.Drawing.Point(398, 171);
            izmeniSmenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            izmeniSmenu.Name = "izmeniSmenu";
            izmeniSmenu.Size = new System.Drawing.Size(178, 56);
            izmeniSmenu.TabIndex = 3;
            izmeniSmenu.Text = "Izmeni";
            izmeniSmenu.UseVisualStyleBackColor = false;
            izmeniSmenu.Click += izmeniSmenu_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button1.Location = new System.Drawing.Point(398, 400);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(178, 56);
            button1.TabIndex = 4;
            button1.Text = "Nazad";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SmenaForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(608, 500);
            Controls.Add(button1);
            Controls.Add(izmeniSmenu);
            Controls.Add(listBoxSmena);
            Controls.Add(izbrisiSmenu);
            Controls.Add(dodajSmenu);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "SmenaForm";
            Text = "SmenaForm";
            Load += SmenaForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button dodajSmenu;
        private System.Windows.Forms.Button izbrisiSmenu;
        private System.Windows.Forms.ListBox listBoxSmena;
        private System.Windows.Forms.Button izmeniSmenu;
        private System.Windows.Forms.Button button1;
    }
}