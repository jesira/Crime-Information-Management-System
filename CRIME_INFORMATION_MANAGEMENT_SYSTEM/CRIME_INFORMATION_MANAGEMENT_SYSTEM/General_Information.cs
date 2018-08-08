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
    public partial class General_Information : Form
    {
        public General_Information()
        {
            InitializeComponent();
        }

        private void General_Information_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Criminal_Info' table. You can move, or remove it, as needed.
            this.criminal_InfoTableAdapter.Fill(this.database1DataSet.Criminal_Info);

        }

        private void General_Information_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FirstForm f = new FirstForm();
            f.ShowDialog();
        }
    }
}
