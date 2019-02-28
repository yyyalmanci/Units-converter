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
    public partial class AlanKare : Form
    {
        public AlanKare()
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

                    double inc = (2.40251E6) * m;
                    sonucLabel.Text = m + " m^4 = " + inc + " in^4 dir";
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

                    double m = inc * (416.231E-9);
                    sonucLabel.Text = inc + " in^4 = " + m + " m^4 dir";
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

                    double ft = m * (115.86);
                    sonucLabel.Text = m + " m^4 = " + ft + " ft^4 dir";
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

                    double m = ft * (8.631E-3);
                    sonucLabel.Text = ft + " ft^4 = " + m + " m^4 dir";
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

                    double inc = cm * (24.025E-3);
                    sonucLabel.Text = cm + " cm^4 = " + inc+ " in^4 dir";
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

                    double cm = inc * (41.623);
                    sonucLabel.Text = inc + " in^4 = " + cm + " cm^4 dir";
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

                    double ft = cm * (1.1586E-6);
                    sonucLabel.Text = cm + " cm^4 = " +ft + " ft^4 dir";
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

                    double cm = ft * (863110);
                    sonucLabel.Text = ft + " ft^4 = " + cm + " cm^4 dir";
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

                    double inc = mm * (2.402E-6);
                    sonucLabel.Text = mm + " mm^4 = " + inc + " inc^4 dir";
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

                    double mm = inc * (416.231E3);
                    sonucLabel.Text = inc + " in^4 = " + mm + " mm^4 dir";
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

                    double ft = mm * (115.861E-12);
                    sonucLabel.Text = mm+ " mm^4 = " + ft + " ft^4 dir";
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

                    double mm = ft * (8.63097E9);
                    sonucLabel.Text = ft + " ft^4 = " + mm + " mm^4 dir";
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
