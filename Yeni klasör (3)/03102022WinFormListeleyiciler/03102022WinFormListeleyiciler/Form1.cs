using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03102022WinFormListeleyiciler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Listeleyiciler ListBox";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lstListe.Items.Add(txtEkle.Text);

            lstListe.Items.Insert(0, txtEkle.Text);
            //lstListe.Items.Insert(0,txtEkle.Text);
            txtEkle.Clear();





            txtEkle.Focus();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // lstListe.Items.Remove(lstListe.SelectedItem);

            string[] silinecekler = new string[lstListe.SelectedItems.Count];

            for (int i = 0; i < lstListe.SelectedItems.Count; i++)
            {
                silinecekler[i] = (string)lstListe.SelectedItems[i];
            }

            foreach (string silinen in silinecekler)
            {
                DialogResult sonuc = MessageBox.Show("Silmek İstediğinizden Eminsiniz", "Dikkat Silinecek!", MessageBoxButtons.YesNo);
                if (sonuc == DialogResult.Yes)
                {
                    lstListe.Items.Remove(silinen);
                }

            }

        }
    }
}
