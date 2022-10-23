using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04102022WinFormGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Sinan Arslan";
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal sayi1 = 0;
            decimal sayi2 = 0;
            decimal sonuc = 0;

            sayi1 = nmSayi1.Value;
            sayi2 = nmSayi2.Value;

            switch (cmbIslem.Text)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    txtSonuc.Text = sonuc.ToString();
                    break;

                case "-":
                    sonuc = sayi1 - sayi2;
                    txtSonuc.Text = sonuc.ToString();
                    break;

                case "/":
                    sonuc = sayi1 / sayi2;
                    txtSonuc.Text = sonuc.ToString();
                    break;

                case "*":
                    sonuc = sayi1 * sayi2;
                    txtSonuc.Text = sonuc.ToString();
                    break;

                case "%":
                    sonuc = sayi1 % sayi2;
                    txtSonuc.Text = sonuc.ToString();
                    break;

                default:
                    break;
            }


        }
    }
}
