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
    public partial class repport : Form
    {
        public repport()
        {
            InitializeComponent();
        }
       
        private void repport_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSet2.Beneficiaire'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.reportViewer1.RefreshReport();
           
        }
        SqlConnection connection =  new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\aboul\\Documents\\test\\WindowsFormsApp3\\Formation.mdf;Integrated Security=True");
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                beneficiaireTableAdapter.Fill(this.dataSet2.Beneficiaire);
                reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                reportViewer1.LocalReport.ReportPath = @"C:\Users\aboul\Documents\test\WindowsFormsApp3\دعوة حضور دورة تكوينية.rdlc";
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", dataSet2.Tables[0]));
                reportViewer1.RefreshReport();
               
            }
            catch (Exception ex) { }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from beneficiaire ", connection);
      
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet2", dt);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\aboul\Documents\test\WindowsFormsApp3\Report18.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from beneficiaire where codeFor=@a", connection);
            command.Parameters.AddWithValue("@a", textBox3.Text);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet2", dt);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\aboul\Documents\test\WindowsFormsApp3\Report21.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
