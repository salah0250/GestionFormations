using Microsoft.Reporting.WinForms;
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
    public partial class Statistiques : Form
    {
        public Statistiques()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\aboul\\Documents\\test\\WindowsFormsApp3\\Formation.mdf;Integrated Security=True");

        private void button5_Click_1(object sender, EventArgs e)
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

        private void button6_Click_1(object sender, EventArgs e)
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

        private void button7_Click_1(object sender, EventArgs e)
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
        private void Statistiques_Load(object sender, EventArgs e)
        {

        }

       
    }
}
