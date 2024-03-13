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
using Microsoft.Office.Interop.Excel;
using System.IO;
using ExcelDataReader;
using ClosedXML.Excel;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\aboul\\Documents\\test\\WindowsFormsApp3\\Formation.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlDataReader rd;
        int ID = 0;
        public Form2()
        {
            InitializeComponent();
            DisplayData();
        

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            forConfi.Items.Add("presentiel");
            forConfi.Items.Add("A distance");
        }

        private void DisplayData()
        {
            cn.Open();
            System.Data.DataTable dt = new System.Data.DataTable();
            adapt = new SqlDataAdapter("select * from formations", cn);
            Column1.DataPropertyName = "codefor";
            Column2.DataPropertyName = "Mois";
            Column3.DataPropertyName = "Date";
            Column4.DataPropertyName = "Jour";
            Column5.DataPropertyName = "NumDomaine";
            Column6.DataPropertyName = "NumProjet";
            Column7.DataPropertyName = "Domaine";
            Column8.DataPropertyName = "Sujet";
            Column9.DataPropertyName = "CategorieBeneficiaire";
            Column10.DataPropertyName = "NembreBeneficiaire";
            Column11.DataPropertyName = "ForConfi";
            Column12.DataPropertyName = "Lieu";
           
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }
        private void ClearData()
        {
            codefor.Text = "";
            mois.Text = "";
            date.Text = "";
            jour.Text = "";
            numDomaine.Text = "";
            numProjet.Text = "";
            CategorieBeneficiaire.Text = "";
            NembreBeneficiaire.Text = "";
            forConfi.Text = "";
            codefor.Text = "";
            lieu.Text = "";
            heure.Text = "";
            ID = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            codefor.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            mois.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            date.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            jour.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            numDomaine.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            numProjet.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            Domaine.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            sujet.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            CategorieBeneficiaire.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            NembreBeneficiaire.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            forConfi.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            lieu.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            heure.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void ajouter_Click_1(object sender, EventArgs e)
        {

            if (codefor.Text != "" && numProjet.Text != "")
            {
                cmd = new SqlCommand("insert into formations(CodeFor,Mois,Date,Jour,NumDomaine,NumProjet,Domaine,Sujet,CategorieBeneficiaire,NembreBeneficiaire,ForConfi,Lieu,Heure) values(@CodeFor,@Mois,@Date,@Jour,@NumDomaine,@NumProjet,@Domaine,@Sujet,@CategorieBeneficiaire,@NembreBeneficiaire,@ForConfi,@Lieu,@Heure)", cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@CodeFor", codefor.Text);
                cmd.Parameters.AddWithValue("@Mois", mois.Text);
                cmd.Parameters.AddWithValue("@Date", date.Text);
                cmd.Parameters.AddWithValue("@Jour", jour.Text);
                cmd.Parameters.AddWithValue("@NumDomaine", numDomaine.Text);
                cmd.Parameters.AddWithValue("@NumProjet", numProjet.Text);
                cmd.Parameters.AddWithValue("@Domaine", Domaine.Text);
                cmd.Parameters.AddWithValue("@Sujet", sujet.Text);
                cmd.Parameters.AddWithValue("@CategorieBeneficiaire", CategorieBeneficiaire.Text);
                cmd.Parameters.AddWithValue("@NembreBeneficiaire", NembreBeneficiaire.Text);
                cmd.Parameters.AddWithValue("@ForConfi", forConfi.Text);
                cmd.Parameters.AddWithValue("@Lieu", lieu.Text);
                cmd.Parameters.AddWithValue("@Heure", heure.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Enregistrement inséré avec succès");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("SVP fournir plus des détails!");
            }
        }

    
        private void update_Click_1(object sender, EventArgs e)
        {
            if (codefor.Text != "" && numProjet.Text != "")
            {
                cmd = new SqlCommand("update formations set Mois=@Mois,Date=@Date,Jour=@Jour,NumDomaine=@NumDomaine,NumProjet=@NumProjet,Domaine=@Domaine,Sujet=@Sujet,CategorieBeneficiaire=@CategorieBeneficiaire,NembreBeneficiaire=@NembreBeneficiaire,ForConfi=@ForConfi,Lieu=@Lieu,Heure=@Heure where CodeFor=@CodeFor", cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@CodeFor", codefor.Text);
                cmd.Parameters.AddWithValue("@Mois", mois.Text);
                cmd.Parameters.AddWithValue("@Date", date.Text);
                cmd.Parameters.AddWithValue("@Jour", jour.Text);
                cmd.Parameters.AddWithValue("@NumDomaine", numDomaine.Text);
                cmd.Parameters.AddWithValue("@NumProjet", numProjet.Text);
                cmd.Parameters.AddWithValue("@Domaine", Domaine.Text);
                cmd.Parameters.AddWithValue("@Sujet", sujet.Text);
                cmd.Parameters.AddWithValue("@CategorieBeneficiaire", CategorieBeneficiaire.Text);
                cmd.Parameters.AddWithValue("@NembreBeneficiaire", NembreBeneficiaire.Text);
                cmd.Parameters.AddWithValue("@ForConfi", forConfi.Text);
                cmd.Parameters.AddWithValue("@Lieu", lieu.Text);
                cmd.Parameters.AddWithValue("@Heure", heure.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Enregistrement mis à jour avec succès");
                cn.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner Enregistrer pour mettre à jour");
            }
        }

        private void delete_Click_1(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete from formations where CodeFor=@CodeFor", cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@CodeFor", codefor.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("supprimer avec succès");
            cn.Close();
            DisplayData();
            ClearData();
        }

        private void chercher_Click_1(object sender, EventArgs e)
        {
            if (codefor.Text != "")
            {
                cn.Open();
                System.Data.DataTable dt = new System.Data.DataTable();
                adapt = new SqlDataAdapter("select * from formations where CodeFor='" + codefor.Text + "'", cn);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                cn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DataTableCollection tableCollection;
        private void button5_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*xlsx" })
            {
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtfilename.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName,FileMode.Open,FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() {UseHeaderRow = true }   
                            });
                            tableCollection = result.Tables;
                            comsheet.Items.Clear();
                            foreach(System.Data.DataTable table in tableCollection)
                                comsheet.Items.Add(table.TableName);
                        }
                    }
                }
            }

        }

        private void comsheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Data.DataTable dt = tableCollection[comsheet.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                try { myRange.Value2 = dataGridView1.Columns[j].HeaderText; }
               catch(Exception ex) { }
            }
            StartRow++;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {

                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    try { myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                        myRange.Select();
                    }
                    catch (Exception ex) { }
                   
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                cn.Open();
                cmd = new SqlCommand("insert into formations(CodeFor, Mois, Date, Jour, NumDomaine, NumProjet, Domaine, Sujet, CategorieBeneficiaire, NembreBeneficiaire, ForConfi, Lieu, Heure) values(@CodeFor, @Mois, @Date, @Jour, @NumDomaine, @NumProjet, @Domaine, @Sujet, @CategorieBeneficiaire, @NembreBeneficiaire, @ForConfi, @Lieu, @Heure)", cn);
                cmd.Parameters.AddWithValue("@CodeFor", dataGridView1.Rows[i].Cells[0].Value);
                cmd.Parameters.AddWithValue("@Mois", dataGridView1.Rows[i].Cells[1].Value);
                cmd.Parameters.AddWithValue("@Date", dataGridView1.Rows[i].Cells[2].Value);
                cmd.Parameters.AddWithValue("@Jour", dataGridView1.Rows[i].Cells[3].Value);
                cmd.Parameters.AddWithValue("@NumDomaine", dataGridView1.Rows[i].Cells[4].Value);
                cmd.Parameters.AddWithValue("@NumProjet", dataGridView1.Rows[i].Cells[5].Value);
                cmd.Parameters.AddWithValue("@Domaine", dataGridView1.Rows[i].Cells[6].Value);
                cmd.Parameters.AddWithValue("@Sujet", dataGridView1.Rows[i].Cells[7].Value);
                cmd.Parameters.AddWithValue("@CategorieBeneficiaire", dataGridView1.Rows[i].Cells[8].Value);
                cmd.Parameters.AddWithValue("@NembreBeneficiaire", dataGridView1.Rows[i].Cells[9].Value);
                cmd.Parameters.AddWithValue("@ForConfi", dataGridView1.Rows[i].Cells[10].Value);
                cmd.Parameters.AddWithValue("@Lieu", dataGridView1.Rows[i].Cells[11].Value);
                cmd.Parameters.AddWithValue("@Heure", dataGridView1.Rows[i].Cells[12].Value);
                try { cmd.ExecuteNonQuery(); }
                catch(Exception es) { }
               
                
                cn.Close();
            }
            MessageBox.Show("Enregistrement mis à jour avec succès");
            DisplayData();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          this.Close();
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
    }
    }

  

