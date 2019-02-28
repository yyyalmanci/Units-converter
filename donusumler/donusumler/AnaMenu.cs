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
            kutle.StartPosition = FormStartPosition.CenterScreen;
            kutle.ShowDialog();
        }

        private void yogunluk_Click(object sender, EventArgs e)
        {
            Yogunluk yogunluk = new Yogunluk();
            yogunluk.StartPosition = FormStartPosition.CenterScreen;
            yogunluk.ShowDialog();
        }

        private void Alan_Click(object sender, EventArgs e)
        {
            Alan alan = new Alan();
            alan.StartPosition = FormStartPosition.CenterScreen; 
            alan.ShowDialog();
        }

        private void hacim_Click(object sender, EventArgs e)
        {
            Hacim hacim = new Hacim();
            hacim.StartPosition = FormStartPosition.CenterScreen;
            hacim.ShowDialog();
           
        }

        private void AlanKare_Click(object sender, EventArgs e)
        {
            AlanKare alankare = new AlanKare();
            alankare.StartPosition = FormStartPosition.CenterScreen;
            alankare.ShowDialog();
        }

        private void kuvvet_Click(object sender, EventArgs e)
        {
            Kuvvet kuvvet = new Kuvvet();
            kuvvet.StartPosition = FormStartPosition.CenterScreen;
            kuvvet.ShowDialog();
        }

        private void moment_Click(object sender, EventArgs e)
        {
            Moment moment = new Moment();
            moment.StartPosition = FormStartPosition.CenterScreen;
            moment.ShowDialog();
        }

        private void basinc_Click(object sender, EventArgs e)
        {
            Basinc basinc = new Basinc();
            basinc.StartPosition = FormStartPosition.CenterScreen;
            basinc.ShowDialog();
        }

        private void elastik_Click(object sender, EventArgs e)
        {
            Elastik elastik = new Elastik();
            elastik.StartPosition = FormStartPosition.CenterScreen;
            elastik.ShowDialog();
        }

        private void rijitlik_Click(object sender, EventArgs e)
        {
            Rijitlik rijit = new Rijitlik();
            rijit.StartPosition = FormStartPosition.CenterScreen;
            rijit.ShowDialog();

        }

        private void isenerji_Click(object sender, EventArgs e)
        {
            IsEnerji isenerji = new IsEnerji();
            isenerji.StartPosition = FormStartPosition.CenterScreen;
            isenerji.ShowDialog();
        }

        private void guc_Click(object sender, EventArgs e)
        {
            Guc guc = new Guc();
            guc.StartPosition = FormStartPosition.CenterScreen;
            guc.ShowDialog();
        }
    }
    }

