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
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button1.Location = new System.Drawing.Point(78, 36);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(150, 150);
            button1.TabIndex = 0;
            button1.Text = "Ekipe";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button2.Location = new System.Drawing.Point(286, 36);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(150, 150);
            button2.TabIndex = 1;
            button2.Text = "Smene";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button3.Location = new System.Drawing.Point(491, 36);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(150, 150);
            button3.TabIndex = 2;
            button3.Text = "Objekti";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button4.Location = new System.Drawing.Point(78, 249);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(150, 150);
            button4.TabIndex = 3;
            button4.Text = "Vozila";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button5.Location = new System.Drawing.Point(286, 249);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(150, 150);
            button5.TabIndex = 4;
            button5.Text = "Regionalni centri";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button6.Location = new System.Drawing.Point(491, 249);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(150, 150);
            button6.TabIndex = 5;
            button6.Text = "Nazad";
            button6.UseVisualStyleBackColor = false;
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
            Controls.Add(button1);
            Name = "OstaloForm";
            Text = "OstaloForm";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}