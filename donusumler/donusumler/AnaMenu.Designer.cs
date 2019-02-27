namespace donusumler
{
    partial class AnaMenu
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
            this.uzunluk = new System.Windows.Forms.Button();
            this.uzunlukDonusum = new System.Windows.Forms.Button();
            this.Agirlik = new System.Windows.Forms.Button();
            this.yogunluk = new System.Windows.Forms.Button();
            this.Alan = new System.Windows.Forms.Button();
            this.hacim = new System.Windows.Forms.Button();
            this.AlanKare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uzunluk
            // 
            this.uzunluk.Location = new System.Drawing.Point(12, 12);
            this.uzunluk.Name = "uzunluk";
            this.uzunluk.Size = new System.Drawing.Size(116, 56);
            this.uzunluk.TabIndex = 0;
            this.uzunluk.Text = "Sıcaklık Dönüştür";
            this.uzunluk.UseVisualStyleBackColor = true;
            this.uzunluk.Click += new System.EventHandler(this.sicaklik_Click);
            // 
            // uzunlukDonusum
            // 
            this.uzunlukDonusum.Location = new System.Drawing.Point(166, 12);
            this.uzunlukDonusum.Name = "uzunlukDonusum";
            this.uzunlukDonusum.Size = new System.Drawing.Size(116, 56);
            this.uzunlukDonusum.TabIndex = 1;
            this.uzunlukDonusum.Text = "Uzunluk dönüşmleri";
            this.uzunlukDonusum.UseVisualStyleBackColor = true;
            this.uzunlukDonusum.Click += new System.EventHandler(this.uzunlukDonusum_Click);
            // 
            // Agirlik
            // 
            this.Agirlik.Location = new System.Drawing.Point(325, 12);
            this.Agirlik.Name = "Agirlik";
            this.Agirlik.Size = new System.Drawing.Size(116, 56);
            this.Agirlik.TabIndex = 2;
            this.Agirlik.Text = "Kütle Dönüşümleri";
            this.Agirlik.UseVisualStyleBackColor = true;
            this.Agirlik.Click += new System.EventHandler(this.Agirlik_Click);
            // 
            // yogunluk
            // 
            this.yogunluk.Location = new System.Drawing.Point(12, 93);
            this.yogunluk.Name = "yogunluk";
            this.yogunluk.Size = new System.Drawing.Size(116, 56);
            this.yogunluk.TabIndex = 3;
            this.yogunluk.Text = "Yoğunluk Dönüştür";
            this.yogunluk.UseVisualStyleBackColor = true;
            this.yogunluk.Click += new System.EventHandler(this.yogunluk_Click);
            // 
            // Alan
            // 
            this.Alan.Location = new System.Drawing.Point(166, 93);
            this.Alan.Name = "Alan";
            this.Alan.Size = new System.Drawing.Size(116, 56);
            this.Alan.TabIndex = 4;
            this.Alan.Text = "Alan Dönüştür";
            this.Alan.UseVisualStyleBackColor = true;
            this.Alan.Click += new System.EventHandler(this.Alan_Click);
            // 
            // hacim
            // 
            this.hacim.Location = new System.Drawing.Point(12, 167);
            this.hacim.Name = "hacim";
            this.hacim.Size = new System.Drawing.Size(116, 56);
            this.hacim.TabIndex = 5;
            this.hacim.Text = "Hacim Dönüştür";
            this.hacim.UseVisualStyleBackColor = true;
            this.hacim.Click += new System.EventHandler(this.hacim_Click);
            // 
            // AlanKare
            // 
            this.AlanKare.Location = new System.Drawing.Point(325, 93);
            this.AlanKare.Name = "AlanKare";
            this.AlanKare.Size = new System.Drawing.Size(116, 56);
            this.AlanKare.TabIndex = 6;
            this.AlanKare.Text = "Alan Karesi Dönüştür";
            this.AlanKare.UseVisualStyleBackColor = true;
            this.AlanKare.Click += new System.EventHandler(this.AlanKare_Click);
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 354);
            this.Controls.Add(this.AlanKare);
            this.Controls.Add(this.hacim);
            this.Controls.Add(this.Alan);
            this.Controls.Add(this.yogunluk);
            this.Controls.Add(this.Agirlik);
            this.Controls.Add(this.uzunlukDonusum);
            this.Controls.Add(this.uzunluk);
            this.Name = "AnaMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AnaMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uzunluk;
        private System.Windows.Forms.Button uzunlukDonusum;
        private System.Windows.Forms.Button Agirlik;
        private System.Windows.Forms.Button yogunluk;
        private System.Windows.Forms.Button Alan;
        private System.Windows.Forms.Button hacim;
        private System.Windows.Forms.Button AlanKare;
    }
}

