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
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void sicaklik_Click(object sender, EventArgs e)
        {
            Sicaklik sicaklik = new Sicaklik();
          //  sicaklik.Size = new System.Drawing.Size(1000, 500); // forma boyut veriliyor...
            sicaklik.StartPosition = FormStartPosition.CenterScreen;
            sicaklik.ShowDialog();

        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void uzunlukDonusum_Click(object sender, EventArgs e)
        {
            Uzunluk uzunluk = new Uzunluk();
            //  sicaklik.Size = new System.Drawing.Size(1000, 500); // forma boyut veriliyor...
            uzunluk.StartPosition = FormStartPosition.CenterScreen;
            uzunluk.ShowDialog();

        }

        private void Agirlik_Click(object sender, EventArgs e)
        {
            Kutle kutle = new Kutle();
             kutle.ShowDialog();
        }

        private void yogunluk_Click(object sender, EventArgs e)
        {
            Yogunluk yogunluk = new Yogunluk();
            yogunluk.ShowDialog();
        }

        private void Alan_Click(object sender, EventArgs e)
        {
            Alan alan = new Alan();
            alan.ShowDialog();
        }

        private void hacim_Click(object sender, EventArgs e)
        {
            Hacim hacim = new Hacim();
            hacim.ShowDialog();
           
        }

        private void AlanKare_Click(object sender, EventArgs e)
        {
            AlanKare alankare = new AlanKare();
            alankare.ShowDialog();
        }
    }
    }

