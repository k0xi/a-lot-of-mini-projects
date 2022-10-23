using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03102022WinFormListeleyiciler2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lstListe.Items.Add(txtEkle.Text);
            txtEkle.Clear();
            txtEkle.Focus();
        }

        private void btnSiliniz_Click(object sender, EventArgs e)
        {

            string[] silinecekveri = new string[lstListe.SelectedItems.Count];

            for (int i = 0; i < lstListe.SelectedItems.Count; i++)
            {
                silinecekveri[i] =(string) lstListe.SelectedItems[i];
            }


            foreach (string silinen in silinecekveri)
            {
                lstListe.Items.Remove(silinen);
            }


            /*
             1 adet combobox ismi cmbDersler
             1 adet textbox ismi txtDersEkle
             1 adet button ismi btnEkle
             1adet listbox ismi lstListe
             
             

            Combo tür dersler listelensin
            Textboxa ders adları girilsin listboxa eklensin
             
             
             */




           
        }
    }
}
