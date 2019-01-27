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
    public partial class Patient_InformationSt : Form
    {
        DatabaseDataContext DB = new DatabaseDataContext();
        public Patient_InformationSt()
        {
            InitializeComponent();
            dataGridView1.DataSource = DB.Patientregs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            (new MenuSt()).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            (new LoginOption()).Show();
        }
    }
}
