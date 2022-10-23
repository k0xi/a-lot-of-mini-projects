using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03102022WinFormsFirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Furkan Güleryüz";

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal sayi1 = numericUpDown1.Value;
            decimal sayi2 = numericUpDown2.Value;
            decimal sonuc;

            switch (cmbIslem.Text)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    textBox1.Text = sonuc.ToString();
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    textBox1.Text = sonuc.ToString();
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    textBox1.Text = sonuc.ToString();
                    break;
                case "/":
                    sonuc = sayi1 / sayi2;
                    textBox1.Text = sonuc.ToString();
                    break;
                case "%":
                    sonuc = sayi1 % sayi2;
                    textBox1.Text = sonuc.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
