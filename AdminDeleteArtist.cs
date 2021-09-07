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
    public partial class AdminDeleteArtist : Form
    {

        DBAccess objdBAccess = new DBAccess();
        DataTable dtArtDel = new DataTable();

        public AdminDeleteArtist()
        {
            InitializeComponent();
        }

        private void selectbtn_Click(object sender, EventArgs e)
        {
            string deleteArt = deletetxtF.Text;
            if (deleteArt == "")
            {
                MessageBox.Show("please enter a value ");
            }
            else
            {
                string query = "select * from Artist where artistName   = '" + deleteArt + "'";
                objdBAccess.readDatathroughAdapter(query, dtArtDel);
                dataGridView3.DataSource = dtArtDel;
                objdBAccess.closeConn();
            }
        }

        private void yesbtn_Click(object sender, EventArgs e)
        {
            string deleteArt = deletetxtF.Text;
            string query = " delete from Artist where artistName  = '" + deleteArt + "'";
            objdBAccess.readDatathroughAdapter(query, dtArtDel);
            MessageBox.Show("Artist is Deleted");
        }

        private void nobtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin home = new Admin();
            home.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin home = new Admin();
            home.Show();
        }
    }
}
