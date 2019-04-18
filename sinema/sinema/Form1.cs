using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace sinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kuladi = textBox1.Text;
            string sifre = textBox2.Text;
            OleDbConnection baglanti;
            OleDbCommand komut;
            OleDbDataReader sorguu;
            baglanti = new OleDbConnection("provider=microsoft.Ace.oledb.12.0; data source=sinema.accdb");
            baglanti.Open();
            komut = new OleDbCommand(("select * from tablo1 where kullanici_adi='" + textBox1.Text + "' and kullanici_sifre='" + textBox2.Text + "'"), baglanti);
            sorguu = komut.ExecuteReader();
            if (sorguu.Read())
            {
                MessageBox.Show("hosgeldiniz ");
                Form f3 = new Form3();
                Form1.ActiveForm.Hide();
                f3.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            Form1.ActiveForm.Hide();
            f2.Show();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

            Form f6 = new Form6();
            Form1.ActiveForm.Hide();
            f6.Show();
        }
    }
}
