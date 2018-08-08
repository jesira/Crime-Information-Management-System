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
    public partial class Add_New_Criminal_Information : Form
    {
        string str =null;
        string str1 =null;
        string g = null;

        ProjectLINQDataContext db = new ProjectLINQDataContext();


        public Add_New_Criminal_Information()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            g = "Female";
        }

        private void Add_New_Criminal_Information_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstForm f = new FirstForm();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminProfileInfo a = new adminProfileInfo();
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                str = ofd.FileName;
                //  MessageBox.Show(str);
                pictureBox1.Image = Image.FromFile(str);
            }

           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                str1 =ofd.FileName;
                //  MessageBox.Show(str);
                pictureBox3.Image = Image.FromFile(str1);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Criminal_Info cf = new Criminal_Info();
                cf.Finger_Print = str1;
                cf.Photo = str;
                cf.Name = textBox1.Text;
                cf.NID_No_ = int.Parse(textBox3.Text);
                cf.Gender = g;
                cf.DOB = textBox6.Text;
                cf.Birth_Place = textBox2.Text;
                cf.Blood_Group = comboBox3.Text;
                DateTime current = DateTime.Now;
                int age = current.Year - int.Parse(textBox6.Text);
                cf.Age = age;
                db.Criminal_Infos.InsertOnSubmit(cf);
                db.SubmitChanges();
                MessageBox.Show("Information Inserted");
                
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            g = "Male";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            g = "Transgender";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox3.Image = null;
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox6.Text = null;
            comboBox3.Text = null;
            str = null;
            str1= null;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllCriminalsInformartion af = new AllCriminalsInformartion();
            af.ShowDialog();
        }

        private void cancel_Click(object sender, EventArgs e)
        {

        }

        private void Add_New_Criminal_Information_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            FingerPrintForm f = new FingerPrintForm();
            f.ShowDialog();
        }
    }
}
