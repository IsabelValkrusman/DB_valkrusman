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
using static System.Net.Mime.MediaTypeNames;


namespace DB_valkrusman
{
    public partial class kategooria : Form
    {
        
        public kategooria()
        {
           // this.Size = new System.Drawing.Size(600, 300);
        
           InitializeComponent();
            //TreeNode tovarNode = new TreeNode();
        
            //tovarNode.Name = "Tooted";
            //tovarNode.Text = "Tooted";
            ////this.treeView1.Nodes.Add("Puuviljad");
            //this.treeView2.Nodes.Add("Magus");


            //TreeNode tovarNode1 = new TreeNode();

            //tovarNode.Nodes.Add(new TreeNode("Puuviljad"));

            

            // tovarNode.Expand();
            //tovarNode.ExpandAll();
            // tovarNode.Collapse();

        }
        private void puuviljad_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("Banaan");
            treeView1.Nodes.Add("Apelsin");
            treeView1.Nodes.Add("Õun");
            treeView1.Nodes.Add("Greip");
        


            treeView1.Nodes[0].Nodes.Add("Aafrika banaan 20$/kg");
            treeView1.Nodes[0].Nodes.Add("Roheline banaan 25$/kg");
            treeView1.Nodes[0].Nodes.Add("Kollane banaan 15$/kg");

            treeView1.Nodes[1].Nodes.Add("Suur apelsin 30$/kg");
            treeView1.Nodes[1].Nodes.Add("Mahlane aelsin 23$/kg");
            treeView1.Nodes[1].Nodes.Add("Pakitud apelsin 15$/kg");

            treeView1.Nodes[2].Nodes.Add("Poola õun 5$/kg");
            treeView1.Nodes[2].Nodes.Add("Kodu õun 10$/kg");
            treeView1.Nodes[2].Nodes.Add("Väike õun 15$/kg");

            treeView1.Nodes[3].Nodes.Add("Vikerkaare greip 40$/kg");
            treeView1.Nodes[3].Nodes.Add("Kooritud greip 17$/kg");
            treeView1.Nodes[3].Nodes.Add("Mini greip 20$/kg");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //    TreeNode tovarNode = new TreeNode("korv");
            //    treeView1.BeginUpdate();
            //    treeView1.Nodes.Add(tovarNode);
            //    treeView1.Nodes[0].Nodes.Add("Banaan");
            //    treeView1.Nodes[0].Nodes.Add("Oun");
            //    treeView1.Nodes[0].Nodes.Add("Greip");
            //    treeView1.Nodes[0].Nodes.Add("Viinamari");
            //    treeView1.EndUpdate();
            //    treeView1.Nodes[0].Nodes.RemoveAt(0);



         }

          

        private void button1_Click(object sender, EventArgs e)
        {
            treeView2.Nodes.Add("Paprika");
            treeView2.Nodes.Add("Kurk");
            treeView2.Nodes.Add("Tomat");
            treeView2.Nodes.Add("Porgand");
        


            treeView2.Nodes[0].Nodes.Add("Portugalia paprika 16$/kg");
            treeView2.Nodes[0].Nodes.Add("Punane paprika 5$/kg");
            treeView2.Nodes[0].Nodes.Add("Kollane paprika 13$/kg");

            treeView2.Nodes[1].Nodes.Add("Pikk kurk 6$/kg");
            treeView2.Nodes[1].Nodes.Add("Lühike kurk 9$/kg");
            treeView2.Nodes[1].Nodes.Add("Kiles kurk 12$/kg");

            treeView2.Nodes[2].Nodes.Add("Kollane tomat 30$/kg");
            treeView2.Nodes[2].Nodes.Add("Oranz tomat 13$/kg");
            treeView2.Nodes[2].Nodes.Add("Mini tomat 6$/kg");

            treeView2.Nodes[3].Nodes.Add("Vikerkaare porgand 6$/kg");
            treeView2.Nodes[3].Nodes.Add("Kooritud porgand 23$/kg");
            treeView2.Nodes[3].Nodes.Add("Mini porgand 4$/kg");
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView3_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            treeView3.Nodes.Add("Kommid");
            treeView3.Nodes.Add("Marmelaad");
            treeView3.Nodes.Add("Halvaa");
            treeView3.Nodes.Add("Karamell");


            treeView3.Nodes[0].Nodes.Add("Masha kommid 23$/kg");
            treeView3.Nodes[0].Nodes.Add("Vikerkaare kommid 19$/kg");
            treeView3.Nodes[0].Nodes.Add("Purunevad kommid 21$/kg");

            treeView3.Nodes[1].Nodes.Add("Vedel marmelaad 20$/kg");
            treeView3.Nodes[1].Nodes.Add("Puuvilja marmelaad 32$/kg");
            treeView3.Nodes[1].Nodes.Add("Haribo marmelaad 4$/kg");

            treeView3.Nodes[2].Nodes.Add("Purunev halvaa 20$/kg");
            treeView3.Nodes[2].Nodes.Add("Niiske halvaa 6$/kg");
            treeView3.Nodes[2].Nodes.Add("Mango halvaa 25$/kg");

            treeView3.Nodes[3].Nodes.Add("Sokolaadi karamell 26$/kg");
            treeView3.Nodes[3].Nodes.Add("Pähkli karamell 27$/kg");
            treeView3.Nodes[3].Nodes.Add("Vanilje karamell 21$/kg");
        }

        private void treeView4_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView4.Nodes.Add("Saiakesed");
            treeView4.Nodes.Add("Jahu");
            treeView4.Nodes.Add("Küpsised");
            treeView4.Nodes.Add("Rullid");


            treeView4.Nodes[0].Nodes.Add("Kaneelisai 13$/kg");
            treeView4.Nodes[0].Nodes.Add("Moonisai 26$/kg");
            treeView4.Nodes[0].Nodes.Add("Pähklisai 22$/kg");

            treeView4.Nodes[1].Nodes.Add("Nisujahu 27$/kg");
            treeView4.Nodes[1].Nodes.Add("Isekerkiv jahu 21$/kg");
            treeView4.Nodes[1].Nodes.Add("Saia jahu 12$/kg");

            treeView4.Nodes[2].Nodes.Add("Domino küpsised 13$/kg");
            treeView4.Nodes[2].Nodes.Add("Oreo küpsised 5$/kg");
            treeView4.Nodes[2].Nodes.Add("Maasika küpsised 21$/kg");

            treeView4.Nodes[3].Nodes.Add("Maasika rullid 15$/kg");
            treeView4.Nodes[3].Nodes.Add("Sokolaadi rullid 12$/kg");
            treeView4.Nodes[3].Nodes.Add("Vanilje rullid 32$/kg");

        }

      
    }

}


