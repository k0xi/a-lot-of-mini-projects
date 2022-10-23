using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm21102022Demo9B
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
            satir.Text = txtAdSoyad.Text;
            satir.SubItems.Add(txtTCNO.Text);
            if (rdbErkek.Checked)
            {
                satir.SubItems.Add("Erkek");
            }
            else
            {
                satir.SubItems.Add("KIZ");
            }
            //satir.SubItems.Add();
            //satir.SubItems.Add();
            //satir.SubItems.Add();
        }
    }
}
