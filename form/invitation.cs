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
    public partial class invitation : Form
    {
        public invitation()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\aboul\\Documents\\test\\WindowsFormsApp3\\Formation.mdf;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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
    }
}
