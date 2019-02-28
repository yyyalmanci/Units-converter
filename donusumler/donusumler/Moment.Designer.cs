namespace donusumler
{
    partial class Moment
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
            this.sonucLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_nm = new System.Windows.Forms.Button();
            this.nm_lb = new System.Windows.Forms.Button();
            this.ft_nm = new System.Windows.Forms.Button();
            this.nm_ft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sonucLabel
            // 
            this.sonucLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sonucLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonucLabel.Location = new System.Drawing.Point(173, 129);
            this.sonucLabel.Name = "sonucLabel";
            this.sonucLabel.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.sonucLabel.Size = new System.Drawing.Size(128, 36);
            this.sonucLabel.TabIndex = 49;
            this.sonucLabel.Text = "sonuc";
            this.sonucLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(173, 77);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(128, 38);
            this.richTextBox1.TabIndex = 48;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(173, 33);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(128, 26);
            this.label1.TabIndex = 47;
            this.label1.Text = "Değer Giriniz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_nm
            // 
            this.lb_nm.Location = new System.Drawing.Point(27, 77);
            this.lb_nm.Name = "lb_nm";
            this.lb_nm.Size = new System.Drawing.Size(95, 38);
            this.lb_nm.TabIndex = 46;
            this.lb_nm.Text = "in*lb to N*m";
            this.lb_nm.UseVisualStyleBackColor = true;
            this.lb_nm.Click += new System.EventHandler(this.lb_nm_Click);
            // 
            // nm_lb
            // 
            this.nm_lb.Location = new System.Drawing.Point(27, 33);
            this.nm_lb.Name = "nm_lb";
            this.nm_lb.Size = new System.Drawing.Size(95, 38);
            this.nm_lb.TabIndex = 45;
            this.nm_lb.Text = "N*m to in*lb";
            this.nm_lb.UseVisualStyleBackColor = true;
            this.nm_lb.Click += new System.EventHandler(this.nm_lb_Click);
            // 
            // ft_nm
            // 
            this.ft_nm.Location = new System.Drawing.Point(27, 173);
            this.ft_nm.Name = "ft_nm";
            this.ft_nm.Size = new System.Drawing.Size(95, 38);
            this.ft_nm.TabIndex = 50;
            this.ft_nm.Text = "ft*lb to N*m";
            this.ft_nm.UseVisualStyleBackColor = true;
            this.ft_nm.Click += new System.EventHandler(this.ft_nm_Click);
            // 
            // nm_ft
            // 
            this.nm_ft.Location = new System.Drawing.Point(27, 129);
            this.nm_ft.Name = "nm_ft";
            this.nm_ft.Size = new System.Drawing.Size(95, 38);
            this.nm_ft.TabIndex = 51;
            this.nm_ft.Text = "N*m to ft*lb";
            this.nm_ft.UseVisualStyleBackColor = true;
            this.nm_ft.Click += new System.EventHandler(this.nm_ft_Click);
            // 
            // Moment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 282);
            this.Controls.Add(this.nm_ft);
            this.Controls.Add(this.ft_nm);
            this.Controls.Add(this.sonucLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_nm);
            this.Controls.Add(this.nm_lb);
            this.Name = "Moment";
            this.Text = "Moment Dönüşümleri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label sonucLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lb_nm;
        private System.Windows.Forms.Button nm_lb;
        private System.Windows.Forms.Button ft_nm;
        private System.Windows.Forms.Button nm_ft;
    }
}