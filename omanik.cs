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
    public partial class omanik : Form
    {
        //TextWriter txt = new StreamWriter("C:\\Users\\opilane\\source\\repos\\DB_valkrusman\\kasutajad");

        public omanik()
        {
            InitializeComponent();
        }
   
        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox3.Text != string.Empty || textBox2.Text != string.Empty || textBox1.Text != string.Empty)
            //{
            //    if (textBox2.Text == textBox3.Text)
            //    {
            //        txt = new SqlCommand("select * from LoginTable where username='" + textBox1.Text + "'", txt);
            //        txt = txt.ExecuteReader();
            //        if (txt.Read())
            //        {
            //            txt.Close();
            //            MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        else
            //        {
            //            txt.Close();
            //            txt = new SqlCommand("insert into LoginTable values(@username,@password)", txt);
            //            txt.Parameters.AddWithValue("username", textBox1.Text);
            //            txt.Parameters.AddWithValue("password", textBox2.Text);
            //            txt.ExecuteNonQuery();
            //            MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            Form1 Parid = new Form1();
            Parid.ShowDialog();
        }
    }
}
