using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form5 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public Form5()
        {
            InitializeComponent();
            random = new Random();
           
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(thecolor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(thecolor.ColorList.Count);
            }
            tempIndex = index;
            string color = thecolor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    paneltitle.BackColor = color;
                    panellogo.BackColor = thecolor.ChangeColorBrightness(color, -0.3);
                    thecolor.PrimaryColor = color;
                    thecolor.SecondaryColor = thecolor.ChangeColorBrightness(color, -0.3);
                    
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelmenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                  //  previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.paneldes.Controls.Add(childForm);
            this.paneldes.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            Formations.Text = childForm.Text;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new form.Formations(), sender);
        }

  

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new form.Beneficiaire(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);


        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new form.invitation(), sender);
        }

        private void panelmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new form.TableaudePresence(), sender);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new form.Statistiques(), sender);
        }
    }
}
