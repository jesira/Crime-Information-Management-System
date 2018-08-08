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
    public partial class Matched_Criminal_History_Form : Form

    {
        int s =0;
        ProjectLINQDataContext data = new ProjectLINQDataContext();
        public Matched_Criminal_History_Form(int s)
        {
            InitializeComponent();
           
            this.s = s;
            using (data)
            {
               Criminal_Info ci = data.Criminal_Infos.Single(Criminal_Info => Criminal_Info.Criminal_ID ==s);
                if(ci !=null)
                {
                    textBox7.Text = ci.Criminal_ID.ToString();
                    textBox1.Text = ci.Name;
                    textBox8.Text = ci.Gender;
                    textBox3.Text = ci.DOB;
                    DateTime current = DateTime.Now;
                    int age = current.Year - int.Parse(ci.DOB);
                    textBox4.Text = age.ToString();
                    textBox2.Text = ci.Blood_Group;
                    textBox5.Text = ci.Birth_Place;
                    textBox6.Text = ci.NID_No_.ToString();
                    pictureBox1.Image = Image.FromFile(ci.Photo);
                }
                

            }
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Matched_Criminal_History_Form_Load(object sender, EventArgs e)
        {
            try {
                using (ProjectLINQDataContext pl = new ProjectLINQDataContext())
                {

                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.ColumnCount = 3;
                    dataGridView1.Columns[0].HeaderText = "Criminal ID";
                    dataGridView1.Columns[0].DataPropertyName = "Criminal_ID";
                    dataGridView1.Columns[1].HeaderText = "Crime Type";
                    dataGridView1.Columns[1].DataPropertyName = "Crime";
                    //dataGridView1.Columns[2].HeaderText = "Age";
                    //dataGridView1.Columns[2].DataPropertyName = "Age";
                    dataGridView1.Columns[2].HeaderText = "Year";
                    dataGridView1.Columns[2].DataPropertyName = "Year";
                    dataGridView1.DataSource = pl.CrimeInfos;
                
                }

                } 
            catch(Exception ee)
            {
                //MessageBox.Show(ee.Message);
            }
        }

        private void Matched_Criminal_History_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstForm a = new FirstForm();
            a.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewCrime a = new AddNewCrime(int.Parse(textBox7.Text),int.Parse(textBox4.Text));
            a.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
            
            try
            {
                using (ProjectLINQDataContext pl = new ProjectLINQDataContext())
                {

                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.ColumnCount =3;
                    dataGridView1.Columns[0].HeaderText = "Criminal ID";
                    dataGridView1.Columns[0].DataPropertyName = "Criminal_ID";
                    dataGridView1.Columns[1].HeaderText = "Crime Type";
                    dataGridView1.Columns[1].DataPropertyName = "Crime";
                    //dataGridView1.Columns[2].HeaderText = "Age";
                    //dataGridView1.Columns[2].DataPropertyName = "Age";
                    dataGridView1.Columns[2].HeaderText = "Year";
                    dataGridView1.Columns[2].DataPropertyName = "Year";
                    dataGridView1.DataSource = data.CrimeInfos.Where(x => x.Criminal_ID.ToString().Contains(textBox7.Text)).ToList();
                    // dataGridView1.DataSource = pl.CrimeInfos;

                }

            }
            catch (Exception ee)
            {
                //MessageBox.Show(ee.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_New_Criminal_Information a = new Add_New_Criminal_Information();
            a.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FingerPrintForm f = new FingerPrintForm();
            f.ShowDialog();
        }
    }
}
