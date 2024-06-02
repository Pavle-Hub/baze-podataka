namespace WindowsFormsApp1.Forms
{
    partial class LicaIObjektiZaAlarmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicaIObjektiZaAlarmForm));
            listView1 = new System.Windows.Forms.ListView();
            ColumnMatBr = new System.Windows.Forms.ColumnHeader();
            ColumnIme = new System.Windows.Forms.ColumnHeader();
            ColumnPrezime = new System.Windows.Forms.ColumnHeader();
            ColumnDatum = new System.Windows.Forms.ColumnHeader();
            ColumnPol = new System.Windows.Forms.ColumnHeader();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            listView2 = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { ColumnMatBr, ColumnIme, ColumnPrezime, ColumnDatum, ColumnPol });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new System.Drawing.Point(12, 67);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(707, 244);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            listView1.MouseDoubleClick += listView1_MouseDoubleClick;
            // 
            // ColumnMatBr
            // 
            ColumnMatBr.Text = "Maticni Broj";
            ColumnMatBr.Width = 150;
            // 
            // ColumnIme
            // 
            ColumnIme.Text = "Ime";
            ColumnIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ColumnIme.Width = 150;
            // 
            // ColumnPrezime
            // 
            ColumnPrezime.Text = "Prezime";
            ColumnPrezime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ColumnPrezime.Width = 150;
            // 
            // ColumnDatum
            // 
            ColumnDatum.Text = "Datum Rodjenja";
            ColumnDatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ColumnDatum.Width = 150;
            // 
            // ColumnPol
            // 
            ColumnPol.Text = "Pol";
            ColumnPol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(39, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(344, 28);
            label1.TabIndex = 1;
            label1.Text = "Tehnicka lica koja odrzavaju alarm:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(39, 330);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(340, 28);
            label2.TabIndex = 2;
            label2.Text = "Objekat u kome je ugradjen alarm:";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Location = new System.Drawing.Point(12, 381);
            listView2.Name = "listView2";
            listView2.Size = new System.Drawing.Size(664, 79);
            listView2.TabIndex = 3;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id_Objekta";
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
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Povrsina";
            columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            columnHeader4.Width = 150;
            // 
            // LicaIObjektiZaAlarmForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(731, 539);
            Controls.Add(listView2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "LicaIObjektiZaAlarmForm";
            Text = "LicaIObjektiZaAlarmForm";
            Load += LicaIObjektiZaAlarmForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ColumnMatBr;
        private System.Windows.Forms.ColumnHeader ColumnIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader ColumnPrezime;
        private System.Windows.Forms.ColumnHeader ColumnDatum;
        private System.Windows.Forms.ColumnHeader ColumnPol;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}