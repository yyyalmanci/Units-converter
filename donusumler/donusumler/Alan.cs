using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace donusumler
{
    public partial class Alan : Form
    {
        public Alan()
        {
            InitializeComponent();
        }

        private void m_inc_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("lütfen sayı giriniz");

            }
            else
            {
                if (richTextBox1.Text.Contains(",")) // virgul varsa sayıda noktaya çeviriyor.
                {
                    richTextBox1.Text = richTextBox1.Text.Replace(",", ".");

                }
                try
                {
                    double m = Convert.ToDouble(richTextBox1.Text);

                    double inc = 1550*m;
                    sonucLabel.Text = m + " m^2 = " + inc + "in^2 dir";
                    sonucLabel.Width = sonucLabel.Text.Length * 10;
                }
                catch
                {
                    MessageBox.Show("sayı giriniz");
                }


            }
        }

        private void in_m_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("lütfen sayı giriniz");

            }
            else
            {
                if (richTextBox1.Text.Contains(",")) // virgul varsa sayıda noktaya çeviriyor.
                {
                    richTextBox1.Text = richTextBox1.Text.Replace(",", ".");

                }
                try
                {
                    double inc = Convert.ToDouble(richTextBox1.Text);

                    double m = inc*(6.4516E-4);
                    sonucLabel.Text = inc + " inc^2 = " + m + "m^2 dir";
                    sonucLabel.Width = sonucLabel.Text.Length * 10;
                }
                catch
                {
                    MessageBox.Show("sayı giriniz");
                }


            }
        }

        private void m_ft_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("lütfen sayı giriniz");

            }
            else
            {
                if (richTextBox1.Text.Contains(",")) // virgul varsa sayıda noktaya çeviriyor.
                {
                    richTextBox1.Text = richTextBox1.Text.Replace(",", ".");

                }
                try
                {
                    double m = Convert.ToDouble(richTextBox1.Text);

                    double ft = 10.76 * m;
                    sonucLabel.Text = m + " m^2 = " + ft + "ft^2 dir";
                    sonucLabel.Width = sonucLabel.Text.Length * 10;
                }
                catch
                {
                    MessageBox.Show("sayı giriniz");
                }


            }
        }

        private void ft_m_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("lütfen sayı giriniz");

            }
            else
            {
                if (richTextBox1.Text.Contains(",")) // virgul varsa sayıda noktaya çeviriyor.
                {
                    richTextBox1.Text = richTextBox1.Text.Replace(",", ".");

                }
                try
                {
                    double ft = Convert.ToDouble(richTextBox1.Text);

                    double m = ft* (0.0929) ;
                    sonucLabel.Text = ft + " ft^2 = " + m + "m^2 dir";
                    sonucLabel.Width = sonucLabel.Text.Length * 10;
                }
                catch
                {
                    MessageBox.Show("sayı giriniz");
                }


            }
        }

        private void cm_inc_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("lütfen sayı giriniz");

            }
            else
            {
                if (richTextBox1.Text.Contains(",")) // virgul varsa sayıda noktaya çeviriyor.
                {
                    richTextBox1.Text = richTextBox1.Text.Replace(",", ".");

                }
                try
                {
                    double cm = Convert.ToDouble(richTextBox1.Text);

                    double inc = 0.155 * cm;
                    sonucLabel.Text = cm + " cm^2 = " + inc + "inc^2 dir";
                    sonucLabel.Width = sonucLabel.Text.Length * 10;
                }
                catch
                {
                    MessageBox.Show("sayı giriniz");
                }


            }
        }

        private void inc_cm_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("lütfen sayı giriniz");

            }
            else
            {
                if (richTextBox1.Text.Contains(",")) // virgul varsa sayıda noktaya çeviriyor.
                {
                    richTextBox1.Text = richTextBox1.Text.Replace(",", ".");

                }
                try
                {
                    double inc = Convert.ToDouble(richTextBox1.Text);

                    double cm = inc*6.4516 ;
                    sonucLabel.Text = inc + " inc^2 = " + cm + "cm^2 dir";
                    sonucLabel.Width = sonucLabel.Text.Length * 10;
                }
                catch
                {
                    MessageBox.Show("sayı giriniz");
                }


            }
        }

        private void cm_ft_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("lütfen sayı giriniz");

            }
            else
            {
                if (richTextBox1.Text.Contains(",")) // virgul varsa sayıda noktaya çeviriyor.
                {
                    richTextBox1.Text = richTextBox1.Text.Replace(",", ".");

                }
                try
                {
                    double cm = Convert.ToDouble(richTextBox1.Text);

                    double ft = cm*(1.07E-3);
                    sonucLabel.Text = cm + " cm^2 = " + ft + "ft^2 dir";
                    sonucLabel.Width = sonucLabel.Text.Length * 10;
                }
                catch
                {
                    MessageBox.Show("sayı giriniz");
                }


            }
        }

        private void ft_cm_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("lütfen sayı giriniz");

            }
            else
            {
                if (richTextBox1.Text.Contains(",")) // virgul varsa sayıda noktaya çeviriyor.
                {
                    richTextBox1.Text = richTextBox1.Text.Replace(",", ".");

                }
                try
                {
                    double ft = Convert.ToDouble(richTextBox1.Text);

                    double cm = ft * 929.03;
                    sonucLabel.Text = ft + " ft^2 = " + cm + "cm^2 dir";
                    sonucLabel.Width = sonucLabel.Text.Length * 10;
                }
                catch
                {
                    MessageBox.Show("sayı giriniz");
                }


            }
        }

        private void mm_in_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("lütfen sayı giriniz");

            }
            else
            {
                if (richTextBox1.Text.Contains(",")) // virgul varsa sayıda noktaya çeviriyor.
                {
                    richTextBox1.Text = richTextBox1.Text.Replace(",", ".");

                }
                try
                {
                    double mm = Convert.ToDouble(richTextBox1.Text);

                    double inc = mm *(1.55E-3);
                        
                    sonucLabel.Text = mm + " mm^2 = " + inc + "inc^2 dir";
                    sonucLabel.Width = sonucLabel.Text.Length * 10;
                }
                catch
                {
                    MessageBox.Show("sayı giriniz");
                }


            }
        }

        private void in_mm_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("lütfen sayı giriniz");

            }
            else
            {
                if (richTextBox1.Text.Contains(",")) // virgul varsa sayıda noktaya çeviriyor.
                {
                    richTextBox1.Text = richTextBox1.Text.Replace(",", ".");

                }
                try
                {
                    double inc = Convert.ToDouble(richTextBox1.Text);

                    double mm = 645.16 * inc;
                    sonucLabel.Text = inc + " inc^2 = " + mm + "mm^2 dir";
                    sonucLabel.Width = sonucLabel.Text.Length * 10;
                }
                catch
                {
                    MessageBox.Show("sayı giriniz");
                }


            }
        }

        private void mm_ft_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("lütfen sayı giriniz");

            }
            else
            {
                if (richTextBox1.Text.Contains(",")) // virgul varsa sayıda noktaya çeviriyor.
                {
                    richTextBox1.Text = richTextBox1.Text.Replace(",", ".");

                }
                try
                {
                    double mm = Convert.ToDouble(richTextBox1.Text);

                    double ft = mm*(1.0764E-5);
                    sonucLabel.Text = mm + " m^2 = " + ft + "ft^2 dir";
                    sonucLabel.Width = sonucLabel.Text.Length * 10;
                }
                catch
                {
                    MessageBox.Show("sayı giriniz");
                }


            }
        }

        private void ft_mm_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("lütfen sayı giriniz");

            }
            else
            {
                if (richTextBox1.Text.Contains(",")) // virgul varsa sayıda noktaya çeviriyor.
                {
                    richTextBox1.Text = richTextBox1.Text.Replace(",", ".");

                }
                try
                {
                    double ft = Convert.ToDouble(richTextBox1.Text);

                    double mm = 92.903 *ft;
                    sonucLabel.Text = ft + " ft^2 = " + mm + "mm^2 dir";
                    sonucLabel.Width = sonucLabel.Text.Length * 10;
                }
                catch
                {
                    MessageBox.Show("sayı giriniz");
                }


            }
        }
    }
}
