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
    public partial class Doctorview : Form
    {
        DatabaseDataContext DB = new DatabaseDataContext();
        public Doctorview()
        {
            InitializeComponent();
            dataGridView1.DataSource = DB.Doctorrs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Doctor()).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new LoginOption()).Show();
        }
    }
}
