using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsListboxUse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // lstListe.Items.Add(txtAd.Text);
            lstListe.Items.Insert(0, txtAd.Text);
            txtAd.Clear();
            txtAd.Focus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // lstListe.Items.Remove(lstListe.SelectedItem);

            string[] silinecekler = new string[lstListe.SelectedItems.Count];

            for (int i = 0; i < lstListe.SelectedItems.Count; i++)
            {
                silinecekler[i] =(string) lstListe.SelectedItems[i];
            }

            foreach (string silinen in silinecekler)
            {
                lstListe.Items.Remove(silinen);
            }
        }
    }
}
