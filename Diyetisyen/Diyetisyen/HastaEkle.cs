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
    public partial class HastaEkle : Form
    {
        List<Hasta> hastas1 = new List<Hasta>();
        public HastaEkle(List<Hasta> hastas)
        {
            InitializeComponent();
            hastas1 = hastas;
        }
        private void btnHastaKayit_Click(object sender, EventArgs e)
        {
            hastas1.Add(new Hasta()
            {
                HastaKayitNo = hastas1.Count + 1,
                Tc = txtHastaTC.Text,
                HastaAdi = txtHastaAdi.Text,
                HastaSoyadi = txtHastaSoyadi.Text,
                HastalikAdi = cmbHastalikAdi.Text,
                DiyetAdi = cmbDiyetTipi.Text,
                DiyetVerilisTarihi = DateTime.Now,
            });
            MessageBox.Show("Hasta Basariyla Sisteme Eklendi");
            DiyetisyenForm diyetisyenForm = new DiyetisyenForm(hastas1);
            diyetisyenForm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DiyetisyenForm diyetisyenForm = new DiyetisyenForm(hastas1);
            diyetisyenForm.Show();
            this.Hide();
        }
    }
}
