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
            dodajSmenu = new System.Windows.Forms.Button();
            izbrisiSmenu = new System.Windows.Forms.Button();
            listBoxSmena = new System.Windows.Forms.ListBox();
            izmeniSmenu = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // dodajSmenu
            // 
            dodajSmenu.Location = new System.Drawing.Point(401, 57);
            dodajSmenu.Name = "dodajSmenu";
            dodajSmenu.Size = new System.Drawing.Size(90, 31);
            dodajSmenu.TabIndex = 0;
            dodajSmenu.Text = "Dodaj";
            dodajSmenu.UseVisualStyleBackColor = true;
            dodajSmenu.Click += dodajSmenu_Click;
            // 
            // izbrisiSmenu
            // 
            izbrisiSmenu.Location = new System.Drawing.Point(401, 110);
            izbrisiSmenu.Name = "izbrisiSmenu";
            izbrisiSmenu.Size = new System.Drawing.Size(90, 26);
            izbrisiSmenu.TabIndex = 1;
            izbrisiSmenu.Text = "Izbrisi";
            izbrisiSmenu.UseVisualStyleBackColor = true;
            izbrisiSmenu.Click += izbrisiSmenu_Click;
            // 
            // listBoxSmena
            // 
            listBoxSmena.FormattingEnabled = true;
            listBoxSmena.ItemHeight = 15;
            listBoxSmena.Location = new System.Drawing.Point(21, 24);
            listBoxSmena.Name = "listBoxSmena";
            listBoxSmena.Size = new System.Drawing.Size(331, 304);
            listBoxSmena.TabIndex = 2;
            listBoxSmena.MouseDoubleClick += listBoxSmena_MouseDoubleClick;
            // 
            // izmeniSmenu
            // 
            izmeniSmenu.Location = new System.Drawing.Point(401, 159);
            izmeniSmenu.Name = "izmeniSmenu";
            izmeniSmenu.Size = new System.Drawing.Size(90, 23);
            izmeniSmenu.TabIndex = 3;
            izmeniSmenu.Text = "Izmeni";
            izmeniSmenu.UseVisualStyleBackColor = true;
            izmeniSmenu.Click += izmeniSmenu_Click;
            // 
            // SmenaForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(532, 375);
            Controls.Add(izmeniSmenu);
            Controls.Add(listBoxSmena);
            Controls.Add(izbrisiSmenu);
            Controls.Add(dodajSmenu);
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
    }
}