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
    public partial class AdminUpdateArtist : Form
    {
        DBAccess objdBAccess = new DBAccess();
        DataTable dtartist = new DataTable();
        public AdminUpdateArtist()
        {
            InitializeComponent();
        }



        private void selectbtn_Click(object sender, EventArgs e)
        {
            string newName = nametxtF.Text;
            if (newName == "")
            {
                MessageBox.Show("please enter a value ");
            }
            else
            {
                string query = "select * from Artist where artistName  = '" + newName + "'";
                objdBAccess.readDatathroughAdapter(query, dtartist);
                dataGridView2.DataSource = dtartist;
                objdBAccess.closeConn();
            }

        }

        private void updateEmpbtn_Click(object sender, EventArgs e)
        {
            string query;
            int lala = 0;
            string newName = nametxtF.Text;
            string newBirth = birthtxtFnew.Text;
            string newAge = agetxtFnew.Text;
            string newStyle = styletxtFnew.Text;
           

            if (newBirth == "")
            {
                lala = 1;
            }
            else
            {
                query = "update Artist SET birthplace    = '" + newBirth + "' where artistName  =  '" + newName + "'";
                objdBAccess.readDatathroughAdapter(query, dtartist);
            }


            if (newAge == "")
            {
                lala = 1;
            }
            else
            {
                query = "update Artist SET age    = '" + newAge + "' where artistName  =  '" + newName + "'";
                objdBAccess.readDatathroughAdapter(query, dtartist);
            }
            if (newStyle == "")
            {
                lala = 1;
            }
            else
            {
                query = "update Artist SET styleOfArt    = '" + newStyle + "' where artistName  =  '" + newName + "'";
                objdBAccess.readDatathroughAdapter(query, dtartist);
            }


            MessageBox.Show("Artist is updated successfully");

            objdBAccess.closeConn();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin home = new Admin();
            home.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
