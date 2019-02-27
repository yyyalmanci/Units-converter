namespace donusumler
{
    partial class Yogunluk
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
            this.kg_lb = new System.Windows.Forms.Button();
            this.kg_sl = new System.Windows.Forms.Button();
            this.sl_kg = new System.Windows.Forms.Button();
            this.lb_kg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sonucLabel
            // 
            this.sonucLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sonucLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonucLabel.Location = new System.Drawing.Point(153, 129);
            this.sonucLabel.Name = "sonucLabel";
            this.sonucLabel.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.sonucLabel.Size = new System.Drawing.Size(128, 36);
            this.sonucLabel.TabIndex = 38;
            this.sonucLabel.Text = "sonuc";
            this.sonucLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(153, 74);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(128, 38);
            this.richTextBox1.TabIndex = 37;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(153, 27);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(128, 26);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ağırlık Giriniz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // kg_lb
            // 
            this.kg_lb.Location = new System.Drawing.Point(23, 129);
            this.kg_lb.Name = "kg_lb";
            this.kg_lb.Size = new System.Drawing.Size(95, 38);
            this.kg_lb.TabIndex = 35;
            this.kg_lb.Text = "kg/m^3 to lb/ft^3";
            this.kg_lb.UseVisualStyleBackColor = true;
            this.kg_lb.Click += new System.EventHandler(this.kg_lb_Click);
            // 
            // kg_sl
            // 
            this.kg_sl.Location = new System.Drawing.Point(23, 27);
            this.kg_sl.Name = "kg_sl";
            this.kg_sl.Size = new System.Drawing.Size(95, 38);
            this.kg_sl.TabIndex = 32;
            this.kg_sl.Text = "kg/m^3 to slug/ft^3";
            this.kg_sl.UseVisualStyleBackColor = true;
            this.kg_sl.Click += new System.EventHandler(this.kg_sl_Click);
            // 
            // sl_kg
            // 
            this.sl_kg.Location = new System.Drawing.Point(23, 74);
            this.sl_kg.Name = "sl_kg";
            this.sl_kg.Size = new System.Drawing.Size(95, 38);
            this.sl_kg.TabIndex = 39;
            this.sl_kg.Text = "slug/ft^3 to kg/m^3";
            this.sl_kg.UseVisualStyleBackColor = true;
            this.sl_kg.Click += new System.EventHandler(this.sl_kg_Click);
            // 
            // lb_kg
            // 
            this.lb_kg.Location = new System.Drawing.Point(23, 183);
            this.lb_kg.Name = "lb_kg";
            this.lb_kg.Size = new System.Drawing.Size(95, 38);
            this.lb_kg.TabIndex = 40;
            this.lb_kg.Text = "lb/ft^3 to kg/m^3 ";
            this.lb_kg.UseVisualStyleBackColor = true;
            this.lb_kg.Click += new System.EventHandler(this.lb_kg_Click);
            // 
            // Yogunluk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 310);
            this.Controls.Add(this.lb_kg);
            this.Controls.Add(this.sl_kg);
            this.Controls.Add(this.sonucLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kg_lb);
            this.Controls.Add(this.kg_sl);
            this.Name = "Yogunluk";
            this.Text = "Yogunluk";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label sonucLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kg_lb;
        private System.Windows.Forms.Button kg_sl;
        private System.Windows.Forms.Button sl_kg;
        private System.Windows.Forms.Button lb_kg;
    }
}