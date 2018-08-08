using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRIME_INFORMATION_MANAGEMENT_SYSTEM
{
    public partial class EmailForm : Form
    {
        ProjectLINQDataContext db = new ProjectLINQDataContext();
        public EmailForm()
        {
            InitializeComponent();
        }

   

        private void EmailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AdminLogin al = db.AdminLogins.Single(AdminLogin => AdminLogin.Email == textBox1.Text);

                if ((textBox1.Text == al.Email) )
                {
                    this.Hide();
                    ForgotPassWordForm fp = new ForgotPassWordForm(textBox1.Text);
                    fp.ShowDialog();
                }

            }

            catch (Exception ex)
            {

                MessageBox.Show("Email doesn't match!!\n Please try again!!");
                textBox1.Text = null;

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminLogin a = new adminLogin();
            a.ShowDialog();
        }

    }
}
