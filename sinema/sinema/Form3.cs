﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sinema
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f5 = new Form5();
            Form3.ActiveForm.Hide();
            f5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f4 = new Form4();
            Form3.ActiveForm.Hide();
            f4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f5 = new Form5();
            Form3.ActiveForm.Hide();
            f5.Show();
        }
    }
}
