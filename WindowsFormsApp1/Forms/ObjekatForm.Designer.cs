namespace WindowsFormsApp1.Forms
{
    partial class ObjekatForm
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
            listView1 = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            dodajDugme = new System.Windows.Forms.Button();
            izbrisiDugme = new System.Windows.Forms.Button();
            telefoniDugme = new System.Windows.Forms.Button();
            smeneDugme = new System.Windows.Forms.Button();
            alarmDugme = new System.Windows.Forms.Button();
            intervencijeDugme = new System.Windows.Forms.Button();
            nazadDugme = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new System.Drawing.Point(12, 25);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(475, 457);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Adresa";
            columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tip";
            columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Povrsina";
            columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader4.Width = 100;
            // 
            // dodajDugme
            // 
            dodajDugme.Location = new System.Drawing.Point(513, 25);
            dodajDugme.Name = "dodajDugme";
            dodajDugme.Size = new System.Drawing.Size(161, 57);
            dodajDugme.TabIndex = 1;
            dodajDugme.Text = "Dodaj";
            dodajDugme.UseVisualStyleBackColor = true;
            dodajDugme.Click += dodajDugme_Click;
            // 
            // izbrisiDugme
            // 
            izbrisiDugme.Location = new System.Drawing.Point(513, 88);
            izbrisiDugme.Name = "izbrisiDugme";
            izbrisiDugme.Size = new System.Drawing.Size(161, 57);
            izbrisiDugme.TabIndex = 2;
            izbrisiDugme.Text = "Izbrisi";
            izbrisiDugme.UseVisualStyleBackColor = true;
            izbrisiDugme.Click += izbrisiDugme_Click;
            // 
            // telefoniDugme
            // 
            telefoniDugme.Location = new System.Drawing.Point(513, 151);
            telefoniDugme.Name = "telefoniDugme";
            telefoniDugme.Size = new System.Drawing.Size(161, 55);
            telefoniDugme.TabIndex = 3;
            telefoniDugme.Text = "Kontakt telefoni";
            telefoniDugme.UseVisualStyleBackColor = true;
            telefoniDugme.Click += telefoniDugme_Click;
            // 
            // smeneDugme
            // 
            smeneDugme.Location = new System.Drawing.Point(513, 212);
            smeneDugme.Name = "smeneDugme";
            smeneDugme.Size = new System.Drawing.Size(161, 55);
            smeneDugme.TabIndex = 4;
            smeneDugme.Text = "Prikaz smena";
            smeneDugme.UseVisualStyleBackColor = true;
            smeneDugme.Click += smeneDugme_Click;
            // 
            // alarmDugme
            // 
            alarmDugme.Location = new System.Drawing.Point(513, 273);
            alarmDugme.Name = "alarmDugme";
            alarmDugme.Size = new System.Drawing.Size(161, 55);
            alarmDugme.TabIndex = 5;
            alarmDugme.Text = "Prikaz alarma";
            alarmDugme.UseVisualStyleBackColor = true;
            alarmDugme.Click += alarmDugme_Click;
            // 
            // intervencijeDugme
            // 
            intervencijeDugme.Location = new System.Drawing.Point(513, 334);
            intervencijeDugme.Name = "intervencijeDugme";
            intervencijeDugme.Size = new System.Drawing.Size(161, 55);
            intervencijeDugme.TabIndex = 6;
            intervencijeDugme.Text = "Intervencije";
            intervencijeDugme.UseVisualStyleBackColor = true;
            intervencijeDugme.Click += intervencijeDugme_Click;
            // 
            // nazadDugme
            // 
            nazadDugme.Location = new System.Drawing.Point(513, 431);
            nazadDugme.Name = "nazadDugme";
            nazadDugme.Size = new System.Drawing.Size(161, 51);
            nazadDugme.TabIndex = 7;
            nazadDugme.Text = "Nazad";
            nazadDugme.UseVisualStyleBackColor = true;
            nazadDugme.Click += nazadDugme_Click;
            // 
            // ObjekatForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(700, 494);
            Controls.Add(nazadDugme);
            Controls.Add(intervencijeDugme);
            Controls.Add(alarmDugme);
            Controls.Add(smeneDugme);
            Controls.Add(telefoniDugme);
            Controls.Add(izbrisiDugme);
            Controls.Add(dodajDugme);
            Controls.Add(listView1);
            Name = "ObjekatForm";
            Text = "ObjekatForm";
            Load += ObjekatForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button dodajDugme;
        private System.Windows.Forms.Button izbrisiDugme;
        private System.Windows.Forms.Button telefoniDugme;
        private System.Windows.Forms.Button smeneDugme;
        private System.Windows.Forms.Button alarmDugme;
        private System.Windows.Forms.Button intervencijeDugme;
        private System.Windows.Forms.Button nazadDugme;
    }
}