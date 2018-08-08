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
    public partial class adminLogin : Form
    {
        ProjectLINQDataContext db = new ProjectLINQDataContext();
        public adminLogin()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            EmailForm ef = new EmailForm();
            ef.ShowDialog();
        }

        private void adminLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AdminLogin al = db.AdminLogins.Single(AdminLogin => AdminLogin.UserName == textBox1.Text && AdminLogin.Password == textBox2.Text);

                if ((textBox1.Text == al.UserName) && (textBox2.Text == al.Password))
                {
                    this.Hide();
                    FingerPrintForm f = new FingerPrintForm();
                    f.ShowDialog();
                }
                
            }

            catch(Exception ex)
            {
                MessageBox.Show("Username and password doesn't match!!\n Please try again!!");
                textBox1.Text = null;
                textBox2.Text = null;

            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}