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
    public partial class EmpCustInfo : Form
    {

        DBAccess objdBAccess = new DBAccess();
        DataTable dtCustView = new DataTable();
        public EmpCustInfo()
        {
            InitializeComponent();
        }

        private void viewCustBtn_Click(object sender, EventArgs e)
        {
            string CustName = CustNametxt.Text;
            if (CustName == "")
            {
                MessageBox.Show("please enter a value ");
            }
            else
            {
                string query = "select * from Customer where CustomerName    = '" + CustName + "'";
                objdBAccess.readDatathroughAdapter(query, dtCustView);
                dataGridView1.DataSource = dtCustView;
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
