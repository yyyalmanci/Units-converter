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
    public partial class Sicaklik : Form
    {
        

        public Sicaklik()
        {
            InitializeComponent();
            
        }

        private void Sicaklik_Load(object sender, EventArgs e)
        {
            c_to_fBTN.Enabled = false;
            c_to_kBTN.Enabled = false;
            c_to_rBTN.Enabled = false;
            k_to_cBTN.Enabled = false;
            k_to_rBTN.Enabled = false;
            k_to_fBTN.Enabled = false;
            f_to_cBTN.Enabled = false;
            f_to_rBTN.Enabled = false;
            f_to_kBTN.Enabled = false;
            r_to_cBTN.Enabled = false;
            r_to_kBTN.Enabled = false;
            r_to_fBTN.Enabled = false;

         
        }

       

        
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            
        }

      

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            c_to_fBTN.Enabled = true;
            c_to_kBTN.Enabled = true;
            c_to_rBTN.Enabled = true;
            k_to_cBTN.Enabled = true;
            k_to_rBTN.Enabled = true;
            k_to_fBTN.Enabled = true;
            f_to_cBTN.Enabled = true;
            f_to_rBTN.Enabled = true;
            f_to_kBTN.Enabled = true;
            r_to_cBTN.Enabled = true;
            r_to_kBTN.Enabled = true;
            r_to_fBTN.Enabled = true;
        }


        private void c_to_fBTN_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("lütfen sayı giriniz");

            }
            else
            {
                
                if (richTextBox1.Text.Contains(","))
                {
                    richTextBox1.Text = richTextBox1.Text.Replace(",", ".");

                }
               double Celcius = Convert.ToDouble(richTextBox1.Text);

                double fahreneit = Celcius *9/5 + 32;


                sonucLabel.Text = Celcius + " Celcius = " + fahreneit + " Fahreneite eşittir";


            }
        }
        private void c_to_kBTN_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("lütfen sayı giriniz");

            }
            else
            {

                if (richTextBox1.Text.Contains(","))
                {
                    richTextBox1.Text = richTextBox1.Text.Replace(",", ".");

                }
                double Celcius = Convert.ToDouble(richTextBox1.Text);

                double Kelvin = Celcius + 273.15;

                sonucLabel.Text = Celcius + " Celcius = " + Kelvin + " Kelvine eşittir";


            }
        }
        private void c_to_rBTN_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("lütfen sayı giriniz");

            }
            else
            {

                if (richTextBox1.Text.Contains(","))
                {
                    richTextBox1.Text = richTextBox1.Text.Replace(",", ".");

                }
                double Celcius = Convert.ToDouble(richTextBox1.Text);

                double Rankie = ( Celcius+273.15)*9/5;

                sonucLabel.Text = Celcius + " Celcius = " + Rankie + " Rankie a eşittir";


            }
        }

        private void k_to_cBTN_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("lütfen sayı giriniz");

            }
            else
            {

                if (richTextBox1.Text.Contains(","))
                {
                    richTextBox1.Text = richTextBox1.Text.Replace(",", ".");

                }
                double kelvin = Convert.ToDouble(richTextBox1.Text);

                double Celcius = kelvin - 273.15;

                sonucLabel.Text = kelvin + " kelvin = " + Celcius + " Celciusa eşittir";


            }
        }
        private void k_to_fBTN_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("lütfen sayı giriniz");

            }
            else
            {

                if (richTextBox1.Text.Contains(","))
                {
                    richTextBox1.Text = richTextBox1.Text.Replace(",", ".");

                }
                double kelvin = Convert.ToDouble(richTextBox1.Text);

                double fahreneit = (kelvin*9/5) - 459.67;

                sonucLabel.Text = kelvin + " kelvin = " + fahreneit + " fahreneite eşittir";


            }

        }
        private void k_to_rBTN_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("lütfen sayı giriniz");

            }
            else
            {

                if (richTextBox1.Text.Contains(","))
                {
                    richTextBox1.Text = richTextBox1.Text.Replace(",", ".");

                }
                double kelvin = Convert.ToDouble(richTextBox1.Text);

                double rankie = kelvin*9/5;

                sonucLabel.Text = kelvin + " kelvin = " + rankie + " rankie a eşittir";


            }
        }

        private void f_to_cBTN_Click(object sender, EventArgs e)
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
                double fahreneit = Convert.ToDouble(richTextBox1.Text);

                double celcius = ((fahreneit - 32)*5)/9;

                sonucLabel.Text = fahreneit + " fahreneit = " + celcius + " Celciusa eşittir";


            }
        }
        private void f_to_kBTN_Click(object sender, EventArgs e)
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
                double fahreneit = Convert.ToDouble(richTextBox1.Text);

                double kelvin = (fahreneit + 459.67) * 5 / 9;

                sonucLabel.Text = fahreneit + " fahreneit = " + kelvin + " kelvine eşittir";


            }
        }
        private void f_to_rBTN_Click(object sender, EventArgs e)
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
                double fahreneit = Convert.ToDouble(richTextBox1.Text);

                double rankie = fahreneit + 459.67;

                sonucLabel.Text = fahreneit + " fahreneit = " + rankie + " rankie a eşittir";


            }
        }

        private void r_to_fBTN_Click(object sender, EventArgs e)
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
                double rankie = Convert.ToDouble(richTextBox1.Text);

                double fahreneit = rankie - 459.67;

                sonucLabel.Text = rankie + " rankie = " + fahreneit + " fahreneit e eşittir";


            }
        }

        private void r_to_cBTN_Click(object sender, EventArgs e)
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
                double rankie = Convert.ToDouble(richTextBox1.Text);

                double celcius = (rankie - 491.67)*5/9;

                sonucLabel.Text = rankie + " rankie = " + celcius + " celcius e eşittir";


            }
        }

        private void r_to_kBTN_Click(object sender, EventArgs e)
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
                double rankie = Convert.ToDouble(richTextBox1.Text);

                double kelvin = rankie*5/9;

                sonucLabel.Text = rankie + " rankie = " + kelvin + " kelvin e eşittir";


            }
        }
    }
}
