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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new MenuAd()).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new LoginOption()).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DatabaseDataContext DB = new DatabaseDataContext();
            int id = int.Parse(textBoxSearch.Text);
            Doctorr ob = DB.Doctorrs.SingleOrDefault(st => st.Id == id);
            if (ob != null)
            {
                textBoxNamee.Text = ob.Name;
                textBoxDesignation.Text = ob.Designation;
                textBoxDepartment.Text = ob.Department;
                textBoxDegree.Text = ob.Degree_Qualification;
            }
            else
            {
                MessageBox.Show("Invalid Search");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DatabaseDataContext DB = new DatabaseDataContext();
            Doctorr dd = new Doctorr();
            dd.Name = textBoxNamee.Text;
            dd.Designation = textBoxDesignation.Text;
            dd.Department = textBoxDepartment.Text;
            dd.Degree_Qualification = textBoxDegree.Text;
            
            DB.Doctorrs.InsertOnSubmit(dd);
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Doctorview()).Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DatabaseDataContext DB = new DatabaseDataContext();
            int id = int.Parse(textBoxSearch.Text);
            Doctorr ob = DB.Doctorrs.SingleOrDefault(st => st.Id == id);
            if (ob != null)
            {
                ob.Name=textBoxNamee.Text;
                ob.Designation=textBoxDesignation.Text;
                ob.Department = textBoxDepartment.Text;
                ob.Degree_Qualification=textBoxDegree.Text;
                DB.SubmitChanges();
                MessageBox.Show("Staff Updated");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
