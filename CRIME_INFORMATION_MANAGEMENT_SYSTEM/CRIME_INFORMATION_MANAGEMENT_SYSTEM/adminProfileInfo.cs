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
    public partial class adminProfileInfo : Form
    {
        ProjectLINQDataContext pl = new ProjectLINQDataContext();
        public adminProfileInfo()
        {
            InitializeComponent();
        }

        private void adminProfileInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_New_Criminal_Information a = new Add_New_Criminal_Information();
            a.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLogin al = pl.AdminLogins.Single(AdminLogin => AdminLogin.Userid ==1);
            try
            {
                if (textBox3.Text == textBox4.Text && textBox3.Text != "" && textBox4.Text != "")
                {

                    al.Password = textBox4.Text;
                    al.Email = textBox2.Text;
                    al.UserName = textBox1.Text;
                    pl.SubmitChanges();
                    MessageBox.Show("Profile Successfully Updated !");
                    this.Hide();
                    Add_New_Criminal_Information a = new Add_New_Criminal_Information();
                    a.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Password Doesn't Match !");

                }
                
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            
        }
    }
}
