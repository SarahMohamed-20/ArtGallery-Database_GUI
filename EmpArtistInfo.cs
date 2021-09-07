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
    public partial class EmpArtistInfo : Form
    {
        DBAccess objdBAccess = new DBAccess();
        DataTable dtArtView = new DataTable();
        public EmpArtistInfo()
        {
            InitializeComponent();
        }

        private void viewArtistBtn_Click(object sender, EventArgs e)
        {
            string ArtistName = artNametxt.Text;
            if (ArtistName == "")
            {
                MessageBox.Show("please enter a value ");
            }
            else
            {
                string query = "select * from Artist where artistName   = '" + ArtistName + "'";
                objdBAccess.readDatathroughAdapter(query, dtArtView);
                dataGridView1.DataSource = dtArtView;
                objdBAccess.closeConn();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee home = new Employee();
            home.Show();
        }
    }
}
