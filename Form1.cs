using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_valkrusman
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog;
        //SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\AppData\Tooded_DB.mdf;Integrated Security = True");
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\opilane\source\repos\DB_valkrusman\AppData\Tooded_DB.mdf;Integrated Security = True");
        SqlCommand cmd;
        SqlDataAdapter adapter_toode, adapter_kat;
        private SaveFileDialog save;

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

        private void Kustuta_btn_Click(object sender, EventArgs e)
        {
            //if(MessageBox.Show("Toode-Jah/Kategooria-Ei","Mida soovite kustutada?",MessageBoxButtons.YesNo)==0)
            {

                if (dataGridView1.SelectedRows.Count == 0)
                    return;

                string sql = "DELETE FROM Toodedtable WHERE id=@rowID";

                using (SqlCommand deleteRecord = new SqlCommand(sql, connect))
                {
                    connect.Open();
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    int rowID = Convert.ToInt32(dataGridView1[0, selectedIndex].Value);

                    deleteRecord.Parameters.Add("@rowID", SqlDbType.Int).Value = rowID;
                    deleteRecord.ExecuteNonQuery();

                    dataGridView1.Rows.RemoveAt(selectedIndex);
                }
            }
            //else
            //{
            //    if (Kat_cbox.Text == "") return;
            //    string sql = "DELETE FROM Kategooria WHERE Kategooria_nimetus=@kat";
            //    using (SqlCommand deleteRecord = new SqlCommand(sql, connect))
            //    {
            //        deleteRecord.Parameters.AddWithValue("@kat", Kat_cbox.Text);
            //        deleteRecord.ExecuteNonQuery();
            //    }
            //}
            connect.Close();
        }

        openFileDialog open;
        PictureBox pictureBox1;
       Random rand=new Random();

        public int Id { get; private set; }

        private void Otsi_btn_Click(object sender, EventArgs e)
        {

            //openFileDialog.InitialDirectory = @"C:\Users\opilane\source\repos\DB_valkrusman\Images";
            //if(openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    string ext=Path.GetExtension(openFileDialog.FileName);
            //    pictureBox1.Load(openFileDialog.FileName);
            //    Bitmap finalImg = new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);
            //    pictureBox1.Image= finalImg;
            //    pictureBox1.Show();
            //    string destinationFile;
            //    try
            //    {
            //        destinationFile = @"..\..\pictures\" + toode_txt.Text + ext;
            //        File.Copy(openFileDialog.FileName, destinationFile);
            //    }
            //    catch
            //    {
            //        destinationFile = @"..\..\pictures\" + toode_txt + rand.Next(1, 99999).ToString() + ext;
            //    }
            //}


            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All files(*.*) | *.jpg | PNG Files(*.png) | *.png | BMP Files(*.bmp) | *.bmp | All files(*.*) | *.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Toode_gb.Load(openFileDialog.FileName);
            }
        }

        private void Uuenda_btn_Click(object sender, EventArgs e)
        {
            if (toode_txt.Text.Trim() != string.Empty && kogus_txt.Text.Trim() != string.Empty && hind_txt.Text.Trim() != string.Empty && Kat_cbox.SelectedItem != null)
            {
                try
                {
                    cmd = new SqlCommand("UPDATE Toodedtable SET Toodenimetus,Kogus,Hind,Pilt,Kategooria_id) VALUES (@toode,@kogus,@hind,@pilt,@kat)", connect);
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

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;//kui andmed puuduvad reas
            toode_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            kogus_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            hind_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            Toode_gb.Image = Image.FromFile(@"..\..\Images\" + dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            string v = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            Kat_cbox.SelectedIndex=Int32.Parse(v)-1;
        }


         
    }
}
