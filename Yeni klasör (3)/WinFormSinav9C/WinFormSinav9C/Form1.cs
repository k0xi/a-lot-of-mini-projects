using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormSinav9C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            ListViewItem satir = new ListViewItem();
            satir.UseItemStyleForSubItems = false;
            satir.Text = txtAdSoyad.Text;
            satir.SubItems.Add(txtTCNO.Text);

            if (rdbErkek.Checked)
            {
                satir.SubItems.Add("Erkek");
                satir.SubItems[2].BackColor = Color.Blue;
            }
            else
            {
                satir.SubItems.Add("Kız");
                satir.SubItems[2].BackColor = Color.Pink;
            }

            satir.SubItems.Add(cmbSinif.Text);
            satir.SubItems.Add(cmbSube.Text);
            satir.SubItems.Add(cmbBolum.Text);

            lsvListe.Items.Add(satir);

            txtAdSoyad.Clear();
            txtTCNO.Clear();
            cmbBolum.SelectedItem = -1;
            cmbSube.SelectedItem = -1;
            cmbSinif.SelectedItem = -1;

        }

        private void rdbErkek_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbErkek.Checked)
            {
                rdbErkek.BackColor = Color.Blue;
            }
            else
            {
                rdbKiz.BackColor = Color.Pink;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lsvListe.SelectedItems.Count > 0)
            {
                lsvListe.SelectedItems[0].Remove();
            }
            else
            {
                MessageBox.Show("Listeden Bir seçim yapınız");
            }
        }
    }
}
