namespace Święta
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.TreePanel = new System.Windows.Forms.Panel();
            this.SnowManPanel = new System.Windows.Forms.Panel();
            this.ReindeerPanel = new System.Windows.Forms.Panel();
            this.SantaPanel = new System.Windows.Forms.Panel();
            this.GiftsPanel = new System.Windows.Forms.Panel();
            this.BearPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(923, 540);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(8, 618);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kliknięty element:";
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.MessageLabel.Location = new System.Drawing.Point(11, 654);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(301, 24);
            this.MessageLabel.TabIndex = 3;
            this.MessageLabel.Text = "Nie wybranego żadnego elementu";
            // 
            // TreePanel
            // 
            this.TreePanel.BackColor = System.Drawing.Color.Transparent;
            this.TreePanel.Location = new System.Drawing.Point(69, 43);
            this.TreePanel.Name = "TreePanel";
            this.TreePanel.Size = new System.Drawing.Size(187, 331);
            this.TreePanel.TabIndex = 4;
            this.TreePanel.Click += new System.EventHandler(this.TreePanel_Click_1);
            // 
            // SnowManPanel
            // 
            this.SnowManPanel.BackColor = System.Drawing.Color.Transparent;
            this.SnowManPanel.ForeColor = System.Drawing.Color.Transparent;
            this.SnowManPanel.Location = new System.Drawing.Point(312, 259);
            this.SnowManPanel.Name = "SnowManPanel";
            this.SnowManPanel.Size = new System.Drawing.Size(134, 186);
            this.SnowManPanel.TabIndex = 5;
            this.SnowManPanel.Click += new System.EventHandler(this.SnowManPanel_Click);
            // 
            // ReindeerPanel
            // 
            this.ReindeerPanel.BackColor = System.Drawing.Color.Transparent;
            this.ReindeerPanel.Location = new System.Drawing.Point(456, 103);
            this.ReindeerPanel.Name = "ReindeerPanel";
            this.ReindeerPanel.Size = new System.Drawing.Size(246, 229);
            this.ReindeerPanel.TabIndex = 6;
            this.ReindeerPanel.Click += new System.EventHandler(this.ReindeerPanel_Click);
            // 
            // SantaPanel
            // 
            this.SantaPanel.BackColor = System.Drawing.Color.Transparent;
            this.SantaPanel.Location = new System.Drawing.Point(701, 188);
            this.SantaPanel.Name = "SantaPanel";
            this.SantaPanel.Size = new System.Drawing.Size(137, 395);
            this.SantaPanel.TabIndex = 7;
            this.SantaPanel.Click += new System.EventHandler(this.SantaPanel_Click);
            // 
            // GiftsPanel
            // 
            this.GiftsPanel.BackColor = System.Drawing.Color.Transparent;
            this.GiftsPanel.Location = new System.Drawing.Point(237, 435);
            this.GiftsPanel.Name = "GiftsPanel";
            this.GiftsPanel.Size = new System.Drawing.Size(354, 148);
            this.GiftsPanel.TabIndex = 8;
            this.GiftsPanel.Click += new System.EventHandler(this.GiftsPanel_Click);
            // 
            // BearPanel
            // 
            this.BearPanel.BackColor = System.Drawing.Color.Transparent;
            this.BearPanel.Location = new System.Drawing.Point(89, 435);
            this.BearPanel.Name = "BearPanel";
            this.BearPanel.Size = new System.Drawing.Size(123, 148);
            this.BearPanel.TabIndex = 9;
            this.BearPanel.Click += new System.EventHandler(this.BearPanel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 710);
            this.Controls.Add(this.BearPanel);
            this.Controls.Add(this.GiftsPanel);
            this.Controls.Add(this.SantaPanel);
            this.Controls.Add(this.ReindeerPanel);
            this.Controls.Add(this.SnowManPanel);
            this.Controls.Add(this.TreePanel);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Święta";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Panel TreePanel;
        private System.Windows.Forms.Panel SnowManPanel;
        private System.Windows.Forms.Panel ReindeerPanel;
        private System.Windows.Forms.Panel SantaPanel;
        private System.Windows.Forms.Panel GiftsPanel;
        private System.Windows.Forms.Panel BearPanel;
    }
}

