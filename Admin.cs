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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void AdminAdd_Click(object sender, EventArgs e)
        {
            if ((String)list1.SelectedItem == "Employee")
            {
                this.Hide();
                AdminAddEmp home = new AdminAddEmp();
                home.Show();
            }

            if ((String)list1.SelectedItem == "Artist")
            {
                this.Hide();
                AdminAddArtist home = new AdminAddArtist();
                home.Show();
            }
        }

        private void AdminUpdate_Click(object sender, EventArgs e)
        {
            if ((String)list2.SelectedItem == "Employee")
            {
                this.Hide();
                AdminUpdateEmp home = new AdminUpdateEmp();
                home.Show();
            }

            else if ((String)list2.SelectedItem == "Artist")
            {
                this.Hide();
                AdminUpdateArtist home = new AdminUpdateArtist();
                home.Show();

            }
        }




        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            intro home = new intro();
            home.Show();
        }

        private void AdminDelete_Click(object sender, EventArgs e)
        {
            if ((String)list3.SelectedItem == "Employee")
            {
                this.Hide();
                AdminDeleteEmp home = new AdminDeleteEmp();
                home.Show();
            }

           else  if ((String)list3.SelectedItem == "Artist")
            {
                this.Hide();
                AdminDeleteArtist home = new AdminDeleteArtist();
                home.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((String)comboBox1.SelectedItem == "Employees")
            {
                this.Hide();
                DisplayEmp home = new DisplayEmp();
                home.Show();
            }

            if ((String)comboBox1.SelectedItem == "Artists")
            {
                this.Hide();
                DisplayArtist home = new DisplayArtist();
                home.Show();
            }

            if ((String)comboBox1.SelectedItem == "Specific Artist Artwork")
            {
                this.Hide();
                ArtistWorks home = new ArtistWorks();
                home.Show();
            }
        }
    }
}
