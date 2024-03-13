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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\aboul\\Documents\\test\\Nouveau dossier\\WindowsFormsApp3\\Formation.mdf;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void formationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

     

        private void button1_Click(object sender, EventArgs e)
        {
             Form2 frm = new Form2();
             frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String username, user_password;
            username = textBox1.Text;
            user_password = textBox2.Text;

            
                String querry = "SELECT * FROM admin WHERE Num = '"+textBox1.Text+"' AND MotdePasse = '"+textBox2.Text+ "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry,cn);
                DataTable dt = new DataTable();
            try { sda.Fill(dt); }
                catch(Exception ex) { }
                if(dt.Rows.Count ==1)
                {
                    Form5 frm = new Form5();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("invalide donnes","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
