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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          string deger= YasimiHesapla(dateTimePicker1.Value).ToString();
            label1.Text = deger;


          



        }



        int YasimiHesapla(DateTime yil)
        {
            int sonuc;

            int dyil = yil.Year;
            sonuc = DateTime.Now.Year - dyil;
            return sonuc;
        }

        int YasimiHesapla(int yil,int dyil)
        {
            int sonuc;
            sonuc = DateTime.Now.Year-dyil;
            return sonuc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                int okunan = int.Parse(textBox1.Text);
                YasimiHesapla(DateTime.Now.Year, okunan);

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

           

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar!=8)
            {
                e.Handled = true;
                int gelenyil = int.Parse(textBox2.Text);

                YasimiHesapla(DateTime.Now.Year, gelenyil);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
