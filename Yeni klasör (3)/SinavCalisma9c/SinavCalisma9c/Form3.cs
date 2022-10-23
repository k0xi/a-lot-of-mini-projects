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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ListViewItem satir = new ListViewItem();
            satir.Text = txtAdSoyad.Text;
            satir.SubItems.Add(txtTCNO.Text);
            if (rdbErkek.Checked)
            {
                satir.SubItems[2].Text = "Erkek";
            }
            else
            {
                satir.SubItems[2].Text = "Kız";
            }

        }

        private void rdbErkek_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
