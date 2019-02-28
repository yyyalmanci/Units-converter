namespace donusumler
{
    partial class Elastik
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
            this.lb_pa = new System.Windows.Forms.Button();
            this.pa_lb = new System.Windows.Forms.Button();
            this.sonucLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_pa
            // 
            this.lb_pa.Location = new System.Drawing.Point(20, 84);
            this.lb_pa.Name = "lb_pa";
            this.lb_pa.Size = new System.Drawing.Size(96, 40);
            this.lb_pa.TabIndex = 54;
            this.lb_pa.Text = "lb/ft^2 to Pa";
            this.lb_pa.UseVisualStyleBackColor = true;
            this.lb_pa.Click += new System.EventHandler(this.lb_pa_Click);
            // 
            // pa_lb
            // 
            this.pa_lb.Location = new System.Drawing.Point(20, 26);
            this.pa_lb.Name = "pa_lb";
            this.pa_lb.Size = new System.Drawing.Size(96, 40);
            this.pa_lb.TabIndex = 53;
            this.pa_lb.Text = "Pa to lb/ft^2";
            this.pa_lb.UseVisualStyleBackColor = true;
            this.pa_lb.Click += new System.EventHandler(this.pa_lb_Click);
            // 
            // sonucLabel
            // 
            this.sonucLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sonucLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonucLabel.Location = new System.Drawing.Point(194, 131);
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
            this.richTextBox1.Location = new System.Drawing.Point(194, 67);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(128, 38);
            this.richTextBox1.TabIndex = 51;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(160, 26);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(190, 26);
            this.label1.TabIndex = 50;
            this.label1.Text = "Değer Giriniz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Elastik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 276);
            this.Controls.Add(this.lb_pa);
            this.Controls.Add(this.pa_lb);
            this.Controls.Add(this.sonucLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "Elastik";
            this.Text = "Elastik Katsayısı Dönüşümleri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lb_pa;
        private System.Windows.Forms.Button pa_lb;
        private System.Windows.Forms.Label sonucLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
    }
}