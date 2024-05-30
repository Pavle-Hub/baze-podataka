namespace WindowsFormsApp1.Forms
{
    partial class AlarmiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmiForm));
            listBox1 = new System.Windows.Forms.ListBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new System.Drawing.Point(10, 24);
            listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(281, 334);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button1.Location = new System.Drawing.Point(324, 24);
            button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(219, 44);
            button1.TabIndex = 1;
            button1.Text = "Prikaži toplotne alarme";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button2.Location = new System.Drawing.Point(324, 104);
            button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(219, 44);
            button2.TabIndex = 2;
            button2.Text = "Prikaži alarme detekcije pokreta";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button3.Location = new System.Drawing.Point(324, 182);
            button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(219, 44);
            button3.TabIndex = 3;
            button3.Text = "Prikaži ultrazvučne alarme";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            button4.Location = new System.Drawing.Point(324, 297);
            button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(219, 60);
            button4.TabIndex = 4;
            button4.Text = "Nazad";
            button4.UseVisualStyleBackColor = false;
            // 
            // AlarmiForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(574, 378);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "AlarmiForm";
            Text = "AlarmiForm";
            Load += AlarmiForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}