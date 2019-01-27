using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class Patient_Information : Form
    {
        DatabaseDataContext DB = new DatabaseDataContext();
        public Patient_Information()
        {
            InitializeComponent();
            dataGridView1.DataSource = DB.Patientregs;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = DB.Patientregs;
        }

        private void Patient_Information_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            (new MenuAd()).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            (new LoginOption()).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
