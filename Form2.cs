﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortalSpreLumeaMuzicii
{
    public partial class Cuprins : Form
    {
        public Cuprins()
        {
            InitializeComponent();
        }

        private void Cuprins_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.ShowDialog();
            form5 = null;
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            //Start start = new Start();
            //start.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
            form3 = null;
            this.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();
            form4 = null;
            this.Show();
        }
    }
}
