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
    public partial class AddNewCrime : Form
    {
        int a = 0;
        int b = 0;
        ProjectLINQDataContext db = new ProjectLINQDataContext();
        public AddNewCrime(int a,int b)
        {
            InitializeComponent();
            this.a = a;
            this.b = b;
            textBox1.Text = a.ToString();
            textBox2.Text = b.ToString();

        }

        private void AddNewCrime_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CrimeInfo ci = new CrimeInfo();
                ci.Criminal_ID = int.Parse(textBox1.Text);
                ci.Crime = comboBox1.Text;
                ci.Year = int.Parse(textBox3.Text);
                ci.Area = textBox4.Text;
                ci.Age = int.Parse(textBox2.Text);
                db.CrimeInfos.InsertOnSubmit(ci);
                db.SubmitChanges();
                MessageBox.Show("Information Inserted !!");
                this.Hide();
                Matched_Criminal_History_Form f = new Matched_Criminal_History_Form(int.Parse(textBox1.Text));
                f.ShowDialog();
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Matched_Criminal_History_Form f = new Matched_Criminal_History_Form(int.Parse(textBox1.Text));
            f.ShowDialog();
        }

        private void AddNewCrime_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void AddNewCrime_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
