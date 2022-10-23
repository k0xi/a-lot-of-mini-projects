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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



            return;




        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sonuc = TariheGoreHesapla(dateTimePicker1.Value).ToString();
            label1.Text = sonuc;
            

        }

       

        int TariheGoreHesapla(DateTime tarih)//Method tanımı ve parametreleri
        {
            int sonuc;//geriye değer döndereceğim değişken
            int dogumyil = tarih.Year;
            sonuc = DateTime.Now.Year - dogumyil;
            return sonuc;//geriye değer dönderdim!
        }
    }
}
