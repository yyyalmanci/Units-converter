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
    public partial class Uzunluk : Form
    {
        public Uzunluk()
        {
            InitializeComponent();
        }

        

        private void Uzunluk_Load(object sender, EventArgs e)
        {

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

                    double inc = 39.3700* m;
                    sonucLabel.Text = m + " m = " + inc + " in dir";
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

                    double m = 0.0254 * inc;
                    sonucLabel.Text = inc + " in = " + m + " m dir";
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

                    double ft = 3.28 * m;
                    sonucLabel.Text = m + " m = " + ft + " ft dir";
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

                    double m = 0.3048 *ft;
                    sonucLabel.Text = ft + " ft = " + m + " m dir";
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

                    double inc = 0.39370 * cm;
                    sonucLabel.Text = cm + " cm = " + inc + " in dir";
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

                    double cm = 2.54 * inc;
                    sonucLabel.Text = inc + " inc = " + cm + " cm dir";
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

                    double ft = 0.0328 * cm;
                    sonucLabel.Text = cm + " cm = " + ft + " ft dir";
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

                    double cm = 30.48 * ft;
                    sonucLabel.Text = ft + "ft = " + cm + " cm dir";
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

                    double inc = 0.03937 * mm;
                    sonucLabel.Text = mm + " mm = " + inc + " in dir";
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

                    double mm = 25.4 * inc;
                    sonucLabel.Text = inc + " in = " + mm + " mm dir";
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

                    double ft = 0.00328 * mm;
                    sonucLabel.Text = mm + " mm = " + ft+ " ft dir";
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

                    double mm = 304.8 *ft;
                    sonucLabel.Text = ft + " ft = " + mm + " mm dir";
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
