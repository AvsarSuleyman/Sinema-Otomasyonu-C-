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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

       
        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=sinema.accdb");
            DataSet verilecek = new DataSet();
            baglanti.Open();

            OleDbDataAdapter alveri = new OleDbDataAdapter("select *from Tablo2", baglanti);
            alveri.Fill(verilecek, "Tablo2");
            dataGridView1.DataSource = verilecek.Tables["Tablo2"];
            alveri.Dispose();
            baglanti.Close();
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=sinema.accdb");
            baglanti.Open();
            OleDbCommand alveri = new OleDbCommand("delete * from Tablo2 where film_adi='"+textBox2.Text+"' ", baglanti);
            alveri.ExecuteNonQuery();
            MessageBox.Show("Weri Silindi!!!");
            baglanti.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=sinema.accdb");
            DataSet verilecek = new DataSet();
            baglanti.Open();

            OleDbDataAdapter alveri = new OleDbDataAdapter("select *from Tablo2", baglanti);
            alveri.Fill(verilecek, "Tablo2");
            dataGridView1.DataSource = verilecek.Tables["Tablo2"];
            alveri.Dispose();
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=sinema.accdb");
            baglanti.Open();
            OleDbCommand alveri = new OleDbCommand("delete * from Tablo2 where film_adi='" + textBox2.Text + "' ", baglanti);
            alveri.ExecuteNonQuery();
            MessageBox.Show("Weri Silindi!!!");
            baglanti.Close();
        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            OleDbConnection baglanti;
            OleDbCommand komut;
            baglanti = new OleDbConnection("provider=microsoft.Ace.oledb.12.0; data source=sinema.accdb");
            DataSet vericek = new DataSet();
            baglanti.Open();
            komut = new OleDbCommand("insert into Tablo2 ([film_adi],[salon_no],[seans_saati],[yönetmen],[vizyon_tarihi],[tür],[puan]) values('" + textBox11.Text + "','" + textBox9.Text + "','" + textBox7.Text + "','" + textBox12.Text + "','" + textBox1.Text + "','" + textBox10.Text + "','" + textBox8.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("kayıt eklendi");

            baglanti.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form f1 = new Form1();
            f1.Show();
            this.Close();
        }
    }
}
