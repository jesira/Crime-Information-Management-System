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
    public partial class FingerPrintForm : Form
    {
        string path1 =null;
        ProjectLINQDataContext db = new ProjectLINQDataContext();
        public FingerPrintForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path1 = ofd.FileName;
                pictureBox1.Image = Image.FromFile(path1);
            }
        }
         private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Criminal_Info ci = db.Criminal_Infos.Single(Criminal_Info=>Criminal_Info.Finger_Print ==path1);

                if (ci!=null)
                {
                    MessageBox.Show("Fingerprint Macthed");
                    this.Hide();
                    Matched_Criminal_History_Form fp = new Matched_Criminal_History_Form(ci.Criminal_ID);
                    fp.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Fingerprint doesn't Match");
                    this.Hide();
                    Add_New_Criminal_Information al = new Add_New_Criminal_Information();
                    al.ShowDialog();
                }

            }

            catch (Exception ex)
            {

               // MessageBox.Show(ex.Message);
                MessageBox.Show("Fingerprint doesn't Match");
                this.Hide();
                Add_New_Criminal_Information al = new Add_New_Criminal_Information();
                al.ShowDialog();


            }

        }

       /* private void button3_Click(object sender, EventArgs e)
        {
            if(path1 == path2)
            {
                MessageBox.Show("Fingerprint Matched!!!!");
            }
            else
            {
                MessageBox.Show("Fingerprint didn't Match!!!!");

            }
        }*/

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

  
            
  