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
    public partial class Rijitlik : Form
    {
        public Rijitlik()
        {
            InitializeComponent();
        }

        private void kpa_ks_Click(object sender, EventArgs e)
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
                    double kpa = Convert.ToDouble(richTextBox1.Text);

                    double ks = kpa * (145.0377E-6);
                    sonucLabel.Text = kpa + " kPa = " + ks + " ksi dir";
                    sonucLabel.Width = sonucLabel.Text.Length * 10;
                }
                catch
                {
                    MessageBox.Show("sayı giriniz");
                }


            }
        }

        private void ksi_kp_Click(object sender, EventArgs e)
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
                    double ks = Convert.ToDouble(richTextBox1.Text);

                    double kpa = ks * (6.8947E3);
                    sonucLabel.Text = ks + " ksi = " + kpa + " kPa dir";
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
