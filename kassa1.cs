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
    public partial class kassa1 : Form
    {
        //static string QueryString = @"C:\Users\opilane\source\repos\DB_valkrusman\Arved;Initial Catalog=TestDataBase;Integrated Security=True";
        //SqlConnection con = new SqlConnection(QueryString);
        SqlCommand cmd = new SqlCommand();
        SaveFileDialog sfd = new SaveFileDialog();
        RichTextBox rtb = new RichTextBox();

        OpenFileDialog openFileDialog;
        //SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\AppData\Tooded_DB.mdf;Integrated Security = True");
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\opilane\source\repos\DB_valkrusman\AppData\Tooded_DB.mdf;Integrated Security = True");
        SqlDataAdapter adapter_toode, adapter_kat;

        public kassa1()
        {
            InitializeComponent();
            Naita_Andmed();
            InitializeComponent();
        }



        private void Lisa_btn_Click(object sender, EventArgs e)
        {

            if (toode_txt.Text.Trim() != string.Empty && kogus_txt1.Text.Trim() != string.Empty && hind_txt1.Text.Trim() != string.Empty && Kat_cbox.SelectedItem != null)
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO Toodedtable(Toodenimetus,Kogus,Hind,Pilt,Kategooria_id) VALUES (@toode,@kogus,@hind,@pilt,@kat)", connect);
                    connect.Open();
                    cmd.Parameters.AddWithValue("@toode", toode_txt.Text);
                    cmd.Parameters.AddWithValue("@kogus", kogus_txt1.Text);
                    cmd.Parameters.AddWithValue("@hind", hind_txt1.Text);//format andmebaasis ja vormis võrdsed
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
            DataTable dt_toode = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT * FROM Toodedtable", connect);
            adapter_toode.Fill(dt_toode);
            dataGridView1.DataSource = dt_toode;

            Toode_gb.Image = Image.FromFile("../../Images/info.jpg");

            connect.Close();
            Naita_Kat();
        }

        public void Kustuta_andmed()
        {
            toode_txt.Text = " ";
            hind_txt1.Text = " ";
            kogus_txt1.Text = " ";
            Kat_cbox.Items.Clear();
        }


        private void Lisa_kat_btn_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("INSERT INTO Kategooria (Kategooria_nimetus) VALUES (@kat)", connect);
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
            connect.Close();
        }


        Random rand = new Random();
        SaveFileDialog save;
        OpenFileDialog open;

        public int Id { get; private set; }
        public object PdfWriter { get; private set; }

        private void Otsi_btn_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();

            open.InitialDirectory = @"C:\Users\opilane\source\repos\DB_valkrusman\Images";
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            FileInfo open_info = new FileInfo(@"C:\Users\opilane\source\repos\DB_valkrusman\Images" + open.FileName);
            if (open.ShowDialog() == DialogResult.OK && toode_txt != null)
            {
                save = new SaveFileDialog();
                save.InitialDirectory = Path.GetFullPath(@"..\..\Images");
                save.FileName = toode_txt.Text + Path.GetExtension(open.FileName); //".jpg";            
                save.Filter = "Image Files" + Path.GetExtension(open.FileName) + "|" + Path.GetExtension(open.FileName);


                if (save.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(open.FileName, save.FileName);
                    save.RestoreDirectory = true;
                    Toode_gb.Image = Image.FromFile(save.FileName);
                }
            }
        }

        private void Uuenda_btn_Click(object sender, EventArgs e)
        {
            if (toode_txt.Text != "" && kogus_txt1.Text != "" && hind_txt1.Text != "" && Toode_gb.Image != null)
            {
                cmd = new SqlCommand("UPDATE Toodetable  SET Toodenimetus=@toode,Kogus=@kogus,Hind=@hind, Pilt=@pilt WHERE Id=@id", connect);
                connect.Open();
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@toode", toode_txt.Text);
                cmd.Parameters.AddWithValue("@kogus", kogus_txt1.Text);
                cmd.Parameters.AddWithValue("@hind", hind_txt1.Text.Replace(",", "."));
                string file_pilt = toode_txt.Text + ".jpg";//kontroll
                cmd.Parameters.AddWithValue("@pilt", file_pilt);
                cmd.ExecuteNonQuery();
                connect.Close();
                Naita_Andmed();
                Kustuta_andmed();
                MessageBox.Show("Andmed uuendatud");
            }
            else
            {
                MessageBox.Show("Viga");
            }


        }

        //Document document=new Document();

        private void button1_Click(object sender, EventArgs e)
        {
            sfd.Title = "Save As PDF";
            sfd.Filter = "(*.pdf)|*.pdf";
            sfd.InitialDirectory = @"C:\";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                iTextSharp.text.Document doc = new iTextSharp.text.Document();
                // PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                doc.Open();
                doc.Add(new iTextSharp.text.Paragraph(rtb.Text));
                doc.Close();
            }
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;//kui andmed puuduvad reas
                toode_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                kogus_txt1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                hind_txt1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                Toode_gb.Image = Image.FromFile(@"..\..\Images\" + dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                string v = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                Kat_cbox.SelectedIndex = Int32.Parse(v) - 1;

            }
            catch (Exception)
            {
                MessageBox.Show("Seda pilti ei ole! Lisa pilt! ");
            }





        }


    }
}