﻿using System;
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
    public partial class MenuSt : Form
    {
        public MenuSt()
        {
            InitializeComponent();
        }

        private void MenuSt_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            (new LoginOption()).Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            (new Patient_RegistrationSt()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Patient_InformationSt()).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Patient_StatusSt()).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new BloodBankSt()).Show();
        }

       
    }
}
