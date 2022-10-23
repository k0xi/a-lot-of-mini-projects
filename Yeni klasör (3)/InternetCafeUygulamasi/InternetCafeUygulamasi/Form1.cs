using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetCafeUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();      // Güncel saati yazdırma işlemi     


            if (lblGuncel.Text == DateTime.Now.ToLongTimeString())  // ayarlanan Saat ile güncel saat denk olduğunda
            {
                System.Diagnostics.Process.Start("shutdown", "-f -s"); // Sistemi Kapat
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;                                  // Form yüklendiğinde güncel saati başlat
            label1.Text = DateTime.Now.ToLongTimeString();          // Yazdır 
            for (int i = 0; i <= 23; i++)                           // Comboboxa otomatik veriyi yükleme
            {
                cmbSaat.Items.Add(i);
            }
            for (int i = 0; i <= 59; i++)                          // comboboxa veriyi (dakika ve saniye) yükleme
            {
                cmbDakika.Items.Add(i);
                cmbSaniye.Items.Add(i);
            }
        }
        int kapamasure;    // Global olarak değişkenlerimi tanımlıyorum
        string yenisaatdeger;
        string yenidakikadeger;
        string yenisaniyedeger;
        private void btnAyarla_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)                 // Eğer radyo butonda ilk seçenek seçili ise (saate göre kapanma)her 3 combo boxtaki değeri string olarak alıyorum.
            {

                string saat = cmbSaat.SelectedItem.ToString();
                string dakika = cmbDakika.SelectedItem.ToString();
                string saniye = cmbSaniye.SelectedItem.ToString();

                //Alınan değerleri Convert ediyorum, karşılaştırma yapmak için..

                int saatdeger = Convert.ToInt32(saat);
                int dakikadeger = Convert.ToInt32(dakika);
                int saniyedeger = Convert.ToInt32(saniye);

                // Saat değeri 10 dan küçük ise labela yazdırırken başına 0 değerini ekliyorum.

                if (saatdeger < 10)
                {
                    yenisaatdeger = "0" + saatdeger.ToString();
                }

                else
                {
                    yenisaatdeger = saatdeger.ToString();
                }

                // Dakika değeri 10 dan küçük ise labela yazdırırken başına 0 değerini ekliyorum.

                if (dakikadeger < 10)
                {
                    yenidakikadeger = "0" + dakikadeger.ToString();
                }
                else
                {
                    yenidakikadeger = dakikadeger.ToString();
                }

                // Saniye değeri 10 dan küçük ise labela yazdırırken başına 0 değerini ekliyorum.
                if (saniyedeger < 10)
                {
                    yenisaniyedeger = "0" + saniyedeger.ToString();
                }

                else
                {
                    yenisaniyedeger = saniyedeger.ToString();
                }

                // Saat formatını belirlediğim karar yapısına göre label da yazdırıyorum

                lblGuncel.Text = yenisaatdeger + ":" + yenidakikadeger + ":" + yenisaniyedeger;
            }

            // Eğer radyo buton 2 işaretli ise;

            if (radioButton2.Checked == true)

            // seçilen dakika sıfır değilse, seçilen ifadeyi 60 (saniye) ile çarpıyorum, timer 2 yi başlatıyorum.
            {
                if (Convert.ToInt32(cmbDakika.SelectedItem) != 0)
                {
                    int kapamadakika = Convert.ToInt32(cmbDakika.SelectedItem.ToString());
                    kapamasure = 60 * kapamadakika;
                    timer2.Start();

                }

                // seçilen değer sıfır ise kullanıcıya uyarı veriyor.
                else
                {
                    MessageBox.Show("Lütfen sıfır değerini seçmeyiniz");
                }
            }


        }

        private void btnIptal_Click(object sender, EventArgs e)
        {

            //Eğer iptal butonuna basılmış ise işlemi iptal ettiriyorum, Timer duruyor.
            System.Diagnostics.Process.Start("shutdown", " -a");
            lblGuncel.Text = "";
            timer2.Stop();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cmbSaat.Enabled = true;
            cmbDakika.Enabled = true;
            cmbSaniye.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            // Eğer radyo buton 2 seçili ise, saat ve saniye seçilmesin diye combobox'a false veriyorum.
            cmbSaat.Enabled = false;
            cmbDakika.Enabled = true;
            cmbSaniye.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // Dakikaya göre kapanma seçildiğinde kalan süreyi ekrana yazdırıyorum.

            kapamasure--;
            lblGuncel.Text = kapamasure.ToString();
            Refresh();
            // süre 0 olduğunda sistemi 30 saniye içinde kapatıyorum.

            if (kapamasure == 0)
            {
                System.Diagnostics.Process.Start("shutdown", "-f -s");
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            // Çıkış butonu uyarısı..
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Eminmisiniz?", "Uyarı", MessageBoxButtons.OKCancel);
            {
                if (sonuc == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }
    }
}
    
