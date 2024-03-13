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
using Microsoft.Reporting.WinForms;
namespace WindowsFormsApp3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
          
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\aboul\\Documents\\test\\WindowsFormsApp3\\Formation.mdf;Integrated Security=True");
        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from beneficiaire where PPR=@a", connection);
            command.Parameters.AddWithValue("@a", textBox1.Text);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet2", dt);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\aboul\Documents\test\WindowsFormsApp3\دعوة حضور دورة تكوينية.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }
    
  
        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from beneficiaire where codeFor=@a", connection);
            command.Parameters.AddWithValue("@a", textBox2.Text);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet2", dt);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\aboul\Documents\test\WindowsFormsApp3\دعوة حضور دورة تكوينية.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from beneficiaire where codeFor=@a", connection);
            command.Parameters.AddWithValue("@a", textBox2.Text);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet2", dt);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\aboul\Documents\test\WindowsFormsApp3\Report20.rdlc";
 
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from beneficiaire where codeFor=@a", connection);
            command.Parameters.AddWithValue("@a", textBox2.Text);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet2", dt);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\aboul\Documents\test\WindowsFormsApp3\Report21.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from beneficiaire where codeFor=@a", connection);
            command.Parameters.AddWithValue("@a", textBox2.Text);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet2", dt);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\aboul\Documents\test\WindowsFormsApp3\Report23.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from beneficiaire where codeFor=@a", connection);
            command.Parameters.AddWithValue("@a", textBox2.Text);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet2", dt);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\aboul\Documents\test\WindowsFormsApp3\Report24.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from beneficiaire where NumProjet=@a", connection);
            command.Parameters.AddWithValue("@a", textBox3.Text);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet2", dt);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\aboul\Documents\test\WindowsFormsApp3\Report26.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
