namespace donusumler
{
    partial class IsEnerji
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
            this.lb_j = new System.Windows.Forms.Button();
            this.j_lb = new System.Windows.Forms.Button();
            this.sonucLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.k_b = new System.Windows.Forms.Button();
            this.b_k = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_j
            // 
            this.lb_j.Location = new System.Drawing.Point(20, 87);
            this.lb_j.Name = "lb_j";
            this.lb_j.Size = new System.Drawing.Size(96, 40);
            this.lb_j.TabIndex = 59;
            this.lb_j.Text = "ft*lb to J";
            this.lb_j.UseVisualStyleBackColor = true;
            this.lb_j.Click += new System.EventHandler(this.lb_j_Click);
            // 
            // j_lb
            // 
            this.j_lb.Location = new System.Drawing.Point(20, 29);
            this.j_lb.Name = "j_lb";
            this.j_lb.Size = new System.Drawing.Size(96, 40);
            this.j_lb.TabIndex = 58;
            this.j_lb.Text = "J to ft*lb";
            this.j_lb.UseVisualStyleBackColor = true;
            this.j_lb.Click += new System.EventHandler(this.j_lb_Click);
            // 
            // sonucLabel
            // 
            this.sonucLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sonucLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonucLabel.Location = new System.Drawing.Point(194, 134);
            this.sonucLabel.Name = "sonucLabel";
            this.sonucLabel.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.sonucLabel.Size = new System.Drawing.Size(128, 36);
            this.sonucLabel.TabIndex = 57;
            this.sonucLabel.Text = "sonuc";
            this.sonucLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(194, 70);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(128, 38);
            this.richTextBox1.TabIndex = 56;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(160, 29);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(190, 26);
            this.label1.TabIndex = 55;
            this.label1.Text = "Değer Giriniz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // k_b
            // 
            this.k_b.Location = new System.Drawing.Point(20, 146);
            this.k_b.Name = "k_b";
            this.k_b.Size = new System.Drawing.Size(96, 40);
            this.k_b.TabIndex = 60;
            this.k_b.Text = "kWh to Btu";
            this.k_b.UseVisualStyleBackColor = true;
            this.k_b.Click += new System.EventHandler(this.k_b_Click);
            // 
            // b_k
            // 
            this.b_k.Location = new System.Drawing.Point(20, 202);
            this.b_k.Name = "b_k";
            this.b_k.Size = new System.Drawing.Size(96, 40);
            this.b_k.TabIndex = 61;
            this.b_k.Text = "Btu to kWh";
            this.b_k.UseVisualStyleBackColor = true;
            this.b_k.Click += new System.EventHandler(this.b_k_Click);
            // 
            // IsEnerji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 277);
            this.Controls.Add(this.b_k);
            this.Controls.Add(this.k_b);
            this.Controls.Add(this.lb_j);
            this.Controls.Add(this.j_lb);
            this.Controls.Add(this.sonucLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "IsEnerji";
            this.Text = "İş Enerji Dönüşümleri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lb_j;
        private System.Windows.Forms.Button j_lb;
        private System.Windows.Forms.Label sonucLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button k_b;
        private System.Windows.Forms.Button b_k;
    }
}