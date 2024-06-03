namespace WindowsFormsApp1.Forms
{
    partial class EkipaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EkipaForm));
            listView1 = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            dodajDugme = new System.Windows.Forms.Button();
            nazadDugme = new System.Windows.Forms.Button();
            obrisiDugme = new System.Windows.Forms.Button();
            smeneDugme = new System.Windows.Forms.Button();
            intervencijeDugme = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new System.Drawing.Point(12, 24);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(565, 473);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.MouseDoubleClick += listView1_MouseDoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Clan1";
            columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Clan2";
            columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Clan3";
            columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Clan4";
            columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader5.Width = 150;
            // 
            // dodajDugme
            // 
            dodajDugme.Location = new System.Drawing.Point(609, 24);
            dodajDugme.Name = "dodajDugme";
            dodajDugme.Size = new System.Drawing.Size(215, 55);
            dodajDugme.TabIndex = 1;
            dodajDugme.Text = "Dodaj";
            dodajDugme.UseVisualStyleBackColor = true;
            dodajDugme.Click += dodajDugme_Click;
            // 
            // nazadDugme
            // 
            nazadDugme.Location = new System.Drawing.Point(609, 442);
            nazadDugme.Name = "nazadDugme";
            nazadDugme.Size = new System.Drawing.Size(215, 55);
            nazadDugme.TabIndex = 2;
            nazadDugme.Text = "Nazad";
            nazadDugme.UseVisualStyleBackColor = true;
            nazadDugme.Click += nazadDugme_Click;
            // 
            // obrisiDugme
            // 
            obrisiDugme.Location = new System.Drawing.Point(609, 85);
            obrisiDugme.Name = "obrisiDugme";
            obrisiDugme.Size = new System.Drawing.Size(215, 55);
            obrisiDugme.TabIndex = 3;
            obrisiDugme.Text = "Obrisi";
            obrisiDugme.UseVisualStyleBackColor = true;
            obrisiDugme.Click += obrisiDugme_Click;
            // 
            // smeneDugme
            // 
            smeneDugme.Location = new System.Drawing.Point(609, 175);
            smeneDugme.Name = "smeneDugme";
            smeneDugme.Size = new System.Drawing.Size(215, 55);
            smeneDugme.TabIndex = 4;
            smeneDugme.Text = "Smene za ekipu";
            smeneDugme.UseVisualStyleBackColor = true;
            smeneDugme.Click += smeneDugme_Click;
            // 
            // intervencijeDugme
            // 
            intervencijeDugme.Location = new System.Drawing.Point(609, 236);
            intervencijeDugme.Name = "intervencijeDugme";
            intervencijeDugme.Size = new System.Drawing.Size(215, 55);
            intervencijeDugme.TabIndex = 5;
            intervencijeDugme.Text = "Intervencije ekipe";
            intervencijeDugme.UseVisualStyleBackColor = true;
            intervencijeDugme.Click += intervencijeDugme_Click;
            // 
            // EkipaForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(856, 509);
            Controls.Add(intervencijeDugme);
            Controls.Add(smeneDugme);
            Controls.Add(obrisiDugme);
            Controls.Add(nazadDugme);
            Controls.Add(dodajDugme);
            Controls.Add(listView1);
            Name = "EkipaForm";
            Text = "EkipaForm";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button dodajDugme;
        private System.Windows.Forms.Button nazadDugme;
        private System.Windows.Forms.Button obrisiDugme;
        private System.Windows.Forms.Button smeneDugme;
        private System.Windows.Forms.Button intervencijeDugme;
    }
}