using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavCalisma9c
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            ListViewItem satir = new ListViewItem();
            satir.Text = txtAdSoyad.Text;
            satir.SubItems.Add(txtTCNO.Text);

            if(rdbErkek.Checked)
            {

            }
            else
            {

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void rdbErkek_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
