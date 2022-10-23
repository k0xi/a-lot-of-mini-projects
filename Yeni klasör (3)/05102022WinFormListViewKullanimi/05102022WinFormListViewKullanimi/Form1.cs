using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05102022WinFormListViewKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ListViewItem satir = new ListViewItem();// Ozaman ListView  satir oluşturururum
            satir.UseItemStyleForSubItems = false;//Eğer Kendim ListView içine renk vs özellikler ekleyeceksem stil bunu false çekerim
            satir.Text = txtAdSoyad.Text;//ListViewItem İlk elemanı texti temsil eder
            satir.SubItems.Add(txtTCNO.Text);//ListViewItem Sonraki elemanlarının tamamı SubItems dir

            if (rdbErkek.Checked)//Cinsiyet Kontrolü için if yapısı kullandım rdbErkek Seçili ise erkektir
            {
                satir.SubItems.Add("Erkek");
                satir.SubItems[2].BackColor = rdbErkek.BackColor;//ListView  Arkaplan renk ayarlıyorum

            }
            else//değilsee kız 
            {
                satir.SubItems.Add("Kız");
                satir.SubItems[2].BackColor = rdbKiz.BackColor;
            }
            satir.SubItems.Add(cmbSinif.Text);//3 numaralı subıtemi ekledim
            satir.SubItems.Add(cmbSube.Text);//4 numaralı subıtemi ekledim
            satir.SubItems.Add(cmbBolum.Text);//5 numaralı subıtemi ekledim

            lsvListe.Items.Add(satir);// Satırı ListView Verdim ListView  Eklemek İçin ListViewItem ister

            txtAdSoyad.Clear();//form temizleme işlemleri
            txtTCNO.Clear();
            cmbSinif.SelectedItem = -1;
            cmbBolum.SelectedItem = -1;
            cmbSube.SelectedItem = -1;
        }

        private void rdbErkek_CheckedChanged(object sender, EventArgs e)
        {
            rdbErkek.BackColor = Color.Blue;
            rdbKiz.BackColor = Color.Pink;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
           
          DialogResult sonuc=     MessageBox.Show("Silmek İstediğinizden EminMisiniz", "Dikkat Silinecek!", MessageBoxButtons.YesNo);

            if (sonuc == DialogResult.Yes)
            {
                lsvListe.Items.Remove(lsvListe.SelectedItems[0]);
            }
        }
    }
}
