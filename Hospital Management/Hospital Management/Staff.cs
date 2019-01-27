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
    public partial class Staff : Form
    {
        
        public Staff()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Staffinfo ob = new Staffinfo();
            ob.fullname = textboxFullname.Text;
            ob.username = textboxUsername.Text;
            ob.password = textboxPassword.Text;
            ob.phone = textboxPhone.Text;
            ob.DOB= textboxDOB.Text;
            ob.address = textboxAddress.Text;
            DatabaseDataContext DB = new DatabaseDataContext();
            DB.Staffinfos.InsertOnSubmit(ob);
            try
            {
                DB.SubmitChanges();
                MessageBox.Show("Inserted.");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DatabaseDataContext DB = new DatabaseDataContext();
            int id = int.Parse(textBoxIDD.Text);
            Staffinfo ob = DB.Staffinfos.SingleOrDefault(st => st.Id == id);
            if (ob != null)
            {
                ob.fullname = textboxFullname.Text;
                ob.address = textboxAddress.Text;
                ob.DOB = textboxAddress.Text;
                ob.phone = textboxPhone.Text;
                ob.password = textboxPassword.Text;
                ob.username = textboxUsername.Text;
                DB.SubmitChanges();
                MessageBox.Show("Staff Updated");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseDataContext DB = new DatabaseDataContext();
            int id = int.Parse(textBoxIDD.Text);
            Staffinfo ob = DB.Staffinfos.SingleOrDefault(st => st.Id == id);
            if (ob != null)
            {
                textboxFullname.Text = ob.fullname;
                textboxAddress.Text = ob.address;
                textboxDOB.Text = ob.DOB;
                textboxPhone.Text = ob.phone;
                textboxPassword.Text = ob.password;
                textboxUsername.Text = ob.username;
            }
            else 
            {
                MessageBox.Show("Invalid Search");
            }

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DatabaseDataContext DB = new DatabaseDataContext();
            int id = int.Parse(textBoxIDD.Text);
            Staffinfo ob = DB.Staffinfos.SingleOrDefault(st => st.Id == id);
            if (ob != null)
            {
                DB.Staffinfos.DeleteOnSubmit(ob);
                DB.SubmitChanges();
                MessageBox.Show("Staff Deleted");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            (new MenuAd()).Show();
        }
    }
}
