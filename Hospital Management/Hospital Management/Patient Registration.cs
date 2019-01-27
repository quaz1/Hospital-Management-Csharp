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
    public partial class Patient_Registration : Form
    {
        
        public Patient_Registration()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new MenuAd().Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseDataContext DB = new DatabaseDataContext();
            Patientreg obp = new Patientreg();
            obp.regno = textboxregno.Text;
            obp.regdate = textboxregDate.Text;
            obp.PID = textBoxPID.Text;
            obp.pname = textBoxName.Text;
            obp.gender_ = textBoxGender.Text;
            obp.age = textBoxAge.Text;
            obp.pphone = textBoxPhone.Text;
            obp.paddress = textBoxAddress.Text;
            obp.disease = textBoxDisease.Text;
            obp.roomno = textBoxRoomNo.Text;
            obp.roomtype = textBoxRoomType.Text;
            obp.price = textBoxPrice.Text;
            obp.blood = textBoxBlood.Text;

            DB.Patientregs.InsertOnSubmit(obp);

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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginOption().Visible = true;
        }



        }
    
}
