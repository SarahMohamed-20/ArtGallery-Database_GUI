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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmpArtistInfo home = new EmpArtistInfo();
            home.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmpCustInfo home = new EmpCustInfo();
            home.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmpPieceInfo home = new EmpPieceInfo();
            home.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            intro home = new intro();
            home.Show();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeBought home = new EmployeeBought();
            home.Show();
        }
    }
}
