using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace Diyetisyen
{
    public partial class DiyetisyenForm : Form
    {
        List<Hasta> hastass = new List<Hasta>();
        public DiyetisyenForm(List<Hasta> hastas1)
        {
            InitializeComponent();
            hastass = hastas1;
        }
        
        public void gridDoldur() { dataGridView2.DataSource = hastass; }
        private void DiyetisyenForm_Load(object sender, EventArgs e)
        {
            gridDoldur();
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.CurrentRow.Selected = true;
            hastaId.Text = dataGridView2.Rows[e.RowIndex].Cells["HastaKayitNo"].FormattedValue.ToString();
        }
        private void AkdenizDiyetUygBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < hastass.Count; i++)
            {
                if (hastass[i].HastaKayitNo == Convert.ToInt32(hastaId.Text))
                {
                    Factory factory = new Factory();
                    IDiyet diyet = factory.DiyetNesnesiOlustur("Akdeniz");
                    diyet.diyetYap(hastass[i]);
                }
            }
            gridDoldur();
        }
        private void GlutenDiyetUygBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < hastass.Count; i++)
            {
                if (hastass[i].HastaKayitNo == Convert.ToInt32(hastaId.Text))
                {
                    Factory factory = new Factory();
                    IDiyet diyet = factory.DiyetNesnesiOlustur("GlutenFree");
                    diyet.diyetYap(hastass[i]);
                }
            }
            gridDoldur();
        }
        private void DenizurunDiyetUygBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < hastass.Count; i++)
            {
                if (hastass[i].HastaKayitNo == Convert.ToInt32(hastaId.Text))
                {
                    Factory factory = new Factory();
                    IDiyet diyet = factory.DiyetNesnesiOlustur("Deniz Ürünleri");
                    diyet.diyetYap(hastass[i]);
                }
            }
            gridDoldur();
        }
        private void YesilliklerdunyasiDiyetUygBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < hastass.Count; i++)
            {
                if (hastass[i].HastaKayitNo == Convert.ToInt32(hastaId.Text))
                {
                    Factory factory = new Factory();
                    IDiyet diyet = factory.DiyetNesnesiOlustur("Yeşillikler Dünyası");
                    diyet.diyetYap(hastass[i]);
                }
            }
            gridDoldur();
        }
        private void yeniHastaEkleBtn_Click(object sender, EventArgs e)
        {
            HastaEkle hastaEkle = new HastaEkle(hastass);
            hastaEkle.Show();
            this.Hide();
        }
        private void btnRaporAl_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < hastass.Count; i++)
            {
                if (hastass[i].HastaKayitNo == Convert.ToInt32(hastaId.Text))
                {
                    string strResultJson = JsonConvert.SerializeObject(hastass[i]);
                    File.WriteAllText(@"data.json", strResultJson);
                    if (hastass[i].DiyetAdi == "Akdeniz")
                    {
                        Akdeniz akdeniz = new Akdeniz();
                        string strResultJson2 = JsonConvert.SerializeObject(akdeniz);
                        File.AppendAllText(@"data.json", strResultJson2);
                    }
                    else if (hastass[i].DiyetAdi == "GlutenFree")
                    {
                        GlutenFree glutenFree = new GlutenFree();
                        string strResultJson2 = JsonConvert.SerializeObject(glutenFree);
                        File.AppendAllText(@"data.json", strResultJson2);
                    }
                    else if (hastass[i].DiyetAdi == "Deniz Ürünleri")
                    {
                        DenizUrunleri denizUrunleri = new DenizUrunleri();
                        string strResultJson2 = JsonConvert.SerializeObject(denizUrunleri);
                        File.AppendAllText(@"data.json", strResultJson2);
                    }
                    else
                    {
                        YesilliklerDunyasi yesilliklerDunyasi = new YesilliklerDunyasi();
                        string strResultJson2 = JsonConvert.SerializeObject(yesilliklerDunyasi);
                        File.AppendAllText(@"data.json", strResultJson2);
                    }
                }
            }
            MessageBox.Show("Json Dosyasi Sırasıyla Hasta Bİlgileri ve Diyet Bilgileri Olacak Sekilde Olusturuldu");
        }

        private void btnHTMLRaporAl_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < hastass.Count; i++)
            {
                if (hastass[i].HastaKayitNo == Convert.ToInt32(hastaId.Text))
                {
                    string strResultHTML = JsonConvert.SerializeObject(hastass[i]);
                    File.WriteAllText(@"data.html", strResultHTML);
                    if (hastass[i].DiyetAdi == "Akdeniz")
                    {
                        Akdeniz akdeniz = new Akdeniz();
                        string strResultHTML2 = JsonConvert.SerializeObject(akdeniz);
                        File.AppendAllText(@"data.html", strResultHTML2);
                    }
                    else if(hastass[i].DiyetAdi == "GlutenFree")
                    {
                        GlutenFree glutenFree = new GlutenFree();
                        string strResultHTML2 = JsonConvert.SerializeObject(glutenFree);
                        File.AppendAllText(@"data.html", strResultHTML2);
                    }
                    else if (hastass[i].DiyetAdi == "Deniz Ürünleri")
                    {
                        DenizUrunleri denizUrunleri = new DenizUrunleri();
                        string strResultHTML2 = JsonConvert.SerializeObject(denizUrunleri);
                        File.AppendAllText(@"data.html", strResultHTML2);
                    }
                    else
                    {
                        YesilliklerDunyasi yesilliklerDunyasi = new YesilliklerDunyasi();
                        string strResultHTML2 = JsonConvert.SerializeObject(yesilliklerDunyasi);
                        File.AppendAllText(@"data.html", strResultHTML2);
                    }
                }
            }
            MessageBox.Show("HTML Dosyasi Sırasıyla Hasta Bİlgileri ve Diyet Bilgileri Olacak Sekilde Olusturuldu");
        }

        private void btnUstDiyetJsonRaporAl_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < hastass.Count; i++)
            {
                if (hastass[i].HastaKayitNo == Convert.ToInt32(hastaId.Text))
                {
                    if (hastass[i].DiyetAdi == "Akdeniz")
                    {
                        Akdeniz akdeniz = new Akdeniz();
                        string strResultJson2 = JsonConvert.SerializeObject(akdeniz);
                        File.WriteAllText(@"data.json", strResultJson2);
                    }
                    else if (hastass[i].DiyetAdi == "GlutenFree")
                    {
                        GlutenFree glutenFree = new GlutenFree();
                        string strResultJson2 = JsonConvert.SerializeObject(glutenFree);
                        File.WriteAllText(@"data.json", strResultJson2);
                    }
                    else if (hastass[i].DiyetAdi == "Deniz Ürünleri")
                    {
                        DenizUrunleri denizUrunleri = new DenizUrunleri();
                        string strResultJson2 = JsonConvert.SerializeObject(denizUrunleri);
                        File.WriteAllText(@"data.json", strResultJson2);
                    }
                    else
                    {
                        YesilliklerDunyasi yesilliklerDunyasi = new YesilliklerDunyasi();
                        string strResultJson2 = JsonConvert.SerializeObject(yesilliklerDunyasi);
                        File.WriteAllText(@"data.json", strResultJson2);
                    }
                    string strResultJson = JsonConvert.SerializeObject(hastass[i]);
                    File.AppendAllText(@"data.json", strResultJson);
                }
            }
            MessageBox.Show("Json Dosyasi Sırasıyla Diyet Bilgileri ve Hasta Bİlgileri Olacak Sekilde Olusturuldu");
        }

        private void btnUstDiyetHTMLRaporAl_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < hastass.Count; i++)
            {
                if (hastass[i].HastaKayitNo == Convert.ToInt32(hastaId.Text))
                {
                    if (hastass[i].DiyetAdi == "Akdeniz")
                    {
                        Akdeniz akdeniz = new Akdeniz();
                        string strResultHTML2 = JsonConvert.SerializeObject(akdeniz);
                        File.WriteAllText(@"data.html", strResultHTML2);
                    }
                    else if (hastass[i].DiyetAdi == "GlutenFree")
                    {
                        GlutenFree glutenFree = new GlutenFree();
                        string strResultHTML2 = JsonConvert.SerializeObject(glutenFree);
                        File.WriteAllText(@"data.html", strResultHTML2);
                    }
                    else if (hastass[i].DiyetAdi == "Deniz Ürünleri")
                    {
                        DenizUrunleri denizUrunleri = new DenizUrunleri();
                        string strResultHTML2 = JsonConvert.SerializeObject(denizUrunleri);
                        File.WriteAllText(@"data.html", strResultHTML2);
                    }
                    else
                    {
                        YesilliklerDunyasi yesilliklerDunyasi = new YesilliklerDunyasi();
                        string strResultHTML2 = JsonConvert.SerializeObject(yesilliklerDunyasi);
                        File.WriteAllText(@"data.html", strResultHTML2);
                    }
                    string strResultHTML = JsonConvert.SerializeObject(hastass[i]);
                    File.AppendAllText(@"data.html", strResultHTML);
                }
            }
            MessageBox.Show("HTML Dosyasi Sırasıyla Diyet Bilgileri ve Hasta Bİlgileri Olacak Sekilde Olusturuldu");
        }
    }
}
