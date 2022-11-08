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
    public partial class kasutaja : Form
    {
        public kasutaja()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kassa1 Parid = new kassa1();
            Parid.ShowDialog();
        }
    }
}
