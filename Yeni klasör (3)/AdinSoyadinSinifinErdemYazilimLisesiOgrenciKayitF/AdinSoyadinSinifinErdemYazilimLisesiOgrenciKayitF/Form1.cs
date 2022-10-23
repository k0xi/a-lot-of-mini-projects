using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdinSoyadinSinifinErdemYazilimLisesiOgrenciKayitF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ListViewItem satir = new ListViewItem();//ListView nesnesi içine ListViewItem Alır
           satir.UseItemStyleForSubItems = false;//ListView içine ben kendim müdahale edecek isem style renk gibi kullanırım
            satir.Text = txtAdSoyad.Text;//ListView in ilk yeri text ile başlar
            satir.SubItems.Add(txtTCNO.Text);//Listview in diğer elemanları SubItemsdir


            if (rdbKiz.Checked == true)//Eğer radio button kız seçili ise 
            {
                satir.SubItems.Add("Kız");//içine Kız yaz
                satir.SubItems[2].BackColor=rdbKiz.BackColor;//arka plan rengini radio buttondan al
            }
            else
            {
                satir.SubItems.Add("Erkek");
                satir.SubItems[2].BackColor = rdbErkek.BackColor;
            }

            satir.SubItems.Add(cmbSinif.Text);
            satir.SubItems.Add(cmbSube.Text);
            satir.SubItems.Add(cmbBolum.Text);

            lsvListe.Items.Add(satir);//listview yazdığım tüm satırı items olarak atıyorum

            txtAdSoyad.Clear();
            txtTCNO.Clear();
            cmbBolum.SelectedIndex = -1;
            cmbSinif.SelectedIndex = -1;
            cmbSube.SelectedIndex = -1;
            rdbErkek.Checked = true;
        }

        private void rdbErkek_CheckedChanged(object sender, EventArgs e)
        {
            rdbErkek.BackColor = Color.Blue;//radio butonun arka plan rengini mavi yap
            rdbKiz.BackColor = Color.Pink;//radio buton arka plan rengini pembe yap
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            

          DialogResult sonuc=  MessageBox.Show("Silmek İstediğinizden Emin misiniz?","Dikkat Silinecek",MessageBoxButtons.YesNo);
            if(sonuc==DialogResult.Yes)
            {
                lsvListe.Items.Remove(lsvListe.SelectedItems[0]);//ListView  elemanlarını siliyorum
            }
        }
    }
}
