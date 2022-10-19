using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_valkrusman
{
    public partial class Form1 : Form
    {
        //SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\AppData\Tooded_DB.mdf;Integrated Security = True");
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\opilane\source\repos\DB_valkrusman\AppData\Tooded_DB.mdf;Integrated Security = True");
        SqlCommand cmd;
        SqlDataAdapter adapter_toode, adapter_kat;
       // C:\Users\opilane\source\repos\DB_valkrusman\AppData\Tooded_DB.mdf

        public Form1()
        {
            InitializeComponent();
            Naita_Andmed();
        }

       


        private void Lisa_btn_Click(object sender, EventArgs e)
        {

            if (toode_txt.Text.Trim() != string.Empty && kogus_txt.Text.Trim() != string.Empty && hind_txt.Text.Trim() != string.Empty && Kat_cbox.SelectedItem != null)
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO Toodedtable(Toodenimetus,Kogus,Hind,Pilt,Kategooria_id) VALUES (@toode,@kogus,@hind,@pilt,@kat)", connect);
                    connect.Open();
                    cmd.Parameters.AddWithValue("@toode", toode_txt.Text);
                    cmd.Parameters.AddWithValue("@kogus", kogus_txt.Text);
                    cmd.Parameters.AddWithValue("@hind", hind_txt.Text);//format andmebaasis ja vormis võrdsed
                    cmd.Parameters.AddWithValue("@pilt", toode_txt.Text + ".jpg"); //format?
                    cmd.Parameters.AddWithValue("@kat", Kat_cbox.SelectedIndex + 1);//id andmebaasist võtta
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    Kustuta_andmed();
                    Naita_Andmed();

                }
                catch (Exception)
                {
                    MessageBox.Show("Andmebaasiga viga!");
                }
            }
            else
            {
                MessageBox.Show("Sisesta andmeid");
            }

        }


        public void Naita_Andmed()
        {
            connect.Open();
            DataTable dt_toode=new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT * FROM Toodedtable",connect);
            adapter_toode.Fill(dt_toode);
            dataGridView1.DataSource = dt_toode;
            
            Toode_gb.Image = Image.FromFile("../../Images/info.jpg");

            connect.Close();
            Naita_Kat();
        }

        public void Kustuta_andmed()
        {
            toode_txt.Text = " ";
            hind_txt.Text = " ";
            kogus_txt.Text = " ";
            Kat_cbox.Items.Clear();
        }


        private void Lisa_kat_btn_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand("INSERT INTO Kategooria(Kategooria_nimetus)VALUES(@kat)", connect);
            connect.Open();
            cmd.Parameters.AddWithValue("@kat", Kat_cbox.Text);
            cmd.ExecuteNonQuery();
            connect.Close();
            Kustuta_andmed();
            Naita_Kat();

        }


        public void Naita_Kat()
        {
            connect.Open();
            adapter_kat = new SqlDataAdapter("SELECT Kategooria_nimetus FROM Kategooria", connect);
            DataTable dt_kat = new DataTable();
            adapter_kat.Fill(dt_kat);
            foreach (DataRow nimetus in dt_kat.Rows)
            {
                Kat_cbox.Items.Add(nimetus["Kategooria_nimetus"]);
            }
            connect.Close();
        }

      

      















        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        
        private void Toode_gb_Click(object sender, EventArgs e)
        {

        }
    }
}
