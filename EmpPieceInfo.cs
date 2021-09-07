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
    public partial class EmpPieceInfo : Form
    {

        DBAccess objdBAccess = new DBAccess();
        DataTable dtPieceView = new DataTable();
        public EmpPieceInfo()
        {
            InitializeComponent();
        }

        private void viewArtBtn_Click(object sender, EventArgs e)
        {
            string PieceName = PieceNametxt.Text;
            if (PieceName == "")
            {
                MessageBox.Show("please enter a value ");
            }
            else
            {
                string query = "select * from ArtWork where title     = '" + PieceName + "'";
                objdBAccess.readDatathroughAdapter(query, dtPieceView);
                dataGridView1.DataSource = dtPieceView;
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
