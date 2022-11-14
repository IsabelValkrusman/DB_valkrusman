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
            kategooria Parid = new kategooria();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            soodustus Parid = new soodustus();
            Parid.ShowDialog();
        }

        private void pood_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Bitmap pilt = new Bitmap(@"..\..\sport.jpg");

            //load image in picturebox
            //pilt.Image = bmp;

            //write image
            //bmp.Save(@"..\..\sport.jpg");

            MessageBox.Show(pilt.ToString());

           
        }
    }
}
