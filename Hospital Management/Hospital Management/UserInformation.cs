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
    public partial class UserInformation : Form
    {
        DatabaseDataContext DB = new DatabaseDataContext();
        public UserInformation()
        {
            InitializeComponent();
           // dataGridView1.DataSource = DB.Logins;
            dataGridView1.DataSource = DB.Logins;
            
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

        private void UserInformation_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
