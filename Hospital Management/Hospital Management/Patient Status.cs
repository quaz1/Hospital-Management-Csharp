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
    public partial class Patient_CheckOut : Form
    {
        public Patient_CheckOut()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseDataContext DB = new DatabaseDataContext();
            int id = int.Parse(textBoxSearchh.Text);
            Patientreg ob = DB.Patientregs.SingleOrDefault(pt => pt.Id == id);
            if (ob != null)
            {
                DB.Patientregs.DeleteOnSubmit(ob);
                DB.SubmitChanges();
                MessageBox.Show("Patient Checked Out");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void textBoxSearchh_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DatabaseDataContext DB = new DatabaseDataContext();
            int id = int.Parse(textBoxSearchh.Text);
            Patientreg obp = DB.Patientregs.SingleOrDefault(st => st.Id == id);
            if (obp != null)
            {
                textboxregno.Text = obp.regno;
                textboxregDate.Text = obp.regdate;
                textBoxPID.Text = obp.PID;
                textBoxName.Text = obp.pname;
                textBoxGender.Text = obp.gender_;
                textBoxAge.Text = obp.age;
                textBoxPhone.Text = obp.pphone;
                textBoxAddress.Text = obp.paddress;
                textBoxDisease.Text = obp.disease;
                textBoxRoomNo.Text = obp.roomno;
                textBoxRoomType.Text = obp.roomtype;
                textBoxPrice.Text = obp.price;
                textBoxBlood.Text = obp.blood;
            }
            else
            {
                MessageBox.Show("Invalid Search");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            (new LoginOption()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new MenuAd()).Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DatabaseDataContext DB = new DatabaseDataContext();
            Patientreg ob1 = new Patientreg();
            string bd = textBoxBlood.Text;
            Blood ob = DB.Bloods.SingleOrDefault(asd => asd.BloodType==bd);
            if (ob != null)
            {
                DB.Bloods.DeleteOnSubmit(ob);
                DB.SubmitChanges();
                MessageBox.Show("BLood Taken");
            }
            else 
            {
                MessageBox.Show("Blood Not Available");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            DatabaseDataContext DB = new DatabaseDataContext();
            int id = int.Parse(textBoxSearchh.Text);
            Patientreg ob = DB.Patientregs.SingleOrDefault(pt => pt.Id == id);
            Morgue ob1 = new Morgue();
            ob1.Name = textBoxName.Text;
            ob1.PatientID = textBoxPID.Text;
            ob1.Cause_of_Death = textBoxCause.Text;
            ob1.Time_of_Death = textBoxTime.Text;
            ob1.Disease = textBoxDisease.Text;
            DB.Morgues.InsertOnSubmit(ob1);
            DB.SubmitChanges();
            if (ob != null)
            {
                DB.Patientregs.DeleteOnSubmit(ob);
                DB.SubmitChanges();
                MessageBox.Show("Patient Has Passed Away!!");
                
            }
            else
            {
                MessageBox.Show("Error");
            }

        }
    }
}
