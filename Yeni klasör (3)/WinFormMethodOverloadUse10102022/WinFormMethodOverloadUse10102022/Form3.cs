using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormMethodOverloadUse10102022
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             string gelentarih=  YasimiHesapla(dateTimePicker1.Value).ToString();
            // string gelentarih=  YasimiHesapla(textBox1.Text).ToString();
            label1.Text = gelentarih;
        }

        int YasimiHesapla(DateTime  tarih)
        {
            int sonuc;

            int dyil = tarih.Year;

            sonuc = DateTime.Now.Year - dyil;

            return sonuc;
        }

        int YasimiHesapla(string tarih)
        {
            int sonuc;


            int dyil = int.Parse(tarih);

            sonuc = DateTime.Now.Year - dyil;

            return sonuc;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string gelentarih = YasimiHesapla(textBox1.Text).ToString();
            label1.Text = gelentarih;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
