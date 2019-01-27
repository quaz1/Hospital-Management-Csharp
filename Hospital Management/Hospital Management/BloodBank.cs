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
    public partial class BloodBank : Form
    {
        DatabaseDataContext DB = new DatabaseDataContext();
        public BloodBank()
        {
            InitializeComponent();
            dataGridView1.DataSource = DB.Bloods;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Blood s = new Blood();
            s.BloodType = textboxBLoodType.Text;
            s.Quanitity = textBoxQuantity.Text;
            DB.Bloods.InsertOnSubmit(s);
            DB.SubmitChanges();
            MessageBox.Show("Blood Added");
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

        private void textBoxSearchblood_TextChanged(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxSearchblood.Text);
            Blood ob = DB.Bloods.SingleOrDefault(st => st.Id == id);
            if (ob != null)
            {
                textboxBLoodType.Text = ob.BloodType;
                textBoxQuantity.Text = ob.Quanitity;
            }
            else
            {
                MessageBox.Show("Invalid Search");
            }
        }

        private void BloodBank_Load(object sender, EventArgs e)
        {

        }
    }
}
