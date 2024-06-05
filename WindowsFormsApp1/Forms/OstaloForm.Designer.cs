namespace WindowsFormsApp1.Forms
{
    partial class OstaloForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OstaloForm));
            prikaziEkipe = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // prikaziEkipe
            // 
            prikaziEkipe.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            prikaziEkipe.Location = new System.Drawing.Point(78, 36);
            prikaziEkipe.Name = "prikaziEkipe";
            prikaziEkipe.Size = new System.Drawing.Size(150, 149);
            prikaziEkipe.TabIndex = 0;
            prikaziEkipe.Text = "Ekipe";
            prikaziEkipe.UseVisualStyleBackColor = false;
            prikaziEkipe.Click += prikaziEkipe_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button2.Location = new System.Drawing.Point(286, 36);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(150, 149);
            button2.TabIndex = 1;
            button2.Text = "Smene";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button3.Location = new System.Drawing.Point(491, 36);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(150, 149);
            button3.TabIndex = 2;
            button3.Text = "Objekti";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button4.Location = new System.Drawing.Point(78, 249);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(150, 149);
            button4.TabIndex = 3;
            button4.Text = "Vozila";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button5.Location = new System.Drawing.Point(286, 249);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(150, 149);
            button5.TabIndex = 4;
            button5.Text = "Regionalni centri";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button6.Location = new System.Drawing.Point(491, 249);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(150, 149);
            button6.TabIndex = 5;
            button6.Text = "Nazad";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // OstaloForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(717, 463);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(prikaziEkipe);
            Name = "OstaloForm";
            Text = "OstaloForm";
            Load += OstaloForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button prikaziEkipe;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}