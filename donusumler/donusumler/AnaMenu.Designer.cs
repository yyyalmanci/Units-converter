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
            this.kuvvet = new System.Windows.Forms.Button();
            this.moment = new System.Windows.Forms.Button();
            this.basinc = new System.Windows.Forms.Button();
            this.elastik = new System.Windows.Forms.Button();
            this.rijitlik = new System.Windows.Forms.Button();
            this.isenerji = new System.Windows.Forms.Button();
            this.guc = new System.Windows.Forms.Button();
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
            // kuvvet
            // 
            this.kuvvet.Location = new System.Drawing.Point(166, 167);
            this.kuvvet.Name = "kuvvet";
            this.kuvvet.Size = new System.Drawing.Size(116, 56);
            this.kuvvet.TabIndex = 7;
            this.kuvvet.Text = "Kuvvet Dönüştür";
            this.kuvvet.UseVisualStyleBackColor = true;
            this.kuvvet.Click += new System.EventHandler(this.kuvvet_Click);
            // 
            // moment
            // 
            this.moment.Location = new System.Drawing.Point(325, 167);
            this.moment.Name = "moment";
            this.moment.Size = new System.Drawing.Size(116, 56);
            this.moment.TabIndex = 8;
            this.moment.Text = "Moment Dönüştür";
            this.moment.UseVisualStyleBackColor = true;
            this.moment.Click += new System.EventHandler(this.moment_Click);
            // 
            // basinc
            // 
            this.basinc.Location = new System.Drawing.Point(12, 239);
            this.basinc.Name = "basinc";
            this.basinc.Size = new System.Drawing.Size(116, 56);
            this.basinc.TabIndex = 9;
            this.basinc.Text = "Basınç Dönüştür";
            this.basinc.UseVisualStyleBackColor = true;
            this.basinc.Click += new System.EventHandler(this.basinc_Click);
            // 
            // elastik
            // 
            this.elastik.Location = new System.Drawing.Point(166, 239);
            this.elastik.Name = "elastik";
            this.elastik.Size = new System.Drawing.Size(116, 56);
            this.elastik.TabIndex = 10;
            this.elastik.Text = "Elastiklik Katsayısı Dönüştür";
            this.elastik.UseVisualStyleBackColor = true;
            this.elastik.Click += new System.EventHandler(this.elastik_Click);
            // 
            // rijitlik
            // 
            this.rijitlik.Location = new System.Drawing.Point(325, 239);
            this.rijitlik.Name = "rijitlik";
            this.rijitlik.Size = new System.Drawing.Size(116, 56);
            this.rijitlik.TabIndex = 11;
            this.rijitlik.Text = "Rijitlik Katsayısı Dönüştür";
            this.rijitlik.UseVisualStyleBackColor = true;
            this.rijitlik.Click += new System.EventHandler(this.rijitlik_Click);
            // 
            // isenerji
            // 
            this.isenerji.Location = new System.Drawing.Point(12, 314);
            this.isenerji.Name = "isenerji";
            this.isenerji.Size = new System.Drawing.Size(116, 56);
            this.isenerji.TabIndex = 12;
            this.isenerji.Text = "İş Enerji Dönüştür";
            this.isenerji.UseVisualStyleBackColor = true;
            this.isenerji.Click += new System.EventHandler(this.isenerji_Click);
            // 
            // guc
            // 
            this.guc.Location = new System.Drawing.Point(166, 314);
            this.guc.Name = "guc";
            this.guc.Size = new System.Drawing.Size(116, 56);
            this.guc.TabIndex = 13;
            this.guc.Text = "Guc Dönüştür";
            this.guc.UseVisualStyleBackColor = true;
            this.guc.Click += new System.EventHandler(this.guc_Click);
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 391);
            this.Controls.Add(this.guc);
            this.Controls.Add(this.isenerji);
            this.Controls.Add(this.rijitlik);
            this.Controls.Add(this.elastik);
            this.Controls.Add(this.basinc);
            this.Controls.Add(this.moment);
            this.Controls.Add(this.kuvvet);
            this.Controls.Add(this.AlanKare);
            this.Controls.Add(this.hacim);
            this.Controls.Add(this.Alan);
            this.Controls.Add(this.yogunluk);
            this.Controls.Add(this.Agirlik);
            this.Controls.Add(this.uzunlukDonusum);
            this.Controls.Add(this.uzunluk);
            this.Name = "AnaMenu";
            this.Text = "Birim Dönüşümleri";
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
        private System.Windows.Forms.Button kuvvet;
        private System.Windows.Forms.Button moment;
        private System.Windows.Forms.Button basinc;
        private System.Windows.Forms.Button elastik;
        private System.Windows.Forms.Button rijitlik;
        private System.Windows.Forms.Button isenerji;
        private System.Windows.Forms.Button guc;
    }
}

