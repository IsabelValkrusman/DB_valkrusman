using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_valkrusman
{
    public partial class pood : Form
    {
        public pood()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Parid = new Form1();
            Parid.ShowDialog();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kasutaja Parid = new kasutaja();
            Parid.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            omanik Parid = new omanik();
            Parid.ShowDialog();
        }
    }
}
