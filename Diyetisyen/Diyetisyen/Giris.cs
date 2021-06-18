using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diyetisyen
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void GirisBtn_Click(object sender, EventArgs e)
        {
            Diyetisyen diyetisyen = new Diyetisyen();

            List<Hasta> hastas = new List<Hasta>();
            hastas.Add(new Hasta()
            {
                HastaKayitNo = 1,
                Tc = 123.ToString(),
                HastaAdi = "Tarık",
                HastaSoyadi = "Kıldırıç",
                HastalikAdi = "Obez",
                DiyetAdi = "GlutenFree",
                DiyetVerilisTarihi = DateTime.Now,
            });
            hastas.Add(new Hasta()
            {
                HastaKayitNo = 2,
                Tc = 12121.ToString(),
                HastaAdi = "Alpay",
                HastaSoyadi = "Duymaz",
                HastalikAdi = "Şeker",
                DiyetAdi = "Akdeniz",
                DiyetVerilisTarihi = DateTime.Now,
            });
            if (diyetisyen.kullaniciadi == GirisUserName.Text && diyetisyen.sifre == GirisSifre.Text)
            {
                DiyetisyenForm diyetisyenForm = new DiyetisyenForm(hastas);
                diyetisyenForm.Show();
                this.Hide();
            }
            else MessageBox.Show("Hatalı Giris Bilgileri");
        }

      
    }
}
