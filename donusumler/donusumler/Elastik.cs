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
    public partial class Elastik : Form
    {
        public Elastik()
        {
            InitializeComponent();
        }

        private void pa_lb_Click(object sender, EventArgs e)
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
                    double pa = Convert.ToDouble(richTextBox1.Text);

                    double lb = pa * (20.885E-3);
                    sonucLabel.Text = pa + " Pa = " + lb + " lb/ft^2 dir";
                    sonucLabel.Width = sonucLabel.Text.Length * 10;
                }
                catch
                {
                    MessageBox.Show("sayı giriniz");
                }


            }
        }

        private void lb_pa_Click(object sender, EventArgs e)
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
                    double lb = Convert.ToDouble(richTextBox1.Text);

                    double pa = lb * (47.880);
                    sonucLabel.Text = lb + " lb/ft^2 = " + pa + " Pa dir";
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
