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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("provider=microsoft.Ace.oledb.12.0; data source=sinema.accdb");
            baglanti.Open();
            OleDbCommand cmdgrs = new OleDbCommand("Select * From Tablo1 where tc='" + textBox1.Text.ToString() + "'", baglanti);
            OleDbDataReader rd = cmdgrs.ExecuteReader();
            while (rd.Read())
            {
                if (textBox1.Text.ToString() == rd["tc"].ToString())
                {

                    label3.Visible = true;
                    label3.Text = rd["kullanici_sifre"].ToString();

                }
                else
                    {
                        MessageBox.Show("Hata!!!");

                    }
            } baglanti.Close();
        }
    }
}
