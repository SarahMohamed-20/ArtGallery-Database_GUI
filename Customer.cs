using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProj
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                this.Hide();
                CustomerArtist custart = new CustomerArtist();
                custart.Show();
            }
            if (radioButton2.Checked == true)
            {
                this.Hide();
                CustomerWork custart = new CustomerWork();
                custart.Show();
            }
            if (radioButton3.Checked == true)
            {
                this.Hide();
                Categories custart = new Categories();
                custart.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            intro custart = new intro();
            custart.Show();
        }
    }
}
