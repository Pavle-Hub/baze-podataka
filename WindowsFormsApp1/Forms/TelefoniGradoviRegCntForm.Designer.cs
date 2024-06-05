namespace WindowsFormsApp1.Forms
{
    partial class TelefoniGradoviRegCntForm
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
            listView2 = new System.Windows.Forms.ListView();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            dodajGradDugme = new System.Windows.Forms.Button();
            izbrisiGradDugme = new System.Windows.Forms.Button();
            izbrisiBrojDugme = new System.Windows.Forms.Button();
            dodajBrojDugme = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            nazadDugme = new System.Windows.Forms.Button();
            listView3 = new System.Windows.Forms.ListView();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new System.Drawing.Point(12, 39);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(206, 255);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ime grada";
            columnHeader1.Width = 200;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader2 });
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Location = new System.Drawing.Point(12, 328);
            listView2.Name = "listView2";
            listView2.Size = new System.Drawing.Size(206, 255);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Telefonski broj";
            columnHeader2.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(12, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(374, 28);
            label1.TabIndex = 2;
            label1.Text = "Lista svih gradova regionalnog centra:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(12, 297);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(480, 28);
            label2.TabIndex = 3;
            label2.Text = "Lista svih telefonskih brojeva regionalnog centra:";
            // 
            // dodajGradDugme
            // 
            dodajGradDugme.Location = new System.Drawing.Point(259, 90);
            dodajGradDugme.Name = "dodajGradDugme";
            dodajGradDugme.Size = new System.Drawing.Size(195, 59);
            dodajGradDugme.TabIndex = 4;
            dodajGradDugme.Text = "Dodaj grad";
            dodajGradDugme.UseVisualStyleBackColor = true;
            dodajGradDugme.Click += dodajGradDugme_Click;
            // 
            // izbrisiGradDugme
            // 
            izbrisiGradDugme.Location = new System.Drawing.Point(259, 155);
            izbrisiGradDugme.Name = "izbrisiGradDugme";
            izbrisiGradDugme.Size = new System.Drawing.Size(195, 59);
            izbrisiGradDugme.TabIndex = 5;
            izbrisiGradDugme.Text = "Izbrisi grad";
            izbrisiGradDugme.UseVisualStyleBackColor = true;
            izbrisiGradDugme.Click += izbrisiGradDugme_Click;
            // 
            // izbrisiBrojDugme
            // 
            izbrisiBrojDugme.Location = new System.Drawing.Point(259, 435);
            izbrisiBrojDugme.Name = "izbrisiBrojDugme";
            izbrisiBrojDugme.Size = new System.Drawing.Size(195, 62);
            izbrisiBrojDugme.TabIndex = 6;
            izbrisiBrojDugme.Text = "Izbrisi broj";
            izbrisiBrojDugme.UseVisualStyleBackColor = true;
            izbrisiBrojDugme.Click += izbrisiBrojDugme_Click;
            // 
            // dodajBrojDugme
            // 
            dodajBrojDugme.Location = new System.Drawing.Point(259, 370);
            dodajBrojDugme.Name = "dodajBrojDugme";
            dodajBrojDugme.Size = new System.Drawing.Size(195, 59);
            dodajBrojDugme.TabIndex = 7;
            dodajBrojDugme.Text = "Dodaj broj";
            dodajBrojDugme.UseVisualStyleBackColor = true;
            dodajBrojDugme.Click += dodajBrojDugme_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(259, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(195, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(259, 337);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(195, 27);
            textBox2.TabIndex = 9;
            // 
            // nazadDugme
            // 
            nazadDugme.Location = new System.Drawing.Point(288, 826);
            nazadDugme.Name = "nazadDugme";
            nazadDugme.Size = new System.Drawing.Size(141, 46);
            nazadDugme.TabIndex = 10;
            nazadDugme.Text = "Nazad";
            nazadDugme.UseVisualStyleBackColor = true;
            nazadDugme.Click += nazadDugme_Click;
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader3 });
            listView3.FullRowSelect = true;
            listView3.GridLines = true;
            listView3.Location = new System.Drawing.Point(12, 617);
            listView3.Name = "listView3";
            listView3.Size = new System.Drawing.Size(206, 255);
            listView3.TabIndex = 11;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Registarske oznake";
            columnHeader3.Width = 200;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(12, 586);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(353, 28);
            label3.TabIndex = 12;
            label3.Text = "Lista svih vozila regionalnog centra:";
            // 
            // TelefoniGradoviRegCntForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(491, 911);
            Controls.Add(label3);
            Controls.Add(listView3);
            Controls.Add(nazadDugme);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dodajBrojDugme);
            Controls.Add(izbrisiBrojDugme);
            Controls.Add(izbrisiGradDugme);
            Controls.Add(dodajGradDugme);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Name = "TelefoniGradoviRegCntForm";
            Text = "TelefoniGradoviRegCntForm";
            Load += TelefoniGradoviRegCntForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button dodajGradDugme;
        private System.Windows.Forms.Button izbrisiGradDugme;
        private System.Windows.Forms.Button izbrisiBrojDugme;
        private System.Windows.Forms.Button dodajBrojDugme;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button nazadDugme;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label3;
    }
}