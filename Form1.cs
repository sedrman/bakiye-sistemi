using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakiye_Sistemi
{
    public partial class Form1 : Form
    {
        double bakiye = 0.00;
        public Form1()
        {
            InitializeComponent();

        }


        private void button3_Click(object sender, EventArgs e)
        {
            lstgecmis.Items.Clear();
            MessageBox.Show("Geçmiş Silindi...", "Bildirim");
        }

        private void btngelir_Click(object sender, EventArgs e)
        {
            string deger = txtdeger.Text;
            string urun = txturun.Text;

            if (deger== "" || urun =="")
            {
                MessageBox.Show("Hatalı Giriş, Lütfen Tekrar Deniyiniz.", "Uyarı!");
            }
            else
            {
                lstgecmis.Items.Add(urun + " (+₺" + deger + ")");
                double intdeger = Convert.ToDouble(deger);
                bakiye = bakiye + intdeger;
                label4.Text = bakiye.ToString("#0.00");
                txtdeger.Clear();
                txturun.Clear();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btngider_Click(object sender, EventArgs e)
        {
            string deger = txtdeger.Text;
            string urun = txturun.Text;

            if (deger == "" || urun == "")
            {
                MessageBox.Show("Hatalı Giriş, Lütfen Tekrar Deniyiniz.", "Uyarı!");
            }
            else
            {
                lstgecmis.Items.Add(urun + " (-₺" + deger + ")");
                double intdeger = Convert.ToDouble(deger);
                bakiye = bakiye - intdeger;
                label4.Text = bakiye.ToString("#0.00");
                txtdeger.Clear();
                txturun.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
