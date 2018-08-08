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
    public partial class AllCriminalsInformartion : Form
    {
        ProjectLINQDataContext db = new ProjectLINQDataContext();
        int indexRow =0;
        public AllCriminalsInformartion()
        {
            InitializeComponent();
            try
            {
                using (db)
                {

                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.ColumnCount = 7;
                    dataGridView1.Columns[0].HeaderText = "Criminal ID";
                    dataGridView1.Columns[0].DataPropertyName = "Criminal_ID";
                    dataGridView1.Columns[1].HeaderText = "Name";
                    dataGridView1.Columns[1].DataPropertyName = "Name";
                    dataGridView1.Columns[2].HeaderText = "Gender";
                    dataGridView1.Columns[2].DataPropertyName = "Gender";
                    dataGridView1.Columns[3].HeaderText = "DOB";
                    dataGridView1.Columns[3].DataPropertyName = "DOB";
                    dataGridView1.Columns[4].HeaderText = "Blood Group";
                    dataGridView1.Columns[4].DataPropertyName = "Blood_Group";
                    dataGridView1.Columns[5].HeaderText = "Birth Place";
                    dataGridView1.Columns[5].DataPropertyName = "Birth_Place";
                    dataGridView1.Columns[6].HeaderText = "NID No.";
                    dataGridView1.Columns[6].DataPropertyName = "NID_No_";
                    dataGridView1.DataSource = db.Criminal_Infos;

                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }


        }

        private void AllCriminalsInformartion_Load(object sender, EventArgs e)
        {

        }

        private void AllCriminalsInformartion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_New_Criminal_Information a = new Add_New_Criminal_Information();
            a.ShowDialog();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBox7.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                textBox6.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProjectLINQDataContext pl = new ProjectLINQDataContext();
            DataGridViewRow newrow = dataGridView1.Rows[indexRow];
            Criminal_Info ci = pl.Criminal_Infos.Single(Criminal_Info=>Criminal_Info.Criminal_ID ==int.Parse(textBox2.Text));
            try
            {

                if(ci!=null)
                {
                ci.Name = textBox3.Text;
                ci.DOB = textBox4.Text;
                ci.Blood_Group = comboBox1.Text;
                ci.Birth_Place = textBox7.Text;
                ci.NID_No_ = int.Parse(textBox6.Text);
                pl.SubmitChanges();
                newrow.Cells[1].Value = textBox3.Text;
                newrow.Cells[1].Value = textBox3.Text;
                newrow.Cells[3].Value = textBox4.Text;
                newrow.Cells[4].Value = comboBox1.Text;
                newrow.Cells[5].Value = textBox7.Text;
                newrow.Cells[6].Value = textBox6.Text;
                MessageBox.Show("Profile Successfully Updated !");
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;
                comboBox1.Text = null;
                textBox6.Text = null;
                textBox7.Text = null;


                }
                
                else
                {
                    MessageBox.Show("Data Not found");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
        }

        private void button3_Click(object sender, EventArgs e)
        {


            //dataGridView1.Refresh();
            ProjectLINQDataContext pl2 = new ProjectLINQDataContext();
            Criminal_Info cif = pl2.Criminal_Infos.SingleOrDefault(Criminal_Info => Criminal_Info.Criminal_ID == int.Parse(textBox2.Text));
            try
            {

                if (pl2 != null)
                {
                    pl2.Criminal_Infos.DeleteOnSubmit(cif);
                    pl2.SubmitChanges();
                    MessageBox.Show("Deleted Successfully");
                    dataGridView1.DataSource = pl2.Criminal_Infos;
                    dataGridView1.Refresh();
                    textBox2.Text = null;
                    textBox3.Text = null;
                    textBox4.Text = null;
                    comboBox1.Text = null;
                    textBox6.Text = null;
                    textBox7.Text = null;
                }
                else
                {
                    MessageBox.Show("Data not found");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //DataTable tbl = dataGridView1.DataSource as DataTable;
            //DataView dv = new DataView(tbl);
            //dv.RowFilter = string.Format("Name LIKE '%{0}%'",textBox1.Text);
            //dataGridView1.DataSource = dv;

        }
    }
}
