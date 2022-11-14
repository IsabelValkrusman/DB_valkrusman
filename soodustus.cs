using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_valkrusman
{
    public partial class soodustus : Form
    {


        public soodustus()
        {
            InitializeComponent();
        }

        private void soodustus_Load(object sender, EventArgs e)
        {

        }

        private void arvuta_Click(object sender, EventArgs e)
        {
            int originalhind = 0;
            double soodustus, annabsoodustuse, muugihind = 0;

            originalhind = int.Parse(tootehind.Text);
            soodustus = double.Parse(soodus.Text);

            annabsoodustuse = originalhind * (soodustus / 100);
            muugihind = originalhind - annabsoodustuse;

            hindAlla.Text= annabsoodustuse.ToString();
            muugiHind.Text=muugihind.ToString();
        }

       
    }
}
