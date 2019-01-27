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
    public partial class LoginOption : Form
    {
        DatabaseDataContext DB = new DatabaseDataContext();
        public LoginOption()
        {
            InitializeComponent();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Form1()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new StaffLogin()).Show();
        }

        private void LoginOption_Load(object sender, EventArgs e)
        {

        }
    }
}
