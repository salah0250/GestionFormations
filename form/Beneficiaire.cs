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

namespace WindowsFormsApp3.form
{
    public partial class Beneficiaire : Form
    {
        public Beneficiaire()
        {
            InitializeComponent();
            DisplayData();
        }
        SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\aboul\\Documents\\test\\WindowsFormsApp3\\Formation.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rd;
        SqlDataAdapter adapt;
        private void Beneficiaire_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

    }
}
