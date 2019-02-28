namespace donusumler
{
    partial class Rijitlik
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
            this.ksi_kp = new System.Windows.Forms.Button();
            this.kpa_ks = new System.Windows.Forms.Button();
            this.sonucLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ksi_kp
            // 
            this.ksi_kp.Location = new System.Drawing.Point(22, 91);
            this.ksi_kp.Name = "ksi_kp";
            this.ksi_kp.Size = new System.Drawing.Size(96, 40);
            this.ksi_kp.TabIndex = 54;
            this.ksi_kp.Text = "ksi to kPa";
            this.ksi_kp.UseVisualStyleBackColor = true;
            this.ksi_kp.Click += new System.EventHandler(this.ksi_kp_Click);
            // 
            // kpa_ks
            // 
            this.kpa_ks.Location = new System.Drawing.Point(22, 33);
            this.kpa_ks.Name = "kpa_ks";
            this.kpa_ks.Size = new System.Drawing.Size(96, 40);
            this.kpa_ks.TabIndex = 53;
            this.kpa_ks.Text = "kPa to ksi";
            this.kpa_ks.UseVisualStyleBackColor = true;
            this.kpa_ks.Click += new System.EventHandler(this.kpa_ks_Click);
            // 
            // sonucLabel
            // 
            this.sonucLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sonucLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonucLabel.Location = new System.Drawing.Point(196, 138);
            this.sonucLabel.Name = "sonucLabel";
            this.sonucLabel.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.sonucLabel.Size = new System.Drawing.Size(128, 36);
            this.sonucLabel.TabIndex = 52;
            this.sonucLabel.Text = "sonuc";
            this.sonucLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(196, 74);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(128, 38);
            this.richTextBox1.TabIndex = 51;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(162, 33);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(190, 26);
            this.label1.TabIndex = 50;
            this.label1.Text = "Değer Giriniz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Rijitlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 288);
            this.Controls.Add(this.ksi_kp);
            this.Controls.Add(this.kpa_ks);
            this.Controls.Add(this.sonucLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "Rijitlik";
            this.Text = "Rijitlik Katsayısı Dönüşümü";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ksi_kp;
        private System.Windows.Forms.Button kpa_ks;
        private System.Windows.Forms.Label sonucLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
    }
}