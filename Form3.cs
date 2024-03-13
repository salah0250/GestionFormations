using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\aboul\\Documents\\test\\WindowsFormsApp3\\Formation.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rd;
        SqlDataAdapter adapt;
        public Form3()
        {
            InitializeComponent();
            DisplayData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

   

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            forConfi.Items.Add("encadrent");
            forConfi.Items.Add("professeur");
          
        }
        private void DisplayData()
        {
            cn.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Beneficiaire", cn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }
        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

  

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox8.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox16.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox14.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox15.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox13.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox12.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            textBox11.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            textBox18.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            textBox17.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
            forConfi.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            try
            {
                cmd.CommandText = "select * from Formations where CodeFor=@a";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@a", textBox1.Text);
                cn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    textBox1.Text = rd[0].ToString();
                    textBox2.Text = rd[5].ToString();
                    textBox3.Text = rd[7].ToString();
                    textBox4.Text = rd[11].ToString();
                   textBox18.Text= rd[2].ToString();
                    textBox5.Text = rd[6].ToString();
                    textBox6.Text = rd[8].ToString();
                    textBox7.Text = rd[10].ToString();
                    textBox11.Text = rd[9].ToString();
                    textBox17.Text = rd[12].ToString();
                    textBox19.Text = rd[3].ToString();
                    textBox20.Text = rd[1].ToString();
                }
                rd.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { cn.Close(); }
        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            try
            {
                cmd.CommandText = "select * from DATAIDENTIFPERSONNEL where PPR=@a";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@a", textBox8.Text);
                cn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    textBox16.Text = rd[14].ToString() + rd[15].ToString();
                    textBox10.Text = rd[16].ToString();
                    textBox9.Text = rd[17].ToString();
                    textBox14.Text = rd[18].ToString() + "/" + rd[19].ToString() + "/" + rd[20].ToString();
                    textBox15.Text = rd[22].ToString();
                    textBox12.Text = rd[54].ToString();
                    textBox13.Text = rd[52].ToString();

                }
                rd.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { cn.Close(); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            try
            {
                cmd.CommandText = "Delete Beneficiaire where PPR=@a";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@a", textBox8.Text);
                cmd.Parameters.AddWithValue("@b", textBox16.Text);
                cmd.Parameters.AddWithValue("@c", textBox9.Text);
                cmd.Parameters.AddWithValue("@d", textBox10.Text);
                cmd.Parameters.AddWithValue("@e", textBox14.Text);
                cmd.Parameters.AddWithValue("@f", textBox15.Text);
                cmd.Parameters.AddWithValue("@g", textBox13.Text);
                cmd.Parameters.AddWithValue("@K", textBox12.Text);
                cmd.Parameters.AddWithValue("@L", textBox1.Text);
                cmd.Parameters.AddWithValue("@M", textBox2.Text);
                cmd.Parameters.AddWithValue("@N", textBox3.Text);
                cmd.Parameters.AddWithValue("@O", textBox4.Text);
                cmd.Parameters.AddWithValue("@P", textBox5.Text);
                cmd.Parameters.AddWithValue("@Q", textBox6.Text);
                cmd.Parameters.AddWithValue("@R", textBox7.Text);
                cmd.Parameters.AddWithValue("@S", textBox11.Text);
                cmd.Parameters.AddWithValue("@T", textBox18.Text);
                cmd.Parameters.AddWithValue("@U", textBox17.Text);
                cmd.Parameters.AddWithValue("@w", forConfi.Text);
                cn.Open();

                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("La supression est fait par succee");


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { cn.Close(); }
            cmd.CommandText = "Select * from Beneficiaire ";
            cn.Open();
            rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(rd);
            rd.Close();
            dataGridView1.DataSource = dt;

            cn.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            try
            {
                cmd.CommandText = "insert into Beneficiaire values(@a,@b,@c,@d,@e,@f,@g,@k,@L,@M,@N,@O,@P,@Q,@R,@S,@T,@U,@W)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@a", textBox8.Text);
                cmd.Parameters.AddWithValue("@b", textBox16.Text);
                cmd.Parameters.AddWithValue("@c", textBox9.Text);
                cmd.Parameters.AddWithValue("@d", textBox10.Text);
                cmd.Parameters.AddWithValue("@e", textBox14.Text);
                cmd.Parameters.AddWithValue("@f", textBox15.Text);
                cmd.Parameters.AddWithValue("@g", textBox13.Text);
                cmd.Parameters.AddWithValue("@K", textBox12.Text);
                cmd.Parameters.AddWithValue("@L", textBox1.Text);
                cmd.Parameters.AddWithValue("@M", textBox2.Text);
                cmd.Parameters.AddWithValue("@N", textBox3.Text);
                cmd.Parameters.AddWithValue("@O", textBox4.Text);
                cmd.Parameters.AddWithValue("@P", textBox5.Text);
                cmd.Parameters.AddWithValue("@Q", textBox6.Text);
                cmd.Parameters.AddWithValue("@R", textBox7.Text);
                cmd.Parameters.AddWithValue("@S", textBox11.Text);
                cmd.Parameters.AddWithValue("@T", textBox18.Text);
                cmd.Parameters.AddWithValue("@U", textBox17.Text);
                cmd.Parameters.AddWithValue("@W", forConfi.Text);
                cn.Open();

                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("L'ajoute est fait par succee");


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { cn.Close(); }
            cmd.CommandText = "Select * from Beneficiaire ";
            cn.Open();
            rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(rd);
            rd.Close();
            dataGridView1.DataSource = dt;


            cn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            try
            {
                cmd.CommandText = " Update Beneficiaire set NometPrenom=@b,NOM_ETABA=@c,LA_Fonc=@d,DateNaissance=@e,GENRE=@f,Milieu=@g,Commun=@k,CodeFor=@L,NumProjet=@M,Sujet=@N,Lieu=@O,Dommaine=@P,CategorieBeneficiaire=@Q,ForConfi=@R,NembreBeneficiaire=@S,Date=@T,Heure=@U,Type=@W where PPR=@a";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@a", textBox8.Text);
                cmd.Parameters.AddWithValue("@b", textBox16.Text);
                cmd.Parameters.AddWithValue("@c", textBox9.Text);
                cmd.Parameters.AddWithValue("@d", textBox10.Text);
                cmd.Parameters.AddWithValue("@e", textBox14.Text);
                cmd.Parameters.AddWithValue("@f", textBox15.Text);
                cmd.Parameters.AddWithValue("@g", textBox13.Text);
                cmd.Parameters.AddWithValue("@K", textBox12.Text);
                cmd.Parameters.AddWithValue("@L", textBox1.Text);
                cmd.Parameters.AddWithValue("@M", textBox2.Text);
                cmd.Parameters.AddWithValue("@N", textBox3.Text);
                cmd.Parameters.AddWithValue("@O", textBox4.Text);
                cmd.Parameters.AddWithValue("@P", textBox5.Text);
                cmd.Parameters.AddWithValue("@Q", textBox6.Text);
                cmd.Parameters.AddWithValue("@R", textBox7.Text);
                cmd.Parameters.AddWithValue("@S", textBox11.Text);
                cmd.Parameters.AddWithValue("@T", textBox18.Text);
                cmd.Parameters.AddWithValue("@U", textBox17.Text);
                cmd.Parameters.AddWithValue("@W", forConfi.Text);
                cn.Open();

                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("La modification est fait par succee");


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { cn.Close(); }
            cmd.CommandText = "Select * from Beneficiaire ";
            cn.Open();
            rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Load(rd);
            rd.Close();
            dataGridView1.DataSource = dt;

            cn.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox8.Text = " ";
            textBox16.Text = " ";
            textBox9.Text = " ";
            textBox10.Text = " ";
            textBox14.Text = " ";
            textBox15.Text = " ";
            textBox13.Text = " ";
            textBox12.Text = " ";
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";
            textBox11.Text = " ";
            textBox18.Text = " ";
            textBox17.Text = " ";
            forConfi.Text = " ";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
