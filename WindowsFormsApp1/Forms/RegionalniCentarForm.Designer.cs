namespace WindowsFormsApp1.Forms
{
    partial class RegionalniCentarForm
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
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            dodajDugme = new System.Windows.Forms.Button();
            izbrisiDugme = new System.Windows.Forms.Button();
            nazadDugme = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader5, columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new System.Drawing.Point(12, 25);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(568, 314);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "ID";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Adresa";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Maticni broj menadzera";
            columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ime menadzera";
            columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Prezime menadzera";
            columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader4.Width = 100;
            // 
            // dodajDugme
            // 
            dodajDugme.Location = new System.Drawing.Point(599, 25);
            dodajDugme.Name = "dodajDugme";
            dodajDugme.Size = new System.Drawing.Size(149, 49);
            dodajDugme.TabIndex = 1;
            dodajDugme.Text = "Dodaj";
            dodajDugme.UseVisualStyleBackColor = true;
            dodajDugme.Click += dodajDugme_Click;
            // 
            // izbrisiDugme
            // 
            izbrisiDugme.Location = new System.Drawing.Point(599, 80);
            izbrisiDugme.Name = "izbrisiDugme";
            izbrisiDugme.Size = new System.Drawing.Size(149, 49);
            izbrisiDugme.TabIndex = 2;
            izbrisiDugme.Text = "Izbrisi";
            izbrisiDugme.UseVisualStyleBackColor = true;
            izbrisiDugme.Click += izbrisiDugme_Click;
            // 
            // nazadDugme
            // 
            nazadDugme.Location = new System.Drawing.Point(599, 290);
            nazadDugme.Name = "nazadDugme";
            nazadDugme.Size = new System.Drawing.Size(149, 49);
            nazadDugme.TabIndex = 3;
            nazadDugme.Text = "Nazad";
            nazadDugme.UseVisualStyleBackColor = true;
            nazadDugme.Click += nazadDugme_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(599, 176);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(149, 73);
            button2.TabIndex = 5;
            button2.Text = "Informacije o regionalnom centru";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // RegionalniCentarForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(759, 362);
            Controls.Add(button2);
            Controls.Add(nazadDugme);
            Controls.Add(izbrisiDugme);
            Controls.Add(dodajDugme);
            Controls.Add(listView1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "RegionalniCentarForm";
            Text = "RegionalniCentarForm";
            Load += RegionalniCentarForm_Load;
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
        private System.Windows.Forms.Button nazadDugme;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}