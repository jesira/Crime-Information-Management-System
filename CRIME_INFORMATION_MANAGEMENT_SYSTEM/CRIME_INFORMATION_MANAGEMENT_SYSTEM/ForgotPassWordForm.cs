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
    public partial class ForgotPassWordForm : Form
    {
        ProjectLINQDataContext pl = new ProjectLINQDataContext();
        string email = null;
        public ForgotPassWordForm(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ForgotPassWordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminLogin a = new adminLogin();
            a.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AdminLogin al = pl.AdminLogins.Single(AdminLogin => AdminLogin.Email ==email);
                if (textBox1.Text ==textBox2.Text && textBox1.Text !="" && textBox2.Text !="")
                {
            
                    al.Password = textBox1.Text;
                    pl.SubmitChanges();
                    MessageBox.Show("Password Successfully Changed !");
                    this.Hide();
                    adminLogin a = new adminLogin();
                    a.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Password Doesn't Match !!");
                }
            }
            catch(Exception ex)
            {

            }
            
        }
    }
}
