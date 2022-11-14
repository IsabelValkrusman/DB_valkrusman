using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


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
            {
                //SqlConnection con = new SqlConnection("Data Source=NiluNilesh;Integrated Security=True");  
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\opilane\source\repos\DB_valkrusman\AppData\Tooded_DB.mdf;Integrated Security = True");
                SqlCommand cmd = new SqlCommand("INSERT INTO Kasutajad (Kasutaja, Parool) VALUES (@Kasutaja, @Paroolid)", con);
                //SqlCommand cmd = new SqlCommand(@"sp_insert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Kasutaja", textBox1.Text);
                cmd.Parameters.AddWithValue("@Paroolid", textBox2.Text);


                con.Open();
               cmd.ExecuteNonQuery();
                con.Close();
               




            }

          
        }

     
    }
}
