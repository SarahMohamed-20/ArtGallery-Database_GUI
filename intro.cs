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
    public partial class intro : Form
    {
        public intro()
        {
            InitializeComponent();
        }



        private void Admin_Click(object sender, EventArgs e)
        {

            this.Hide();
            Admin home = new Admin();
            home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee home = new Employee();
            home.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer home = new Customer();
            home.Show();
        }
    }
}
