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
    public partial class StaffLogin : Form
    {
        DatabaseDataContext DB = new DatabaseDataContext();
        public StaffLogin()
        {
            InitializeComponent();
            textboxPasspassword.UseSystemPasswordChar = true; 
        }

        private void StaffLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textboxUserusername.Text;
            string password = textboxPasspassword.Text;
            var login = DB.Staffinfos.FirstOrDefault(std => std.username == username && std.password == password);
            if (login != null)
            {
                this.Hide();
                new MenuSt().Visible = true;

            }
            else
            {
                MessageBox.Show("Username or password is incorrect!");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            (new LoginOption()).Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
