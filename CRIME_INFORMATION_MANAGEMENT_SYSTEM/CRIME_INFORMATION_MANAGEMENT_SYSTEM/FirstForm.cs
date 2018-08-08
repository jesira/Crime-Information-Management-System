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
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private void adminLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminLogin a = new adminLogin();
            a.ShowDialog();

        }






        //**********************************************************************************************//
        private void generalLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            General_Information gi = new General_Information();
            gi.ShowDialog();
        }

        private void FirstForm_Load(object sender, EventArgs e)
        {

        }

        private void FirstForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
