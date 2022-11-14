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


        //public class WelcomePage
        //{

        //}
        //TextWriter txt = new StreamWriter("C:\\Users\\opilane\\source\\repos\\DB_valkrusman\\kasutajad");

        public omanik()
        {
            InitializeComponent();
        }
    
        
        private void button1_Click(object sender, EventArgs e)
        { //Connection String   
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\opilane\source\repos\DB_valkrusman\AppData\Tooded_DB.mdf;Integrated Security = True");
            SqlCommand cmd = new SqlCommand("select * from Userlogins where Kasutaja=@kasutaja and Parool =@Parool", con);
            cmd.Parameters.AddWithValue("@kasutaja", textBox1.Text);
            cmd.Parameters.AddWithValue("@Parool", textBox2.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //Connection open here   
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Logimine õnnestus");
                //after successful it will redirect  to next page .  
                omanik settingsForm = new omanik();
                settingsForm.Show();

                Form1 Parid = new Form1();
                Parid.ShowDialog();
            }
            else
            {
                MessageBox.Show("Palun lisa korektne parool ja kasutaja");
           
            }


        }

     
        
    }
}
