using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseProj
{
    public partial class AdminAddArtist : Form

    {
        DBAccess objdBAccess = new DBAccess();
        public AdminAddArtist()
        {
            InitializeComponent();
        }

        private void AddArtistbtn_Click(object sender, EventArgs e)
        {
            string Artistname = ArtisttxtF.Text;
            string birthplace = birthtxtF.Text;
            string age = agetxtF.Text;
            string StyleArt = styletxtF.Text;





            if (Artistname.Equals(""))
            {
                MessageBox.Show("please enter a value");
            }
            else if (birthplace.Equals(""))
            {
                MessageBox.Show("please enter a value");
            }
            else
            if (age.Equals(""))
            {
                MessageBox.Show("please enter a value");
            }
            else
            if (StyleArt.Equals(""))
            {
                MessageBox.Show("please enter a value");
            }

            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into Artist (artistName  ,birthplace  ,age  ,styleOfArt  )values (@Artistname,@birthplace,@age,@StyleArt)");
                insertCommand.Parameters.AddWithValue("@Artistname", Artistname);
                insertCommand.Parameters.AddWithValue("@birthplace ", birthplace);
                insertCommand.Parameters.AddWithValue("@age ", age);
                insertCommand.Parameters.AddWithValue("@StyleArt ", StyleArt);
        

                int row = objdBAccess.executeQuery(insertCommand);
                if (row == 1)
                {
                    MessageBox.Show("Artist is added Succesfully");
                }
                else
                    MessageBox.Show("error");

            }
            ArtisttxtF.Clear();
            birthtxtF.Clear();
            agetxtF.Clear();
            styletxtF.Clear();
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin home = new Admin();
            home.Show();
        }
    }
}
