using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatewayToTheWorldOfMusic
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
            Tutorial tutorial = new Tutorial();
            tutorial.ShowDialog();
            tutorial = null;
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
            Piano piano = new Piano();
            piano.ShowDialog();
            piano = null;
            this.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Testing testing = new Testing();
            testing.ShowDialog();
            testing = null;
            this.Show();
        }
    }
}
