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
    public partial class AdminDeleteEmp : Form
    {
        DBAccess objdBAccess = new DBAccess();
        DataTable dtEmpDel = new DataTable();

        public AdminDeleteEmp()
        {
            InitializeComponent();
        }

        private void selectbtn_Click(object sender, EventArgs e)
        {
            string deleteEmpp = deletetxtF.Text;
            if (deleteEmpp == "")
            {
                MessageBox.Show("please enter a value ");
            }
            else
            {
                string query = "select * from Employee where ID  = '" + deleteEmpp + "'";
                objdBAccess.readDatathroughAdapter(query, dtEmpDel);
                dataGridView3.DataSource = dtEmpDel;
                objdBAccess.closeConn();
            }

        }

        private void yesbtn_Click(object sender, EventArgs e)
        {
            string deleteEmpp = deletetxtF.Text;
            string query = " delete from Employee where ID  = '" + deleteEmpp + "'";
            objdBAccess.readDatathroughAdapter(query, dtEmpDel);
            MessageBox.Show("Employee is Deleted");
        }

        private void nobtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin home = new Admin();
            home.Show();
        }
    }
}
