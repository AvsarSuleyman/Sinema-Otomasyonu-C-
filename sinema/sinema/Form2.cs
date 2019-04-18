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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti;
            OleDbCommand komut;
            baglanti = new OleDbConnection("provider=microsoft.Ace.oledb.12.0; data source=sinema.accdb");
            baglanti.Open();

            komut = new OleDbCommand("insert into Tablo1 ([tc],[ad],[soyad],[kullanici_adi],[kullanici_sifre],[e-posta],[tel]) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Tebrikler Kaydınız Tamamlandı");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f1 = new Form1();
            f1.Show();
            this.Close();
        }
    }
}
